using System;
using DAProject.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAProject.Properties;
using DAProject.Views.InsertForms;

namespace DAProject.Views
{
    public partial class PratosForm : Form
    {
        public PratosForm()
        {
            InitializeComponent();
            LoadPratos();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (NewPratoForm newPratoForm = new NewPratoForm())
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    newPratoForm.Owner = addCard;
                    newPratoForm.ShowDialog();
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
        private void LoadPratos(string nameSearch = "")
        {
            flowLayoutPanel1.Controls.Clear();
            nameSearch = nameSearch.ToLower();

            var pratos = MainController.GetPratos().Where(e => e.descricao.ToLower().Contains(nameSearch)).ToList();
            Console.WriteLine($"Found {pratos.Count} entities.");
            foreach (var prato in pratos)
            {
                CardPrato card = new CardPrato(prato);
                if (prato.tipo == "Carne" )
                {
                    card.SetPictureBoxImage(Resources.Meat);
                }else if (prato.tipo == "Peixe")
                {
                    card.SetPictureBoxImage(Resources.Seafood);
                }
                else
                {
                    card.SetPictureBoxImage(Resources.Vegetarian_Mark);
                }
                flowLayoutPanel1.Controls.Add(card);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string nameSearch = siticoneTextBox1.Text;
            LoadPratos(nameSearch);
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            string nameSearch = siticoneTextBox1.Text;
            LoadPratos(nameSearch);
        }
    }
}
