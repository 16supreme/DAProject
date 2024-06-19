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
    public partial class MenusForm : Form
    {
        public MenusForm()
        {
            InitializeComponent();
            LoadMenus();
        }

        private void LoadMenus(string dateSearch="")
        {
            flowLayoutPanel1.Controls.Clear();
            List<Classes.Menu> menus;

            if (dateSearch.Length == 0)
            {
                menus = MainController.GetMenus();
            }
            else
            {
                DateTime SearchDate;
                bool isValidDate = DateTime.TryParse(dateSearch, out SearchDate);
                if (isValidDate)
                {
                    menus = MainController.GetMenus().Where(e => e.dataHora == SearchDate).ToList();
                }
                else
                {
                    menus = MainController.GetMenus();
                }
                
            }
            
            Console.WriteLine($"Found {menus.Count} entities.");
            foreach (var menu in menus)
            {
                CardMenu card = new CardMenu(menu);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string dateSearch = siticoneTextBox1.Text;
            LoadMenus(dateSearch);
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (NewMenuForm newMenuForm = new NewMenuForm())
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    newMenuForm.Owner = addCard;
                    newMenuForm.ShowDialog();
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
            string dateSearch = siticoneTextBox1.Text;
            LoadMenus(dateSearch);
        }
    }
}
