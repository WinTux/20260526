using System.Diagnostics;

namespace Ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clicCambiarNombre(object sender, EventArgs e)
        {
            Console.WriteLine("Botón clickeado");
            Debug.WriteLine("Botón clickeado");
            if(lblTitulo.Text == "Hola mundo")
                lblTitulo.Text = "Hasta luego";
            else 
                lblTitulo.Text = "Hola mundo";
        }

        private void entrandoAlabel(object sender, EventArgs e)
        {
            lblTitulo.Text = "Entrando al label";
        }
    }
}
