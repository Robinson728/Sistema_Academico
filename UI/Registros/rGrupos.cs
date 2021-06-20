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
    public partial class rGrupos : Form
    {
        public rGrupos()
        {
            InitializeComponent();

            AsignaturaComboBox.DataSource = AsignaturasBLL.GetAsignaturas();
            AsignaturaComboBox.DisplayMember = "Nombre";
            AsignaturaComboBox.ValueMember = "AsignaturaId";

            ProfesorComboBox.DataSource = ProfesoresBLL.GetProfesores();
            ProfesorComboBox.DisplayMember = "Nombre";
            ProfesorComboBox.ValueMember = "ProfesorId";
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            CantidadEstudiantesTextBox.Clear();
            AulaTextBox.Clear();
            NumeroGrupoTextBox.Clear();
        }

        private void LlenaCampo(Grupos grupos)
        {
            IdNumericUpDown.Value = grupos.GrupoId;
            AsignaturaComboBox.Text = grupos.Asignatura;
            ProfesorComboBox.Text = grupos.Profesor;
            CantidadEstudiantesTextBox.Text = grupos.CantidadEstudiantes.ToString();
            AulaTextBox.Text = grupos.Aula;
            NumeroGrupoTextBox.Text = grupos.NumeroGrupo.ToString();
        }

        private Grupos LlenaClase()
        {
            Grupos grupos = new Grupos();

            grupos.GrupoId = (int)IdNumericUpDown.Value;
            grupos.Asignatura = AsignaturaComboBox.Text;
            grupos.Profesor = ProfesorComboBox.Text;
            grupos.CantidadEstudiantes = Convert.ToInt32(CantidadEstudiantesTextBox.Text);
            grupos.Aula = AulaTextBox.Text;
            grupos.NumeroGrupo = Convert.ToInt32(NumeroGrupoTextBox.Text);

            return grupos;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(AsignaturaComboBox.Text))
            {
                ErrorProvider.SetError(AsignaturaComboBox, "Este campo no puede estar vacío");
                AsignaturaComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ProfesorComboBox.Text))
            {
                ErrorProvider.SetError(ProfesorComboBox, "Este campo no puede estar vacío");
                ProfesorComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CantidadEstudiantesTextBox.Text))
            {
                ErrorProvider.SetError(CantidadEstudiantesTextBox, "Este campo no puede estar vacío");
                CantidadEstudiantesTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(AulaTextBox.Text))
            {
                ErrorProvider.SetError(AulaTextBox, "Este campo no puede estar vacío");
                AulaTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NumeroGrupoTextBox.Text))
            {
                ErrorProvider.SetError(NumeroGrupoTextBox, "Este campo no puede estar vacío");
                NumeroGrupoTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public void RecibirGrupo(int id)
        {
            Grupos grupos = GruposBLL.Buscar(id);

            LlenaCampo(grupos);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Grupos grupos;

            if (!Validar())
                return;

            grupos = LlenaClase();

            var paso = GruposBLL.Guardar(grupos);

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

            if (GruposBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumericUpDown, "Id no existente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            cProfesores grupos = new cProfesores();
            grupos.Show();
            Close();
        }
    }
}
