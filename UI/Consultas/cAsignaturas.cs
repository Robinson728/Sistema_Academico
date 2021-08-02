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
    public partial class cAsignaturas : Form
    {
        public cAsignaturas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            CreditosTextBox.Clear();
            GrupoTextBox.Clear();
            ConsultaAsignaturaDataGridView.DataSource = null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Asignaturas>();

            if((IdTextBox.Text == string.Empty) && (NombreTextBox.Text==string.Empty) && (DescripcionTextBox.Text==string.Empty)
                    && (SemestreTextBox.Text==string.Empty) && (CreditosTextBox.Text==string.Empty) && (GrupoTextBox.Text==string.Empty))
            {
                lista = AsignaturasBLL.GetList(r => true);
            }
            else
            {
                if (IdTextBox.Text != string.Empty)
                    lista = AsignaturasBLL.GetList(r => r.AsignaturaId == Conversiones.ToInt(IdTextBox.Text));

                if (NombreTextBox.Text != string.Empty)
                    lista = AsignaturasBLL.GetList(r => r.Nombre.Contains(NombreTextBox.Text));

                if (DescripcionTextBox.Text != string.Empty)
                    lista = AsignaturasBLL.GetList(r => r.Descripcion.Contains(DescripcionTextBox.Text));

                if (CreditosTextBox.Text != string.Empty)
                    lista = AsignaturasBLL.GetList(r => r.Creditos == Conversiones.ToInt(CreditosTextBox.Text));

                if (GrupoTextBox.Text != string.Empty)
                    lista = AsignaturasBLL.GetList(r => r.Grupo == Conversiones.ToInt(GrupoTextBox.Text));
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

            if(ConsultaAsignaturaDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = ConsultaAsignaturaDataGridView.CurrentRow.Cells[0].Value.ToString();
            var asignaturas = new rAsignaturas();
            asignaturas.RecibirAsignatura(Conversiones.ToInt(id));
            asignaturas.Show();
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
