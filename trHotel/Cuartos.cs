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
    public partial class Cuartos : Form
    {
        public Cuartos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cuartos_Load(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Show();
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            AyudaVenta a = new AyudaVenta();
            a.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notificar n = new Notificar();
            n.Show();
        }
    }
}
