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
        public CardFuncionario(Classes.Funcionario funcionario)
        {
            InitializeComponent();
            LoadData(funcionario);
        }
         
        private void LoadData(Classes.Funcionario funcionario)
        {
            lblNome.Text = funcionario.nome;
            lblNif.Text = Convert.ToString(funcionario.nif);
            lblUsername.Text = funcionario.username;
        }
    }
}
