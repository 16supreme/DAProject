using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject.Views.InsertForms
{
    public partial class NewPratoForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        List<string> combo1 = new List<string>{"Carne","Peixe","Vegetariano"};
        List<string> combo2 = new List<string>{"Disponível","Indisponível"};
        bool getAtivo;

        public NewPratoForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            siticoneComboBox1.DataSource = combo1;
            siticoneComboBox2.DataSource = combo2;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                if (siticoneTextBox1.TextLength == 0 || siticoneComboBox1.SelectedItem == null || siticoneComboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (siticoneComboBox2.SelectedItem == "Disponível")
                    {
                        getAtivo = true;
                    }
                    else
                    {
                        getAtivo= false;
                    }
                    var prato = new Prato{ descricao = siticoneTextBox1.Text, tipo = Convert.ToString(siticoneComboBox1.SelectedItem), ativo = getAtivo };
                    db.Pratos.Add(prato);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
