using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace trHotel
{
    public partial class TestConection : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=MugenPC\\SQLEXPRESS;Initial Catalog=trHotel;Integrated Security=True");
        public TestConection()
        {
            InitializeComponent();
        }

        private void TestConection_Load(object sender, EventArgs e)
        {
            cn.Open();
            if (cn != null) label3.Text = "Conectado";
            else { label3.Text = "desconectado"; }
        }
    }
}
