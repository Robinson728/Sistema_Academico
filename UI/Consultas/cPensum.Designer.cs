
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
            this.EsActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.ConsultaAsignaturaDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.UsarFiltroFechascheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.EsActivoGroupBox.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(154, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 43);
            this.panel1.TabIndex = 44;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Enabled = false;
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(202, 10);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.HastaDateTimePicker.TabIndex = 11;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(159, 14);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(37, 15);
            this.HastaLabel.TabIndex = 10;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Enabled = false;
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(56, 10);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.DesdeDateTimePicker.TabIndex = 9;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(11, 13);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(39, 15);
            this.DesdeLabel.TabIndex = 8;
            this.DesdeLabel.Text = "Desde";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(581, 11);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(88, 75);
            this.BuscarButton.TabIndex = 43;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EsActivoGroupBox
            // 
            this.EsActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.EsActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.EsActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.EsActivoGroupBox.Location = new System.Drawing.Point(477, 3);
            this.EsActivoGroupBox.Name = "EsActivoGroupBox";
            this.EsActivoGroupBox.Size = new System.Drawing.Size(98, 83);
            this.EsActivoGroupBox.TabIndex = 42;
            this.EsActivoGroupBox.TabStop = false;
            this.EsActivoGroupBox.Text = "Es Activo?";
            // 
            // InactivosRadioButton
            // 
            this.InactivosRadioButton.AutoSize = true;
            this.InactivosRadioButton.Location = new System.Drawing.Point(17, 59);
            this.InactivosRadioButton.Name = "InactivosRadioButton";
            this.InactivosRadioButton.Size = new System.Drawing.Size(72, 19);
            this.InactivosRadioButton.TabIndex = 2;
            this.InactivosRadioButton.Text = "Inactivos";
            this.InactivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivosRadioButton
            // 
            this.ActivosRadioButton.AutoSize = true;
            this.ActivosRadioButton.Location = new System.Drawing.Point(17, 37);
            this.ActivosRadioButton.Name = "ActivosRadioButton";
            this.ActivosRadioButton.Size = new System.Drawing.Size(64, 19);
            this.ActivosRadioButton.TabIndex = 1;
            this.ActivosRadioButton.Text = "Activos";
            this.ActivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(17, 16);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(56, 19);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(154, 59);
            this.CriterioTextBox.Multiline = true;
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(318, 26);
            this.CriterioTextBox.TabIndex = 41;
            // 
            // ConsultaAsignaturaDataGridView
            // 
            this.ConsultaAsignaturaDataGridView.AllowUserToAddRows = false;
            this.ConsultaAsignaturaDataGridView.AllowUserToDeleteRows = false;
            this.ConsultaAsignaturaDataGridView.AllowUserToOrderColumns = true;
            this.ConsultaAsignaturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaAsignaturaDataGridView.Location = new System.Drawing.Point(4, 93);
            this.ConsultaAsignaturaDataGridView.Name = "ConsultaAsignaturaDataGridView";
            this.ConsultaAsignaturaDataGridView.ReadOnly = true;
            this.ConsultaAsignaturaDataGridView.RowTemplate.Height = 25;
            this.ConsultaAsignaturaDataGridView.Size = new System.Drawing.Size(665, 251);
            this.ConsultaAsignaturaDataGridView.TabIndex = 40;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "AsignaturaId",
            "Nombre",
            "Descripción",
            "Credito",
            "Grupo"});
            this.FiltroComboBox.Location = new System.Drawing.Point(44, 63);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(104, 23);
            this.FiltroComboBox.TabIndex = 39;
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Location = new System.Drawing.Point(4, 66);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(34, 15);
            this.FiltroLabel.TabIndex = 38;
            this.FiltroLabel.Text = "Filtro";
            // 
            // UsarFiltroFechascheckBox
            // 
            this.UsarFiltroFechascheckBox.AutoSize = true;
            this.UsarFiltroFechascheckBox.Location = new System.Drawing.Point(4, 27);
            this.UsarFiltroFechascheckBox.Name = "UsarFiltroFechascheckBox";
            this.UsarFiltroFechascheckBox.Size = new System.Drawing.Size(134, 19);
            this.UsarFiltroFechascheckBox.TabIndex = 37;
            this.UsarFiltroFechascheckBox.Text = "Usar Filtro de Fechas";
            this.UsarFiltroFechascheckBox.UseVisualStyleBackColor = true;
            // 
            // cPensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EsActivoGroupBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.ConsultaAsignaturaDataGridView);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.UsarFiltroFechascheckBox);
            this.Name = "cPensum";
            this.Text = "cPensum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EsActivoGroupBox.ResumeLayout(false);
            this.EsActivoGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox EsActivoGroupBox;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.DataGridView ConsultaAsignaturaDataGridView;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.CheckBox UsarFiltroFechascheckBox;
    }
}