
CREATE DATABASE IF NOT EXISTS ProductsDB;

-- Usar la base de datos 'MiBaseDeDatos'
USE ProductsDB;

-- Crear una tabla 'Productos'
CREATE TABLE IF NOT EXISTS Products (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    PName VARCHAR(255) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);

-- Insertar algunos productos de ejemplo
INSERT INTO Products (PName, Price) VALUES ('Producto 1', 10.00);
INSERT INTO Products (PName, Price) VALUES ('Producto 2', 20.00);
INSERT INTO Products (PName, Price) VALUES ('Producto 3', 15.50);
