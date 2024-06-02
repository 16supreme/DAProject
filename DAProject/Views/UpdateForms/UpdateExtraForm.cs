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
    public partial class UpdateExtraForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        private Classes.Extra getExtra;
        List<string> combo1 = new List<string> { "Disponível", "Indisponível" };
        bool getAtivo;
        public UpdateExtraForm(Classes.Extra extra)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            getExtra = extra;
            LoadData();
        }
        private void LoadData()
        {
            tbDescricao.Text = getExtra.descricao;
            tbPreco.Text = Convert.ToString(getExtra.preco);
            siticoneComboBox1.DataSource = combo1;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var getExtraID = db.Extras.Find(getExtra.id);

                if (getExtraID != null)
                {
                    if (tbDescricao.TextLength == 0 || tbPreco.TextLength == 0)
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
                        getExtraID.descricao = tbDescricao.Text;
                        getExtraID.preco = Convert.ToDouble(tbPreco.Text);
                        getExtraID.ativo = getAtivo;
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Este extra não existe!");
                }
            }
        }
    }
}
