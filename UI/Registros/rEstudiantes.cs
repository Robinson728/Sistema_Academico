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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            MatriculaMaskedTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            EmailTextBox.Clear();
            ClaveTextBox.Clear();
            FechaIngresoDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Estudiantes estudiantes)
        {
            IdNumericUpDown.Value = estudiantes.EstudianteId;
            NombreTextBox.Text = estudiantes.Nombre;
            estudiantes.Matricula = Convert.ToInt32(MatriculaMaskedTextBox.Text);
            estudiantes.Telefono = Convert.ToInt32(TelefonoMaskedTextBox.Text);
            CarreraComboBox.Text = estudiantes.Carrera;
            EmailTextBox.Text = estudiantes.Email;
            ClaveTextBox.Text = estudiantes.Clave;
            FechaIngresoDateTimePicker.Value = estudiantes.FechaIngreso;
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = (int)IdNumericUpDown.Value;
            estudiantes.Nombre = NombreTextBox.Text;
            estudiantes.Matricula = Convert.ToInt32(MatriculaMaskedTextBox.Text);
            estudiantes.Telefono = Convert.ToInt32(TelefonoMaskedTextBox.Text);
            estudiantes.Carrera = CarreraComboBox.Text;
            estudiantes.Email = EmailTextBox.Text;
            estudiantes.Clave = ClaveTextBox.Text;
            estudiantes.FechaIngreso = FechaIngresoDateTimePicker.Value;

            return estudiantes;
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
            if (string.IsNullOrWhiteSpace(MatriculaMaskedTextBox.Text))
            {
                ErrorProvider.SetError(MatriculaMaskedTextBox, "Este campo no puede estar vacío");
                MatriculaMaskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                ErrorProvider.SetError(TelefonoMaskedTextBox, "Este campo no puede estar vacío");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CarreraComboBox.Text))
            {
                ErrorProvider.SetError(CarreraComboBox, "Este campo no puede estar vacío");
                CarreraComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                ErrorProvider.SetError(EmailTextBox, "Este campo no puede estar vacío");
                EmailTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                ErrorProvider.SetError(ClaveTextBox, "Este campo no puede estar vacío");
                ClaveTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            estudiantes = EstudiantesBLL.Buscar(id);

            if (estudiantes != null)
                LlenaCampo(estudiantes);
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes;

            if (!Validar())
                return;

            estudiantes = LlenaClase();

            var paso = EstudiantesBLL.Guardar(estudiantes);

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

            if (EstudiantesBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumericUpDown, "Id no existente");
        }
    }
}
