﻿
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
            this.esActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.PeriodoSemestreGroupBox = new System.Windows.Forms.GroupBox();
            this.InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.FinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InicioLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PeriodoSemestreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // esActivoCheckBox
            // 
            this.esActivoCheckBox.AutoSize = true;
            this.esActivoCheckBox.Checked = true;
            this.esActivoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.esActivoCheckBox.Location = new System.Drawing.Point(326, 6);
            this.esActivoCheckBox.Name = "esActivoCheckBox";
            this.esActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.esActivoCheckBox.TabIndex = 25;
            this.esActivoCheckBox.Text = "Activo";
            this.esActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(248, 130);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(93, 42);
            this.EliminarButton.TabIndex = 24;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(149, 130);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 42);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(50, 130);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(93, 42);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
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
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(150, 5);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(61, 23);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.UseVisualStyleBackColor = true;
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
            this.IdNumericUpDown.Size = new System.Drawing.Size(65, 23);
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
            // rSemestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 177);
            this.Controls.Add(this.esActivoCheckBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PeriodoSemestreGroupBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdLabel);
            this.Name = "rSemestres";
            this.Text = "rSemestres";
            this.PeriodoSemestreGroupBox.ResumeLayout(false);
            this.PeriodoSemestreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox esActivoCheckBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.GroupBox PeriodoSemestreGroupBox;
        private System.Windows.Forms.DateTimePicker InicioDateTimePicker;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.DateTimePicker FinalDateTimePicker;
        private System.Windows.Forms.Label InicioLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label IdLabel;
    }
}