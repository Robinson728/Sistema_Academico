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
    public partial class cSemestres : Form
    {
        public cSemestres()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Semestres>();

            if (!string.IsNullOrWhiteSpace(FiltroComboBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //AsignaturaId
                        lista = SemestresBLL.GetList(r => r.SemestreId == Conversiones.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //Nombre
                        lista = SemestresBLL.GetList(r => r.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = SemestresBLL.GetList(r => true);
        }
    }
}
