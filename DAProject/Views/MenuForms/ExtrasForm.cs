using DAProject.Controllers;
using DAProject.Views.Cards;
using DAProject.Views.InsertForms;
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
    public partial class ExtrasForm : Form
    {
        public ExtrasForm()
        {
            InitializeComponent();
            LoadExtras();
        }

        private void LoadExtras(string nameSearch = "")
        {
            flowLayoutPanel1.Controls.Clear();
            nameSearch = nameSearch.ToLower();

            var extras = MainController.GetExtras().Where(e => e.descricao.ToLower().Contains(nameSearch)).ToList();
            Console.WriteLine($"Found {extras.Count} entities.");
            foreach (var extra in extras)
            {
                CardExtra card = new CardExtra(extra);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (NewExtraForm newExtraForm = new NewExtraForm())
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    newExtraForm.Owner = addCard;
                    newExtraForm.ShowDialog();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string nameSearch = siticoneTextBox1.Text;
            LoadExtras(nameSearch);
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            string nameSearch = siticoneTextBox1.Text;
            LoadExtras(nameSearch);
        }
    }
}
