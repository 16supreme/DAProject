using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using DAProject.Views.UpdateForms;
using Siticone.Desktop.UI.WinForms;
using static DAProject.Classes;
using iText.Kernel.Exceptions;

namespace DAProject.Views.Cards
{
    public partial class CardReserva : UserControl
    {

        private Classes.Reserva GetReserva;

        public CardReserva(Classes.Reserva getReserva)
        {
            InitializeComponent();
            LoadData(getReserva); 
        }

        private void LoadData(Classes.Reserva getReserva)
        {
            GetReserva = getReserva;

            using (var db = new CantinaContext())
            {
                GetReserva = db.Reservas
                .Include(m => m.cliente)
                .Include(m => m.menu)
                .Include(m => m.prato)
                .Include(m => m.extras)
                .FirstOrDefault(m => m.id == getReserva.id);
            }

            foreach (var extra in GetReserva.extras)
            {
                extrasListBox.Items.Add(extra.ToString());
            }
            lblID.Text = Convert.ToString(getReserva.id);
            lblCliente.Text = GetReserva.cliente.nome;
            lblNIF.Text = Convert.ToString(GetReserva.cliente.nif);
            lblPrato.Text = Convert.ToString(GetReserva.prato.ToString());
            siticoneGroupBox1.Text = "(Menu)" + Convert.ToString(GetReserva.menu.dataHora);
            if (GetReserva.used)
            {
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox2, new System.Drawing.Point(0, pictureBox2.Height));
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja mesmo deletar esta reserva?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                using (var db = new CantinaContext())
                {
                    var deleteReserva = db.Reservas.Find(GetReserva.id);

                    if (deleteReserva != null)
                    {
                        db.Reservas.Remove(deleteReserva);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Esta reserva não existe!");
                    }
                }
            }
        }

        private void utilizadaNãoUtilizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var getReservaID = db.Reservas.
                    Include(m => m.cliente)
                    .Include(m => m.menu)
                    .Include(m => m.prato)
                    .Include(m => m.extras)
                    .Include(m => m.multa)
                    .FirstOrDefault(m => m.id == GetReserva.id); ;

                if (getReservaID != null)
                {
                    if (getReservaID.used)
                    {
                        getReservaID.used = false;
                        pictureBox3.Visible = false;
                        utilizadaNãoUtilizadaToolStripMenuItem.Text = "Utilizada";
                        db.SaveChanges();
                    }
                    else
                    {
                        getReservaID.used = true;
                        pictureBox3.Visible = true;
                        utilizadaNãoUtilizadaToolStripMenuItem.Text = "Não utilizada";
                        db.SaveChanges();
                        CreatePDF(getReservaID);
                    }
                }
                else
                {
                    MessageBox.Show("Esta reserva não existe!");
                }
            }
        }

        private void CreatePDF(Reserva reserva)
        {
                string path = "../FaturaFiles/" + reserva.id + ".pdf";
                double total;
                
                if (reserva.cliente is Estudante estudante)
                {
                    if(reserva.multa != null)
                    {
                        total = reserva.menu.precoEstudante + reserva.extras.Sum(e => e.preco) + reserva.multa.valor;
                    }
                    else
                    {
                        total = reserva.menu.precoEstudante + reserva.extras.Sum(e => e.preco);
                    }
                    
                }
                else
                {
                    if (reserva.multa != null)
                    {
                        total = reserva.menu.precoProfessor + reserva.extras.Sum(e => e.preco) + reserva.multa.valor;
                    }
                    else
                    {
                        total = reserva.menu.precoProfessor + reserva.extras.Sum(e => e.preco);
                    }
                }

                using (PdfWriter writer = new PdfWriter(path))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        document.Add(new Paragraph("Fatura de Reserva").SetFontSize(20).SetBold());
                        document.Add(new Paragraph("Cliente: " + reserva.cliente.nome));
                        document.Add(new Paragraph("NIF: " + reserva.cliente.nif));
                        document.Add(new Paragraph("Data do Menu: " + reserva.menu.dataHora));
                        document.Add(new Paragraph("Prato: " + reserva.prato.ToString()));
                        document.Add(new Paragraph("Extras:"));

                        foreach (var extra in reserva.extras)
                        {
                            document.Add(new Paragraph(extra.descricao + " - " + extra.preco + "€"));
                        }

                        if (reserva.multa != null) 
                        {
                            document.Add(new Paragraph("Multa: " + reserva.multa.valor.ToString() + "€"));
                        }
                        
                        document.Add(new Paragraph("Total: " + total + "€").SetBold());
                        document.Close();
                    }
                }

                
                using (var db = new CantinaContext())
                {

                    db.Set<Cliente>().Attach(reserva.cliente);
                    db.Set<Classes.Menu>().Attach(reserva.menu);
                    db.Set<Prato>().Attach(reserva.prato);
                    foreach (var extra in reserva.extras)
                    {
                        db.Set<Extra>().Attach(extra); // Assuming Extra is an entity
                    }
                    if (reserva.multa != null)
                    {
                        db.Set<Multa>().Attach(reserva.multa);
                    }
                var fatura = new Fatura { total = total, dataHora = DateTime.Now, cliente = reserva.cliente, menu = reserva.menu };
                    db.Faturas.Add(fatura);

                    foreach (var extra in reserva.extras)
                    {
                        var itemFatura = new ItemFatura { descricao = extra.descricao, preco = extra.preco, fatura = fatura };
                        db.ItensFatura.Add(itemFatura);
                    }
                    db.SaveChanges();
                }

                MessageBox.Show("Fatura criada!");
        }
    }
}
