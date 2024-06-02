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

namespace DAProject.Views.UpdateForms
{
    public partial class UpdateMultaForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        private Classes.Multa getMulta;
        public UpdateMultaForm(Classes.Multa multa)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            getMulta = multa;
            LoadData();
        }
        private void LoadData()
        {
            siticoneTextBox1.Text = Convert.ToString(getMulta.valor);
            siticoneTextBox2.Text = Convert.ToString(getMulta.numHoras);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var getMultaID = db.Multas.Find(getMulta.id);

                if (getMultaID != null)
                {
                    if (siticoneTextBox1.TextLength == 0 || siticoneTextBox2.TextLength == 0)
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }
                    else
                    { 
                        getMultaID.valor = Convert.ToInt32(siticoneTextBox1.Text);
                        getMultaID.numHoras = Convert.ToInt32(siticoneTextBox2.Text);
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Esta multa não existe!");
                }
            }
        }
    }
}
