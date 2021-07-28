
namespace Sistema_Academico.UI.Registros
{
    partial class rProfesores
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
            this.label7 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Teléfono";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::Sistema_Academico.Properties.Resources.icono_eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(199, 179);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(93, 42);
            this.EliminarButton.TabIndex = 35;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Sistema_Academico.Properties.Resources.icono_guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(102, 179);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 42);
            this.GuardarButton.TabIndex = 34;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Sistema_Academico.Properties.Resources.icono_nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(5, 179);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(93, 42);
            this.NuevoButton.TabIndex = 33;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cédula";
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FechaIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresoDateTimePicker.Enabled = false;
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(279, 151);
            this.FechaIngresoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.FechaIngresoDateTimePicker.TabIndex = 28;
            this.FechaIngresoDateTimePicker.Value = new System.DateTime(2021, 3, 22, 16, 32, 1, 0);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NombreTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NombreTextBox.Location = new System.Drawing.Point(74, 35);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(315, 23);
            this.NombreTextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Profesor Id";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.IdNumericUpDown.Location = new System.Drawing.Point(74, 6);
            this.IdNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.IdNumericUpDown.TabIndex = 20;
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(265, 64);
            this.TelefonoMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TelefonoMaskedTextBox.Mask = "(999)000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(124, 23);
            this.TelefonoMaskedTextBox.TabIndex = 39;
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(74, 64);
            this.CedulaMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(121, 23);
            this.CedulaMaskedTextBox.TabIndex = 40;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DireccionTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DireccionTextBox.Location = new System.Drawing.Point(74, 93);
            this.DireccionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(315, 23);
            this.DireccionTextBox.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Dirección";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailTextBox.Location = new System.Drawing.Point(74, 122);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(315, 23);
            this.EmailTextBox.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Email";
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ClaveTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ClaveTextBox.Location = new System.Drawing.Point(74, 151);
            this.ClaveTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(120, 23);
            this.ClaveTextBox.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Clave";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 47;
            this.label11.Text = "Fecha Ingreso";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Sistema_Academico.Properties.Resources.Icono_Buscar_2;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(296, 179);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(93, 42);
            this.Buscarbutton.TabIndex = 54;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 225);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdNumericUpDown);
            this.Name = "rProfesores";
            this.Text = "Registro de Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Button Buscarbutton;
    }
}