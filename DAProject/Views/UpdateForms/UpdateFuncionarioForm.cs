using MaterialSkin;
using MaterialSkin.Controls;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject.Views.UpdateForms
{
    public partial class UpdateFuncionarioForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        private Classes.Funcionario getFuncionario;
        
        public UpdateFuncionarioForm(Classes.Funcionario funcionario)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            getFuncionario = funcionario;
            LoadData();
        }

        private void LoadData()
        {
            tbNome.Text = getFuncionario.nome;
            tbNif.Text = Convert.ToString(getFuncionario.nif);
            tbUsername.Text = getFuncionario.username;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var getFuncionarioID = db.Funcionarios.Find(getFuncionario.id);

                if (getFuncionarioID != null) 
                {
                    getFuncionarioID.nome = tbNome.Text;
                    getFuncionarioID.nif = Convert.ToInt32(tbNif.Text);
                    getFuncionarioID.username = tbUsername.Text;
                    db.SaveChanges();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Este funcionário não existe!");
                }
            }
        }
    }
}
