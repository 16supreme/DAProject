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

namespace DAProject.Views
{
    public partial class CardFuncionario : UserControl
    {
        private Classes.Funcionario getFuncionario;
        public CardFuncionario(Classes.Funcionario funcionario)
        {
            InitializeComponent();
            LoadData(funcionario);
        }
         
        private void LoadData(Classes.Funcionario funcionario)
        {
            getFuncionario = funcionario;
            lblNome.Text = funcionario.nome;
            lblNif.Text = Convert.ToString(funcionario.nif);
            lblUsername.Text = funcionario.username;
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
                using (UpdateFuncionarioForm updateFuncionarioForm = new UpdateFuncionarioForm(getFuncionario))
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    updateFuncionarioForm.Owner = addCard;
                    updateFuncionarioForm.ShowDialog();
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
                    var deleteFuncionario = db.Funcionarios.Find(getFuncionario.id);

                    if (deleteFuncionario != null)
                    {
                        db.Funcionarios.Remove(deleteFuncionario);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Este professor não existe!");
                    }
                }
            }
        }
    }
}
