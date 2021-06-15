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
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            /*var lista = new List<Estudiantes>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //AsignaturaId
                        lista = EstudiantesBLL.GetList(r => r.EstudianteId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Nombre
                        lista = EstudiantesBLL.GetList(r => r.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //Descripcion
                        lista = EstudiantesBLL.GetList(r => r.Matricula == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 3: //Semestre
                        lista = EstudiantesBLL.GetList(r => r.Telefono == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 4: //Creditos
                        lista = EstudiantesBLL.GetList(r => r.Carrera.Contains(CriterioTextBox.Text));
                        break;
                    case 5: //Grupo
                        lista = EstudiantesBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text));
                        break;
                    case 6: //Creditos
                        lista = EstudiantesBLL.GetList(r => r.Clave.Contains(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = EstudiantesBLL.GetList(r => true);*/
        }
    }
}
