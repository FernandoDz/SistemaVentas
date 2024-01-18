using AppVentas.AccesoADatos;
using AppVentas.EntidadDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.LogicaDeNegocio
{
    public class DetalleFacturaBL
    {
        public async Task<int> CrearAsync(DetalleFactura pDetalleFactura)
        {
            return await DetalleFacturaDAL.CrearAsync(pDetalleFactura);
        }
        public async Task<List<DetalleFactura>> ObtenerTodosAsync()
        {
            return await DetalleFacturaDAL.ObtenerTodosAsync();
        }
    }
}
