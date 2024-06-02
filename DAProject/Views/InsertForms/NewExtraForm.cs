using MaterialSkin;
using MaterialSkin.Controls;
using Siticone.Desktop.UI.WinForms;
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
    public partial class NewExtraForm : MaterialForm
    {
        MaterialSkinManager materialskinManager;
        List<string> combo1 = new List<string> { "Disponível", "Indisponível" };
        bool getAtivo;
        public NewExtraForm()
        {
            InitializeComponent();
            materialskinManager = MaterialSkinManager.Instance;
            materialskinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            siticoneComboBox1.DataSource = combo1;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                if (siticoneTextBox1.TextLength == 0 || siticoneTextBox2.Text.Length == 0 || siticoneComboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (siticoneComboBox1.SelectedItem == "Disponível")
                    {
                        getAtivo = true;
                    }
                    else
                    {
                        getAtivo = false;
                    }
                    var extra = new Extra { descricao = siticoneTextBox1.Text, preco = Convert.ToDouble(siticoneTextBox2.Text), ativo = getAtivo };
                    db.Extras.Add(extra);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
