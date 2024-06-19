using DAProject.Properties;
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

namespace DAProject.Views
{
    public partial class NewClienteForm : MaterialForm
    {

        MaterialSkinManager materialSkinManager;
        List<string> comboData = new List<string> { "Estudante", "Professor" };
        int comboValue;
        public NewClienteForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            clientTypeCB.DataSource = comboData;
        }

        private void clientTypeCB_SelectedIndexChanged(object sender,EventArgs e)
        {

            comboValue = clientTypeCB.SelectedIndex;

            if(comboValue == 0)
            {
                numEstudantetb.Enabled = true;
                numEstudantetb.Visible = true;
                emailtb.Enabled = false;
                emailtb.Visible = false;
                pictureBox1.Image = Resources.Man_Student;
            }
            else
            {
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
                if (siticoneTextBox1.TextLength == 0 || siticoneTextBox3.TextLength == 0 || clientTypeCB.SelectedValue == null || (emailtb.Text.Length == 0 && numEstudantetb.Text.Length == 0))
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (siticoneTextBox3.TextLength != 9)
                    {
                        MessageBox.Show("O NIF deve conter 9 digitos!");
                    }
                    else
                    {
                        int nif = Convert.ToInt32(siticoneTextBox3.Text);
                        var checkNIF = db.Utilizadores.FirstOrDefault(User => User.nif == nif);

                        if(checkNIF != null) 
                        {
                            MessageBox.Show("Já existe um utilizador com este NIF!");
                        }
                        else
                        {
                            if(comboValue == 0)
                            {
                                if(numEstudantetb.Text.Length == 7) 
                                {
                                    var estudante = new Estudante { nome = siticoneTextBox1.Text, nif = Convert.ToInt32(siticoneTextBox3.Text), numEstudante = Convert.ToInt32(numEstudantetb.Text) };
                                    db.Utilizadores.Add(estudante);
                                    db.SaveChanges();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("O número de estudante deve conter 7 dígitos!");
                                }
                            }
                            else
                            {
                                if (emailtb.Text.Contains("@"))
                                {
                                    var professor = new Professor { nome = siticoneTextBox1.Text, nif = Convert.ToInt32(siticoneTextBox3.Text), email = emailtb.Text };
                                    db.Utilizadores.Add(professor);
                                    db.SaveChanges();
                                    this.Close();
                                }
                                else 
                                {
                                    MessageBox.Show("Formato de email errado (@)!");
                                }
                                
                            }
                            
                        }
                        
                    }

                }
            }
        }
    }
}
