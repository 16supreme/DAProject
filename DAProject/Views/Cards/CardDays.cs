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

namespace DAProject.Views.Cards
{
    public partial class CardDays : UserControl
    {
        ReservasForm reservasForm;
        MainForm mainForm;
        public CardDays(MainForm mainform)
        {
            InitializeComponent();
            mainForm = mainform;
        }

        private void CardDays_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numday)
        {
            lblDay.Text = numday+"";
        }

        public void Menus(DateTime menuDate)
        {
            menuIDs.Items.Add(menuDate);
        }

        private void CardDays_Click(object sender, EventArgs e)
        {
            if (reservasForm == null)
            {
                reservasForm = new ReservasForm();
                reservasForm.FormClosed += reservasForm_FormClosed;
                reservasForm.MdiParent = mainForm;
                reservasForm.Dock = DockStyle.Fill;
                reservasForm.Show();
            }
            else
            {
                reservasForm.Activate();
            }
        }

        private void reservasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reservasForm = null;
        }
    }
}
