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

namespace Sistema_Academico.UI
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();

            this.rAsignaturasToolStripMenuItem.Click += new EventHandler(this.rAsignaturasToolStripMenuItem_ItemClicked);
            this.rCalificacionesToolStripMenuItem.Click += new EventHandler(this.rCalificacionesToolStripMenuItem_ItemClicked);
            this.rCarrerasToolStripMenuItem.Click += new EventHandler(this.rCarrerasToolStripMenuItem_ItemClicked);
            this.rEstudiantesToolStripMenuItem.Click += new EventHandler(this.rEstudiantesToolStripMenuItem_ItemClicked);
            this.rGruposToolStripMenuItem.Click += new EventHandler(this.rGruposToolStripMenuItem_ItemClicked);
            this.rPensumToolStripMenuItem.Click += new EventHandler(this.rPensumToolStripMenuItem_ItemClicked);
            this.rProfesoresToolStripMenuItem.Click += new EventHandler(this.rProfesoresToolStripMenuItem_ItemClicked);
            this.rSeleccionToolStripMenuItem.Click += new EventHandler(this.rSeleccionToolStripMenuItem_ItemClicked);
            this.rSemestresToolStripMenuItem.Click += new EventHandler(this.rSemestresToolStripMenuItem_ItemClicked);

            this.cAsignaturasTolStripMenuItem.Click += new EventHandler(this.cAsignaturasTolStripMenuItem_ItemClicked);
            this.cCalificacionesToolStripMenuItem.Click += new EventHandler(this.cCalificacionesToolStripMenuItem_ItemClicked);
            this.cCarrerasToolStripMenuItem.Click += new EventHandler(this.cCarrerasToolStripMenuItem_ItemClicked);
            this.cEstudiantesToolStripMenuItem.Click += new EventHandler(this.cEstudiantesToolStripMenuItem_ItemClicked);
            this.cGruposToolStripMenuItem.Click += new EventHandler(this.cGruposToolStripMenuItem_ItemClicked);
            this.cPensumToolStripMenuItem.Click += new EventHandler(this.cPensumToolStripMenuItem_ItemClicked);
            this.cProfesorToolStripMenuItem.Click += new EventHandler(this.cProfesorToolStripMenuItem_ItemClicked);
            this.cSemestresToolStripMenuItem.Click += new EventHandler(this.cSemestresToolStripMenuItem_ItemClicked);
        }

        //------------------------------REGISTROS--------------------------------------
        public void rAsignaturasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rAsignaturas asignaturas = new rAsignaturas();
            asignaturas.MdiParent = this;
            asignaturas.Show();
        }
        
        public void rCalificacionesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rCalificaciones calificaciones = new rCalificaciones();
            calificaciones.MdiParent = this;
            calificaciones.Show();
        }
        
        public void rCarrerasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            RCarreras carreras = new RCarreras();
            carreras.MdiParent = this;
            carreras.Show();
        }
        
        public void rEstudiantesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rEstudiantes estudiantes = new rEstudiantes();
            estudiantes.MdiParent = this;
            estudiantes.Show();
        }

        public void rGruposToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rGrupos grupos = new rGrupos();
            grupos.MdiParent = this;
            grupos.Show();
        }
        
        public void rPensumToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            RPensum pensum = new RPensum();
            pensum.MdiParent = this;
            pensum.Show();
        }

        public void rProfesoresToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rProfesores profesores = new rProfesores();
            profesores.MdiParent = this;
            profesores.Show();
        }
        
        public void rSeleccionToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rSeleccionAsignaturas seleccionAsignaturas = new rSeleccionAsignaturas();
            seleccionAsignaturas.MdiParent = this;
            seleccionAsignaturas.Show();
        }
        
        public void rSemestresToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rSemestres semestres = new rSemestres();
            semestres.MdiParent = this;
            semestres.Show();
        }

        //------------------------------CONSULTAS--------------------------------------

        public void cAsignaturasTolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cAsignaturas asignaturas = new cAsignaturas();
            asignaturas.MdiParent = this;
            asignaturas.Show();
        }

        public void cCalificacionesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cCalificaciones calificaciones = new cCalificaciones();
            calificaciones.MdiParent = this;
            calificaciones.Show();
        }

        public void cCarrerasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cCarreras carreras = new cCarreras();
            carreras.MdiParent = this;
            carreras.Show();
        }

        public void cEstudiantesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cEstudiantes estudiantes = new cEstudiantes();
            estudiantes.MdiParent = this;
            estudiantes.Show();
        }
        public void cGruposToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cGrupos grupos = new cGrupos();
            grupos.MdiParent = this;
            grupos.Show();
        }

        public void cPensumToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cPensum pensum = new cPensum();
            pensum.MdiParent = this;
            pensum.Show();
        }

        public void cProfesorToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cProfesor profesores = new cProfesor();
            profesores.MdiParent = this;
            profesores.Show();
        }

        public void cSemestresToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            cSemestres semestres = new cSemestres();
            semestres.MdiParent = this;
            semestres.Show();
        }
    }
}
