using DAProject.Controllers;
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
    public partial class FuncionariosForm : Form
    {

        public FuncionariosForm()
        {
            InitializeComponent();
            LoadFuncionarios();
        }

        private void AddCard_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (NewFuncionarioForm newFuncionarioForm = new NewFuncionarioForm())
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    newFuncionarioForm.Owner = addCard;
                    newFuncionarioForm.ShowDialog();
                    addCard.Dispose();  
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                addCard.Dispose();
            }
        }

        private void LoadFuncionarios()
        {

            var funcionarios = MainController.GetFuncionarios();
            Console.WriteLine($"Found {funcionarios.Count} entities.");
            foreach (var funcionario in funcionarios)
            {
                CardFuncionario card = new CardFuncionario(funcionario);
                flowLayoutPanel1.Controls.Add(card);
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadFuncionarios();
        }
    }
}
