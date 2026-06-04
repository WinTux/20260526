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
        int _idProducto;
        public FormAgregarEditarProducto(int idProducto)
        {
            InitializeComponent();
            _idProducto = idProducto;
            if (_idProducto > 0)
                llenarCampos();
        }

        private void llenarCampos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Productos WHERE Id = @id", conn);
                adaptador.SelectCommand.Parameters.AddWithValue("@id", _idProducto);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                // Llenar los textbox con los datos del registro en tabla
                foreach (DataRow row in tabla.Rows)
                {
                    textBox1.Text = row["Nombre"].ToString();
                    textBox2.Text = row["Precio"].ToString();
                    textBox3.Text = row["Foto"].ToString();
                    textBox4.Text = row["Cantidad"].ToString();
                    checkBox1.Checked = (bool)row["Activo"];
                }
                conn.Close();
            }
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
                if (_idProducto < 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Productos VALUES (@nom, @precio, @foto, @cant, @activo);", conn);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@foto", foto);
                    cmd.Parameters.AddWithValue("@cant", cant);
                    cmd.Parameters.AddWithValue("@activo", activo);
                    cmd.ExecuteNonQuery();
                }
                else { 
                    SqlCommand cmd = new SqlCommand("UPDATE Productos SET Nombre = @nom, Precio = @precio, Foto = @foto, Cantidad = @cant, Activo = @activo WHERE Id = @id;", conn);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@foto", foto);
                    cmd.Parameters.AddWithValue("@cant", cant);
                    cmd.Parameters.AddWithValue("@activo", activo);
                    cmd.Parameters.AddWithValue("@id", _idProducto);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
        }
    }
}
