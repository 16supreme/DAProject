using DAProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAProject.Classes;

namespace DAProject.Controllers
{
    public class MainController
    {
        public MainController() { }
        public void FormTransition<T>(ref Form form,MainForm mainform, FormClosedEventHandler form_FormClosed)
        {
                if (form == null)
                {
                Console.WriteLine(Convert.ToString(form), mainform, form_FormClosed);
                    form = new Form();
                    form.FormClosed += form_FormClosed;
                    form.MdiParent = mainform;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }
        public static List<Funcionario> GetFuncionarios()
        {
            using (var db = new CantinaContext())
            {
                return db.Funcionarios.ToList();
            }
        }

        public static List<Estudante> GetEstudantes()
        {
            using (var db = new CantinaContext())
            {
                return db.Estudantes.ToList();
            }
        }

        public static List<Professor> GetProfessores()
        {
            using (var db = new CantinaContext())
            {
                return db.Professores.ToList();
            }
        }

        public static List<Prato> GetPratos()
        {
            using (var db = new CantinaContext())
            {
                return db.Pratos.ToList();
            }
        }

        public static List<Extra> GetExtras()
        {
            using (var db = new CantinaContext())
            {
                return db.Extras.ToList();
            }
        }
    }        
}

