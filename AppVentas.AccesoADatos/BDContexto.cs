using AppVentas.EntidadDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.AccesoADatos
{
    public class BDContexto: DbContext
    {virtual 
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<EncabezadoFactura> EncabezadoFactura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=BDSysVenta.mssql.somee.com; Initial Catalog=BDSysVenta; User Id=fernandoss_SQLLogin_1; Pwd=snu8c8tzyo");
        }


        //incluye aca tu conexion a sql server y la base de datos
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer(@"Data source = DESKTOP-5D189V7;
        //   Initial Catalog = exampleBD;

        //  Integrated Security =True");
        //}


    }

}
