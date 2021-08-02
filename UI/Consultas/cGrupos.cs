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
    public partial class cGrupos : Form
    {
        public cGrupos()
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
            ConsultaAsignaturaDataGridView.DataSource = null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Grupos>();

            if ((IdTextBox.Text == string.Empty) && (AsignaturaTextBox.Text == string.Empty) && (ProfesorTextBox.Text == string.Empty)
                    && (AulaTextBox.Text == string.Empty) && (CantidadEstudiantesTextBox.Text == string.Empty) && (NumeroGrupoTextBox.Text == string.Empty))
            {
                lista = GruposBLL.GetList(r => true);
            }
            else
            {
                if (IdTextBox.Text != string.Empty)
                    lista = GruposBLL.GetList(r => r.GrupoId == Conversiones.ToInt(IdTextBox.Text));

                if (AsignaturaTextBox.Text != string.Empty)
                    lista = GruposBLL.GetList(r => r.Asignatura.Contains(AsignaturaTextBox.Text));

                if (ProfesorTextBox.Text != string.Empty)
                    lista = GruposBLL.GetList(r => r.Profesor.Contains(ProfesorTextBox.Text));

                if (AulaTextBox.Text != string.Empty)
                    lista = GruposBLL.GetList(r => r.Aula.Contains(AulaTextBox.Text));

                if (NumeroGrupoTextBox.Text != string.Empty)
                    lista = GruposBLL.GetList(r => r.NumeroGrupo == Conversiones.ToInt(NumeroGrupoTextBox.Text));

                if (CantidadEstudiantesTextBox.Text != string.Empty)
                    lista = GruposBLL.GetList(r => r.CantidadEstudiantes == Conversiones.ToInt(CantidadEstudiantesTextBox.Text));
            }

            if (UsarFiltroFechascheckBox.Checked == true)
            {
                lista = lista.Where(a => a.FechaCreacion.Date >= DesdeDateTimePicker.Value.Date && a.FechaCreacion.Date <= HastaDateTimePicker.Value.Date).ToList();
            }

            ConsultaAsignaturaDataGridView.DataSource = null;
            ConsultaAsignaturaDataGridView.DataSource = lista;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            string id;

            if (ConsultaAsignaturaDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = ConsultaAsignaturaDataGridView.CurrentRow.Cells[0].Value.ToString();
            rGrupos grupos = new rGrupos();
            grupos.RecibirGrupo(Conversiones.ToInt(id));
            grupos.Show();
            Close();
        }

        private void UsarFiltroFechascheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarFiltroFechascheckBox.Checked == true)
            {
                DesdeDateTimePicker.Enabled = true;
                HastaDateTimePicker.Enabled = true;
            }
            if (UsarFiltroFechascheckBox.Checked == false)
            {
                DesdeDateTimePicker.Enabled = false;
                HastaDateTimePicker.Enabled = false;
            }
        }
    }
}
