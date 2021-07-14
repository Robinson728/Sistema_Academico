using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Academico.BLL;

namespace Sistema_Academico.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if(UsuarioTextBox.Text=="Admin123" && ClaveTextBox.Text == "1234")
            {
                MainForms main2 = new MainForms();
                main2.Show();
            }
            else if (EstudiantesBLL.ConfirmarClave(UsuarioTextBox.Text, ClaveTextBox.Text))
            {
                MainEstudiantes main = new MainEstudiantes();
                main.Show();
            }
            else
            {
                MessageBox.Show("Error Nombre Usuario o Contraseña incorrecta!", "Error!");
                UsuarioTextBox.Clear();
                ClaveTextBox.Focus();
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
