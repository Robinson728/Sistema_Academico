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
using Sistema_Academico.UI.Registros;

namespace Sistema_Academico.UI.Consultas
{
    public partial class cCarreras : Form
    {
        public cCarreras()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            CreditosTextBox.Clear();
            TotalAsignaturaTextBox.Clear();
            HorasPensumTextBox.Clear();
            HorasPracticasTextBox.Clear();
            HorasTeoricasTextBox.Clear();
            DuracionTextBox.Clear();
            ConsultaAsignaturaDataGridView.DataSource = null;
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            var lista = new List<Carreras>();

            if ((IdTextBox.Text == string.Empty) && (NombreTextBox.Text == string.Empty) && (CreditosTextBox.Text == string.Empty)
                    && (TotalAsignaturaTextBox.Text == string.Empty) && (HorasPensumTextBox.Text == string.Empty) && (HorasPracticasTextBox.Text == string.Empty)
                        && (HorasTeoricasTextBox.Text == string.Empty) && (DuracionTextBox.Text == string.Empty))
            {
                lista = CarrerasBLL.GetList(r => true);
            }
            else
            {
                if (IdTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.CarreraId == Conversiones.ToInt(IdTextBox.Text));

                if (NombreTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.Nombre.Contains(NombreTextBox.Text));

                if (CreditosTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.Creditos == Conversiones.ToInt(CreditosTextBox.Text));

                if (TotalAsignaturaTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.TotalAsignaturas == Conversiones.ToInt(TotalAsignaturaTextBox.Text));

                if (HorasPensumTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.HorasPensum == Conversiones.ToDouble(HorasPensumTextBox.Text));

                if (HorasPracticasTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.HorasPracticas == Conversiones.ToDouble(HorasPracticasTextBox.Text));

                if (HorasTeoricasTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.HorasTeoricas == Conversiones.ToDouble(HorasTeoricasTextBox.Text));

                if (DuracionTextBox.Text != string.Empty)
                    lista = CarrerasBLL.GetList(r => r.Duracion == Conversiones.ToDouble(DuracionTextBox.Text));
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
            var carreras = new RCarreras();
            carreras.RecibirCarrera(Conversiones.ToInt(id));
            carreras.Show();
            Close();
        }
    }
}
