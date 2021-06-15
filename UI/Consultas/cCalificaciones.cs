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
    public partial class cCalificaciones : Form
    {
        public cCalificaciones()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            /*var lista = new List<Calificaciones>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //AsignaturaId
                        lista = CalificacionesBLL.GetList(r => r.EstudianteId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Nombre
                        lista = CalificacionesBLL.GetList(r => r.NombreEstudiante.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //Descripcion
                        lista = CalificacionesBLL.GetList(r => r.MatriculaEstudiante == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 3: //Semestre
                        lista = CalificacionesBLL.GetList(r => r.CalificacionFinal == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = CalificacionesBLL.GetList(r => true);*/
        }
    }
}
