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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();

            CarreraComboBox.DataSource = CarrerasBLL.GetCarreras();
            CarreraComboBox.DisplayMember = "Nombre";
            CarreraComboBox.ValueMember = "CarreraId";
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
            MatriculaMaskedTextBox.Text = estudiantes.Matricula;
            TelefonoMaskedTextBox.Text = estudiantes.Telefono;
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
            estudiantes.Matricula = MatriculaMaskedTextBox.Text;
            estudiantes.Telefono = TelefonoMaskedTextBox.Text;
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

        public void RecibirEstudiante(int id)
        {
            Estudiantes estudiantes = EstudiantesBLL.Buscar(id);

            LlenaCampo(estudiantes);
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

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            cEstudiantes estudiantes = new cEstudiantes();
            estudiantes.Show();
            Close();
        }
    }
}
