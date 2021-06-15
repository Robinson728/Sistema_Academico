using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Academico.UI.Registros;
using Sistema_Academico.UI.Consultas;

namespace Sistema_Academico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.rAsignaturasToolStripMenuItem.Click += new EventHandler(this.rAsignaturasToolStripMenuItem_ItemClicked);
            this.rGruposToolStripMenuItem.Click += new EventHandler(this.rGruposToolStripMenuItem_ItemClicked);
            this.rProfesoresToolStripMenuItem.Click += new EventHandler(this.rProfesoresToolStripMenuItem_ItemClicked);

            this.cGruposToolStripMenuItem.Click += new EventHandler(this.cGruposToolStripMenuItem_ItemClicked);
            this.cAsignaturasTolStripMenuItem.Click += new EventHandler(this.cAsignaturasTolStripMenuItem_ItemClicked);
        }

        public void rAsignaturasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rAsignaturas asignaturas = new rAsignaturas();
            asignaturas.MdiParent = this;
            asignaturas.Show();
        }

        public void rGruposToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rGrupos grupos = new rGrupos();
            grupos.MdiParent = this;
            grupos.Show();
        }

        public void rProfesoresToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rProfesores profesores = new rProfesores();
            profesores.MdiParent = this;
            profesores.Show();
        }

        public void cGruposToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cGrupos grupos = new cGrupos();
            grupos.MdiParent = this;
            grupos.Show();
        }

        public void cAsignaturasTolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cAsignaturas asignaturas = new cAsignaturas();
            asignaturas.MdiParent = this;
            asignaturas.Show();
        }
    }
}
