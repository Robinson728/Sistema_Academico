using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Academico.BLL;
using Sistema_Academico.Models;

namespace Sistema_Academico.UI.Consultas
{
    public partial class cAsignaturas : Form
    {
        public cAsignaturas()
        {
            InitializeComponent();
        }
        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            var lista = new List<Asignaturas>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //AsignaturaId
                        lista = AsignaturasBLL.GetList(r => r.AsignaturaId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Nombre
                        lista = AsignaturasBLL.GetList(r => r.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //Descripcion
                        lista = AsignaturasBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //Semestre
                        lista = AsignaturasBLL.GetList(r => r.Semestre.Contains(CriterioTextBox.Text));
                        break;
                    case 4: //Creditos
                        lista = AsignaturasBLL.GetList(r => r.Creditos == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 5: //Grupo
                        lista = AsignaturasBLL.GetList(r => r.Grupo == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = AsignaturasBLL.GetList(r => true);
        }
    }
}
