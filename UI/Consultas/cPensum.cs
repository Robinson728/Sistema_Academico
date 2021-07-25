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
            AsignaturaTextBox.Clear();
            CarreraTextBox.Clear();
            ClaveTextBox.Clear();
            HorasPracticasTextBox.Clear();
            CreditosTextBox.Clear();
            PreRequisitosTextBox.Clear();
            HorasTeoricasTextBox.Clear();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Pensum>();

            if ((IdTextBox.Text == string.Empty)&&(ClaveTextBox.Text == string.Empty) && (AsignaturaTextBox.Text == string.Empty) && (CreditosTextBox.Text == string.Empty) &&
                (CarreraTextBox.Text == string.Empty) && (HorasPracticasTextBox.Text == string.Empty)&&(HorasTeoricasTextBox.Text == string.Empty)&&(PreRequisitosTextBox.Text == string.Empty))
            {
                lista = PensumBLL.GetList(r => true);
            }
            else
            {
                if (IdTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.PensumId == Conversiones.ToInt(IdTextBox.Text));
                if (ClaveTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.Clave.Contains(ClaveTextBox.Text));
                if (AsignaturaTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.Asignatura.Contains(AsignaturaTextBox.Text));
                if (CreditosTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.Creditos == Conversiones.ToInt(CreditosTextBox.Text));
                if (CarreraTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.Carrera.Contains(CarreraTextBox.Text));
                if (HorasPracticasTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.HorasPracticas == Conversiones.ToInt(HorasPracticasTextBox.Text));
                if (HorasTeoricasTextBox.Text != string.Empty)
                    lista = PensumBLL.GetList(r => r.HorasTeoricas == Conversiones.ToInt(HorasTeoricasTextBox.Text));
            }

            ConsultaAsignaturaDataGridView.DataSource = null;
            ConsultaAsignaturaDataGridView.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
