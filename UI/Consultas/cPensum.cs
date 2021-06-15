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
    public partial class cPensum : Form
    {
        public cPensum()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            /*var lista = new List<Pensum>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Pensum ID
                        lista = PensumBLL.GetList(r => r.PensumId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Carrera
                        lista = PensumBLL.GetList(r => r.Carrera.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //Asignatura
                        lista = PensumBLL.GetList(r => r.Asignatura.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //Credito
                        lista = PensumBLL.GetList(r => r.Creditos == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 4: // Horas prracticas
                        lista = PensumBLL.GetList(r => r.HorasPracticas == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 5: //Horas teoricas
                        lista = PensumBLL.GetList(r => r.HorasTeoricas == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 6: //PreRequisitos 
                        lista = PensumBLL.GetList(r => r.PreRequisitos.Contains(CriterioTextBox.Text));
                        break;
                    case 7: //Clave 
                        lista = PensumBLL.GetList(r => r.Clave.Contains(CriterioTextBox.Text));
                        break;
                    case 8: //Semestre 
                        lista = PensumBLL.GetList(r => r.Semestre.Contains(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = PensumBLL.GetList(r => true);*/
        }
    }
}
