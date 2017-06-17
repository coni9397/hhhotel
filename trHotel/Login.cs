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
    public partial class Login : Form
    {
        validacion v = new validacion();
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin" && comboBox1.Text == "Administrador")
            {
                MessageBox.Show("Se ha logeado como usuario administrador !.", "Aviso | Administrador");
                MenuAdmin ma = new MenuAdmin();
                ma.Show();
                this.Close();
            }
            else if (textBox1.Text == "Usuario" && textBox2.Text == "Usuario" && comboBox1.Text == "Usuario")
            {
                MessageBox.Show("Se ha logeado como tipo usuario!.", "Aviso | Usuario");
                VentaCuartos mu = new VentaCuartos();
                mu.Show();
                this.Close();
            }else if(textBox1.Text == "SuperADM" && textBox2.Text == "qwe"){
                SecretMenú sm = new SecretMenú();
                sm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Las credenciales no coinciden con ninguna cuenta de usuario o administrador, Por favor intente nuevamente.", "Error | Visitante");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.user(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.password(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.noCharacter(e);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuario");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ayuda a = new Ayuda();
            a.Show();
        }
    }
}
