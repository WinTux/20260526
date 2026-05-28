using System.Diagnostics;

namespace Ventana
{
    public partial class Form1 : Form
    {
        List<string> listaCompras;
        public Form1()
        {
            InitializeComponent();
            listaCompras = new List<string>();
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
    }
}
