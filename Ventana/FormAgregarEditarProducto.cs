using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ventana
{
    public partial class FormAgregarEditarProducto : Form
    {
        string connectionString = "Server=.;Database=Tienda;User Id=sa;Password=123456ABCxyz;Trusted_Connection=True;TrustServerCertificate=True;";
        public FormAgregarEditarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string precio = textBox2.Text;
            string foto = textBox3.Text;
            string cant = textBox4.Text;
            int activo = checkBox1.Checked ? 1 : 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos VALUES (@nom, @precio, @foto, @cant, @activo);", conn);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@cant", cant);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
