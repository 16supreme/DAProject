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
    public partial class UpdatePratoForm : MaterialForm
    {

        MaterialSkinManager materialSkinManager;
        private Classes.Prato getPrato;
        List<string> combo1 = new List<string> { "Carne", "Peixe", "Vegetariano" };
        List<string> combo2 = new List<string> { "Disponível", "Indisponível" };
        bool getAtivo;

        public UpdatePratoForm(Classes.Prato prato)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            getPrato = prato;
            LoadData();
        }

        private void LoadData()
        {
            tbDescricao.Text = getPrato.descricao;
            siticoneComboBox1.DataSource = combo1;
            siticoneComboBox2.DataSource = combo2;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var getPratoID = db.Pratos.Find(getPrato.id);

                if (getPratoID != null)
                {
                    if (tbDescricao.TextLength == 0)
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
                            getAtivo = false;
                        }
                        getPratoID.descricao = tbDescricao.Text;
                        getPratoID.tipo = Convert.ToString(siticoneComboBox1.SelectedItem);
                        getPratoID.ativo = getAtivo;
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Este prato não existe!");
                }
            }
        }
    }
}
