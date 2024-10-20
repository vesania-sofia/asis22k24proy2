CREATE DATABASE BancoDB;
USE BancoDB;

-- Tabla: btl_banco
CREATE TABLE btl_banco (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL
);

-- Tabla: btl_cliente
CREATE TABLE btl_cliente (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    direccion VARCHAR(200) NOT NULL
);

-- Tabla: btl_cuentabancaria
CREATE TABLE btl_cuentabancaria (
    id INT AUTO_INCREMENT PRIMARY KEY,
    banco_id INT NOT NULL,
    numerocuenta VARCHAR(20) UNIQUE NOT NULL,
    saldo DECIMAL(10,2) NOT NULL,
    tipocuenta VARCHAR(50) NOT NULL,
    cliente_id INT NOT NULL,
    CONSTRAINT fk_banco FOREIGN KEY (banco_id) REFERENCES btl_banco(id),
    CONSTRAINT fk_cliente FOREIGN KEY (cliente_id) REFERENCES btl_cliente(id)
);

-- Tabla: btl_movimientobancario
CREATE TABLE btl_movimientobancario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    no_cuenta INT NOT NULL,
    fecha_movimiento DATE NOT NULL,
    tipo_movimiento VARCHAR(50) NOT NULL,
    monto DECIMAL(10,2) NOT NULL,
    descripcion TEXT,
    metodo_pago VARCHAR(50),
    estado VARCHAR(50),
    CONSTRAINT fk_cuenta FOREIGN KEY (no_cuenta) REFERENCES btl_cuentabancaria(id)
);

-- Tabla: btl_transaccion
CREATE TABLE btl_transaccion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    cuenta_id INT NOT NULL,
    fecha DATETIME NOT NULL,
    monto DECIMAL(10,2) NOT NULL,
    tipo_transaccion VARCHAR(50) NOT NULL,
    CONSTRAINT fk_cuenta_transaccion FOREIGN KEY (cuenta_id) REFERENCES btl_cuentabancaria(id)
);

