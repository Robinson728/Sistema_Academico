﻿
namespace Sistema_Academico.UI.Registros
{
    partial class RPensum
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
            this.CarreracomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SemestretextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CLaveAsingnaturacomboBox = new System.Windows.Forms.ComboBox();
            this.NombreAsignaturacomboBox = new System.Windows.Forms.ComboBox();
            this.HorasPracticastextBox = new System.Windows.Forms.TextBox();
            this.HorasteoricastextBox = new System.Windows.Forms.TextBox();
            this.PreRequisitostextBox = new System.Windows.Forms.TextBox();
            this.CreditoscomboBox = new System.Windows.Forms.ComboBox();
            this.PemsumdataGridView = new System.Windows.Forms.DataGridView();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREREQUISITOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PemsumdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarreracomboBox
            // 
            this.CarreracomboBox.FormattingEnabled = true;
            this.CarreracomboBox.Location = new System.Drawing.Point(176, 9);
            this.CarreracomboBox.Name = "CarreracomboBox";
            this.CarreracomboBox.Size = new System.Drawing.Size(324, 33);
            this.CarreracomboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carrera ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horas Teoricas";
            // 
            // SemestretextBox
            // 
            this.SemestretextBox.Location = new System.Drawing.Point(602, 54);
            this.SemestretextBox.Name = "SemestretextBox";
            this.SemestretextBox.Size = new System.Drawing.Size(219, 31);
            this.SemestretextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Horas Practicas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Creditos ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pre-Req";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Semestre ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre Asignarura";
            // 
            // CLaveAsingnaturacomboBox
            // 
            this.CLaveAsingnaturacomboBox.FormattingEnabled = true;
            this.CLaveAsingnaturacomboBox.Location = new System.Drawing.Point(602, 6);
            this.CLaveAsingnaturacomboBox.Name = "CLaveAsingnaturacomboBox";
            this.CLaveAsingnaturacomboBox.Size = new System.Drawing.Size(219, 33);
            this.CLaveAsingnaturacomboBox.TabIndex = 16;
            // 
            // NombreAsignaturacomboBox
            // 
            this.NombreAsignaturacomboBox.FormattingEnabled = true;
            this.NombreAsignaturacomboBox.Location = new System.Drawing.Point(176, 54);
            this.NombreAsignaturacomboBox.Name = "NombreAsignaturacomboBox";
            this.NombreAsignaturacomboBox.Size = new System.Drawing.Size(324, 33);
            this.NombreAsignaturacomboBox.TabIndex = 17;
            // 
            // HorasPracticastextBox
            // 
            this.HorasPracticastextBox.Location = new System.Drawing.Point(176, 105);
            this.HorasPracticastextBox.Name = "HorasPracticastextBox";
            this.HorasPracticastextBox.Size = new System.Drawing.Size(192, 31);
            this.HorasPracticastextBox.TabIndex = 18;
            // 
            // HorasteoricastextBox
            // 
            this.HorasteoricastextBox.Location = new System.Drawing.Point(506, 96);
            this.HorasteoricastextBox.Name = "HorasteoricastextBox";
            this.HorasteoricastextBox.Size = new System.Drawing.Size(315, 31);
            this.HorasteoricastextBox.TabIndex = 20;
            // 
            // PreRequisitostextBox
            // 
            this.PreRequisitostextBox.Location = new System.Drawing.Point(506, 145);
            this.PreRequisitostextBox.Name = "PreRequisitostextBox";
            this.PreRequisitostextBox.Size = new System.Drawing.Size(315, 31);
            this.PreRequisitostextBox.TabIndex = 22;
            // 
            // CreditoscomboBox
            // 
            this.CreditoscomboBox.FormattingEnabled = true;
            this.CreditoscomboBox.Location = new System.Drawing.Point(176, 145);
            this.CreditoscomboBox.Name = "CreditoscomboBox";
            this.CreditoscomboBox.Size = new System.Drawing.Size(192, 33);
            this.CreditoscomboBox.TabIndex = 23;
            // 
            // PemsumdataGridView
            // 
            this.PemsumdataGridView.AllowUserToAddRows = false;
            this.PemsumdataGridView.AllowUserToDeleteRows = false;
            this.PemsumdataGridView.AllowUserToOrderColumns = true;
            this.PemsumdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PemsumdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.DESCRIPCION,
            this.HP,
            this.HT,
            this.CR,
            this.PREREQUISITOS});
            this.PemsumdataGridView.Location = new System.Drawing.Point(12, 196);
            this.PemsumdataGridView.Name = "PemsumdataGridView";
            this.PemsumdataGridView.ReadOnly = true;
            this.PemsumdataGridView.RowHeadersWidth = 62;
            this.PemsumdataGridView.RowTemplate.Height = 33;
            this.PemsumdataGridView.Size = new System.Drawing.Size(809, 341);
            this.PemsumdataGridView.TabIndex = 24;
            this.PemsumdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PemsumdataGridView_CellContentClick);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(231, 553);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(137, 58);
            this.Nuevobutton.TabIndex = 25;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(423, 553);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(137, 58);
            this.Guardarbutton.TabIndex = 26;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 8;
            this.Clave.Name = "Clave";
            this.Clave.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CLAVE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "Descripcion";
            this.DESCRIPCION.MinimumWidth = 8;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 150;
            // 
            // HP
            // 
            this.HP.HeaderText = "HP";
            this.HP.MinimumWidth = 8;
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            this.HP.Width = 150;
            // 
            // HT
            // 
            this.HT.HeaderText = "HT";
            this.HT.MinimumWidth = 8;
            this.HT.Name = "HT";
            this.HT.ReadOnly = true;
            this.HT.Width = 150;
            // 
            // CR
            // 
            this.CR.HeaderText = "CR";
            this.CR.MinimumWidth = 8;
            this.CR.Name = "CR";
            this.CR.ReadOnly = true;
            this.CR.Width = 150;
            // 
            // PREREQUISITOS
            // 
            this.PREREQUISITOS.HeaderText = "PRE-REQ";
            this.PREREQUISITOS.MinimumWidth = 8;
            this.PREREQUISITOS.Name = "PREREQUISITOS";
            this.PREREQUISITOS.ReadOnly = true;
            this.PREREQUISITOS.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RPensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 623);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.PemsumdataGridView);
            this.Controls.Add(this.CreditoscomboBox);
            this.Controls.Add(this.PreRequisitostextBox);
            this.Controls.Add(this.HorasteoricastextBox);
            this.Controls.Add(this.HorasPracticastextBox);
            this.Controls.Add(this.NombreAsignaturacomboBox);
            this.Controls.Add(this.CLaveAsingnaturacomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SemestretextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarreracomboBox);
            this.Name = "RPensum";
            this.Text = "Registro de Pensum";
            ((System.ComponentModel.ISupportInitialize)(this.PemsumdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CarreracomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SemestretextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CLaveAsingnaturacomboBox;
        private System.Windows.Forms.ComboBox NombreAsignaturacomboBox;
        private System.Windows.Forms.TextBox HorasPracticastextBox;
        private System.Windows.Forms.TextBox HorasteoricastextBox;
        private System.Windows.Forms.TextBox PreRequisitostextBox;
        private System.Windows.Forms.ComboBox CreditoscomboBox;
        private System.Windows.Forms.DataGridView PemsumdataGridView;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREREQUISITOS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}