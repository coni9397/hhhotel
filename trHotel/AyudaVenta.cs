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
    public partial class AyudaVenta : Form
    {
        public AyudaVenta()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesión, esta seguro que desea salír?", "Cerrando sesión", MessageBoxButtons.YesNo);
            Cuartos c = new Cuartos();
            c.Close();
            Principal p = new Principal();
            p.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
