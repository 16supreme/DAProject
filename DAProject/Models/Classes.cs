using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAProject
{
    public class Classes
    {
        public class Utilizador
        {
            public int id { get; set; }
            public string nome { get; set; }
            public int nif { get; set; }    
        }
        public class Funcionario : Utilizador
        {
            public string username;
        }
        public class Cliente : Utilizador
        {
            public float saldo;
        }
        public class Estudante : Cliente
        {
            public int numEstudante;
        }
        public class Professor : Cliente
        {
            public string email;
        }

        public class Reserva
        {
            public int id { get; set; }
            public Cliente cliente;
            public Menu menu;
            public Prato prato;
            public List<Extra> extras;
            public Multa multa;
        }
        public class Multa
        {
            public int id { get; set; } 
            float valor;
            int numHoras;
        }
        public class Menu
        {
            public int id { get; set; } 
            DateTime dataHora;
            int qtdDisponivel;
            float precoEstudante;
            float precoProfessor;
            List<Prato> pratos;
            List<Extra> extras;
        }
        public class Prato
        {
            public int id { get; set; }
            string descricao;
            string tipo;
            bool ativo;
            List<Menu> menus;
        }
        public class Extra
        {
            public int id { get; set; }
            string descricao;
            float preco;
            bool ativo;
            List<Menu> menus;
        }
        public class Fatura
        {
            public int id { get; set; }
            float total;
            DateTime dataHora;
            Cliente cliente;
            Menu menu;
        }
        public class ItemFatura
        {
            public int id { get; set; }
            string descricao;
            float preco;
            Fatura fatura;
        }
    }
}
