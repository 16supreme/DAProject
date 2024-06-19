using DAProject.Controllers;
using DAProject.Views.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAProject.Views
{
    public partial class HomeForm : Form
    {
        MainForm mainForm;
        int month, year;
        public HomeForm(MainForm mainform)
        {
            InitializeComponent();
            mainForm = mainform;
            DisplayDays();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            List<Classes.Funcionario> funcComboData = MainController.GetFuncionarios();
            funcCombo.DataSource = funcComboData;
            funcCombo.Enabled = true;
            funcCombo.Visible = true;
            funcCombo.DroppedDown = true;
            funcUsername.Visible = false;
        }

        private void funcCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcCombo.Enabled = false;
            funcCombo.Visible = false;
            funcUsername.Text = Convert.ToString(funcCombo.SelectedItem);
            funcUsername.Visible=true;
        }

        public void DisplayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblMonthYear.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year,month,1);

            int days = DateTime.DaysInMonth(year,month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek);

            for (int i = 0; i < dayOfTheWeek; i++) 
            {
                BlankUC blankUC = new BlankUC();
                CalendarLayout.Controls.Add(blankUC);
            }

            for(int i = 1;i <= days;i++) 
            {
                var menus = MainController.GetMenus();
                DateTime cardDate = new DateTime(year,month,i);

                CardDays cardDays = new CardDays(mainForm);
                cardDays.Days(i);
                foreach(var menu in menus)
                {
                    if(menu.dataHora.Date == cardDate)
                    {
                        cardDays.Menus(menu.dataHora);
                    }
                }
                CalendarLayout.Controls.Add(cardDays);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            CalendarLayout.Controls.Clear();

            if (month == 1)
            {
                month = 13;
                year--;
            }

            month--;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblMonthYear.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek);

            for (int i = 0; i < dayOfTheWeek; i++)
            {
                BlankUC blankUC = new BlankUC();
                CalendarLayout.Controls.Add(blankUC);
            }

            for (int i = 1; i <= days; i++)
            {
                var menus = MainController.GetMenus();
                DateTime cardDate = new DateTime(year, month, i);
                CardDays cardDays = new CardDays(mainForm);
                cardDays.Days(i);
                foreach (var menu in menus)
                {
                    if (menu.dataHora.Date == cardDate)
                    {
                        cardDays.Menus(menu.dataHora);
                    }
                }
                CalendarLayout.Controls.Add(cardDays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            CalendarLayout.Controls.Clear();

            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblMonthYear.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek);

            for (int i = 0; i < dayOfTheWeek; i++)
            {
                BlankUC blankUC = new BlankUC();
                CalendarLayout.Controls.Add(blankUC);
            }

            for (int i = 1; i <= days; i++)
            {
                var menus = MainController.GetMenus();
                DateTime cardDate = new DateTime(year, month, i);
                CardDays cardDays = new CardDays(mainForm);
                cardDays.Days(i);
                foreach (var menu in menus)
                {
                    if (menu.dataHora.Date == cardDate)
                    {
                        cardDays.Menus(menu.dataHora);
                    }
                }
                CalendarLayout.Controls.Add(cardDays);
            }
        }

        private void updateCalendar_Click(object sender, EventArgs e)
        {
            CalendarLayout.Controls.Clear();
            DisplayDays();
        }
    }
}
