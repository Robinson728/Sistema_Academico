
namespace Sistema_Academico.UI.Registros
{
    partial class rSemestres
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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.PeriodoSemestreGroupBox = new System.Windows.Forms.GroupBox();
            this.InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.FinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InicioLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.PeriodoSemestreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::Sistema_Academico.Properties.Resources.icono_eliminar;
            this.EliminarButton.Location = new System.Drawing.Point(198, 130);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(93, 42);
            this.EliminarButton.TabIndex = 24;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Sistema_Academico.Properties.Resources.icono_guardar;
            this.GuardarButton.Location = new System.Drawing.Point(101, 130);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 42);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Sistema_Academico.Properties.Resources.icono_nuevo;
            this.NuevoButton.Location = new System.Drawing.Point(4, 130);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(93, 42);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // PeriodoSemestreGroupBox
            // 
            this.PeriodoSemestreGroupBox.Controls.Add(this.InicioDateTimePicker);
            this.PeriodoSemestreGroupBox.Controls.Add(this.FinalLabel);
            this.PeriodoSemestreGroupBox.Controls.Add(this.FinalDateTimePicker);
            this.PeriodoSemestreGroupBox.Controls.Add(this.InicioLabel);
            this.PeriodoSemestreGroupBox.Location = new System.Drawing.Point(5, 63);
            this.PeriodoSemestreGroupBox.Name = "PeriodoSemestreGroupBox";
            this.PeriodoSemestreGroupBox.Size = new System.Drawing.Size(381, 61);
            this.PeriodoSemestreGroupBox.TabIndex = 21;
            this.PeriodoSemestreGroupBox.TabStop = false;
            this.PeriodoSemestreGroupBox.Text = "Periodo Del Semestre";
            // 
            // InicioDateTimePicker
            // 
            this.InicioDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InicioDateTimePicker.Location = new System.Drawing.Point(47, 23);
            this.InicioDateTimePicker.Name = "InicioDateTimePicker";
            this.InicioDateTimePicker.Size = new System.Drawing.Size(134, 23);
            this.InicioDateTimePicker.TabIndex = 3;
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(197, 27);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(32, 15);
            this.FinalLabel.TabIndex = 10;
            this.FinalLabel.Text = "Final";
            // 
            // FinalDateTimePicker
            // 
            this.FinalDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FinalDateTimePicker.Location = new System.Drawing.Point(235, 23);
            this.FinalDateTimePicker.Name = "FinalDateTimePicker";
            this.FinalDateTimePicker.Size = new System.Drawing.Size(134, 23);
            this.FinalDateTimePicker.TabIndex = 8;
            // 
            // InicioLabel
            // 
            this.InicioLabel.AutoSize = true;
            this.InicioLabel.Location = new System.Drawing.Point(5, 27);
            this.InicioLabel.Name = "InicioLabel";
            this.InicioLabel.Size = new System.Drawing.Size(36, 15);
            this.InicioLabel.TabIndex = 9;
            this.InicioLabel.Text = "Inicio";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(5, 37);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(51, 15);
            this.NombreLabel.TabIndex = 19;
            this.NombreLabel.Text = "Nombre";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(77, 6);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(109, 23);
            this.IdNumericUpDown.TabIndex = 18;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(77, 34);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(309, 23);
            this.NombreTextBox.TabIndex = 17;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(5, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(68, 15);
            this.IdLabel.TabIndex = 16;
            this.IdLabel.Text = "Semestre Id";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_Academico.Properties.Resources.Icono_Buscar_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(295, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 53;
            this.button1.Text = "Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rSemestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PeriodoSemestreGroupBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdLabel);
            this.Name = "rSemestres";
            this.Text = "Registro de Semestres";
            this.PeriodoSemestreGroupBox.ResumeLayout(false);
            this.PeriodoSemestreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.GroupBox PeriodoSemestreGroupBox;
        private System.Windows.Forms.DateTimePicker InicioDateTimePicker;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.DateTimePicker FinalDateTimePicker;
        private System.Windows.Forms.Label InicioLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Button button1;
    }
}