using DAProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject.Views
{
    public partial class GestaoClientesForm : Form
    {
        bool AllChecked = true;
        bool StudentChecked = false;
        bool ProfessorChecked = false;
        public GestaoClientesForm()
        {
            InitializeComponent();
            LoadClientes(AllChecked,StudentChecked,ProfessorChecked);
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            Form addCard = new Form();
            try
            {
                using (NewClienteForm newClienteForm= new NewClienteForm())
                {
                    addCard.StartPosition = FormStartPosition.Manual;
                    addCard.FormBorderStyle = FormBorderStyle.None;
                    addCard.Opacity = .50d;
                    addCard.BackColor = Color.Black;
                    addCard.WindowState = FormWindowState.Maximized;
                    addCard.Location = this.Location;
                    addCard.ShowInTaskbar = false;
                    addCard.Show();
                    newClienteForm.Owner = addCard;
                    newClienteForm.ShowDialog();
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

        private void LoadClientes(bool allchecked, bool studchecked, bool profchecked,string nameSearch = "")
        {
            flowLayoutPanel1.Controls.Clear();
            nameSearch = nameSearch.ToLower();

            if (allchecked == true && studchecked == false && profchecked == false){
                var estudantes = MainController.GetEstudantes().Where(e=>e.nome.ToLower().Contains(nameSearch)).ToList();
                var professores = MainController.GetProfessores().Where(e => e.nome.ToLower().Contains(nameSearch)).ToList();
                Console.WriteLine($"Found {estudantes.Count} entities.");
                Console.WriteLine($"Found {professores.Count} entities.");
                foreach (var estudante in estudantes)
                {
                    CardEstudante card = new CardEstudante(estudante);
                    flowLayoutPanel1.Controls.Add(card);
                }
                foreach (var professor in professores)
                {
                    CardProfessor card = new CardProfessor(professor);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }else if(allchecked == false && studchecked == true && profchecked == false)
            {
                var estudantes = MainController.GetEstudantes().Where(e => e.nome.ToLower().Contains(nameSearch)).ToList();
                Console.WriteLine($"Found {estudantes.Count} entities.");
                foreach (var estudante in estudantes)
                {
                    CardEstudante card = new CardEstudante(estudante);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            else if(allchecked == false && studchecked == false && profchecked == true)
            {
                var professores = MainController.GetProfessores().Where(e => e.nome.ToLower().Contains(nameSearch)).ToList();
                Console.WriteLine($"Found {professores.Count} entities.");
                foreach (var professor in professores)
                {
                    CardProfessor card = new CardProfessor(professor);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string nameSearch = siticoneTextBox1.Text;
            LoadClientes(AllChecked, StudentChecked, ProfessorChecked,nameSearch);
        }

        private void AllRadio_CheckedChanged(object sender, EventArgs e)
        {
            AllChecked = AllRadio.Checked;
            if (AllChecked)
            {
                StudentChecked = false;
                ProfessorChecked = false;
            }
        }

        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            StudentChecked = studentRadio.Checked;
            if (StudentChecked)
            {
                AllChecked = false;
                ProfessorChecked = false;
            }
        }

        private void professorRadio_CheckedChanged(object sender, EventArgs e)
        {
            ProfessorChecked = professorRadio.Checked;
            if (ProfessorChecked)
            {
                AllChecked = false;
                StudentChecked = false;
            }
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            string nameSearch = siticoneTextBox1.Text;
            LoadClientes(AllChecked,StudentChecked,ProfessorChecked,nameSearch);
        }
    }
}
