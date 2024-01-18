create database ExampleBD;
go

use ExampleBD;
/*CREACION DE TABLA CLIENTE*/
CREATE TABLE Cliente (
    ClienteId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(MAX) NOT NULL,
    Apellido NVARCHAR(MAX) NOT NULL,
    Telefono INT,
    Direccion NVARCHAR(MAX) NOT NULL
);
/*CREACION DE TABLA PRODUCTO*/
CREATE TABLE Producto
(
    Codigo NVARCHAR(50) PRIMARY KEY,
    Descripcion NVARCHAR(MAX) NOT NULL,
    Precio DECIMAL(18,2) NOT NULL,
    Cantidad INT NOT NULL
);
/*CREACION DE TABLA ENCABEZADO DE FACTURA*/
CREATE TABLE EncabezadoFactura
(
    EncabezadoFacturaId INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATETIME NOT NULL,
    ClienteId INT FOREIGN KEY REFERENCES Clientes(ClienteId),
    Total DECIMAL(18, 2) NOT NULL,
    CONSTRAINT FK_Cliente_EncabezadoFactura FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId)
);
/*CREACION DE TABLA DETALLE DE FACTURA*/
CREATE TABLE DetalleFactura
(
    DetalleFacturaId INT PRIMARY KEY IDENTITY(1,1),
    EncabezadoFacturaId INT FOREIGN KEY REFERENCES EncabezadoFactura(EncabezadoFacturaId),
    ProductoCodigo NVARCHAR(50) FOREIGN KEY REFERENCES Producto(Codigo),
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    Subtotal DECIMAL(18, 2) NOT NULL,
    CONSTRAINT FK_EncabezadoFactura_DetalleFactura FOREIGN KEY (EncabezadoFacturaId) REFERENCES EncabezadoFactura(EncabezadoFacturaId),
    CONSTRAINT FK_Producto_DetalleFactura FOREIGN KEY (ProductoCodigo) REFERENCES Producto(Codigo)
);

/*INSERCION DE DATOS*/
INSERT INTO Cliente(Nombre,Apellido,Telefono,Direccion ) VALUES('Juan','Jose',78892212,'Sonsonate');
INSERT INTO Producto(Codigo,Descripcion,Precio,Cantidad)VALUES('00001M','fruta en lata',15.00,1);