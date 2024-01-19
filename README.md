# Sistema de Ventas - Upgrade Business

Este proyecto fue creado como parte de la prueba técnica para Upgrade Business. Consiste en un sistema de ventas con una arquitectura de n capas. Algunas de estas capas incluyen:

- Capa de Entidades de Negocio.
- Capa de Acceso a Datos.
- Capa de Logica de Negocio
- Capa de Interfaz de Usuario

**Configuración de la Base de Datos:**
La base de datos está hospedada en la nube. Sin embargo, también puedes utilizar una base de datos SQL local cambiando la cadena de conexión en el archivo `BDContexto.cs`. Modifica la conexión en la siguiente sección:

protected override void OnConfiguring(DbContextOptionsBuilder options)
{
    options.UseSqlServer(@"Data Source=BDSysVenta.mssql.somee.com; Initial Catalog=BDSysVenta; User Id=fernandoss_SQLLogin_1; Pwd=snu8c8tzyo");
}

**Ambiente de Desarrollo:**

- Proyecto desarrollado en Visual Studio 2022.
- Utiliza SQL Server Express 2022 y .NET 6.
  <br/>
 **Módulos:**
  <br/>
- Módulo de Clientes.
- Módulo de Productos.
- Módulo de Encabezado de Factura.
- Módulo de Detalle de Factura.
  <br/>
Capturas de Funcionalidad:
<br/>
![sysventas](https://github.com/FernandoDz/SistemaVentas/assets/119868719/fc6960a8-bf16-4391-970a-a9e62de6f349)
 <br/>
![venta](https://github.com/FernandoDz/SistemaVentas/assets/119868719/3dd00fc5-dd52-42ce-82f8-5e6014175f36)
<br/>
 ![encabezado](https://github.com/FernandoDz/SistemaVentas/assets/119868719/81c7f7db-dfcd-4757-8c37-a15abfb8ab02)
 <br/>
 ![detalle](https://github.com/FernandoDz/SistemaVentas/assets/119868719/38e457fe-a2e5-4dc0-81e7-1fa45bba4feb)
