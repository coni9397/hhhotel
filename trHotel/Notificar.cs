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
    public partial class Notificar : Form
    {
        validacion v = new validacion();
        public Notificar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlMenu2.Show();
            pnlMenu2.BringToFront();
            PnlMenu1.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PnlMenu1.Show();
            PnlMenu1.BringToFront();
            pnlMenu2.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Notificar_Load(object sender, EventArgs e)
        {
            pnlMenu2.Hide();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtAsunto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
            v.soloNumeros(e);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
        }
    }
}
