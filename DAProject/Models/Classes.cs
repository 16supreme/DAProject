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
            public string username { get; set; }
        }
        public class Cliente : Utilizador
        {
            public double saldo { get; set; }
        }
        public class Estudante : Cliente
        {
            public int numEstudante { get; set; }
        }
        public class Professor : Cliente
        {
            public string email { get; set; }
        }

        public class Reserva
        {
            public int id { get; set; }
            public Cliente cliente { get; set; }
            public Menu menu { get; set; }
            public Prato prato { get; set; }
            public List<Extra> extras { get; set; }
            public Multa multa { get; set; }
        }
        public class Multa
        {
            public int id { get; set; } 
            double valor { get; set; }
            int numHoras { get; set; }
        }
        public class Menu
        {
            public int id { get; set; } 
            DateTime dataHora{ get; set; }
            int qtdDisponivel{ get; set; }
            double precoEstudante{ get; set; }
            double precoProfessor{ get; set; }
            List<Prato> pratos{ get; set; }
            List<Extra> extras{ get; set; }
        }
        public class Prato
        {
            public int id { get; set; }
            string descricao{ get; set; }
            string tipo{ get; set; }
            bool ativo{ get; set; }
            List<Menu> menus{ get; set; }
        }
        public class Extra
        {
            public int id { get; set; }
            string descricao{ get; set; }
            double preco{ get; set; }
            bool ativo{ get; set; }
            List<Menu> menus{ get; set; }
        }
        public class Fatura
        {
            public int id { get; set; }
            double total{ get; set; }
            DateTime dataHora{ get; set; }
            Cliente cliente{ get; set; }
            Menu menu{ get; set; }
        }
        public class ItemFatura
        {
            public int id { get; set; }
            string descricao{ get; set; }
            double preco{ get; set; }
            Fatura fatura{ get; set; }
        }
    }
}
