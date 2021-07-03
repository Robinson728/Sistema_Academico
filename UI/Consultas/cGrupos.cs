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
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Grupos>();

            if ((IdTextBox.Text == string.Empty) && (AsignaturaTextBox.Text == string.Empty) && (ProfesorTextBox.Text == string.Empty)
                    && (AulaTextBox.Text == string.Empty) && (CantidadEstudiantesTextBox.Text == string.Empty) && (NumeroGrupoTextBox.Text == string.Empty))
            {
                lista = GruposBLL.GetList(r => true);
            }

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
    }
}
