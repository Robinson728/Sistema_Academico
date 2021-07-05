
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
            this.GrupoTextBox = new System.Windows.Forms.TextBox();
            this.CreditosTextBox = new System.Windows.Forms.TextBox();
            this.GrupoLabel = new System.Windows.Forms.Label();
            this.CreditosLabel = new System.Windows.Forms.Label();
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.AsignaturaDetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AsignaturaDetalleGroupBox
            // 
            this.AsignaturaDetalleGroupBox.Controls.Add(this.EstudiantesDataGridView);
            this.AsignaturaDetalleGroupBox.Location = new System.Drawing.Point(9, 215);
            this.AsignaturaDetalleGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsignaturaDetalleGroupBox.Name = "AsignaturaDetalleGroupBox";
            this.AsignaturaDetalleGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsignaturaDetalleGroupBox.Size = new System.Drawing.Size(658, 313);
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
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(7, 27);
            this.EstudiantesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.ReadOnly = true;
            this.EstudiantesDataGridView.RowHeadersWidth = 51;
            this.EstudiantesDataGridView.RowTemplate.Height = 25;
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(645, 276);
            this.EstudiantesDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matrícula";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Carrera";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // GrupoTextBox
            // 
            this.GrupoTextBox.Location = new System.Drawing.Point(384, 180);
            this.GrupoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrupoTextBox.Name = "GrupoTextBox";
            this.GrupoTextBox.Size = new System.Drawing.Size(255, 27);
            this.GrupoTextBox.TabIndex = 45;
            // 
            // CreditosTextBox
            // 
            this.CreditosTextBox.Location = new System.Drawing.Point(72, 179);
            this.CreditosTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreditosTextBox.Name = "CreditosTextBox";
            this.CreditosTextBox.Size = new System.Drawing.Size(255, 27);
            this.CreditosTextBox.TabIndex = 44;
            // 
            // GrupoLabel
            // 
            this.GrupoLabel.AutoSize = true;
            this.GrupoLabel.Location = new System.Drawing.Point(334, 183);
            this.GrupoLabel.Name = "GrupoLabel";
            this.GrupoLabel.Size = new System.Drawing.Size(50, 20);
            this.GrupoLabel.TabIndex = 43;
            this.GrupoLabel.Text = "Grupo";
            // 
            // CreditosLabel
            // 
            this.CreditosLabel.AutoSize = true;
            this.CreditosLabel.Location = new System.Drawing.Point(7, 183);
            this.CreditosLabel.Name = "CreditosLabel";
            this.CreditosLabel.Size = new System.Drawing.Size(64, 20);
            this.CreditosLabel.TabIndex = 42;
            this.CreditosLabel.Text = "Creditos";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(95, 89);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(563, 60);
            this.DescripcionTextBox.TabIndex = 39;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(95, 51);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(563, 27);
            this.NombreTextBox.TabIndex = 38;
            // 
            // AsignaturaIdNumericUpDown
            // 
            this.AsignaturaIdNumericUpDown.Location = new System.Drawing.Point(95, 12);
            this.AsignaturaIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsignaturaIdNumericUpDown.Name = "AsignaturaIdNumericUpDown";
            this.AsignaturaIdNumericUpDown.ReadOnly = true;
            this.AsignaturaIdNumericUpDown.Size = new System.Drawing.Size(71, 27);
            this.AsignaturaIdNumericUpDown.TabIndex = 37;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(0, 93);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 36;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(0, 55);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(64, 20);
            this.NombreLabel.TabIndex = 35;
            this.NombreLabel.Text = "Nombre";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(0, 17);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(97, 20);
            this.IdLabel.TabIndex = 34;
            this.IdLabel.Text = "Asignatura Id";
            // 
            // EliminarButton
            // 
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(334, 536);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(106, 56);
            this.EliminarButton.TabIndex = 51;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(108, 536);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(106, 56);
            this.NuevoButton.TabIndex = 50;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(221, 536);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(106, 56);
            this.GuardarButton.TabIndex = 49;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(447, 536);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(106, 56);
            this.BuscarButton.TabIndex = 52;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click_1);
            // 
            // rAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 605);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AsignaturaDetalleGroupBox);
            this.Controls.Add(this.GrupoTextBox);
            this.Controls.Add(this.CreditosTextBox);
            this.Controls.Add(this.GrupoLabel);
            this.Controls.Add(this.CreditosLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.AsignaturaIdNumericUpDown);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IdLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rAsignaturas";
            this.Text = "Registro de Asignaturas";
            this.AsignaturaDetalleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AsignaturaDetalleGroupBox;
        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.TextBox GrupoTextBox;
        private System.Windows.Forms.TextBox CreditosTextBox;
        private System.Windows.Forms.Label GrupoLabel;
        private System.Windows.Forms.Label CreditosLabel;
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
        private System.Windows.Forms.Button BuscarButton;
    }
}