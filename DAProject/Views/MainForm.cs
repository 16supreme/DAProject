﻿using DAProject.Views;
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

        bool sideBarExpand = true;
        ReservasForm reservasForm;
        PratosForm pratosForm;
        ExtrasForm extrasForm;
        MenusForm menuForms;
        MultasForm multasForm;
        GestaoClientesForm gestaoClientesForm;
        FuncionariosForm funcionariosForm;

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
    }
}
