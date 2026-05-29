using System;
using System.Collections.Generic;
using System.Text;

namespace Ventana.Models
{
    public class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anyo { get; set; }

        public Libro(string titulo, string autor, int anyo)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anyo = anyo;

        }
    }
}
