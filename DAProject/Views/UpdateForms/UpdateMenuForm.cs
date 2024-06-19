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
using DAProject.Controllers;
using MaterialSkin;
using MaterialSkin.Controls;
using Siticone.Desktop.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static DAProject.Classes;
using System.Data.Entity.Infrastructure;


namespace DAProject.Views.UpdateForms
{
    public partial class UpdateMenuForm : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        private Classes.Menu getMenu;
        List<Classes.Prato> pratosCarne = new List<Classes.Prato>();
        List<Classes.Prato> pratosPeixe = new List<Classes.Prato>();
        List<Classes.Prato> pratosVeggie = new List<Classes.Prato>();

        public UpdateMenuForm(Classes.Menu menu)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
            LoadData(menu);
            LoadPratos();
            LoadExtras();
        }

        private void LoadData(Classes.Menu menu)
        {
            getMenu = menu;

            txtqntdDisponivel.Text = Convert.ToString(getMenu.qtdDisponivel);
            txtprecoEstudante.Text = Convert.ToString(getMenu.precoEstudante);
            txtprecoProfessor.Text = Convert.ToString(getMenu.precoProfessor);
            dateTimePicker1.Value = getMenu.dataHora;
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
                    var getMenuID = db.Menus.Include(m => m.pratos).Include(m => m.extras).SingleOrDefault(m => m.id == getMenu.id);

                    if (getMenuID != null)
                    {

                        if (DateTimeIsValid(getMenuID))
                        {
                            try
                            {
                                getMenuID.pratos.Clear();
                                getMenuID.extras.Clear();

                                int meatItemId = (int)meatCombo.SelectedValue;
                                int fishItemId = (int)fishCombo.SelectedValue;
                                int veggieItemId = (int)veggieCombo.SelectedValue;

                                int[] plateIDS = new int[] { meatItemId, fishItemId, veggieItemId };
                                foreach (var plateId in plateIDS)
                                {
                                    var plate = db.Pratos.Find(plateId);
                                    if (plate != null)
                                    {
                                        if (db.Entry(plate).State == EntityState.Detached)
                                        {
                                            db.Pratos.Attach(plate);
                                        }
                                        getMenuID.pratos.Add(plate);
                                    }

                                }

                                foreach (var item in extraChecked.CheckedItems)
                                {
                                    if (item is Classes.Extra selectedExtra)
                                    {
                                        var extra = db.Extras.Find(selectedExtra.id);
                                        if (extra != null)
                                        {
                                            if (db.Entry(extra).State == EntityState.Detached)
                                            {
                                                db.Extras.Attach(extra);
                                            }
                                            getMenuID.extras.Add(extra);
                                        }

                                    }
                                }

                                getMenuID.dataHora = dateTimePicker1.Value;
                                getMenuID.qtdDisponivel = Convert.ToInt32(txtqntdDisponivel.Text);
                                getMenuID.precoEstudante = Convert.ToDouble(txtprecoEstudante.Text);
                                getMenuID.precoProfessor = Convert.ToDouble(txtprecoProfessor.Text);

                                db.SaveChanges();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Já existe um Menu com esta data e hora!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este menu não existe!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        
        private bool FormIsValid()
        {
            if (txtqntdDisponivel.TextLength == 0 || txtprecoEstudante.TextLength == 0 || txtprecoProfessor.TextLength == 0 || meatCombo.SelectedItem == null || fishCombo.SelectedItem == null || veggieCombo.SelectedItem == null || extraChecked.CheckedItems == null)
            {
                return false;
            }

            return true;
        }

        private bool DateTimeIsValid(Classes.Menu menu)
        {

            List<Classes.Menu> menus = MainController.GetMenus();
            foreach (var item in menus)
            {
                if (item.dataHora.Date == dateTimePicker1.Value.Date && item.dataHora.Hour == dateTimePicker1.Value.Hour && item.dataHora.Minute == dateTimePicker1.Value.Minute && item.dataHora.Date != menu.dataHora.Date && item.dataHora.Minute != menu.dataHora.Minute)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
