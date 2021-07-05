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
    public partial class rSeleccionAsignaturas : Form
    {
        private Label SeleccionIdlabel;
        private NumericUpDown numericUpDown1;
        private DataGridView SelecciondataGridView;
        private Button BuscarButton;
        private Button EliminarButton;
        private Button NuevoButton;
        private DataGridViewCheckBoxColumn Seleccion;
        private Button GuardarButton;
        int id;
        int cantidad;

        public rSeleccionAsignaturas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SeleccionIdlabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SelecciondataGridView = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecciondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SeleccionIdlabel
            // 
            this.SeleccionIdlabel.AutoSize = true;
            this.SeleccionIdlabel.Location = new System.Drawing.Point(12, 24);
            this.SeleccionIdlabel.Name = "SeleccionIdlabel";
            this.SeleccionIdlabel.Size = new System.Drawing.Size(89, 20);
            this.SeleccionIdlabel.TabIndex = 2;
            this.SeleccionIdlabel.Text = "Seleccion Id";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(107, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 4;
            // 
            // SelecciondataGridView
            // 
            this.SelecciondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelecciondataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            this.SelecciondataGridView.Location = new System.Drawing.Point(13, 55);
            this.SelecciondataGridView.Name = "SelecciondataGridView";
            this.SelecciondataGridView.RowHeadersWidth = 51;
            this.SelecciondataGridView.RowTemplate.Height = 29;
            this.SelecciondataGridView.Size = new System.Drawing.Size(803, 308);
            this.SelecciondataGridView.TabIndex = 5;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccionar";
            this.Seleccion.MinimumWidth = 6;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccion.Width = 125;
            // 
            // BuscarButton
            // 
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(593, 370);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(106, 56);
            this.BuscarButton.TabIndex = 56;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(480, 370);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(106, 56);
            this.EliminarButton.TabIndex = 55;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(254, 370);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(106, 56);
            this.NuevoButton.TabIndex = 54;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(367, 370);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(106, 56);
            this.GuardarButton.TabIndex = 53;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // rSeleccionAsignaturas
            // 
            this.ClientSize = new System.Drawing.Size(840, 448);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.SelecciondataGridView);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.SeleccionIdlabel);
            this.Name = "rSeleccionAsignaturas";
            this.Text = "Seleccion de Asignatura";
            this.Load += new System.EventHandler(this.rSeleccionAsignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelecciondataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public SeleccionAsignatura LlenarClase()
        {
            var group = GruposBLL.Buscar(id);
            SeleccionAsignatura seleccionasig = new SeleccionAsignatura();

            seleccionasig.SeleccionId = (int)numericUpDown1.Value;
            seleccionasig.GrupoId = group.GrupoId;
            seleccionasig.Asignatura = group.Asignatura;
            seleccionasig.Profesor = group.Profesor;
            seleccionasig.Aula = group.Aula;
            seleccionasig.CantAsignaturas = cantidad;
            seleccionasig.HoraInicio = group.HoraInicio;
            seleccionasig.HoraFinal = group.HoraFin;

            return seleccionasig;
        }

        private void rSeleccionAsignaturas_Load(object sender, EventArgs e)
        {
            var listagrupos = new List<Grupos>();
            listagrupos = GruposBLL.GetList(c => true);
            SelecciondataGridView.DataSource = listagrupos;
            SelecciondataGridView.Columns["CantidadEstudiantes"].Visible = false;
        }

        public void LlenaCampo(SeleccionAsignatura seleccion)
        {
            SelecciondataGridView.DataSource = SeleccionarBLL.Buscar(seleccion.SeleccionId);
        }

        public void RecibirGrupo(int id)
        {
            SeleccionAsignatura seleccion = SeleccionarBLL.Buscar(id);

            LlenaCampo(seleccion);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            cantidad = 0;
            int i = SelecciondataGridView.Rows.Count;
            for(int j = 0; j < i; j++)
            {
                bool seleccion = Convert.ToBoolean(SelecciondataGridView.Rows[j].Cells[0].Value);
                if (seleccion)
                {
                    SelecciondataGridView.Rows[j].Cells[0].Value = false;
                    cantidad++;
                    id = Convert.ToInt32(SelecciondataGridView.Rows[j].Cells[1].Value);
                    SeleccionAsignatura selecciones;
                    selecciones = LlenarClase();

                    var paso = SeleccionarBLL.Guardar(selecciones);

                    if (paso)
                    {
                        MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            CSeleccionAsignatura select = new CSeleccionAsignatura();
            select.Show();
            Close();
        }
    }
}
