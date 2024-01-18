using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.EntidadDeNegocio
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es obligatorio.")]
        public string Apellido { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El número de teléfono del cliente debe ser un número positivo.")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "La dirección del cliente es obligatoria.")]
        public string Direccion { get; set; }

    }
}
