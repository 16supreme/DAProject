using DAProject.Properties;
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
    public partial class UpdateClienteForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        private Classes.Cliente getCliente;

        public UpdateClienteForm(Classes.Cliente cliente)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            getCliente = cliente;
            LoadData();
        }

        private void LoadData()
        {
            tbNIF.Text = Convert.ToString(getCliente.nif);
            tbNome.Text = getCliente.nome;
            if (getCliente is Estudante estudante)
            {
                numEstudantetb.Text = Convert.ToString(estudante.numEstudante);
                numEstudantetb.Enabled = true;
                numEstudantetb.Visible = true;
                emailtb.Enabled = false;
                emailtb.Visible = false;
                pictureBox1.Image = Resources.Man_Student;
            }
            else if(getCliente is Professor professor)
            {
                emailtb.Text = professor.email;
                emailtb.Enabled = true;
                emailtb.Visible = true;
                numEstudantetb.Enabled = false;
                numEstudantetb.Visible = false;
                pictureBox1.Image = Resources.Man_Teacher;
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var getClienteID = db.Clientes.Find(getCliente.id);

                if (getClienteID != null)
                {

                    getClienteID.nome = tbNome.Text;
                    getClienteID.nif = Convert.ToInt32(tbNIF.Text);

                    if (getClienteID is Estudante getEstudante)
                    {
                        getEstudante.numEstudante = Convert.ToInt32(numEstudantetb.Text);
                    }
                    else if(getClienteID is Professor getProfessor)
                    {
                        getProfessor.email = emailtb.Text;
                    }
                    
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
