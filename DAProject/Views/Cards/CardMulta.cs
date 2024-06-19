using DAProject.Views.UpdateForms;
using Microsoft.EntityFrameworkCore.Diagnostics;
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

namespace DAProject.Views.Cards
{
    public partial class CardMulta : UserControl
    {
        private Classes.Multa getMulta;

        public CardMulta(Classes.Multa multa)
        {
            InitializeComponent();
            LoadData(multa);
        }

        private void LoadData(Classes.Multa multa)
        {
            getMulta = multa;
            lblID.Text = "Multa " + Convert.ToString(multa.id);
            lblValor.Text = Convert.ToString(multa.valor) + "€";
            lblHoras.Text = Convert.ToString(multa.numHoras) + "h";
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
                using (UpdateMultaForm updateMultaForm = new UpdateMultaForm(getMulta))
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    updateMultaForm.Owner = addCard;
                    updateMultaForm.ShowDialog();
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
            if ((MessageBox.Show("Deseja mesmo deletar esta multa?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                using (var db = new CantinaContext())
                {
                    var deleteMulta = db.Multas.Find(getMulta.id);

                    if (deleteMulta != null)
                    {
                        db.Multas.Remove(deleteMulta);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Esta multa não existe!");
                    }
                }
            }
        }
    }
}
