using AppVentas.AccesoADatos;
using AppVentas.EntidadDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.LogicaDeNegocio
{
    public class ProductoBL
    {
        public async Task<int> CrearAsync(EncabezadoFactura pEncabezadoFactura)
        {
            return await EncabezadoFacturaDAL.CrearAsync(pEncabezadoFactura);
        }
    }
}
