
namespace Sistema_Academico.UI.Registros
{
    partial class rCalificaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstudianteTextBox = new System.Windows.Forms.TextBox();
            this.MatriculaTextBox = new System.Windows.Forms.TextBox();
            this.EstudianteLabel = new System.Windows.Forms.Label();
            this.MatriculaLabel = new System.Windows.Forms.Label();
            this.IdEstudianteLabel = new System.Windows.Forms.Label();
            this.IdEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.PrimerPacialTextBox = new System.Windows.Forms.TextBox();
            this.PrimerPacialLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstudianteTextBox);
            this.groupBox1.Controls.Add(this.MatriculaTextBox);
            this.groupBox1.Controls.Add(this.EstudianteLabel);
            this.groupBox1.Controls.Add(this.MatriculaLabel);
            this.groupBox1.Controls.Add(this.IdEstudianteLabel);
            this.groupBox1.Controls.Add(this.IdEstudianteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // EstudianteTextBox
            // 
            this.EstudianteTextBox.Location = new System.Drawing.Point(91, 22);
            this.EstudianteTextBox.Name = "EstudianteTextBox";
            this.EstudianteTextBox.ReadOnly = true;
            this.EstudianteTextBox.Size = new System.Drawing.Size(384, 23);
            this.EstudianteTextBox.TabIndex = 1;
            // 
            // MatriculaTextBox
            // 
            this.MatriculaTextBox.Location = new System.Drawing.Point(260, 61);
            this.MatriculaTextBox.Name = "MatriculaTextBox";
            this.MatriculaTextBox.ReadOnly = true;
            this.MatriculaTextBox.Size = new System.Drawing.Size(215, 23);
            this.MatriculaTextBox.TabIndex = 5;
            // 
            // EstudianteLabel
            // 
            this.EstudianteLabel.AutoSize = true;
            this.EstudianteLabel.Location = new System.Drawing.Point(9, 25);
            this.EstudianteLabel.Name = "EstudianteLabel";
            this.EstudianteLabel.Size = new System.Drawing.Size(62, 15);
            this.EstudianteLabel.TabIndex = 0;
            this.EstudianteLabel.Text = "Estudiante";
            // 
            // MatriculaLabel
            // 
            this.MatriculaLabel.AutoSize = true;
            this.MatriculaLabel.Location = new System.Drawing.Point(197, 64);
            this.MatriculaLabel.Name = "MatriculaLabel";
            this.MatriculaLabel.Size = new System.Drawing.Size(57, 15);
            this.MatriculaLabel.TabIndex = 4;
            this.MatriculaLabel.Text = "Matrícula";
            // 
            // IdEstudianteLabel
            // 
            this.IdEstudianteLabel.AutoSize = true;
            this.IdEstudianteLabel.Location = new System.Drawing.Point(9, 64);
            this.IdEstudianteLabel.Name = "IdEstudianteLabel";
            this.IdEstudianteLabel.Size = new System.Drawing.Size(75, 15);
            this.IdEstudianteLabel.TabIndex = 2;
            this.IdEstudianteLabel.Text = "Estudiante Id";
            // 
            // IdEstudianteTextBox
            // 
            this.IdEstudianteTextBox.Location = new System.Drawing.Point(91, 61);
            this.IdEstudianteTextBox.Name = "IdEstudianteTextBox";
            this.IdEstudianteTextBox.ReadOnly = true;
            this.IdEstudianteTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdEstudianteTextBox.TabIndex = 3;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(5, 133);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(480, 39);
            this.GuardarButton.TabIndex = 34;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // PrimerPacialTextBox
            // 
            this.PrimerPacialTextBox.Location = new System.Drawing.Point(74, 104);
            this.PrimerPacialTextBox.Name = "PrimerPacialTextBox";
            this.PrimerPacialTextBox.Size = new System.Drawing.Size(411, 23);
            this.PrimerPacialTextBox.TabIndex = 25;
            // 
            // PrimerPacialLabel
            // 
            this.PrimerPacialLabel.AutoSize = true;
            this.PrimerPacialLabel.Location = new System.Drawing.Point(5, 107);
            this.PrimerPacialLabel.Name = "PrimerPacialLabel";
            this.PrimerPacialLabel.Size = new System.Drawing.Size(61, 15);
            this.PrimerPacialLabel.TabIndex = 24;
            this.PrimerPacialLabel.Text = "Nota Final";
            // 
            // rCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 176);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.PrimerPacialTextBox);
            this.Controls.Add(this.PrimerPacialLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "rCalificaciones";
            this.Text = "Asignación de Calificaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EstudianteTextBox;
        private System.Windows.Forms.TextBox MatriculaTextBox;
        private System.Windows.Forms.Label EstudianteLabel;
        private System.Windows.Forms.Label MatriculaLabel;
        private System.Windows.Forms.Label IdEstudianteLabel;
        private System.Windows.Forms.TextBox IdEstudianteTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox PrimerPacialTextBox;
        private System.Windows.Forms.Label PrimerPacialLabel;
    }
}