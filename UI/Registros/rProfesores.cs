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
    public partial class rProfesores : Form
    {
        public rProfesores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            CedulaMaskedTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            DireccionTextBox.Clear();
            EmailTextBox.Clear();
            ClaveTextBox.Clear();
            FechaIngresoDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Profesores profesores)
        {
            IdNumericUpDown.Value = profesores.ProfesorId;
            NombreTextBox.Text = profesores.Nombre;
            CedulaMaskedTextBox.Text = profesores.Cedula;
            TelefonoMaskedTextBox.Text = profesores.Telefono;
            DireccionTextBox.Text = profesores.Direccion;
            EmailTextBox.Text = profesores.Email;
            ClaveTextBox.Text = profesores.Clave;
            FechaIngresoDateTimePicker.Value = profesores.FechaIngreso;
        }

        private Profesores LlenaClase()
        {
            Profesores profesores = new Profesores();

            profesores.ProfesorId = (int)IdNumericUpDown.Value;
            profesores.Nombre = NombreTextBox.Text;
            profesores.Cedula = CedulaMaskedTextBox.Text;
            profesores.Telefono = TelefonoMaskedTextBox.Text;
            profesores.Direccion = DireccionTextBox.Text;
            profesores.Email = EmailTextBox.Text;
            profesores.Clave = ClaveTextBox.Text;
            profesores.FechaIngreso = FechaIngresoDateTimePicker.Value;

            return profesores;
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
            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                ErrorProvider.SetError(CedulaMaskedTextBox, "Este campo no puede estar vacío");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                ErrorProvider.SetError(TelefonoMaskedTextBox, "Este campo no puede estar vacío");
                TelefonoMaskedTextBox.Focus();
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

        public void RecibirProfesores(int id)
        {
             Profesores profesores= ProfesoresBLL.Buscar(id);

            LlenaCampo(profesores);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            profesores = ProfesoresBLL.Buscar(id);

            if (profesores != null)
                LlenaCampo(profesores);
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Profesores profesores;

            if (!Validar())
                return;

            profesores = LlenaClase();

            var paso = ProfesoresBLL.Guardar(profesores);

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

            if (ProfesoresBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumericUpDown, "Id no existente");
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            cProfesores profesores = new cProfesores();
            profesores.Show();
            Close();
        }
    }
}
