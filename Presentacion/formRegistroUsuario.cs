using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class formRegistroUsuario : Form
    {
        bool mover;
        int posX;
        int posY;

        public formRegistroUsuario()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void formRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formRegistroUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posX = e.X;
            posY = e.Y;
        }

        private void formRegistroUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        private void formRegistroUsuario_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
    }
}
