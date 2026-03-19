IF EXISTS (SELECT name FROM sys.databases WHERE name = 'BD_libreria_utiles')
BEGIN
DROP DATABASE BD_libreria_utiles;
END

CREATE DATABASE BD_libreria_utiles;
USE BD_libreria_utiles;
GO


CREATE TABLE roles_usuarios
(
    id_rol_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre_rol VARCHAR(50) NOT NULL
);

INSERT INTO roles_usuarios (nombre_rol) VALUES
('Administrador'),
('Cliente');

CREATE TABLE usuarios
(
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(20),
    direccion VARCHAR(200),
    usuario VARCHAR(50) UNIQUE NOT NULL,
    clave VARCHAR(255) NOT NULL,
    id_rol_usuario INT NOT NULL,
    FOREIGN KEY (id_rol_usuario)
    REFERENCES roles_usuarios(id_rol_usuario)
);

CREATE TABLE colores
(
    id_color INT PRIMARY KEY IDENTITY(1,1),
    nombre_color VARCHAR(50) NOT NULL
);

CREATE TABLE marcas
(
    id_marca INT PRIMARY KEY IDENTITY(1,1),
    nombre_marca VARCHAR(100) NOT NULL
);


CREATE TABLE categorias
(
    id_categoria INT PRIMARY KEY IDENTITY(1,1),
    nombre_categoria VARCHAR(100) NOT NULL
);


CREATE TABLE productos
(
    id_producto INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(200),
    precio DECIMAL(10,2) NOT NULL,
    existencia INT NOT NULL,
    id_color INT NOT NULL,
    id_marca INT NOT NULL,
    id_categoria INT NOT NULL,
    imagen VARCHAR(355),
    FOREIGN KEY (id_color) REFERENCES colores(id_color),
    FOREIGN KEY (id_marca) REFERENCES marcas(id_marca),
    FOREIGN KEY (id_categoria) REFERENCES categorias(id_categoria)
);


CREATE TABLE ventas
(
    id_venta INT PRIMARY KEY IDENTITY(1,1),
    fecha DATETIME DEFAULT GETDATE(),
    id_usuario INT NOT NULL, -- cliente
    total DECIMAL(10,2) NOT NULL,
    estado VARCHAR(50) DEFAULT 'Pendiente',
    metodo_pago VARCHAR(50) DEFAULT 'Efectivo',
    FOREIGN KEY (id_usuario)
    REFERENCES usuarios(id_usuario)
);


CREATE TABLE detalle_ventas
(
    id_detalle_venta INT PRIMARY KEY IDENTITY(1,1),
    id_venta INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal AS (cantidad * precio_unitario) PERSISTED,
    FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
	FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
);
