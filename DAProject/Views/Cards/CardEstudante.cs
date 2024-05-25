using DAProject.Views.UpdateForms;
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

namespace DAProject.Views
{
    public partial class CardEstudante : UserControl
    {
        private Classes.Cliente getCliente;
        public CardEstudante(Classes.Estudante estudante)
        {
            InitializeComponent();
            LoadData(estudante);
        }

        private void LoadData(Classes.Estudante estudante)
        {
            getCliente = estudante;
            lblSaldo.Text = Convert.ToString(estudante.saldo) + "€";
            lblNif.Text = Convert.ToString(estudante.nif);
            lblNome.Text = estudante.nome;
            lblNumEstudante.Text = Convert.ToString(estudante.numEstudante);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                contextMenuStrip1.Show(pictureBox2, new System.Drawing.Point(0, pictureBox2.Height));
            
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (UpdateClienteForm updateClienteForm= new UpdateClienteForm(getCliente))
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    updateClienteForm.Owner = addCard;
                    updateClienteForm.ShowDialog();
                    addCard.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                addCard.Dispose();
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja mesmo deletar este cliente?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                using (var db = new CantinaContext())
                {
                    var deleteEstudante= db.Clientes.Find(getCliente.id);

                    if (deleteEstudante != null)
                    {
                        db.Clientes.Remove(deleteEstudante);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Este estudante não existe!");
                    }
                }
            }
        }
    }
}
