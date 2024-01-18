using AppVentas.EntidadDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.AccesoADatos
{
    public class EncabezadoFacturaDAL
    {
        public static async Task<int> CrearAsync(EncabezadoFactura pEncabezadoFactura)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pEncabezadoFactura);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<EncabezadoFactura>> ObtenerTodosAsync()
        {
            var encabezados = new List<EncabezadoFactura>();
            using (var bdContexto = new BDContexto())
            {
                encabezados = await bdContexto.EncabezadoFactura.ToListAsync();
            }
            return encabezados;
        }

    }
}
