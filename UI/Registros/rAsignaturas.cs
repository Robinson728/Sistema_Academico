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

namespace Sistema_Academico.UI.Registros
{
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            AsignaturaIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            CreditosTextBox.Clear();
            GrupoTextBox.Clear();
            HoraEntradaDateTimePicker.Value = DateTime.Now;
            HoraSalidaDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Asignaturas asignaturas)
        {
            AsignaturaIdNumericUpDown.Value = asignaturas.AsignaturaId;
            NombreTextBox.Text = asignaturas.Nombre;
            DescripcionTextBox.Text = asignaturas.Descripcion;
            SemestreComboBox.Text = asignaturas.Semestre;
            asignaturas.Creditos = Convert.ToInt32(CreditosTextBox.Text);
            asignaturas.Grupo = Convert.ToInt32(GrupoTextBox.Text);
            HoraEntradaDateTimePicker.Value = asignaturas.HoraInicio;
            HoraSalidaDateTimePicker.Value = asignaturas.HoraFinal;
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas asignaturas = new Asignaturas();

            asignaturas.AsignaturaId = (int)AsignaturaIdNumericUpDown.Value;
            asignaturas.Nombre = NombreTextBox.Text;
            asignaturas.Descripcion = DescripcionTextBox.Text;
            asignaturas.Semestre = SemestreComboBox.Text;
            asignaturas.Creditos = Convert.ToInt32(CreditosTextBox.Text);
            asignaturas.Grupo = Convert.ToInt32(GrupoTextBox.Text);
            asignaturas.HoraInicio = HoraEntradaDateTimePicker.Value;
            asignaturas.HoraFinal = HoraSalidaDateTimePicker.Value;

            return asignaturas;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                ErrorProvider.SetError(NombreTextBox, "Este campo no puede estar vacío");
                NombreTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                ErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacío");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(SemestreComboBox.Text))
            {
                ErrorProvider.SetError(SemestreComboBox, "Este campo no puede estar vacío");
                SemestreComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CreditosTextBox.Text))
            {
                ErrorProvider.SetError(CreditosTextBox, "Este campo no puede estar vacío");
                CreditosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(GrupoTextBox.Text))
            {
                ErrorProvider.SetError(GrupoTextBox, "Este campo no puede estar vacío");
                GrupoTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Asignaturas asignatura = new Asignaturas();
            int id;
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);

            asignatura = AsignaturasBLL.Buscar(id);

            if (asignatura != null)
                LlenaCampo(asignatura);
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Asignaturas asignaturas;

            if (!Validar())
                return;

            asignaturas = LlenaClase();

            var paso = AsignaturasBLL.Guardar(asignaturas);

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
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);

            Limpiar();

            if (AsignaturasBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(AsignaturaIdNumericUpDown, "Id no existente");
        }
    }
}
