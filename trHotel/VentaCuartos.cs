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
    public partial class VentaCuartos : Form
    {
        public VentaCuartos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Inicio de condición de termino de sesión
            MessageBox.Show("¿Está seguro que desea salír?", "Cerrando sesión", MessageBoxButtons.OK);
            if (MessageBoxButtons.OK.Equals(MessageBoxButtons.OK))
            {
                // Inicio de termino de sesión
                this.Close();
                Principal logOut = new Principal();
                logOut.Show();
              
            }
            else
            {
                MessageBox.Show("Se canceló el cierre de sesión, no olvide guardar los datos!.");
            }
         
        }

        private void VentaCuartos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Redireccion a metodo de venta.
            Cuartos vender = new Cuartos();
            vender.Show();
            
            //Termino de redireccion a metodo de venta.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notificar noti = new Notificar();
            noti.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Notificar n = new Notificar();
            n.Show();

        }
    }
}
