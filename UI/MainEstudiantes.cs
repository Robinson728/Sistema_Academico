using Sistema_Academico.UI.Consultas;
using Sistema_Academico.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academico.UI
{
    public partial class MainEstudiantes : Form
    {
        public MainEstudiantes()
        {
            InitializeComponent();

            this.rSeleccionToolStripMenuItem.Click += new EventHandler(this.rSeleccionToolStripMenuItem_ItemClicked);
            this.cSeleccionToolStripMenuItem.Click += new EventHandler(this.cSeleccionToolStripMenuItem_ItemClicked);
        }

        public void rSeleccionToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rSeleccionAsignaturas seleccionAsignaturas = new rSeleccionAsignaturas();
            seleccionAsignaturas.MdiParent = this;
            seleccionAsignaturas.Show();
        }

        public void cSeleccionToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            CSeleccionAsignatura seleccionAsignatura = new CSeleccionAsignatura();
            seleccionAsignatura.MdiParent = this;
            seleccionAsignatura.Show();
        }
    }
}
