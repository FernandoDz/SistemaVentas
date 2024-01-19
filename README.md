Este proyecto fue realizado para la prueba tecnica de Upgrade Business y consta de un sistema de ventas, haciendo uso de arquitectura n capas, entre alguna de estas , capa de entidades de negocio,
capa de acceso a datos(cabe aclarar que la base de datos esta hospedada en la nube, pero igualmente se puede hacer uso de una base de datos SQL cambiando
el string de conexion en el archivo <code>BDContexto.cs<code/>
en la linea
protected override void OnConfiguring(DbContextOptionsBuilder options)
 {
     options.UseSqlServer(@"Data Source=BDSysVenta.mssql.somee.com; Initial Catalog=BDSysVenta; User Id=fernandoss_SQLLogin_1; Pwd=snu8c8tzyo");
 }
 El proyecto fue realizado en el IDE Visual studio 2022 y SQL Server Express 2022 y .NET 6.
 Ademas consta de los siguientes modulos: 
 -Modulo de clientes
 -Modulo de Productos
 -Modulo de Encabezado de Factura
 -Modulo de Detalle de Factura
 A continuacion se muestra capturas de funcionalidad:
 
 ![sysventas](https://github.com/FernandoDz/SistemaVentas/assets/119868719/fc6960a8-bf16-4391-970a-a9e62de6f349)
 <br/>
![venta](https://github.com/FernandoDz/SistemaVentas/assets/119868719/3dd00fc5-dd52-42ce-82f8-5e6014175f36)
<br/>
 ![encabezado](https://github.com/FernandoDz/SistemaVentas/assets/119868719/81c7f7db-dfcd-4757-8c37-a15abfb8ab02)
 <br/>
 ![detalle](https://github.com/FernandoDz/SistemaVentas/assets/119868719/38e457fe-a2e5-4dc0-81e7-1fa45bba4feb)

