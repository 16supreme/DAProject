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
    public partial class MultasForm : Form
    {
        public MultasForm()
        {
            InitializeComponent();
            LoadMultas();
        }

        private void LoadMultas(string hourSearch = "")
        {
            flowLayoutPanel1.Controls.Clear();

            List<Classes.Multa> multas;

            if (hourSearch.Length == 0)
            {
                multas = MainController.GetMultas();
            }
            else
            {
                int SearchHour = Convert.ToInt32(hourSearch);
                multas = MainController.GetMultas().Where(e => e.numHoras == SearchHour).ToList();
            }
            
            Console.WriteLine($"Found {multas.Count} entities.");
            foreach (var multa in multas)
            {
                CardMulta card = new CardMulta(multa);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string hourSearch = siticoneTextBox1.Text;
            LoadMultas(hourSearch);
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (NewMultaForm newMultaForm = new NewMultaForm())
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    newMultaForm.Owner = addCard;
                    newMultaForm.ShowDialog();
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

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            string hourSearch = siticoneTextBox1.Text;
            LoadMultas(hourSearch);
        }
    }
}
