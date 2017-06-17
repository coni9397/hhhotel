using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trHotel
{
    public partial class SecretMenú : Form
    {
        public SecretMenú()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menuMinimized.BringToFront();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuOpen.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuarioMod a = new AgregarUsuarioMod();
            a.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Close();
        }
    }
}
