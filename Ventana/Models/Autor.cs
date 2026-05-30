using System;
using System.Collections.Generic;
using System.Text;

namespace Ventana.Models
{
    public class Autor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Autor() { 
            id = 0;
            nombre = "NA";
            apellido = "NA";
        }
        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
