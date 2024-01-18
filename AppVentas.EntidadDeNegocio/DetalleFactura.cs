using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.EntidadDeNegocio
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaId { get; set; }

        [ForeignKey("Encabezado_Factura")]
        public int EncabezadoFacturaId { get; set; }
        [ForeignKey("ProductoCodigo")]
        public string ProductoCodigo { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser un número positivo.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El subtotal es obligatorio.")]
        public decimal Subtotal { get; set; }
    }
}
