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
        public CardEstudante(Classes.Estudante estudante)
        {
            InitializeComponent();
            LoadData(estudante);
        }

        private void LoadData(Classes.Estudante estudante)
        {
            lblSaldo.Text = Convert.ToString(estudante.saldo) + "€";
            lblNif.Text = Convert.ToString(estudante.nif);
            lblNome.Text = estudante.nome;
            lblNumEstudante.Text = Convert.ToString(estudante.numEstudante);
        }
    }
}
