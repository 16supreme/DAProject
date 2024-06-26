﻿using DAProject.Views.UpdateForms;
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

namespace DAProject.Views
{
    public partial class CardPrato : UserControl
    {
        private Classes.Prato getPrato;
        public CardPrato(Classes.Prato prato)
        {
            InitializeComponent();
            LoadData(prato);
        }

        private void LoadData(Classes.Prato prato)
        {
            getPrato = prato;
            lblDescricao.Text = prato.descricao;
            lblTipo.Text = prato.tipo;
            if (prato.ativo) 
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
                using (UpdatePratoForm updatePratoForm = new UpdatePratoForm(getPrato))
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    updatePratoForm.Owner = addCard;
                    updatePratoForm.ShowDialog();
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
            if ((MessageBox.Show("Deseja mesmo deletar este prato?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                using (var db = new CantinaContext())
                {
                    var deletePrato = db.Pratos.Find(getPrato.id);

                    if (deletePrato != null)
                    {
                        db.Pratos.Remove(deletePrato);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Este prato não existe!");
                    }
                }
            }
        }

        public void SetPictureBoxImage(Image image)
        {
            pictureBox1.Image = image;
        }
    }
}
