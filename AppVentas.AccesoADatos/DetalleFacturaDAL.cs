using AppVentas.EntidadDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.AccesoADatos
{
    public class DetalleFacturaDAL
    {
        public static async Task<int> CrearAsync(DetalleFactura pDetalleFactura)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pDetalleFactura);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<DetalleFactura>> ObtenerTodosAsync()
        {
            var detalles = new List<DetalleFactura>();
            using (var bdContexto = new BDContexto())
            {
                detalles = await bdContexto.DetalleFactura.ToListAsync();
            }
            return detalles;
        }
    }
}
