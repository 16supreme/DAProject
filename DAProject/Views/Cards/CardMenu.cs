using DAProject.Views.UpdateForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DAProject.Views.Cards
{
    public partial class CardMenu : UserControl
    {
        private Classes.Menu getMenu;
        public CardMenu(Classes.Menu menu)
        {
            InitializeComponent();
            LoadData(menu);
        }

        private void LoadData(Classes.Menu menu)
        { 
            getMenu = menu;

            using (var db = new CantinaContext())
            { 
                getMenu = db.Menus
                .Include(m => m.pratos)
                .Include(m => m.extras)
                .FirstOrDefault(m => m.id == menu.id);
            }

            foreach (var prato in getMenu.pratos)
            {
                Console.WriteLine(prato.ToString());
                if (prato.tipo == "Carne")
                {
                    lblCarne.Text = prato.descricao;
                }
                else if(prato.tipo == "Peixe")
                {
                    lblPeixe.Text = prato.descricao;
                }
                else
                {
                    lblVeggie.Text = prato.descricao;
                }
            }

            foreach (var extra in getMenu.extras)
            {
                extrasListBox.Items.Add(extra.ToString());
            }

            lblDataHora.Text = Convert.ToString(menu.dataHora);
            lblPrecoEstudante.Text = "Preço Estudante : " + Convert.ToString(menu.precoEstudante) + "€";
            lblPrecoProfessor.Text = "Preço Professor : " + Convert.ToString(menu.precoProfessor) + "€";
            lblQtnd.Text = "Quantidade : " + Convert.ToString(menu.qtdDisponivel);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox2, new System.Drawing.Point(0, pictureBox2.Height));
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (UpdateMenuForm updateMenuForm = new UpdateMenuForm(getMenu))
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    updateMenuForm.Owner = addCard;
                    updateMenuForm.ShowDialog();
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

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja mesmo deletar este menu?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                using (var db = new CantinaContext())
                {
                    var deleteMenu = db.Menus.Find(getMenu.id);

                    if (deleteMenu != null)
                    {
                        var associatedReservas = db.Reservas.Any(r => r.menu.id == deleteMenu.id);
                        if (associatedReservas)
                        {
                            MessageBox.Show("Este menu possui reservas associadas!");
                        }
                        else
                        {
                            db.Menus.Remove(deleteMenu);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este menu não existe!");
                    }
                }
            }
        }
    }
}
