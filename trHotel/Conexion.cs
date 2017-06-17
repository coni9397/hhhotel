using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace trHotel
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=MUGENPC\\SQLEXPRESS;Initial Catalog=trHotel;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }
        public string insertar( string Nombre, string Usuario, string Contrasena, string tipo)
        {
            string salida = " Se ha insertado un nuevo usuario";
            try
            {
                cmd = new SqlCommand("Insert into Usuarios( Nombre, Usuario, Contrasena, tipo) values('"+Nombre+"','"+Usuario+"', '"+Contrasena+"','"+tipo+"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }


    }
}
