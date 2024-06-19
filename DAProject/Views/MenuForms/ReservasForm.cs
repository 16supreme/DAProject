using DAProject.Controllers;
using DAProject.Views.Cards;
using DAProject.Views.InsertForms;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject.Views
{
    public partial class ReservasForm : Form
    {
        List<string> clientType = new List<string> { "Estudante", "Professor" };
        List<Classes.Menu> menus = new List<Classes.Menu>();
        List<Classes.Extra> selectedExtras = new List<Extra>();
        Classes.Menu selectedMenu;
        Classes.Multa addmulta;
        public ReservasForm()
        {
            InitializeComponent();
            LoadReservas();
            clientTypeCB.DataSource = clientType;
            menus = MainController.GetMenus();
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void addCard_Click(object sender, EventArgs eventArgs)
        {
            using (var db = new CantinaContext())
            {
                if (txtNIF.TextLength == 0 || clientTypeCB.SelectedItem == null || menuCombo.SelectedItem == null || platesCombo.SelectedItem == null)
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if(txtNIF.TextLength == 9)
                    {
                        var clientNIF = Convert.ToInt32(txtNIF.Text);
                        var client = db.Utilizadores.FirstOrDefault(c => c.nif == clientNIF);
                        if (client == null)
                        {
                            var message = MessageBox.Show("Não existe nenhum cliente com este NIF! Deseja registar como um novo cliente?", "Cliente não encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if(message == DialogResult.Yes)
                            {
                                Form addCard = new Form();
                                try
                                {
                                    using (NewClienteForm newClienteForm = new NewClienteForm())
                                    {
                                        addCard.StartPosition = FormStartPosition.Manual;
                                        addCard.FormBorderStyle = FormBorderStyle.None;
                                        addCard.Opacity = .50d;
                                        addCard.BackColor = Color.Black;
                                        addCard.WindowState = FormWindowState.Maximized;
                                        addCard.Location = this.Location;
                                        addCard.ShowInTaskbar = false;
                                        addCard.Show();
                                        newClienteForm.Owner = addCard;
                                        newClienteForm.ShowDialog();
                                        addCard.Dispose();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    addCard.Dispose();
                                }
                            }
                            return;
                        }
                        else if(client!=null && clientTypeCB.SelectedIndex == 0)
                        {
                            bool verifyType = false;
                            var estudantes = MainController.GetEstudantes();
                            foreach (var estudante in estudantes)
                            {
                                if(estudante.nif == client.nif)
                                {
                                    verifyType = true;
                                }
                            }
                            if (!verifyType)
                            {
                                MessageBox.Show("Não existe nenhum estudante com este NIF!");
                                return;
                            }
                        }
                        else if (client != null && clientTypeCB.SelectedIndex == 1)
                        {
                            bool verifyType = false;
                            var professores = MainController.GetProfessores();
                            foreach (var professor in professores)
                            {
                                if (professor.nif == client.nif)
                                {
                                    verifyType = true;
                                }
                            }
                            if (!verifyType)
                            {
                                MessageBox.Show("Não existe nenhum professor com este NIF!");
                                return;
                            }
                        }

                        var addmenu = menus.FirstOrDefault(m => m.dataHora == (DateTime)menuCombo.SelectedItem);
                        
                        if(addmenu.qtdDisponivel == 0)
                        {
                            MessageBox.Show("Este menu já está esgotado!");
                            return;
                        }

                        var selectedPrato = platesCombo.SelectedItem as Classes.Prato;
                        var pratoFromDb = db.Pratos.Find(selectedPrato.id);

                        if (!pratoFromDb.ativo)
                        {
                            MessageBox.Show("Este prato já está esgotado!");
                            return;
                        }
                        
                        if(extraChecked.CheckedItems.Count > 3)
                        {
                            MessageBox.Show("MAX : 3 Extras");
                            return;
                        }
                        else
                        {
                            selectedExtras.Clear();
                            foreach (var item in extraChecked.CheckedItems)
                            {
                                var extra = item as Extra;
                                if (extra != null)
                                {
                                    var extraFromDb = db.Extras.Find(extra.id);
                                    if (extraFromDb != null && extraFromDb.ativo)
                                    {
                                        selectedExtras.Add(extraFromDb);
                                    }
                                    else
                                    {
                                        MessageBox.Show(extraFromDb.ToString() + " já está esgotado!");
                                        return ;
                                    }
                                }
                            }
                        }
                        

                        var limitReserva = addmenu.dataHora.Date.AddHours(10);
                        var multaTime = (DateTime.Now - limitReserva).TotalHours;

                        addmulta = null;

                        if (multaTime > 0)
                        {
                            int maxHoras = 0;
                            var multas = MainController.GetMultas();
                            foreach( var multa in multas)
                            {
                                if(multa.numHoras <= multaTime && multa.numHoras > maxHoras)
                                {
                                    addmulta = multa;
                                    maxHoras = multa.numHoras;
                                }
                            }
                        }

                        Form confirmReservaCard = new Form();
                        try
                        {
                            using (ConfirmReserva confirmReserva = new ConfirmReserva(client as Classes.Cliente,addmenu,selectedPrato,selectedExtras,addmulta,Convert.ToString(clientTypeCB.SelectedItem)))
                            {
                                confirmReservaCard.StartPosition = FormStartPosition.Manual;
                                confirmReservaCard.FormBorderStyle = FormBorderStyle.None;
                                confirmReservaCard.Opacity = .50d;
                                confirmReservaCard.BackColor = Color.Black;
                                confirmReservaCard.WindowState = FormWindowState.Maximized;
                                confirmReservaCard.Location = this.Location;
                                confirmReservaCard.ShowInTaskbar = false;
                                confirmReservaCard.Show();
                                confirmReserva.Owner = confirmReservaCard;
                                confirmReserva.ShowDialog();
                                confirmReservaCard.Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            confirmReservaCard.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O NIF deve conter 9 digitos!");
                    }
                    
                }
            }
        }

        private void menuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            platesCombo.Items.Clear();
            extraChecked.Items.Clear();

            if (menuCombo.SelectedItem is DateTime selectedDateTime)
            {
                
                selectedMenu = menus.FirstOrDefault(menu => menu.dataHora == selectedDateTime);

                if (selectedMenu != null)
                {
                    foreach (var plate in selectedMenu.pratos)
                    {
                        platesCombo.Items.Add(plate);
                        platesCombo.SelectedIndex = 0;
                    }

                    foreach (var extra in selectedMenu.extras)
                    {
                        extraChecked.Items.Add(extra);
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            menuCombo.Items.Clear();
            var selectedDate = dateTimePicker1.Value.Date;

            menus = MainController.GetMenus().Where(menu => menu.dataHora.Date == selectedDate).ToList();

            foreach (var menu in menus)
            {
                menuCombo.Items.Add(menu.dataHora);     
            }

            if (menuCombo.Items.Count > 0)
            {
                menuCombo.SelectedIndex = 0;
            }
        }

        private void LoadReservas(string clientSearch = "")
        {
            flowLayoutPanel1.Controls.Clear();
            List<Classes.Reserva> reservas;

            if (clientSearch.Length == 0)
            {
                reservas = MainController.GetReservas();
            }
            else
            {
                if (int.TryParse(clientSearch, out int searchClient))
                {
                    reservas = MainController.GetReservas().Where(r => r.cliente.nif == searchClient).ToList();
                }
                else
                {
                    reservas = MainController.GetReservas();
                }
            }

            Console.WriteLine($"Found {reservas.Count} entities.");
            foreach (var reserva in reservas)
            {
                CardReserva card = new CardReserva(reserva);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string clientSearch = siticoneTextBox1.Text;
            LoadReservas(clientSearch);
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            string clientSearch = siticoneTextBox1.Text;
            LoadReservas(clientSearch);
        }

    }
}
