using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ventana.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]   
        public int Id { get; set; }
        [StringLength(250)]
        public string? Nombre { get; set; }
        [Column(TypeName = "money")]
        public decimal? Precio { get; set; }
        [StringLength(50)]
        public string? Foto { get; set; }
        public int? Cantidad { get; set; }
        public bool Activo { get; set; }
    }
}
