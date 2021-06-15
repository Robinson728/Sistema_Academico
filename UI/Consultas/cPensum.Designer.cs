
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
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.PreRequisitosTextBox = new System.Windows.Forms.TextBox();
            this.HorasTeoricasTextBox = new System.Windows.Forms.TextBox();
            this.HorasPracticasTextBox = new System.Windows.Forms.TextBox();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreditosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarreraComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaAsignaturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.HastaDateTimePicker);
            this.panel1.Controls.Add(this.HastaLabel);
            this.panel1.Controls.Add(this.DesdeDateTimePicker);
            this.panel1.Controls.Add(this.DesdeLabel);
            this.panel1.Location = new System.Drawing.Point(184, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 43);
            this.panel1.TabIndex = 44;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Enabled = false;
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(307, 9);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(192, 23);
            this.HastaDateTimePicker.TabIndex = 11;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(264, 13);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(37, 15);
            this.HastaLabel.TabIndex = 10;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Enabled = false;
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(66, 9);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(192, 23);
            this.DesdeDateTimePicker.TabIndex = 9;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(21, 13);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(39, 15);
            this.DesdeLabel.TabIndex = 8;
            this.DesdeLabel.Text = "Desde";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(712, 101);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(109, 43);
            this.BuscarButton.TabIndex = 43;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultaAsignaturaDataGridView
            // 
            this.ConsultaAsignaturaDataGridView.AllowUserToAddRows = false;
            this.ConsultaAsignaturaDataGridView.AllowUserToDeleteRows = false;
            this.ConsultaAsignaturaDataGridView.AllowUserToOrderColumns = true;
            this.ConsultaAsignaturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaAsignaturaDataGridView.Location = new System.Drawing.Point(3, 150);
            this.ConsultaAsignaturaDataGridView.Name = "ConsultaAsignaturaDataGridView";
            this.ConsultaAsignaturaDataGridView.ReadOnly = true;
            this.ConsultaAsignaturaDataGridView.RowTemplate.Height = 25;
            this.ConsultaAsignaturaDataGridView.Size = new System.Drawing.Size(933, 281);
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
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(184, 27);
            this.ClaveTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(155, 23);
            this.ClaveTextBox.TabIndex = 99;
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(4, 27);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(159, 23);
            this.IdNumericUpDown.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 95;
            this.label10.Text = "Pensum Id";
            // 
            // PreRequisitosTextBox
            // 
            this.PreRequisitosTextBox.Location = new System.Drawing.Point(547, 73);
            this.PreRequisitosTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PreRequisitosTextBox.Name = "PreRequisitosTextBox";
            this.PreRequisitosTextBox.Size = new System.Drawing.Size(160, 23);
            this.PreRequisitosTextBox.TabIndex = 94;
            // 
            // HorasTeoricasTextBox
            // 
            this.HorasTeoricasTextBox.Location = new System.Drawing.Point(362, 73);
            this.HorasTeoricasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HorasTeoricasTextBox.Name = "HorasTeoricasTextBox";
            this.HorasTeoricasTextBox.Size = new System.Drawing.Size(160, 23);
            this.HorasTeoricasTextBox.TabIndex = 93;
            // 
            // HorasPracticasTextBox
            // 
            this.HorasPracticasTextBox.Location = new System.Drawing.Point(184, 73);
            this.HorasPracticasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HorasPracticasTextBox.Name = "HorasPracticasTextBox";
            this.HorasPracticasTextBox.Size = new System.Drawing.Size(155, 23);
            this.HorasPracticasTextBox.TabIndex = 92;
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(362, 27);
            this.AsignaturaComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(160, 23);
            this.AsignaturaComboBox.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "Asignatura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 88;
            this.label7.Text = "Pre-Req";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 87;
            this.label6.Text = "Creditos ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Horas Practicas";
            // 
            // CreditosTextBox
            // 
            this.CreditosTextBox.Location = new System.Drawing.Point(547, 26);
            this.CreditosTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreditosTextBox.Name = "CreditosTextBox";
            this.CreditosTextBox.Size = new System.Drawing.Size(160, 23);
            this.CreditosTextBox.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 56);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Clave";
            // 
            // CarreraComboBox
            // 
            this.CarreraComboBox.FormattingEnabled = true;
            this.CarreraComboBox.Location = new System.Drawing.Point(3, 73);
            this.CarreraComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CarreraComboBox.Name = "CarreraComboBox";
            this.CarreraComboBox.Size = new System.Drawing.Size(160, 23);
            this.CarreraComboBox.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 100;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 101;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cPensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PreRequisitosTextBox);
            this.Controls.Add(this.HorasTeoricasTextBox);
            this.Controls.Add(this.HorasPracticasTextBox);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreditosTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarreraComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ConsultaAsignaturaDataGridView);
            this.Controls.Add(this.UsarFiltroFechascheckBox);
            this.Name = "cPensum";
            this.Text = "cPensum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaAsignaturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PreRequisitosTextBox;
        private System.Windows.Forms.TextBox HorasTeoricasTextBox;
        private System.Windows.Forms.TextBox HorasPracticasTextBox;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreditosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CarreraComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}