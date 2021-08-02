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
    public partial class cPensum : Form
    {
        public cPensum()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IdTextBox.Clear();
            SemestreTextBox.Clear();
            CarreraTextBox.Clear();
            HorasPracticasTextBox.Clear();
            CreditosTextBox.Clear();
            HorasTeoricasTextBox.Clear();
            ConsultaAsignaturaDataGridView.DataSource = null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Pensum>();

            if ((IdTextBox.Text == string.Empty) && (SemestreTextBox.Text == string.Empty) && (CreditosTextBox.Text == string.Empty) 
                    && (CarreraTextBox.Text == string.Empty) && (HorasPracticasTextBox.Text == string.Empty) && (HorasTeoricasTextBox.Text == string.Empty))
            {
                lista = PensumBLL.GetList(r => true);
            }
            else
            {
                if (IdTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.PensumId == Conversiones.ToInt(IdTextBox.Text));

                if (SemestreTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.Semestre.Contains(SemestreTextBox.Text));

                if (CreditosTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.Creditos == Conversiones.ToInt(CreditosTextBox.Text));

                if (CarreraTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.Carrera.Contains(CarreraTextBox.Text));

                if (HorasPracticasTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.HorasPracticas == Conversiones.ToDouble(HorasPracticasTextBox.Text));

                if (HorasTeoricasTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.HorasTeoricas == Conversiones.ToDouble(HorasTeoricasTextBox.Text));
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
            RPensum pensum = new RPensum();
            pensum.RecibirPensum(Conversiones.ToInt(id));
            pensum.Show();
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
