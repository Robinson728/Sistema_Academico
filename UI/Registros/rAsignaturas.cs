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
            PrerrequisitosTextBox.Clear();
            HorasPracticasTextBox.Clear();
            HorasTeoricasTextBox.Clear();
            GrupoTextBox.Clear();
            ClaveTextBox.Clear();
            CreditosTextBox.Clear();
            FechaCreacionDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Asignaturas asignaturas)
        {
            AsignaturaIdNumericUpDown.Value = asignaturas.AsignaturaId;
            NombreTextBox.Text = asignaturas.Nombre;
            DescripcionTextBox.Text = asignaturas.Descripcion;
            PrerrequisitosTextBox.Text = asignaturas.Prerrequisitos;
            HorasPracticasTextBox.Text = asignaturas.HorasPracticas.ToString();
            HorasTeoricasTextBox.Text = asignaturas.HorasTeoricas.ToString();
            GrupoTextBox.Text = asignaturas.Grupo.ToString();
            ClaveTextBox.Text = asignaturas.Clave;
            CreditosTextBox.Text = asignaturas.Creditos.ToString();
            FechaCreacionDateTimePicker.Value = asignaturas.FechaCreacion;
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas asignaturas = new Asignaturas();

            asignaturas.AsignaturaId = (int)AsignaturaIdNumericUpDown.Value;
            asignaturas.Nombre = NombreTextBox.Text;
            asignaturas.Descripcion = DescripcionTextBox.Text;
            asignaturas.Prerrequisitos = PrerrequisitosTextBox.Text;
            asignaturas.HorasPracticas = Conversiones.ToDouble(HorasPracticasTextBox.Text);
            asignaturas.HorasTeoricas = Conversiones.ToDouble(HorasTeoricasTextBox.Text);
            asignaturas.Grupo = Conversiones.ToInt(GrupoTextBox.Text);
            asignaturas.Clave = ClaveTextBox.Text;
            asignaturas.Creditos = Conversiones.ToInt(CreditosTextBox.Text);
            asignaturas.FechaCreacion = FechaCreacionDateTimePicker.Value;

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
            if (string.IsNullOrWhiteSpace(PrerrequisitosTextBox.Text))
            {
                ErrorProvider.SetError(PrerrequisitosTextBox, "Este campo no puede estar vacío");
                PrerrequisitosTextBox.Focus();
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
            if (string.IsNullOrWhiteSpace(GrupoTextBox.Text))
            {
                ErrorProvider.SetError(GrupoTextBox, "Este campo no puede estar vacío");
                GrupoTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                ErrorProvider.SetError(ClaveTextBox, "Este campo no puede estar vacío");
                ClaveTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CreditosTextBox.Text))
            {
                ErrorProvider.SetError(CreditosTextBox, "Este campo no puede estar vacío");
                CreditosTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public void RecibirAsignatura(int id)
        {
            Asignaturas asignaturas = AsignaturasBLL.Buscar(id);

            LlenaCampo(asignaturas);
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

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            cAsignaturas asignaturas = new cAsignaturas();
            asignaturas.Show();
            Close();
        }
    }
}
