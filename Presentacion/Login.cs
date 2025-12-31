using Logica;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        UsuarioLogica logica;

        public Login()
        {
            InitializeComponent();
            logica = new UsuarioLogica();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            Usuario usuario = logica.Login(cedula, contrasena);

            if (usuario == null)
            {
                MessageBox.Show("Cédula o contraseña incorrecta");
                return;
            }

            if (!usuario.estado)
            {
                MessageBox.Show("Usuario inactivo");
                return;
            }

            MessageBox.Show(
                $"Bienvenido {usuario.Rol.nombre} ---> {usuario.nombre}"
            );
        }


        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
                txtContrasena.PasswordChar = '\0'; 
            else
                txtContrasena.PasswordChar = '*';
        }
    }
}
