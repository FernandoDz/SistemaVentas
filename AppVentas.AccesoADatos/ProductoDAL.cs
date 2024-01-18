using AppVentas.EntidadDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.AccesoADatos
{
    public class ProductoDAL
    {
        internal static IQueryable<Producto> QuerySelect(IQueryable<Producto> pQuery, Producto pProducto)
        {

            if (!string.IsNullOrWhiteSpace(pProducto.Codigo))
                pQuery = pQuery.Where(s => s.Codigo.Contains(pProducto.Codigo));

            if (!string.IsNullOrWhiteSpace(pProducto.Descripcion))
                pQuery = pQuery.Where(s => s.Descripcion.Contains(pProducto.Descripcion));

            if (pProducto.Precio > 0)
                pQuery = pQuery.Where(s => s.Precio == pProducto.Precio);

            return pQuery;
        }
        public static async Task<List<Producto>> BuscarAsync(Producto pProducto)
        {
            var productos = new List<Producto>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Producto.AsQueryable();
                select = QuerySelect(select, pProducto);
                productos = await select.ToListAsync();
            }
            return productos;
        }
    }
}

