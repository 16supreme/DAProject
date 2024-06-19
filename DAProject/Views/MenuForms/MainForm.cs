using DAProject.Controllers;
using DAProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (HomeForm == null)
            {
                HomeForm = new HomeForm(this);
                HomeForm.FormClosed += HomeForm_FormClosed;
                HomeForm.MdiParent = this;
                HomeForm.Dock = DockStyle.Fill;
                HomeForm.Show();
            }
            else
            {
                HomeForm.Activate();
            }
        }

        bool sideBarExpand = true;
        HomeForm HomeForm;
        ReservasForm reservasForm;
        PratosForm pratosForm;
        ExtrasForm extrasForm;
        MenusForm menusForm;
        MultasForm multasForm;
        GestaoClientesForm gestaoClientesForm;
        FuncionariosForm funcionariosForm;
        //MainController mainController = new MainController();

        //<-- Application Form Handling
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,int wParam,int lParam);

        private void OnMouseDown(object sender,MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle,WM_NCLBUTTONDOWN,HTCAPTION,0);
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }else 
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        //Application Form Handling -->

        private void sidebarTransition_Tick(object sender,EventArgs e)
        {
            
            if (sideBarExpand)
            {
                
                sideBar.Width -= 10;
                if(sideBar.Width <= 95)
                {
                    sideBarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if(sideBar.Width >= 200)
                {
                    sideBarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(HomeForm == null)
            {
                HomeForm = new HomeForm(this);
                HomeForm.FormClosed += HomeForm_FormClosed;
                HomeForm.MdiParent = this;
                HomeForm.Dock = DockStyle.Fill;
                HomeForm.Show();
            }
            else
            {
                HomeForm.Activate();
            }
        }

        private void HomeForm_FormClosed(object sender,FormClosedEventArgs e)
        {
            HomeForm = null;
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            if (reservasForm == null)
            {
                reservasForm = new ReservasForm();
                reservasForm.FormClosed += reservasForm_FormClosed;
                reservasForm.MdiParent = this;
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

        private void btnPratos_Click(object sender, EventArgs e)
        {
            if (pratosForm == null)
            {
                pratosForm = new PratosForm();
                pratosForm.FormClosed += pratosForm_FormClosed;
                pratosForm.MdiParent = this;
                pratosForm.Dock = DockStyle.Fill;
                pratosForm.Show();
            }
            else
            {
                pratosForm.Activate();
            }
        }

        private void pratosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pratosForm = null;
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            if (extrasForm == null)
            {
                extrasForm = new ExtrasForm();
                extrasForm.FormClosed += extrasForm_FormClosed;
                extrasForm.MdiParent = this;
                extrasForm.Dock = DockStyle.Fill;
                extrasForm.Show();
            }
            else
            {
                extrasForm.Activate();
            }
        }

        private void extrasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            extrasForm = null;
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            if (menusForm == null)
            {
                menusForm = new MenusForm();
                menusForm.FormClosed += menusForm_FormClosed;
                menusForm.MdiParent = this;
                menusForm.Dock = DockStyle.Fill;
                menusForm.Show();
            }
            else
            {
                menusForm.Activate();
            }
        }

        private void menusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menusForm = null;
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            if (multasForm == null)
            {
                multasForm = new MultasForm();
                multasForm.FormClosed += multasForm_FormClosed;
                multasForm.MdiParent = this;
                multasForm.Dock = DockStyle.Fill;
                multasForm.Show();
            }
            else
            {
                multasForm.Activate();
            }
        }

        private void multasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            multasForm = null;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (gestaoClientesForm == null)
            {
                gestaoClientesForm = new GestaoClientesForm();
                gestaoClientesForm.FormClosed += gestaoClientesForm_FormClosed;
                gestaoClientesForm.MdiParent = this;
                gestaoClientesForm.Dock = DockStyle.Fill;
                gestaoClientesForm.Show();
            }
            else
            {
                gestaoClientesForm.Activate();
            }
        }

        private void gestaoClientesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            gestaoClientesForm = null;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            if (funcionariosForm == null)
            {
                funcionariosForm = new FuncionariosForm();
                funcionariosForm.FormClosed += funcionariosForm_FormClosed;
                funcionariosForm.MdiParent = this;
                funcionariosForm.Dock = DockStyle.Fill;
                funcionariosForm.Show();
            }
            else
            {
                funcionariosForm.Activate();
            }
        }

        private void funcionariosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            funcionariosForm = null;
        }
    }
}
