using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AppVentas.EntidadDeNegocio
{
    public class EncabezadoFactura
    {
        [Key]
        public int EncabezadoFacturaId { get; set; }

        [Required(ErrorMessage = "La fecha de la factura es obligatoria.")]
        public DateTime Fecha { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El total de la factura es obligatorio.")]
        public decimal Total { get; set; }
    }
}
