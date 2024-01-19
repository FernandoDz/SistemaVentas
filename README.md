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

![sistemaventas](https://github.com/FernandoDz/SistemaVentas/assets/119868719/f16caa0a-202f-4e60-9b83-5e65b9bd57e1)

![venta](https://github.com/FernandoDz/SistemaVentas/assets/119868719/a638a98b-b5cf-44df-b934-05078f1d362a)

![encabezado](https://github.com/FernandoDz/SistemaVentas/assets/119868719/9c205280-4b3f-4367-8362-dc0457b174a5)

![detalle](https://github.com/FernandoDz/SistemaVentas/assets/119868719/61d39bfc-25bd-4db4-95c3-80b0c17de06a)

