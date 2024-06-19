using DAProject.Controllers;
using MaterialSkin;
using MaterialSkin.Controls;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject.Views.InsertForms
{
    public partial class NewMenuForm : MaterialForm
    {
        MaterialSkinManager materialskinManager;
        List<Classes.Prato> pratosCarne = new List<Classes.Prato>();
        List<Classes.Prato> pratosPeixe = new List<Classes.Prato>();
        List<Classes.Prato> pratosVeggie = new List<Classes.Prato>();
        List<Classes.Prato> menuPlates = new List<Classes.Prato>();
        List<Classes.Extra> checkedExtras = new List<Classes.Extra>();


        public NewMenuForm()
        {
            InitializeComponent();
            materialskinManager = MaterialSkinManager.Instance;
            materialskinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);

            dateTimePicker1.MinDate = DateTime.Today;

            LoadPratos();
            LoadExtras();
        }

        private void LoadPratos()
        {
            var plates = MainController.GetPratos();
            foreach (var plate in plates)
            {
                if (plate.ativo == true)
                {
                    switch (plate.tipo)
                    {
                        case "Carne":
                            pratosCarne.Add(plate);
                            break;
                        case "Peixe":
                            pratosPeixe.Add(plate);
                            break;
                        default:
                            pratosVeggie.Add(plate);
                            break;
                    }
                }

            }

            meatCombo.DataSource = pratosCarne;
            meatCombo.DisplayMember = "descricao";
            meatCombo.ValueMember = "id";

            fishCombo.DataSource = pratosPeixe;
            fishCombo.DisplayMember = "descricao";
            fishCombo.ValueMember = "id";

            veggieCombo.DataSource = pratosVeggie;
            veggieCombo.DisplayMember = "descricao";
            veggieCombo.ValueMember = "id";
        }

        private void LoadExtras()
        {
            var checkeditems = MainController.GetExtras();
            foreach (var item in checkeditems)
            {
                if (item.ativo == true)
                {
                    extraChecked.Items.Add(item);
                }

            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

            if (FormIsValid())
            {
                using (var db = new CantinaContext())
                {
                    if (DateTimeIsValid())
                    {
                        InsertMenu(db);
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Já existe um Menu com esta data e hora!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void InsertMenu(CantinaContext db)
        {
            int meatItemId = (int)meatCombo.SelectedValue;
            int fishItemId = (int)fishCombo.SelectedValue;
            int veggieItemId = (int)veggieCombo.SelectedValue;

            menuPlates.Clear();

            var plates = MainController.GetPratos();
            foreach (var plate in plates)
            {
                if (plate.id == meatItemId || plate.id == fishItemId || plate.id == veggieItemId)
                {
                    menuPlates.Add(plate);
                    Console.WriteLine("Added Plate: " + plate.id);
                }
            }


            checkedExtras.Clear();

            foreach (var item in extraChecked.CheckedItems)
            {
                if (item is Classes.Extra selectedExtra)
                {
                    foreach (var extra in MainController.GetExtras())
                    {
                        if (extra.id == selectedExtra.id)
                        {
                            checkedExtras.Add(extra);
                            Console.WriteLine("Added Extra: " + extra.id);
                        }
                    }
                }
            }

            var menu = new Classes.Menu { dataHora = dateTimePicker1.Value, qtdDisponivel = Convert.ToInt32(txtqntdDisponivel.Text), precoEstudante = Convert.ToDouble(txtprecoEstudante.Text), precoProfessor = Convert.ToDouble(txtprecoProfessor.Text), pratos = menuPlates, extras = checkedExtras };

            foreach (var prato in menuPlates)
            {
                if (db.Entry(prato).State == EntityState.Detached)
                {
                    db.Pratos.Attach(prato);
                }
            }

            foreach (var extra in checkedExtras)
            {
                if (db.Entry(extra).State == EntityState.Detached)
                {
                    db.Extras.Attach(extra);
                }
            }

            db.Menus.Add(menu);
        }

        private bool FormIsValid() 
        {
            if(txtqntdDisponivel.TextLength == 0 || txtprecoEstudante.TextLength == 0 || txtprecoProfessor.TextLength == 0 || meatCombo.SelectedItem == null || fishCombo.SelectedItem == null || veggieCombo.SelectedItem == null || extraChecked.CheckedItems == null)
            {
                return false; 
            }

            return true;
        }

        private bool DateTimeIsValid()
        {
            List<Classes.Menu> menus = MainController.GetMenus();
            foreach (var item in menus)
            {
                if (item.dataHora.Date == dateTimePicker1.Value.Date && item.dataHora.Hour == dateTimePicker1.Value.Hour && item.dataHora.Minute == dateTimePicker1.Value.Minute)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

