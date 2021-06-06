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
    public partial class cGrupos : Form
    {
        public cGrupos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Grupos>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //GripoID
                        lista = GruposBLL.GetList(r => r.GrupoId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Nombre asignatura
                        lista = GruposBLL.GetList(r => r.Asignatura.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //Nombre Porfesor
                        lista = GruposBLL.GetList(r => r.Profesor.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //Cantidad de estudiantes
                        lista = GruposBLL.GetList(r => r.CantidadEstudiantes == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 4: //Aula
                        lista = GruposBLL.GetList(r => r.Aula.Contains(CriterioTextBox.Text));
                        break;
                    case 5: //Numero de Grupo
                        lista = GruposBLL.GetList(r => r.NumeroGrupo == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = GruposBLL.GetList(r => true);
        }
    }
}
