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
    public partial class cCarreras : Form
    {
        public cCarreras()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Carreras>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //AsignaturaId
                        lista = CarrerasBLL.GetList(r => r.CarreraId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Nombre
                        lista = CarrerasBLL.GetList(r => r.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //Descripcion
                        lista = CarrerasBLL.GetList(r => r.Creditos == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 3: //Semestre
                        lista = CarrerasBLL.GetList(r => r.TotalAsignaturas == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 4: //Creditos
                        lista = CarrerasBLL.GetList(r => r.HorasPensum == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 5: //Grupo
                        lista = CarrerasBLL.GetList(r => r.HorasPracticas == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 6: //AsignaturaId
                        lista = CarrerasBLL.GetList(r => r.HorasTeoricas == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 7: //Nombre
                        lista = CarrerasBLL.GetList(r => r.Duracion == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 8: //Descripcion
                        lista = CarrerasBLL.GetList(r => r.SemestresAcademicos == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 9: //Semestre
                        lista = CarrerasBLL.GetList(r => r.TotalAsignaturasElectivas == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 10: //Creditos
                        lista = CarrerasBLL.GetList(r => r.TituloOtorgado.Contains(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = CarrerasBLL.GetList(r => true);
        }
    }
}
