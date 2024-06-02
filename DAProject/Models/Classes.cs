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
            public double valor { get; set; }
            public int numHoras { get; set; }
        }
        public class Menu
        {
            public int id { get; set; }
            public DateTime dataHora { get; set; }
            public int qtdDisponivel { get; set; }
            public double precoEstudante { get; set; }
            public double precoProfessor{ get; set; }
            public List<Prato> pratos{ get; set; }
            public List<Extra> extras{ get; set; }
        }
        public class Prato
        {
            public int id { get; set; }
            public string descricao{ get; set; }
            public string tipo { get; set; }
            public bool ativo { get; set; }
            public List<Menu> menus{ get; set; }
        }
        public class Extra
        {
            public int id { get; set; }
            public string descricao{ get; set; }
            public double preco{ get; set; }
            public bool ativo{ get; set; }
            public List<Menu> menus{ get; set; }
        }
        public class Fatura
        {
            public int id { get; set; }
            public double total{ get; set; }
            public DateTime dataHora{ get; set; }
            public Cliente cliente{ get; set; }
            public Menu menu{ get; set; }
        }
        public class ItemFatura
        {
            public int id { get; set; }
            public string descricao{ get; set; }
            public double preco{ get; set; }
            public Fatura fatura{ get; set; }
        }
    }
}
