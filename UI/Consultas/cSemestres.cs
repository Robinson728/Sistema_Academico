using Sistema_Academico.BLL;
using Sistema_Academico.Models;
using Sistema_Academico.UI.Registros;
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
        private void Limpiar()
        {
            IdTextBox.Clear();
            NombretextBox.Clear();          
            ConsultaAsignaturaDataGridView.DataSource = null;
        } 
    
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Semestres>();

            if ((IdTextBox.Text == string.Empty) && (NombretextBox.Text == string.Empty))
            {
                lista = SemestresBLL.GetList(r => true);
            }
            else
            {
                if (IdTextBox.Text != string.Empty)
                    lista = SemestresBLL.GetList(r => r.SemestreId == Conversiones.ToInt(IdTextBox.Text));

                if (NombretextBox.Text != string.Empty)
                    lista = SemestresBLL.GetList(r => r.Nombre.Contains(NombretextBox.Text));
            }

            ConsultaAsignaturaDataGridView.DataSource = null;
            ConsultaAsignaturaDataGridView.DataSource = lista;
        }

        private void SeleccionarButton_Click_1(object sender, EventArgs e)
        {
            string id;

            if (ConsultaAsignaturaDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = ConsultaAsignaturaDataGridView.CurrentRow.Cells[0].Value.ToString();
            var semestre = new rSemestres();
            semestre.RecibirSemestre(Conversiones.ToInt(id));
            semestre.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
