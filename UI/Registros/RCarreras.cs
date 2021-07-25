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
    public partial class RCarreras : Form
    {
        public RCarreras()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombreTextBox.Clear();
            CreditosTextBox.Clear();
            TotalAsignaturasTextBox.Clear();
            HorasPracticasTextBox.Clear();
            HorasTeoricasTextBox.Clear();
            HorasPensumTextBox.Clear();
            SemestresAcademicosTextBox.Clear();
            DuracionTextBox.Clear();
            AsignaturasElectivasTextBox.Clear();
            TituloTextBox.Clear();
        }

        private void LlenaCampo(Carreras carreras)
        {
            IdnumericUpDown.Value = carreras.CarreraId;
            NombreTextBox.Text = carreras.Nombre;
            carreras.Creditos = Convert.ToInt32(CreditosTextBox.Text);
            carreras.TotalAsignaturas = Convert.ToInt32(TotalAsignaturasTextBox.Text);
            carreras.HorasPracticas = Convert.ToSingle(HorasPracticasTextBox.Text);
            carreras.HorasTeoricas = Convert.ToSingle(HorasTeoricasTextBox.Text);
            carreras.HorasPensum = Convert.ToSingle(HorasPensumTextBox.Text);
            carreras.SemestresAcademicos = Convert.ToInt32(SemestresAcademicosTextBox.Text);
            carreras.Duracion = Convert.ToSingle(DuracionTextBox.Text);
            carreras.TotalAsignaturasElectivas = Convert.ToInt32(AsignaturasElectivasTextBox.Text);
            TituloTextBox.Text = carreras.TituloOtorgado;
        }

        private Carreras LlenaClase()
        {
            Carreras carreras = new Carreras();

            carreras.CarreraId = (int)IdnumericUpDown.Value;
            carreras.Nombre = NombreTextBox.Text;
            carreras.Creditos = Convert.ToInt32(CreditosTextBox.Text);
            carreras.TotalAsignaturas = Convert.ToInt32(TotalAsignaturasTextBox.Text);
            carreras.HorasPracticas = Convert.ToInt32(HorasPracticasTextBox.Text);
            carreras.HorasTeoricas = Convert.ToInt32(HorasTeoricasTextBox.Text);
            carreras.HorasPensum = Convert.ToInt32(HorasPensumTextBox.Text);
            carreras.SemestresAcademicos = Convert.ToInt32(SemestresAcademicosTextBox.Text);
            carreras.Duracion = Convert.ToInt32(DuracionTextBox.Text);
            carreras.TotalAsignaturasElectivas = Convert.ToInt32(AsignaturasElectivasTextBox.Text);
            carreras.TituloOtorgado = TituloTextBox.Text;

            return carreras;
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
            if (string.IsNullOrWhiteSpace(CreditosTextBox.Text))
            {
                ErrorProvider.SetError(CreditosTextBox, "Este campo no puede estar vacío");
                CreditosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TotalAsignaturasTextBox.Text))
            {
                ErrorProvider.SetError(TotalAsignaturasTextBox, "Este campo no puede estar vacío");
                TotalAsignaturasTextBox.Focus();
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
            if (string.IsNullOrWhiteSpace(HorasPensumTextBox.Text))
            {
                ErrorProvider.SetError(HorasPensumTextBox, "Este campo no puede estar vacío");
                HorasPensumTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(SemestresAcademicosTextBox.Text))
            {
                ErrorProvider.SetError(SemestresAcademicosTextBox, "Este campo no puede estar vacío");
                SemestresAcademicosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DuracionTextBox.Text))
            {
                ErrorProvider.SetError(DuracionTextBox, "Este campo no puede estar vacío");
                DuracionTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(AsignaturasElectivasTextBox.Text))
            {
                ErrorProvider.SetError(AsignaturasElectivasTextBox, "Este campo no puede estar vacío");
                AsignaturasElectivasTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TituloTextBox.Text))
            {
                ErrorProvider.SetError(TituloTextBox, "Este campo no puede estar vacío");
                TituloTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public void RecibirCarrera(int id)
        {
            Carreras carreras = CarrerasBLL.Buscar(id);

            LlenaCampo(carreras);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Carreras carreras;

            if (!Validar())
                return;

            carreras = LlenaClase();

            var paso = CarrerasBLL.Guardar(carreras);

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
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            if (CarrerasBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdnumericUpDown, "Id no existente");
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            cCarreras carreras = new cCarreras();
            carreras.Show();
            Close();
        }
    }
}
