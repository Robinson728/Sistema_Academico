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
    public partial class rSemestres : Form
    {
        public rSemestres()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            InicioDateTimePicker.Value = DateTime.Now;
            FinalDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Semestres semestres)
        {
            IdNumericUpDown.Value = semestres.SemestreId;
            NombreTextBox.Text = semestres.Nombre;
            InicioDateTimePicker.Value = semestres.FechaInicio;
            FinalDateTimePicker.Value = semestres.FechaFin;
        }

        private Semestres LlenaClase()
        {
            Semestres semestres = new Semestres();

            semestres.SemestreId = (int)IdNumericUpDown.Value;
            semestres.Nombre = NombreTextBox.Text;
            semestres.FechaInicio = InicioDateTimePicker.Value;
            semestres.FechaFin = FinalDateTimePicker.Value;

            return semestres;
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

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Semestres semestres = new Semestres();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            semestres = SemestresBLL.Buscar(id);

            if (semestres != null)
                LlenaCampo(semestres);
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Semestres semestres;

            if (!Validar())
                return;

            semestres = LlenaClase();

            var paso = SemestresBLL.Guardar(semestres);

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

            if (SemestresBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumericUpDown, "Id no existente");
        }
    }
}
