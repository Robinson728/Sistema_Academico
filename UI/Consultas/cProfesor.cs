using Sistema_Academico.BLL;
using Sistema_Academico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academico.UI.Consultas
{
    public partial class cProfesor : Form
    {
        public cProfesor()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Profesores>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //ProfesorId
                        lista = ProfesoresBLL.GetList(r => r.ProfesorId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Nombre
                        lista = ProfesoresBLL.GetList(r => r.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //Cedula
                        lista = ProfesoresBLL.GetList(r => r.Cedula == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 3: //Telefono
                        lista = ProfesoresBLL.GetList(r => r.Telefono == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 4: //Direccion
                        lista = ProfesoresBLL.GetList(r => r.Direccion.Contains(CriterioTextBox.Text));
                        break;
                    case 5: //Email
                        lista = ProfesoresBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text));
                        break;
                    case 6: //Clave
                        lista = ProfesoresBLL.GetList(r => r.Clave.Contains(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = ProfesoresBLL.GetList(r => true);
        }
    }
}
