using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Academico.Models;
using Sistema_Academico.BLL;
using Sistema_Academico.UI.Consultas;

namespace Sistema_Academico.UI.Registros
{
    public partial class RPensum : Form
    {
        public RPensum()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            CreditosTextBox.Clear();
            SemestreTextBox.Clear();
            ClaveTextBox.Clear();
            HorasPracticasTextBox.Clear();
            HorasTeoricasTextBox.Clear();
            PreRequisitosTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Pensum pensum)
        {
            IdNumericUpDown.Value = pensum.PensumId;
            CarreraComboBox.Text = pensum.Carrera;
            AsignaturaComboBox.Text = pensum.Asignatura;
            pensum.Creditos = Convert.ToInt32(CreditosTextBox.Text);
            SemestreTextBox.Text = pensum.Semestre;
            ClaveTextBox.Text = pensum.Clave;
            pensum.HorasPracticas = Convert.ToInt32(HorasPracticasTextBox.Text);
            pensum.HorasTeoricas = Convert.ToInt32(HorasTeoricasTextBox.Text);
            PreRequisitosTextBox.Text = pensum.PreRequisitos;
            FechaDateTimePicker.Value = pensum.FechaCreacion;
        }

        private Pensum LlenaClase()
        {
            Pensum pensum = new Pensum();

            pensum.PensumId = (int)IdNumericUpDown.Value;
            pensum.Carrera = CarreraComboBox.Text;
            pensum.Asignatura = AsignaturaComboBox.Text;
            pensum.Creditos = Convert.ToInt32(CreditosTextBox.Text);
            pensum.Semestre = SemestreTextBox.Text;
            pensum.Clave = ClaveTextBox.Text;
            pensum.HorasPracticas = Convert.ToInt32(HorasPracticasTextBox.Text);
            pensum.HorasTeoricas = Convert.ToInt32(HorasTeoricasTextBox.Text);
            pensum.PreRequisitos = PreRequisitosTextBox.Text;
            pensum.FechaCreacion = FechaDateTimePicker.Value;

            return pensum;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(CarreraComboBox.Text))
            {
                ErrorProvider.SetError(CarreraComboBox, "Este campo no puede estar vacío");
                CarreraComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(AsignaturaComboBox.Text))
            {
                ErrorProvider.SetError(AsignaturaComboBox, "Este campo no puede estar vacío");
                AsignaturaComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CreditosTextBox.Text))
            {
                ErrorProvider.SetError(CreditosTextBox, "Este campo no puede estar vacío");
                CreditosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(SemestreTextBox.Text))
            {
                ErrorProvider.SetError(SemestreTextBox, "Este campo no puede estar vacío");
                SemestreTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                ErrorProvider.SetError(ClaveTextBox, "Este campo no puede estar vacío");
                ClaveTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(HorasPracticasTextBox.Text))
            {
                ErrorProvider.SetError(HorasPracticasTextBox, "Este campo no puede estar vacío");
                HorasPracticasTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(HorasTeoricasTextBox.Text))
            {
                ErrorProvider.SetError(HorasTeoricasTextBox, "Este campo no puede estar vacío");
                HorasTeoricasTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PreRequisitosTextBox.Text))
            {
                ErrorProvider.SetError(PreRequisitosTextBox, "Este campo no puede estar vacío");
                PreRequisitosTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public void RecibirPensum(int id)
        {
            Pensum pensum = PensumBLL.Buscar(id);

            LlenaCampo(pensum);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Pensum pensum;

            if (!Validar())
                return;

            pensum = LlenaClase();

            var paso = PensumBLL.Guardar(pensum);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            if (PensumBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumericUpDown, "Id no existente");
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            cPensum pensum = new cPensum();
            pensum.Show();
            Close();
        }
    }
}
