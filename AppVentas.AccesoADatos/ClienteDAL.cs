using AppVentas.EntidadDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.AccesoADatos
{
    public class ClienteDAL
    {
        public static async Task<int> CrearAsync(Cliente pCliente)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pCliente);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> ModificarAsync(Cliente pCliente)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var cliente = await bdContexto.Cliente.FirstOrDefaultAsync(s => s.ClienteId == pCliente.ClienteId);
                cliente.Nombre = pCliente.Nombre;
                bdContexto.Update(cliente);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> EliminarAsync(Cliente pCliente)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var cliente = await bdContexto.Cliente.FirstOrDefaultAsync(s => s.ClienteId== pCliente.ClienteId);
                bdContexto.Cliente.Remove(cliente);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<Cliente> ObtenerPorIdAsync(Cliente pCliente)
        {
            var cliente = new Cliente();
            using (var bdContexto = new BDContexto())
            {
                cliente = await bdContexto.Cliente.FirstOrDefaultAsync(s => s.ClienteId == pCliente.ClienteId);
            }
            return cliente;
        }

        public static async Task<List<Cliente>> ObtenerTodosAsync()
        {
            var clientes = new List<Cliente>();
            using (var bdContexto = new BDContexto())
            {
                clientes = await bdContexto.Cliente.ToListAsync();
            }
            return clientes;
        }

        internal static IQueryable<Cliente> QuerySelect(IQueryable<Cliente> pQuery, Cliente pCliente)
        {
            if (pCliente.ClienteId > 0)
                pQuery = pQuery.Where(s => s.ClienteId == pCliente.ClienteId);

            if (!string.IsNullOrWhiteSpace(pCliente.Nombre))
                pQuery = pQuery.Where(s => s.Nombre.Contains(pCliente.Nombre));

            if (!string.IsNullOrWhiteSpace(pCliente.Apellido))
                pQuery = pQuery.Where(s => s.Apellido.Contains(pCliente.Apellido));

            if (pCliente.Telefono > 0)
                pQuery = pQuery.Where(s => s.Telefono == pCliente.Telefono);

            if (!string.IsNullOrWhiteSpace(pCliente.Direccion))
                pQuery = pQuery.Where(s => s.Direccion.Contains(pCliente.Direccion));

            // Ordenar por ClienteId en orden descendente
            pQuery = pQuery.OrderByDescending(s => s.ClienteId).AsQueryable();

            return pQuery;
        }
    

    public static async Task<List<Cliente>> BuscarAsync(Cliente pCliente)
        {
            var clientes = new List<Cliente>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Cliente.AsQueryable();
                select = QuerySelect(select, pCliente);
                clientes = await select.ToListAsync();
            }
            return clientes;
        }
    }
}

