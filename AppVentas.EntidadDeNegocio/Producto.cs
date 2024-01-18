using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.EntidadDeNegocio
{
    public class Producto
    {
        [Key]

        [Required(ErrorMessage = "El código del producto es obligatorio.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        public string Descripcion { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El precio del producto debe ser un número positivo.")]
        public decimal Precio { get; set; }

        public int Cantidad { get; set; }
    }
}
