using DAProject.Views.Cards;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject.Views.InsertForms
{
    public partial class ConfirmReserva : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        string lblextras;
        double precoExtras = 0;
        double precoMenu = 0;
        double precoMulta = 0;
        double precoTotal = 0 ;
        Cliente getCliente;
        Classes.Menu getMenu;
        Prato getPrato;
        List<Extra> getExtras;
        Multa getMulta;

        public ConfirmReserva(Cliente client, Classes.Menu menu, Prato prato, List<Extra> extras, Multa multa, string clientType)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);

            getData(client,menu,prato,extras,multa);

            lblextras = null;
            precoExtras = 0;

            lblClientType.Text = clientType;
            lblNIF.Text = Convert.ToString(client.nif);
            lblmenu.Text = Convert.ToString(menu.dataHora);
            lblPrato.Text = prato.ToString();
            foreach (var extra in extras)
            {
                lblextras += extra.ToString() + "; ";
                precoExtras += extra.preco;
            }
            lblExtras.Text = lblextras;

            if(clientType == "Estudante")
            {
                precoMenu = menu.precoEstudante;
            }
            else
            {
                precoMenu = menu.precoProfessor;
            }

            if (multa != null) 
            {
                precoMulta = multa.valor;
            }

            precoTotal = precoMenu + precoExtras + precoMulta;

            lblMulta.Text = precoMulta.ToString() + "€";
            lblPrecoMenu.Text = precoMenu.ToString() + "€";
            lblPrecoExtras.Text = precoExtras.ToString() + "€";
            lblPrecoTotal.Text = (precoMenu + precoExtras + precoMulta).ToString() + "€";

        }

        private void getData(Cliente client, Classes.Menu menu, Prato prato, List<Extra> extras, Multa multa)
        {
            getCliente = client;
            getMenu = menu;
            getPrato = prato;
            getExtras = extras;
            getMulta = multa;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if(getCliente.saldo < precoTotal)
            {
                MessageBox.Show("Saldo insuficiente!");
            }
            else
            {
                using (var db = new CantinaContext())
                {
                    getCliente = db.Clientes.Find(getCliente.id) ?? getCliente;
                    AttachEntityIfNotTracked(db, getCliente);

                    getMenu = db.Menus.Find(getMenu.id) ?? getMenu;
                    AttachEntityIfNotTracked(db, getMenu);

                    getPrato = db.Pratos.Find(getPrato.id) ?? getPrato;
                    AttachEntityIfNotTracked(db, getPrato);

                    if (getExtras != null)
                    {
                        for (int i = 0; i < getExtras.Count; i++)
                        {
                            getExtras[i] = db.Extras.Find(getExtras[i].id) ?? getExtras[i];
                            AttachEntityIfNotTracked(db, getExtras[i]);
                        }
                    }

                    if (getMulta != null)
                    {
                        getMulta = db.Multas.Find(getMulta.id) ?? getMulta;
                        AttachEntityIfNotTracked(db, getMulta);
                    }

                    getCliente.saldo -= precoTotal;
                    getMenu.qtdDisponivel--;

                    var reserva = new Reserva { cliente = getCliente, menu = getMenu, prato = getPrato, extras = getExtras, multa = getMulta,used = false};
                    db.Reservas.Add(reserva);
                    db.SaveChanges();
                    CreateTalao(reserva);
                    this.Close();
                }
            }
            
        }

        private void AttachEntityIfNotTracked(DbContext context, object entity)
        {
            var entry = context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                context.Set(entity.GetType()).Attach(entity);
                entry.State = EntityState.Modified;
            }
        }

        private void CreateTalao(Reserva reserva)
        {
            string fileName = "../TalaoFiles/"+reserva.id+".txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Talão de Reserva");
                writer.WriteLine("=================");
                writer.WriteLine("Cliente: "+reserva.cliente.nome);
                writer.WriteLine("NIF: " + reserva.cliente.nif);
                writer.WriteLine();
                writer.WriteLine("Menu:");
                writer.WriteLine("Data/Hora: " + reserva.menu.dataHora);
                writer.WriteLine("Prato: " + reserva.prato);
                
                writer.WriteLine("Extras:");
                foreach (var extra in reserva.extras)
                {
                    writer.WriteLine("- " + extra.descricao + ":" + extra.preco +"€");
                }

                writer.WriteLine();
                if(reserva.multa != null)
                {
                    writer.WriteLine("Multa: " + reserva.multa.valor.ToString() + "€");
                }
                writer.WriteLine("Total: " + lblPrecoTotal.Text);
            }
        }

    }
}
