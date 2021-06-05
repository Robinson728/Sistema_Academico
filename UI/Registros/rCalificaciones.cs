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
    public partial class rCalificaciones : Form
    {
        public rCalificaciones()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            EstudianteTextBox.Clear();
            IdEstudianteTextBox.Clear();
            MatriculaTextBox.Clear();
            CalificacionTextBox.Clear();
        }

        private void LlenaCampo(Calificaciones calificaciones)
        {
            EstudianteTextBox.Text = calificaciones.NombreEstudiante;
            calificaciones.EstudianteId = Convert.ToInt32(IdEstudianteTextBox.Text);
            calificaciones.MatriculaEstudiante = Convert.ToInt32(MatriculaTextBox.Text);
            calificaciones.CalificacionFinal = Convert.ToInt32(CalificacionTextBox.Text);
        }

        private Calificaciones LlenaClase()
        {
            Calificaciones calificaciones = new Calificaciones();

            calificaciones.NombreEstudiante = EstudianteTextBox.Text;
            calificaciones.EstudianteId = Convert.ToInt32(IdEstudianteTextBox.Text);
            calificaciones.MatriculaEstudiante = Convert.ToInt32(MatriculaTextBox.Text);
            calificaciones.CalificacionFinal = Convert.ToInt32(CalificacionTextBox.Text);

            return calificaciones;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudianteTextBox.Text))
            {
                ErrorProvider.SetError(EstudianteTextBox, "Este campo no puede estar vacío");
                EstudianteTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(IdEstudianteTextBox.Text))
            {
                ErrorProvider.SetError(IdEstudianteTextBox, "Este campo no puede estar vacío");
                IdEstudianteTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(MatriculaTextBox.Text))
            {
                ErrorProvider.SetError(MatriculaTextBox, "Este campo no puede estar vacío");
                MatriculaTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CalificacionTextBox.Text))
            {
                ErrorProvider.SetError(CalificacionTextBox, "Este campo no puede estar vacío");
                CalificacionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Calificaciones calificaciones;

            if (!Validar())
                return;

            calificaciones = LlenaClase();

            var paso = CalificacionesBLL.Guardar(calificaciones);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
