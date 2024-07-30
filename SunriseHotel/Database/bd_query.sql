CREATE DATABASE db_sys_hotel
Go

USE db_sys_hotel
GO


CREATE TABLE usuarios (
  id_usuario int PRIMARY KEY IDENTITY(1,1),
  nombre varchar(50) NOT NULL,
  apellido varchar(50) NOT NULL,
  email varchar(150) NOT NULL,
  telefono varchar(20) NOT NULL, -- +1 (999) 999-9999
  clave varchar(50) NOT NULL
);
GO

-- Insertar tres usuarios
INSERT INTO usuarios (nombre, apellido, email, telefono, clave)
VALUES
('Juan', 'Pérez', 'juan.perez@example.com', '+1 (555) 123-4567', 'clave123'),
('María', 'González', 'maria.gonzalez@example.com', '+1 (555) 234-5678', 'clave456'),
('Carlos', 'Ramírez', 'carlos.ramirez@example.com', '+1 (555) 345-6789', 'clave789');
GO


SELECT * FROM usuarios WHERE nombre LIKE 'María';
GO

DELETE FROM usuarios WHERE id_usuario = 7;
Go

SELECT * FROM usuarios
GO

CREATE TABLE habitacion (
  id_habitacion int PRIMARY KEY IDENTITY(1,1),
  hab_nombre varchar(50) NOT NULL,
  hab_tipo int  NULL,
  hab_precio float NULL,
  hab_status varchar(50) NULL
);
GO

SELECT * FROM habitacion
GO

CREATE TABLE tipo_habitacion (
  id_tipo_habitacion int PRIMARY KEY IDENTITY(1,1),
  tipo_nombre varchar(50) NOT NULL,
  tipo_descripcion varchar(250) NULL,
);
GO

SELECT * FROM tipo_habitacion
GO

--Estándar: con dos camas individuales o una doble.
--Ejecutiva: con dos camas individuales o una cama matrimonial.
--Familiar: con capacidad para dos niños y dos adultos.
--Triple: para tres personas.
--Cuádruple: para cuatro personas.
--Suite: dos o más habitaciones, al menos un dormitorio y una sala de estar.

CREATE TABLE clientes(
  id_cliente int PRIMARY KEY IDENTITY(1,1),
  nombre varchar(50) NOT NULL,
  apellido varchar(50) NOT NULL,
  email varchar(150) NOT NULL,
  telefono varchar(20) NOT NULL
);
GO

SELECT * FROM clientes
GO

CREATE TABLE reservaciones (
  id_reservacion int PRIMARY KEY IDENTITY(1,1),
  id_habitacion int NOT NULL,
  id_cliente int NOT NULL,
  fecha_entrada date NOT NULL,
  fecha_salida date NOT NULL,
  estatus varchar(50) NOT NULL,
  dias int NOT NULL,
  precio float NULL,
  cantidad float NULL,
  recibido float NULL,
  cambiar float NULL
);
GO

SELECT * FROM reservaciones
GO

SELECT r.id_reservacion, r.id_cliente, c.nombre, r.id_habitacion, h.hab_nombre, r.fecha_entrada,
r.fecha_salida, r.estatus, r.dias, r.precio, r.cantidad, r.recibido, r.cambiar
FROM reservaciones r
INNER JOIN clientes c ON c.id_cliente = r.id_cliente
INNER JOIN habitacion h ON h.id_habitacion = r.id_habitacion
Go