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

namespace DAProject.Views.UpdateForms
{
    public partial class UpdateClienteSaldo : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        Classes.Cliente client;

        public UpdateClienteSaldo(Cliente cliente)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            client = cliente;
            txtSaldo.Text = Convert.ToString(client.saldo);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var getClienteID = db.Clientes.Find(client.id);

                if (getClienteID != null)
                {

                    getClienteID.saldo += Convert.ToDouble(txtSaldo.Text);

                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este cliente não existe!");
                }
            }
        }
    }
}
