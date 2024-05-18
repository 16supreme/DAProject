using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using static DAProject.Classes;

namespace DAProject.Views
{
    public partial class NewFuncionarioForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public NewFuncionarioForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700,TextShade.WHITE);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                if (siticoneTextBox1.TextLength == 0 || siticoneTextBox2.TextLength == 0 || siticoneTextBox3.TextLength == 0)
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if(siticoneTextBox3.TextLength < 9) 
                    {
                        MessageBox.Show("O NIF deve conter 9 digitos!");
                    }
                    else 
                    {
                        var funcionario = new Funcionario{ username = siticoneTextBox1.Text,nome = siticoneTextBox2.Text, nif = Convert.ToInt32(siticoneTextBox3.Text)};
                        db.Utilizadores.Add(funcionario);
                        db.Funcionarios.Add(funcionario);
                        db.SaveChanges();
                        this.Close();
                    }
                    
                }
            }
        }
    }
}
