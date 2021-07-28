
namespace Sistema_Academico.UI.Consultas
{
    partial class cPensum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConsultaAsignaturaDataGridView = new System.Windows.Forms.DataGridView();
            this.UsarFiltroFechascheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HorasTeoricasTextBox = new System.Windows.Forms.TextBox();
            this.HorasPracticasTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreditosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SemestreTextBox = new System.Windows.Forms.TextBox();
            this.CarreraTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaAsignaturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.HastaDateTimePicker);
            this.panel1.Controls.Add(this.HastaLabel);
            this.panel1.Controls.Add(this.DesdeDateTimePicker);
            this.panel1.Controls.Add(this.DesdeLabel);
            this.panel1.Location = new System.Drawing.Point(181, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 43);
            this.panel1.TabIndex = 44;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Enabled = false;
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(213, 9);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(96, 23);
            this.HastaDateTimePicker.TabIndex = 11;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(170, 13);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(37, 15);
            this.HastaLabel.TabIndex = 10;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Enabled = false;
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(68, 9);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(96, 23);
            this.DesdeDateTimePicker.TabIndex = 9;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(23, 13);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(39, 15);
            this.DesdeLabel.TabIndex = 8;
            this.DesdeLabel.Text = "Desde";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Sistema_Academico.Properties.Resources.Icono_Buscar_2;
            this.BuscarButton.Location = new System.Drawing.Point(523, 103);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(109, 45);
            this.BuscarButton.TabIndex = 43;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultaAsignaturaDataGridView
            // 
            this.ConsultaAsignaturaDataGridView.AllowUserToAddRows = false;
            this.ConsultaAsignaturaDataGridView.AllowUserToDeleteRows = false;
            this.ConsultaAsignaturaDataGridView.AllowUserToOrderColumns = true;
            this.ConsultaAsignaturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaAsignaturaDataGridView.Location = new System.Drawing.Point(3, 153);
            this.ConsultaAsignaturaDataGridView.Name = "ConsultaAsignaturaDataGridView";
            this.ConsultaAsignaturaDataGridView.ReadOnly = true;
            this.ConsultaAsignaturaDataGridView.RowTemplate.Height = 25;
            this.ConsultaAsignaturaDataGridView.Size = new System.Drawing.Size(742, 278);
            this.ConsultaAsignaturaDataGridView.TabIndex = 40;
            // 
            // UsarFiltroFechascheckBox
            // 
            this.UsarFiltroFechascheckBox.AutoSize = true;
            this.UsarFiltroFechascheckBox.Location = new System.Drawing.Point(4, 116);
            this.UsarFiltroFechascheckBox.Name = "UsarFiltroFechascheckBox";
            this.UsarFiltroFechascheckBox.Size = new System.Drawing.Size(134, 19);
            this.UsarFiltroFechascheckBox.TabIndex = 37;
            this.UsarFiltroFechascheckBox.Text = "Usar Filtro de Fechas";
            this.UsarFiltroFechascheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 95;
            this.label10.Text = "Pensum Id";
            // 
            // HorasTeoricasTextBox
            // 
            this.HorasTeoricasTextBox.Location = new System.Drawing.Point(359, 73);
            this.HorasTeoricasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HorasTeoricasTextBox.Name = "HorasTeoricasTextBox";
            this.HorasTeoricasTextBox.Size = new System.Drawing.Size(159, 23);
            this.HorasTeoricasTextBox.TabIndex = 93;
            // 
            // HorasPracticasTextBox
            // 
            this.HorasPracticasTextBox.Location = new System.Drawing.Point(181, 73);
            this.HorasPracticasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HorasPracticasTextBox.Name = "HorasPracticasTextBox";
            this.HorasPracticasTextBox.Size = new System.Drawing.Size(159, 23);
            this.HorasPracticasTextBox.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "Semestre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 87;
            this.label6.Text = "Creditos ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Horas Practicas";
            // 
            // CreditosTextBox
            // 
            this.CreditosTextBox.Location = new System.Drawing.Point(359, 26);
            this.CreditosTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreditosTextBox.Name = "CreditosTextBox";
            this.CreditosTextBox.Size = new System.Drawing.Size(159, 23);
            this.CreditosTextBox.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "Horas Teoricas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 82;
            this.label2.Text = "Carrera ";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Sistema_Academico.Properties.Resources.icono_nuevo;
            this.NuevoButton.Location = new System.Drawing.Point(636, 103);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(109, 45);
            this.NuevoButton.TabIndex = 100;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Image = global::Sistema_Academico.Properties.Resources.grifo;
            this.SeleccionarButton.Location = new System.Drawing.Point(3, 435);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(121, 45);
            this.SeleccionarButton.TabIndex = 101;
            this.SeleccionarButton.Text = "Seleccionar";
            this.SeleccionarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(3, 26);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(159, 23);
            this.IdTextBox.TabIndex = 129;
            // 
            // SemestreTextBox
            // 
            this.SemestreTextBox.Location = new System.Drawing.Point(181, 26);
            this.SemestreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SemestreTextBox.Name = "SemestreTextBox";
            this.SemestreTextBox.Size = new System.Drawing.Size(159, 23);
            this.SemestreTextBox.TabIndex = 130;
            // 
            // CarreraTextBox
            // 
            this.CarreraTextBox.Location = new System.Drawing.Point(3, 73);
            this.CarreraTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CarreraTextBox.Name = "CarreraTextBox";
            this.CarreraTextBox.Size = new System.Drawing.Size(159, 23);
            this.CarreraTextBox.TabIndex = 131;
            // 
            // cPensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 484);
            this.Controls.Add(this.CarreraTextBox);
            this.Controls.Add(this.SemestreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.SeleccionarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HorasTeoricasTextBox);
            this.Controls.Add(this.HorasPracticasTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreditosTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ConsultaAsignaturaDataGridView);
            this.Controls.Add(this.UsarFiltroFechascheckBox);
            this.Name = "cPensum";
            this.Text = "Consulta de Pensum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaAsignaturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView ConsultaAsignaturaDataGridView;
        private System.Windows.Forms.CheckBox UsarFiltroFechascheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HorasTeoricasTextBox;
        private System.Windows.Forms.TextBox HorasPracticasTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreditosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button SeleccionarButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox SemestreTextBox;
        private System.Windows.Forms.TextBox CarreraTextBox;
    }
}