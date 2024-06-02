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
    public partial class NewMultaForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public NewMultaForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                if (siticoneTextBox1.TextLength == 0 || siticoneTextBox2.TextLength == 0)
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    var multa = new Multa { valor = Convert.ToInt32(siticoneTextBox1.Text),numHoras = Convert.ToInt32(siticoneTextBox2.Text) };
                    db.Multas.Add(multa);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
