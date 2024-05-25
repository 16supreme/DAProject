using DAProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAProject.Views
{
    public partial class GestaoClientesForm : Form
    {
        public GestaoClientesForm()
        {
            InitializeComponent();
            LoadClientes();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (NewClienteForm newClienteForm= new NewClienteForm())
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

        private void LoadClientes()
        {

            var estudantes = MainController.GetEstudantes();
            var professores = MainController.GetProfessores();
            Console.WriteLine($"Found {estudantes.Count} entities.");
            Console.WriteLine($"Found {professores.Count} entities.");
            foreach (var estudante in estudantes)
            {
                CardEstudante card = new CardEstudante(estudante);
                flowLayoutPanel1.Controls.Add(card);
            }
            foreach (var professor in professores)
            {
                CardProfessor card = new CardProfessor(professor);
                flowLayoutPanel1.Controls.Add(card);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadClientes();
        }
    }
}
