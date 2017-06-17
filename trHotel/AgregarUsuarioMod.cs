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
    public partial class AgregarUsuarioMod : Form
    {
        Conexion c = new Conexion();
        validacion v = new validacion();
        public AgregarUsuarioMod()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Today.ToLongTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtUser.Text = " ";
            cboTipo.Text = "";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.user(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.password(e);
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.noCharacter(e);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuOpen.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menuMinimized.BringToFront();
        }

        private void AgregarUsuarioMod_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Administrador");
            cboTipo.Items.Add("Usuario");
            Conexion c = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e){
            MessageBox.Show(c.insertar(txtNombre.Text, txtUser.Text, txtPassword.Text, cboTipo.Text));
 
        }
             
        }
    }

