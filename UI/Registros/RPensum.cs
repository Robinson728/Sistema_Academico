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
    public partial class RPensum : Form
    {
        public List<PensumDetalles> Detalle { get; set; }
        public RPensum()
        {
            InitializeComponent();
            this.Detalle = new List<PensumDetalles>();

            AsignaturaComboBox.DataSource = AsignaturasBLL.GetAsignaturas();
            AsignaturaComboBox.DisplayMember = "Nombre";
            AsignaturaComboBox.ValueMember = "AsignaturaId";

            CarreraComboBox.DataSource = CarrerasBLL.GetCarreras();
            CarreraComboBox.DisplayMember = "Nombre";
            CarreraComboBox.ValueMember = "CarreraId";

            SemestreComboBox.DataSource = SemestresBLL.GetSemestres();
            SemestreComboBox.DisplayMember = "Nombre";
            SemestreComboBox.ValueMember = "SemestreId";
        }

        private void CargarGrid()
        {
            PensumDataGridView.DataSource = null;
            PensumDataGridView.DataSource = Detalle;
            PensumDataGridView.Columns["Id"].Visible = false;
            PensumDataGridView.Columns["PensumId"].Visible = false;
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            CreditosTextBox.Clear();
            HorasPracticasTextBox.Clear();
            HorasTeoricasTextBox.Clear();
            HorasPensumTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            PreRequisitosTextBox.Clear();
            ClaveTextBox.Clear();
            DetallePracticasTextBox.Clear();
            DetalleTeoricasTextBox.Clear();
            DetalleCreditosTextBox.Clear();
            this.Detalle = new List<PensumDetalles>();
            CargarGrid();
        }

        private void LlenaCampo(Pensum pensum)
        {
            IdNumericUpDown.Value = pensum.PensumId;
            CarreraComboBox.Text = pensum.Carrera;
            CreditosTextBox.Text = Convert.ToString(pensum.Creditos);
            SemestreComboBox.Text = pensum.Semestre;
            HorasPracticasTextBox.Text = Convert.ToString(pensum.HorasPracticas);
            HorasTeoricasTextBox.Text = Convert.ToString(pensum.HorasTeoricas);
            HorasPensumTextBox.Text = Convert.ToString(pensum.HorasPensum);
            FechaDateTimePicker.Value = pensum.FechaCreacion;
            this.Detalle = pensum.Detalle;
            CargarGrid();
        }

        private Pensum LlenaClase()
        {
            Pensum pensum = new Pensum();

            pensum.PensumId = (int)IdNumericUpDown.Value;
            pensum.Carrera = CarreraComboBox.Text;
            pensum.Creditos += Conversiones.ToInt(CreditosTextBox.Text);
            pensum.Semestre = SemestreComboBox.Text;
            pensum.HorasPracticas += Conversiones.ToInt(HorasPracticasTextBox.Text);
            pensum.HorasTeoricas += Conversiones.ToInt(HorasTeoricasTextBox.Text);
            pensum.HorasPensum += Conversiones.ToInt(HorasPensumTextBox.Text);
            pensum.FechaCreacion = FechaDateTimePicker.Value;
            pensum.Detalle = this.Detalle;
            CargarGrid();

            return pensum;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(CarreraComboBox.Text))
            {
                ErrorProvider.SetError(CarreraComboBox, "Este campo no puede estar vacío");
                CarreraComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CreditosTextBox.Text))
            {
                ErrorProvider.SetError(CreditosTextBox, "Este campo no puede estar vacío");
                CreditosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(SemestreComboBox.Text))
            {
                ErrorProvider.SetError(SemestreComboBox, "Este campo no puede estar vacío");
                SemestreComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(HorasPensumTextBox.Text))
            {
                ErrorProvider.SetError(HorasPensumTextBox, "Este campo no puede estar vacío");
                HorasPensumTextBox.Focus();
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

            return paso;
        }

        private bool ValidarDetalle()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(AsignaturaComboBox.Text))
            {
                ErrorProvider.SetError(AsignaturaComboBox, "Este campo no puede estar vacío");
                AsignaturaComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                ErrorProvider.SetError(ClaveTextBox, "Este campo no puede estar vacío");
                ClaveTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PreRequisitosTextBox.Text))
            {
                ErrorProvider.SetError(PreRequisitosTextBox, "Este campo no puede estar vacío");
                PreRequisitosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DetallePracticasTextBox.Text))
            {
                ErrorProvider.SetError(DetallePracticasTextBox, "Este campo no puede estar vacío");
                DetallePracticasTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DetalleTeoricasTextBox.Text))
            {
                ErrorProvider.SetError(DetalleTeoricasTextBox, "Este campo no puede estar vacío");
                DetalleTeoricasTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DetalleCreditosTextBox.Text))
            {
                ErrorProvider.SetError(DetalleCreditosTextBox, "Este campo no puede estar vacío");
                DetalleCreditosTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public void RecibirPensum(int id)
        {
            Pensum pensum = PensumBLL.Buscar(id);

            LlenaCampo(pensum);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Pensum pensum;

            if (!Validar())
                return;

            pensum = LlenaClase();

            var paso = PensumBLL.Guardar(pensum);

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

            if (PensumBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumericUpDown, "Id no existente");
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            cPensum pensum = new cPensum();
            pensum.Show();
            Close();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarDetalle())
                return;

            if (PensumDataGridView.DataSource != null)
                this.Detalle = (List<PensumDetalles>)PensumDataGridView.DataSource;

            this.Detalle.Add(new PensumDetalles()
            {
                PensumId = (int)IdNumericUpDown.Value,
                Asignatura = AsignaturaComboBox.Text,
                Practicas = Conversiones.ToInt(DetallePracticasTextBox.Text),
                Teoricas = Conversiones.ToInt(DetalleTeoricasTextBox.Text),
                Prerrequisitos = PreRequisitosTextBox.Text,
                Clave = ClaveTextBox.Text,
                Creditos = Conversiones.ToInt(DetalleCreditosTextBox.Text)
            });

            int acumulador = 0;
            int horapractica = Conversiones.ToInt(HorasPracticasTextBox.Text);
            int horateorica = Conversiones.ToInt(HorasTeoricasTextBox.Text);
            int horapensum = Conversiones.ToInt(HorasPensumTextBox.Text);
            int totalcredito = Conversiones.ToInt(CreditosTextBox.Text);

            int practica = Conversiones.ToInt(DetallePracticasTextBox.Text);
            int teorica = Conversiones.ToInt(DetalleTeoricasTextBox.Text);
            int credito = Conversiones.ToInt(DetalleCreditosTextBox.Text);

            horapractica += practica;
            horateorica += teorica;
            acumulador = practica + teorica;
            horapensum += acumulador;
            totalcredito += credito;

            HorasPracticasTextBox.Text = Convert.ToString(horapractica);
            HorasTeoricasTextBox.Text = Convert.ToString(horateorica);
            HorasPensumTextBox.Text = Convert.ToString(horapensum);
            CreditosTextBox.Text = Convert.ToString(totalcredito);

            CargarGrid();
            AsignaturaComboBox.Focus();
            DetalleCreditosTextBox.Clear();
            DetallePracticasTextBox.Clear();
            DetalleTeoricasTextBox.Clear();
            PreRequisitosTextBox.Clear();
            ClaveTextBox.Clear();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if ((PensumDataGridView.Rows.Count > 0) && (PensumDataGridView.CurrentRow != null))
            {
                int totalHorasPracticas = Conversiones.ToInt(HorasPracticasTextBox.Text);
                string acumuladorHorasPracticas = PensumDataGridView.CurrentRow.Cells[3].Value.ToString();
                totalHorasPracticas -= Conversiones.ToInt(acumuladorHorasPracticas);
                HorasPracticasTextBox.Text = Convert.ToString(totalHorasPracticas);

                int totalHorasTeoricas = Conversiones.ToInt(HorasTeoricasTextBox.Text);
                string acumuladorHorasTeoricas = PensumDataGridView.CurrentRow.Cells[4].Value.ToString();
                totalHorasTeoricas -= Conversiones.ToInt(acumuladorHorasTeoricas);
                HorasTeoricasTextBox.Text = Convert.ToString(totalHorasTeoricas);

                int totalCreditos = Conversiones.ToInt(CreditosTextBox.Text);
                string acumuladorCreditos = PensumDataGridView.CurrentRow.Cells[7].Value.ToString();
                totalCreditos -= Conversiones.ToInt(acumuladorCreditos);
                CreditosTextBox.Text = Convert.ToString(totalCreditos);

                int totalHorasPensum = Conversiones.ToInt(HorasPensumTextBox.Text);
                int acumuladorHorasPensum = Conversiones.ToInt(acumuladorHorasPracticas) + Conversiones.ToInt(acumuladorHorasTeoricas);
                totalHorasPensum -= acumuladorHorasPensum;
                HorasPensumTextBox.Text = Convert.ToString(totalHorasPensum);

                Detalle.RemoveAt(PensumDataGridView.CurrentRow.Index);
                CargarGrid();
            }
            else
            {
                ErrorProvider.SetError(PensumDataGridView, "No hay filas que remover");
                PensumDataGridView.Focus();
                if (PensumDataGridView.Rows.Count <= 0)
                {
                    ErrorProvider.SetError(PensumDataGridView, "No hay filas que remover");
                    PensumDataGridView.Focus();
                }
            }
        }
    }
}
