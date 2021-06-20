﻿using Sistema_Academico.BLL;
using Sistema_Academico.Models;
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

namespace Sistema_Academico.UI.Consultas
{
    public partial class cProfesor : Form
    {
        public cProfesor()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IdTextBox.Clear();
            NombreTextBox.Clear();
            DirecciontextBox.Clear();
            EmailTextBox.Clear();
            CedulamaskedTextBox.Clear();
            ClaveTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            FechaIngresodateTimePicker.Value=DateTime.Now;
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            var lista = new List<Profesores>();

            if ((IdTextBox.Text == string.Empty) && (NombreTextBox.Text == string.Empty) && (DirecciontextBox.Text == string.Empty)
                    && (CedulamaskedTextBox.Text == string.Empty) && (EmailTextBox.Text == string.Empty) && (TelefonomaskedTextBox.Text == string.Empty))
            {
                lista = ProfesoresBLL.GetList(r => true);
            }

            if (IdTextBox.Text != string.Empty)
                lista = ProfesoresBLL.GetList(r => r.ProfesorId == Conversiones.ToInt(IdTextBox.Text));

            if (NombreTextBox.Text != string.Empty)
                lista = ProfesoresBLL.GetList(r => r.Nombre.Contains(NombreTextBox.Text));

            if (DirecciontextBox.Text != string.Empty)
                lista = ProfesoresBLL.GetList(r => r.Direccion.Contains(DirecciontextBox.Text));

            if (CedulamaskedTextBox.Text != string.Empty)
                lista = ProfesoresBLL.GetList(r => r.Cedula.Contains(CedulamaskedTextBox.Text));

            if (EmailTextBox.Text != string.Empty)
                lista = ProfesoresBLL.GetList(r => r.Email.Contains(EmailTextBox.Text));

            if (TelefonomaskedTextBox.Text != string.Empty)
                lista = ProfesoresBLL.GetList(r => r.Telefono.Contains(TelefonomaskedTextBox.Text)); 

            ConsultaAsignaturaDataGridView.DataSource = null;
            ConsultaAsignaturaDataGridView.DataSource = lista;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            string id;

            if (ConsultaAsignaturaDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = ConsultaAsignaturaDataGridView.CurrentRow.Cells[0].Value.ToString();
            rProfesores profesores = new rProfesores();
            profesores.RecibirProfesores(Conversiones.ToInt(id));
            profesores.Show();
            Close();
        }
    }
}
    

