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
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            MatriculaMaskedTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            CarreraComboBox.Items.Clear();
            EmailTextBox.Clear();
            ClaveTextBox.Clear();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Estudiantes>();

            if ((IdTextBox.Text == string.Empty) && (NombreTextBox.Text == string.Empty) && (MatriculaMaskedTextBox.Text == string.Empty)
                    && (TelefonoMaskedTextBox.Text == string.Empty) && (CarreraComboBox.Text == string.Empty) && (EmailTextBox.Text == string.Empty) && (ClaveTextBox.Text == string.Empty))
            {
                lista = EstudiantesBLL.GetList(r => true);
            }

            if (IdTextBox.Text != string.Empty)
                lista = EstudiantesBLL.GetList(r => r.EstudianteId == Conversiones.ToInt(IdTextBox.Text));

            if (NombreTextBox.Text != string.Empty)
                lista = EstudiantesBLL.GetList(r => r.Nombre.Contains(NombreTextBox.Text));

            if (MatriculaMaskedTextBox.Text != string.Empty)
                lista = EstudiantesBLL.GetList(r => r.Matricula == Conversiones.ToInt(MatriculaMaskedTextBox.Text));

            if (TelefonoMaskedTextBox.Text != string.Empty)
                lista = EstudiantesBLL.GetList(r => r.Telefono == Conversiones.ToInt(TelefonoMaskedTextBox.Text));

            if (CarreraComboBox.Text != string.Empty)
                lista = EstudiantesBLL.GetList(r => r.Carrera.Contains(CarreraComboBox.Text));

            if (EmailTextBox.Text != string.Empty)
                lista = EstudiantesBLL.GetList(r => r.Email.Contains(EmailTextBox.Text));

            if (ClaveTextBox.Text != string.Empty)
                lista = EstudiantesBLL.GetList(r => r.Clave.Contains(ClaveTextBox.Text));

            ConsultaAsignaturaDataGridView.DataSource = null;
            ConsultaAsignaturaDataGridView.DataSource = lista;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            string id;

            if (ConsultaAsignaturaDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = ConsultaAsignaturaDataGridView.CurrentRow.Cells[0].Value.ToString();
            rEstudiantes estudiantes = new rEstudiantes();
            estudiantes.RecibirEstudia(Conversiones.ToInt(id));
            estudiantes.Show();
            Close();
        }
    }
}
