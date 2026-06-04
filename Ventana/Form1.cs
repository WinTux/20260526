using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Ventana.Models;

namespace Ventana
{
    public partial class Form1 : Form
    {
        List<string> listaCompras;
        Stack<Libro> pilaDeLibros, pilaAuxiliar;
        Queue<Autor> colaDeAutores;
        int contadorAutores = 0;
        string connectionString = "Server=.;Database=Tienda;User Id=sa;Password=123456ABCxyz;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            listaCompras = new List<string>();
            pilaDeLibros = new Stack<Libro>();
            pilaAuxiliar = new Stack<Libro>();
            colaDeAutores = new Queue<Autor>();
        }

        private void clicCambiarNombre(object sender, EventArgs e)
        {
            Console.WriteLine("Botón clickeado");
            Debug.WriteLine("Botón clickeado");
            if (lblTitulo.Text == "Hola mundo")
                lblTitulo.Text = "Hasta luego";
            else
                lblTitulo.Text = "Hola mundo";
        }

        private void entrandoAlabel(object sender, EventArgs e)
        {
            lblTitulo.Text = "Entrando al label";
        }

        private void clicAgregarElemento(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text;
            listaCompras.Add(elemento);
            txtElemento.Clear();
            mostrarLista();
        }

        private void mostrarLista()
        {
            txtLista.Clear();
            lblLista.Text = "";
            foreach (string elemento in listaCompras)
            {
                txtLista.AppendText(elemento + Environment.NewLine);
                lblLista.Text += elemento + Environment.NewLine;
            }
        }

        private void clicEliminarElemento(object sender, EventArgs e)
        {
            string elemento = txtElementoEliminar.Text;
            if (listaCompras.Contains(elemento))
            {
                listaCompras.Remove(elemento);
                mostrarLista();
                txtElementoEliminar.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int anyo = int.Parse(txtAnyo.Text);
            Libro libro = new Libro(titulo, autor, anyo);
            pilaDeLibros.Push(libro);
            mostrarPila();
            txtTitulo.Text = txtAutor.Text = txtAnyo.Text = "";
        }

        private void mostrarPila()
        {
            txtPila.Clear();
            foreach (Libro libro in pilaDeLibros)
                txtPila.AppendText(libro.titulo + " - " + libro.autor + " (" + libro.anyo + ")" + Environment.NewLine);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloeliminar.Text;
            string autor = txtAutorEliminar.Text;
            int anyo = int.Parse(txtAnyoEliminar.Text);
            while (pilaDeLibros.Count > 0)
            {
                Libro actual = pilaDeLibros.Pop();
                if (!actual.autor.Equals(autor) && !actual.titulo.Equals(titulo) && actual.anyo != anyo)
                    pilaAuxiliar.Push(actual);
            }
            while (pilaAuxiliar.Count > 0)
            {
                pilaDeLibros.Push(pilaAuxiliar.Pop());
            }
            mostrarPila();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAutor.Text;
            string apellido = txtApellidoAutor.Text;
            Autor autor = new Autor(nombre, apellido);
            autor.id = ++contadorAutores;
            colaDeAutores.Enqueue(autor);
            mostrarCola();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdAutor.Text);
            Queue<Autor> colaAuxiliar = new Queue<Autor>();
            while (colaDeAutores.Count > 0)
            {
                Autor autor = colaDeAutores.Dequeue();
                if (autor.id == id)
                    Debug.WriteLine("Autor eliminado: " + autor.nombre + " " + autor.apellido);
                else
                    colaAuxiliar.Enqueue(autor);
            }
            while (colaAuxiliar.Count > 0)
                colaDeAutores.Enqueue(colaAuxiliar.Dequeue());
            mostrarCola();
        }
        private void mostrarCola()
        {
            txtCola.Clear();
            foreach (Autor autor in colaDeAutores)
                txtCola.AppendText(autor.nombre + " " + autor.apellido + " (ID: " + autor.id + ")" + Environment.NewLine);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                conn.Open();
                MessageBox.Show("Conexión exitosa a la base de datos");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                MessageBox.Show("Error al conectar a la base de datos");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CargarDatos("SELECT * FROM Productos;");
        }
        private void CargarDatos(string consulta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    DGVproductos.DataSource = tabla;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                MessageBox.Show("Error al conectar a la base de datos");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cargarDatos2();
        }

        private void cargarDatos2()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from Productos", conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                sourceProductos.DataSource = tabla;
                DGVproductos.DataSource = sourceProductos;
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int precioMax = int.Parse(txtPrecioMaximo.Text);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Productos WHERE Precio <= @p", conn);
                adaptador.SelectCommand.Parameters.AddWithValue("@p", precioMax);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                sourceProductos.DataSource = tabla;
                DGVproductos.DataSource = sourceProductos;
                conn.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormAgregarEditarProducto form = new FormAgregarEditarProducto(-1);
            form.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int valorID = int.Parse(DGVproductos.CurrentRow.Cells["Id"].Value.ToString());
            Debug.WriteLine("ID del producto seleccionado: " + valorID);
            FormAgregarEditarProducto form = new FormAgregarEditarProducto(valorID);
            form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                int valorID = int.Parse(DGVproductos.CurrentRow.Cells["Id"].Value.ToString());
                SqlCommand cmd = new SqlCommand("DELETE Productos WHERE Id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", valorID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente");
                cargarDatos2();
                conn.Close();
            }
        }
    }
}
