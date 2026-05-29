using System.Diagnostics;
using Ventana.Models;

namespace Ventana
{
    public partial class Form1 : Form
    {
        List<string> listaCompras;
        Stack<Libro> pilaDeLibros, pilaAuxiliar;
        Queue<Autor> colaDeAutores;
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
            while (pilaDeLibros.Count > 0) {
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
    }
}
