
namespace Sistema_Academico.UI.Registros
{
    partial class rAsignaturas
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
            this.components = new System.ComponentModel.Container();
            this.AsignaturaDetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemestreLabel = new System.Windows.Forms.Label();
            this.SemestreComboBox = new System.Windows.Forms.ComboBox();
            this.GrupoTextBox = new System.Windows.Forms.TextBox();
            this.CreditosTextBox = new System.Windows.Forms.TextBox();
            this.GrupoLabel = new System.Windows.Forms.Label();
            this.CreditosLabel = new System.Windows.Forms.Label();
            this.HorarioGroupBox = new System.Windows.Forms.GroupBox();
            this.HoraEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoraSalidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoraEntradaLabel = new System.Windows.Forms.Label();
            this.HoraSalidaLabel = new System.Windows.Forms.Label();
            this.HoraSLabel = new System.Windows.Forms.Label();
            this.HoraELabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.AsignaturaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AsignaturaDetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            this.HorarioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AsignaturaDetalleGroupBox
            // 
            this.AsignaturaDetalleGroupBox.Controls.Add(this.EstudiantesDataGridView);
            this.AsignaturaDetalleGroupBox.Location = new System.Drawing.Point(3, 202);
            this.AsignaturaDetalleGroupBox.Name = "AsignaturaDetalleGroupBox";
            this.AsignaturaDetalleGroupBox.Size = new System.Drawing.Size(576, 235);
            this.AsignaturaDetalleGroupBox.TabIndex = 48;
            this.AsignaturaDetalleGroupBox.TabStop = false;
            this.AsignaturaDetalleGroupBox.Text = "Lista De Estudiantes";
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.AllowUserToAddRows = false;
            this.EstudiantesDataGridView.AllowUserToDeleteRows = false;
            this.EstudiantesDataGridView.AllowUserToOrderColumns = true;
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(6, 20);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.ReadOnly = true;
            this.EstudiantesDataGridView.RowTemplate.Height = 25;
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(564, 207);
            this.EstudiantesDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matrícula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Carrera";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // SemestreLabel
            // 
            this.SemestreLabel.AutoSize = true;
            this.SemestreLabel.Location = new System.Drawing.Point(405, 38);
            this.SemestreLabel.Name = "SemestreLabel";
            this.SemestreLabel.Size = new System.Drawing.Size(55, 15);
            this.SemestreLabel.TabIndex = 47;
            this.SemestreLabel.Text = "Semestre";
            // 
            // SemestreComboBox
            // 
            this.SemestreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemestreComboBox.FormattingEnabled = true;
            this.SemestreComboBox.Location = new System.Drawing.Point(466, 35);
            this.SemestreComboBox.Name = "SemestreComboBox";
            this.SemestreComboBox.Size = new System.Drawing.Size(113, 23);
            this.SemestreComboBox.TabIndex = 46;
            // 
            // GrupoTextBox
            // 
            this.GrupoTextBox.Location = new System.Drawing.Point(408, 158);
            this.GrupoTextBox.Name = "GrupoTextBox";
            this.GrupoTextBox.Size = new System.Drawing.Size(171, 23);
            this.GrupoTextBox.TabIndex = 45;
            // 
            // CreditosTextBox
            // 
            this.CreditosTextBox.Location = new System.Drawing.Point(408, 129);
            this.CreditosTextBox.Name = "CreditosTextBox";
            this.CreditosTextBox.Size = new System.Drawing.Size(171, 23);
            this.CreditosTextBox.TabIndex = 44;
            // 
            // GrupoLabel
            // 
            this.GrupoLabel.AutoSize = true;
            this.GrupoLabel.Location = new System.Drawing.Point(351, 161);
            this.GrupoLabel.Name = "GrupoLabel";
            this.GrupoLabel.Size = new System.Drawing.Size(40, 15);
            this.GrupoLabel.TabIndex = 43;
            this.GrupoLabel.Text = "Grupo";
            // 
            // CreditosLabel
            // 
            this.CreditosLabel.AutoSize = true;
            this.CreditosLabel.Location = new System.Drawing.Point(351, 132);
            this.CreditosLabel.Name = "CreditosLabel";
            this.CreditosLabel.Size = new System.Drawing.Size(51, 15);
            this.CreditosLabel.TabIndex = 42;
            this.CreditosLabel.Text = "Creditos";
            // 
            // HorarioGroupBox
            // 
            this.HorarioGroupBox.Controls.Add(this.HoraEntradaDateTimePicker);
            this.HorarioGroupBox.Controls.Add(this.HoraSalidaDateTimePicker);
            this.HorarioGroupBox.Controls.Add(this.HoraEntradaLabel);
            this.HorarioGroupBox.Controls.Add(this.HoraSalidaLabel);
            this.HorarioGroupBox.Controls.Add(this.HoraSLabel);
            this.HorarioGroupBox.Controls.Add(this.HoraELabel);
            this.HorarioGroupBox.Location = new System.Drawing.Point(3, 116);
            this.HorarioGroupBox.Name = "HorarioGroupBox";
            this.HorarioGroupBox.Size = new System.Drawing.Size(322, 80);
            this.HorarioGroupBox.TabIndex = 41;
            this.HorarioGroupBox.TabStop = false;
            this.HorarioGroupBox.Text = "Horario";
            // 
            // HoraEntradaDateTimePicker
            // 
            this.HoraEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraEntradaDateTimePicker.Location = new System.Drawing.Point(48, 39);
            this.HoraEntradaDateTimePicker.Name = "HoraEntradaDateTimePicker";
            this.HoraEntradaDateTimePicker.Size = new System.Drawing.Size(107, 23);
            this.HoraEntradaDateTimePicker.TabIndex = 34;
            // 
            // HoraSalidaDateTimePicker
            // 
            this.HoraSalidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraSalidaDateTimePicker.Location = new System.Drawing.Point(209, 39);
            this.HoraSalidaDateTimePicker.Name = "HoraSalidaDateTimePicker";
            this.HoraSalidaDateTimePicker.Size = new System.Drawing.Size(107, 23);
            this.HoraSalidaDateTimePicker.TabIndex = 35;
            this.HoraSalidaDateTimePicker.Value = new System.DateTime(2021, 3, 23, 14, 32, 0, 0);
            // 
            // HoraEntradaLabel
            // 
            this.HoraEntradaLabel.AutoSize = true;
            this.HoraEntradaLabel.Location = new System.Drawing.Point(9, 20);
            this.HoraEntradaLabel.Name = "HoraEntradaLabel";
            this.HoraEntradaLabel.Size = new System.Drawing.Size(93, 15);
            this.HoraEntradaLabel.TabIndex = 6;
            this.HoraEntradaLabel.Text = "Hora De Entrada";
            // 
            // HoraSalidaLabel
            // 
            this.HoraSalidaLabel.AutoSize = true;
            this.HoraSalidaLabel.Location = new System.Drawing.Point(170, 20);
            this.HoraSalidaLabel.Name = "HoraSalidaLabel";
            this.HoraSalidaLabel.Size = new System.Drawing.Size(84, 15);
            this.HoraSalidaLabel.TabIndex = 7;
            this.HoraSalidaLabel.Text = "Hora De Salida";
            // 
            // HoraSLabel
            // 
            this.HoraSLabel.AutoSize = true;
            this.HoraSLabel.Location = new System.Drawing.Point(170, 42);
            this.HoraSLabel.Name = "HoraSLabel";
            this.HoraSLabel.Size = new System.Drawing.Size(33, 15);
            this.HoraSLabel.TabIndex = 23;
            this.HoraSLabel.Text = "Hora";
            // 
            // HoraELabel
            // 
            this.HoraELabel.AutoSize = true;
            this.HoraELabel.Location = new System.Drawing.Point(9, 42);
            this.HoraELabel.Name = "HoraELabel";
            this.HoraELabel.Size = new System.Drawing.Size(33, 15);
            this.HoraELabel.TabIndex = 11;
            this.HoraELabel.Text = "Hora";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(154, 6);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(61, 23);
            this.BuscarButton.TabIndex = 40;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(86, 64);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(493, 46);
            this.DescripcionTextBox.TabIndex = 39;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(86, 35);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(317, 23);
            this.NombreTextBox.TabIndex = 38;
            // 
            // AsignaturaIdNumericUpDown
            // 
            this.AsignaturaIdNumericUpDown.Location = new System.Drawing.Point(86, 6);
            this.AsignaturaIdNumericUpDown.Name = "AsignaturaIdNumericUpDown";
            this.AsignaturaIdNumericUpDown.Size = new System.Drawing.Size(62, 23);
            this.AsignaturaIdNumericUpDown.TabIndex = 37;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(3, 67);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLabel.TabIndex = 36;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(3, 38);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(51, 15);
            this.NombreLabel.TabIndex = 35;
            this.NombreLabel.Text = "Nombre";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 10);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(77, 15);
            this.IdLabel.TabIndex = 34;
            this.IdLabel.Text = "Asignatura Id";
            // 
            // EliminarButton
            // 
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(345, 442);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(93, 42);
            this.EliminarButton.TabIndex = 51;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(147, 442);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(93, 42);
            this.NuevoButton.TabIndex = 50;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(246, 442);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 42);
            this.GuardarButton.TabIndex = 49;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // rAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 489);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AsignaturaDetalleGroupBox);
            this.Controls.Add(this.SemestreLabel);
            this.Controls.Add(this.SemestreComboBox);
            this.Controls.Add(this.GrupoTextBox);
            this.Controls.Add(this.CreditosTextBox);
            this.Controls.Add(this.GrupoLabel);
            this.Controls.Add(this.CreditosLabel);
            this.Controls.Add(this.HorarioGroupBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.AsignaturaIdNumericUpDown);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "rAsignaturas";
            this.Text = "Registro de Asignaturas";
            this.AsignaturaDetalleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            this.HorarioGroupBox.ResumeLayout(false);
            this.HorarioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AsignaturaDetalleGroupBox;
        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.Label SemestreLabel;
        private System.Windows.Forms.ComboBox SemestreComboBox;
        private System.Windows.Forms.TextBox GrupoTextBox;
        private System.Windows.Forms.TextBox CreditosTextBox;
        private System.Windows.Forms.Label GrupoLabel;
        private System.Windows.Forms.Label CreditosLabel;
        private System.Windows.Forms.GroupBox HorarioGroupBox;
        private System.Windows.Forms.DateTimePicker HoraEntradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker HoraSalidaDateTimePicker;
        private System.Windows.Forms.Label HoraEntradaLabel;
        private System.Windows.Forms.Label HoraSalidaLabel;
        private System.Windows.Forms.Label HoraSLabel;
        private System.Windows.Forms.Label HoraELabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.NumericUpDown AsignaturaIdNumericUpDown;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}