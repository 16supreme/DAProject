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

namespace DAProject.Views.Cards
{
    public partial class CardExtra : UserControl
    {
        private Classes.Extra getExtra;
        public CardExtra(Classes.Extra extra)
        {
            InitializeComponent();
            LoadData(extra);
        }

        private void LoadData(Classes.Extra extra)
        {
            getExtra = extra;
            lblDescricao.Text = extra.descricao;
            lblPreco.Text = Convert.ToString(extra.preco) + "€";
            if (extra.ativo)
            {
                lblAtivo.Text = "Disponível";
            }
            else
            {
                lblAtivo.Text = "Indisponível";
            }
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
                using (UpdateExtraForm updateExtraForm = new UpdateExtraForm(getExtra))
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    updateExtraForm.Owner = addCard;
                    updateExtraForm.ShowDialog();
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
            if ((MessageBox.Show("Deseja mesmo deletar este extra?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                using (var db = new CantinaContext())
                {
                    var deleteExtra = db.Extras.Find(getExtra.id);

                    if (deleteExtra != null)
                    {
                        db.Extras.Remove(deleteExtra);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Este extra não existe!");
                    }
                }
            }
        }
    }
}
