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
using Sistema_Academico.UI.Registros;

namespace Sistema_Academico.UI.Consultas
{
    public partial class CSeleccionAsignatura : Form
    {
        public CSeleccionAsignatura()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            AsignaturaTextBox.Clear();
            ProfesorTextBox.Clear();
            AulaTextBox.Clear();
            NumeroGrupoTextBox.Clear();
            CantidadEstudiantesTextBox.Clear();
            ConsultaSeleccionDataGridView.DataSource = null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<SeleccionAsignatura>();

            if ((IdTextBox.Text == string.Empty) && (AsignaturaTextBox.Text == string.Empty) && (ProfesorTextBox.Text == string.Empty)
                    && (AulaTextBox.Text == string.Empty) && (CantidadEstudiantesTextBox.Text == string.Empty) && (NumeroGrupoTextBox.Text == string.Empty))
            {
                lista = SeleccionarBLL.GetList(c => true);
            }
            else
            {
                if (IdTextBox.Text != string.Empty)
                    lista = SeleccionarBLL.GetList(r => r.GrupoId == Conversiones.ToInt(IdTextBox.Text));

                if (AsignaturaTextBox.Text != string.Empty)
                    lista = SeleccionarBLL.GetList(r => r.Asignatura.Contains(AsignaturaTextBox.Text));

                if (ProfesorTextBox.Text != string.Empty)
                    lista = SeleccionarBLL.GetList(r => r.Profesor.Contains(ProfesorTextBox.Text));

                if (AulaTextBox.Text != string.Empty)
                    lista = SeleccionarBLL.GetList(r => r.Aula.Contains(AulaTextBox.Text));

                if (NumeroGrupoTextBox.Text != string.Empty)
                    lista = SeleccionarBLL.GetList(r => r.CantAsignaturas == Conversiones.ToInt(NumeroGrupoTextBox.Text));

                if (CantidadEstudiantesTextBox.Text != string.Empty)
                    lista = SeleccionarBLL.GetList(r => r.SeleccionId == Conversiones.ToInt(CantidadEstudiantesTextBox.Text));
            }


            ConsultaSeleccionDataGridView.DataSource = null;
            ConsultaSeleccionDataGridView.DataSource = lista;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            string id;

            if (ConsultaSeleccionDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = ConsultaSeleccionDataGridView.CurrentRow.Cells[0].Value.ToString();
            rSeleccionAsignaturas seleccion = new rSeleccionAsignaturas();
            seleccion.RecibirGrupo(Conversiones.ToInt(id));
            seleccion.Show();
            Close();
        }
    }
}
