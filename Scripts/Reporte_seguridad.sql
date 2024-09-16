DROP DATABASE  IF EXISTS `colchoneria`;
CREATE DATABASE IF NOT EXISTS `colchoneria`;
USE `colchoneria`;

DROP TABLE IF EXISTS `tbl_modulos`;
CREATE TABLE IF NOT EXISTS `tbl_modulos` (
	pk_id_modulos INT NOT NULL,
    nombre_modulo VARCHAR(50) NOT NULL,
    descripcion_modulo VARCHAR(150) NOT NULL,
    estado_modulo TINYINT DEFAULT 0,
    primary key (`pk_id_modulos`)
);
DROP TABLE IF EXISTS `tbl_aplicaciones`;
CREATE TABLE IF NOT EXISTS `tbl_aplicaciones` (
	pk_id_aplicacion INT NOT NULL AUTO_INCREMENT,
    nombre_aplicacion VARCHAR(50) NOT NULL DEFAULT '0',
    descripcion_aplicacion VARCHAR(150) NOT NULL DEFAULT '0',
    estado_aplicacion TINYINT DEFAULT 0,
	--
	idregistro int NULL,
	ruta varchar(500) NULL,
	nombre_archivo varchar(45) NULL,
	aplicacion varchar(45) NULL,
	estado varchar(45) NULL,
    primary key (`pk_id_aplicacion`)
);
DROP TABLE IF EXISTS `tbl_AsignacionModuloAplicacion`;
CREATE TABLE IF NOT EXISTS `tbl_AsignacionModuloAplicacion` (
  fk_id_modulos INT NOT NULL,
  fk_id_aplicacion INT NOT NULL, 
  PRIMARY KEY (`fk_id_modulos`,`fk_id_aplicacion` ),
  FOREIGN KEY (`fk_id_modulos`) REFERENCES `tbl_modulos` (`pk_id_modulos`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_usuarios`;
CREATE TABLE IF NOT EXISTS `tbl_usuarios` (
  pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  username_usuario VARCHAR(20) NOT NULL,
  password_usuario VARCHAR(100) NOT NULL,
  email_usuario VARCHAR(50) NOT NULL,
  ultima_conexion_usuario DATETIME NULL DEFAULT NULL,
  estado_usuario TINYINT DEFAULT 0 NOT NULL,
  pregunta varchar(50) not null,
  respuesta varchar(50) not null,
  PRIMARY KEY (`pk_id_usuario`)
);

DROP TABLE IF EXISTS `tbl_perfiles`;
CREATE TABLE IF NOT EXISTS `tbl_perfiles` (
	pk_id_perfil INT AUTO_INCREMENT NOT NULL,
    nombre_perfil VARCHAR(50) NOT NULL,
    descripcion_perfil VARCHAR(150) NOT NULL,
    estado_perfil TINYINT DEFAULT 0,
    primary key (pk_id_perfil)
);

DROP TABLE IF EXISTS `tbl_permisosAplicacionesUsuario`;
CREATE TABLE IF NOT EXISTS `tbl_permisosAplicacionesUsuario` (
  fk_id_aplicacion INT NOT NULL, 
  fk_id_usuario INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_permisosAplicacionPerfil`;
CREATE TABLE IF NOT EXISTS `tbl_permisosAplicacionPerfil` (
  fk_id_perfil INT NOT NULL, 
  fk_id_aplicacion INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (`fk_id_perfil`,`fk_id_aplicacion`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_asignacionesPerfilsUsuario`;
CREATE TABLE IF NOT EXISTS `tbl_asignacionesPerfilsUsuario` (
  fk_id_usuario INT NOT NULL, 
  fk_id_perfil INT NOT NULL,
  PRIMARY KEY (`fk_id_usuario`,`fk_id_perfil` ),
  FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_bitacoraDeEventos`;
CREATE TABLE IF NOT EXISTS `tbl_bitacoraDeEventos` (
  pk_id_bitacora INT AUTO_INCREMENT NOT NULL,
  fk_id_usuario INT NOT NULL,
  fk_id_aplicacion INT NOT NULL,
  fecha_bitacora DATE NOT NULL,
  hora_bitacora TIME NOT NULL,
  host_bitacora VARCHAR(45) NOT NULL,
  ip_bitacora VARCHAR(100) NOT NULL,
  accion_bitacora VARCHAR(50) NOT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- vistas ------------------------------------------------------------------------
CREATE 
VIEW `colchoneria`.`vista_aplicacion_perfil` AS 
    SELECT 
        `b`.`fk_id_perfil` AS `ID`,
        `a`.`nombre_perfil` AS `Perfil`,
        `b`.`fk_id_aplicacion` AS `Aplicacion`,
        `b`.`guardar_permiso` AS `Insertar`,
        `b`.`modificar_permiso` AS `Modificar`,
        `b`.`eliminar_permiso` AS `Eliminar`,
        `b`.`buscar_permiso` AS `Buscar`,
        `b`.`imprimir_permiso` AS `Reporte`
    FROM
        (`colchoneria`.`tbl_permisosaplicacionperfil` `b`
        JOIN `colchoneria`.`tbl_perfiles` `a` ON ((`a`.`pk_id_perfil` = `b`.`fk_id_perfil`)));
        
CREATE 
VIEW `colchoneria`.`vista_aplicacionusuario` AS
    SELECT 
        `b`.`fk_id_aplicacion` AS `Aplicacion`,
        `b`.`fk_id_usuario` AS `ID`,
        `a`.`nombre_usuario` AS `Usuario`,
        `b`.`guardar_permiso` AS `Insertar`,
        `b`.`modificar_permiso` AS `Editar`,
        `b`.`eliminar_permiso` AS `Eliminar`,
        `b`.`buscar_permiso` AS `Buscar`,
        `b`.`imprimir_permiso` AS `Reporte`
    FROM
        (`colchoneria`.`tbl_permisosaplicacionesusuario` `b`
        JOIN `colchoneria`.`tbl_usuarios` `a` ON ((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`)));
        
CREATE 
VIEW `colchoneria`.`vista_modulo_aplicacion` AS
    SELECT 
        `b`.`fk_id_modulos` AS `ID`,
        `a`.`nombre_modulo` AS `Modulo`,
        `b`.`fk_id_aplicacion` AS `Aplicacion`,
        `c`.`nombre_aplicacion` AS `Nombre`,
        `c`.`descripcion_aplicacion` AS `Descripcion`
    FROM
        ((`colchoneria`.`tbl_asignacionmoduloaplicacion` `b`
        JOIN `colchoneria`.`tbl_modulos` `a` ON ((`a`.`pk_id_modulos` = `b`.`fk_id_modulos`)))
        JOIN `colchoneria`.`tbl_aplicaciones` `c` ON ((`c`.`pk_id_aplicacion` = `b`.`fk_id_aplicacion`)));
        
CREATE 
VIEW `colchoneria`.`vista_perfil_usuario` AS
    SELECT 
        `b`.`fk_id_usuario` AS `ID`,
        `a`.`nombre_usuario` AS `Usuario`,
        `a`.`username_usuario` AS `nickName`,
        `b`.`fk_id_perfil` AS `perfil`,
        `c`.`nombre_perfil` AS `Nombre`
    FROM
        ((`colchoneria`.`tbl_asignacionesperfilsusuario` `b`
        JOIN `colchoneria`.`tbl_usuarios` `a` ON ((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`)))
        JOIN `colchoneria`.`tbl_perfiles` `c` ON ((`c`.`pk_id_perfil` = `b`.`fk_id_perfil`)));

-- -------- Inserción de datos a las tablas -------------

INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'LOGISTICA', 'Logistica', 1),
('3000', 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
('5000', 'PRODUCCIÓN', 'Produccion', 1),
('6000', 'NOMINAS', 'Nominas', 1),
('7000', 'BANCOS', 'Bancos', 1),
('8000', 'CONTABILIDAD', 'Contabilidad', 1);

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` (pk_id_aplicacion, nombre_aplicacion, descripcion_aplicacion, estado_aplicacion) VALUES
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1'),
('2000', 'MDI LOGISTICA', 'PARA LOGISTICA', '1'),
('2001', 'Marca', 'Catalogos','1'),
(2002, 'Linea', 'Catalogos','1'),
(2003, 'Bodega', 'Catalogos','1'),
(2004, 'Productos', 'Catalogos','1'),
(2005, 'Transporte', 'Catalogos','1'),
(2006, 'Ruta', 'Catalogos','1'),
(2007, 'Conductor', 'Catalogos','1'),
(2101, 'Existencia Bodega', 'Procesos','1'),
(2102, 'Lotes', 'Procesos','1'),
(2103, 'Envios', 'Procesos','1'),
(2201, 'Movimientos', 'Procesos','1'),
(2202, 'Inventarios', 'Procesos','1'),
(2301, 'Seguridad', 'Seguridad','1'),
(2401, 'Informacion', 'Ayuda','1'),
('3000', 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', '1'),
(3001, 'Compras  Cliente', 'Mantenimiento','1'),
(3002, 'Compras Proveedores', 'Mantenimiento','1'),
(3003, 'Compras Vendedor', 'Mantenimiento','1'),
(3102, 'Compras precios', 'Asignaciones','1'),
(3103, 'Compras caja cliente', 'Asignaciones','1'),
(3104, 'Compras caja proveedor', 'Asignaciones','1'),
(3105, 'Compras cotizaciones', 'Asignaciones','1'),
(3106, 'Compras cotizaciones #2', 'Asignaciones','1'),
(3107, 'Compras Facturas Clientes', 'Asignaciones','1'),
(3108, 'Compras Facturas proveedores', 'Asignaciones','1'),
(3109, 'Compras orden compra', 'Asignaciones','1'),
(3110, 'Compras compras', 'Asignaciones','1'),
(3111, 'Compras enlace Contabilidad', 'Asignaciones','1'),
(3202, 'Compras reportes', 'Asignaciones','1'),
(3203, 'Compras Balance Antiguedad', 'Asignaciones','1'),
(3204, 'Compras movimiento clientes', 'Asignaciones','1'),
(3205, 'Compras movimiento proveedor', 'Asignaciones','1'),
(3302, 'Compras Seguridad', 'Asignaciones','1'),
(3402, 'Compras ayuda', 'Asignaciones','1'),
('5000', 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', '1'),
(5001, 'Receta', 'Proceso','1'),
(5002, 'Agregar Receta', 'Proceso','1'),
(5003, 'Ordenes', 'Proceso','1'),
(5004, 'Agregar Orden', 'Proceso','1'),
(5005, 'Proceso de Produccion', 'Proceso','1'),
(5006, 'Proceso de Produccion', 'Proceso','1'),
(5101, 'Ver Recetas', 'Mantenimientos','1'),
(5102, 'Ver Ordenes', 'Mantenimientos','1'),
(5103, 'Proceso de Producción', 'Mantenimientos','1'),
(5104, 'Ver Recetas', 'Mantenimientos','1'),
(5301, 'Seguridad', 'Seguridad','1'),
(5302, 'Seguridad', 'Seguridad','1'),
(5303, 'Seguridad', 'Seguridad','1'),
(5304, 'Seguridad', 'Seguridad','1'),
(5401, 'Seguridad', 'Seguridad','1'),
('6000', 'MDI NOMINAS', 'PARA NOMINAS', '1'),
('6001', 'Mant. Trabajadores', 'PARA NOMINAS', '1'),
('6002', 'Mant. Puestos de Trabajo', 'PARA NOMINAS', '1'),
('6003', 'Mant. Departamentos', 'PARA NOMINAS', '1'),
('6004', 'Mant. Contratos', 'PARA NOMINAS', '1'),
('6005', 'Mant. Percepciones', 'PARA NOMINAS', '1'),
('6006', 'Mant. Horas Extras', 'PARA NOMINAS', '1'),
('6007', 'Mant. Faltas', 'PARA NOMINAS', '1'),
('6008', 'Nominas Control Faltas', 'Mantenimiento','1'),
('6101', 'Asgn. Puesto - Depto.', 'PARA NOMINAS', '1'),
('6102', 'Asgn. Puesto - Trabajador', 'PARA NOMINAS', '1'),
('6103', 'Asgn. Contrato Trabajador', 'PARA NOMINAS', '1'),
('6104', 'Asgn. Prestaciones Contrato', 'PARA NOMINAS', '1'),
('6105', 'Asgn. Prestaciones Individual', 'PARA NOMINAS', '1'),
('6106', 'Prcs. Nomina', 'PARA NOMINAS', '1'),
('6201', 'Rpt. Planillas', 'PARA NOMINAS', '1'),
('6202', 'Rpt. Contratos', 'PARA NOMINAS', '1'),
('6203', 'Rpt. Trabajadores', 'PARA NOMINAS', '1'),
('6301', 'ACCESO SEGURIDAD', 'PARA NOMINAS', '1'),
('6401', 'Nominas Ayuda', 'Ayuda Nominas','1'),
('7000', 'MDI BANCOS', 'PARA BANCOS', '1'),
('7101', 'Bancos Cheques', 'Mantenimientos','1'),
('8000', 'MDI CONTABILIDAD', 'PARA CONTRABILIDAD', '1');

-- -----USUARIOS
INSERT INTO `tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '2022-07-02 21:00:48', '1', 'COLOR FAVORITO', 'ROJO'),
('2', 'Logistica', 'Logistica', 'logisticas', 'X9yc1/l1b2A==', 'logistica@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('3', 'Compras', 'Compras', 'compras', 'X9yc1/l1b2A==', 'compras@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('4', 'Produccion', 'Produccion', 'produccion', 'X9yc1/l1b2A==', 'produccion@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('5', 'Nominas', 'Nominas', 'nominas', 'X9yc1/l1b2A==', 'nominas@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('6', 'Bancos', 'Bancos', 'bancos', 'X9yc1/l1b2A==', 'bancos@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('7', 'Contabilidad', 'Contabilidad', 'contabilidad', 'X9yc1/l1b2A==', 'contabilidad@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('8', 'Auditoria', 'Auditoria', 'auditoria', 'X9yc1/l1b2A==', 'auditoria@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('9', 'Seguridad', 'Seguridad', 'seguridad', 'X9yc1/l1b2A==', 'seguridad@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM=');

-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
('3', 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
('4', 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
('5', 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
('6', 'NOMINAS', 'contiene todos los permisos de nominas', 1),
('7', 'BANCOS', 'contiene todos los permisos de bancos', 1),
('8', 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1),
('9', 'Seguridad', 'Todo Seguridad', '1');

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301'),
('2000', '2000'),
('3000', '3000'),
('5000', '5000'),
('6000', '6000'),
('6000', '6001'),
('6000', '6002'),
('6000', '6003'),
('6000', '6004'),
('6000', '6005'),
('6000', '6006'),
('6000', '6007'),
('6000', '6101'),
('6000', '6102'),
('6000', '6103'),
('6000', '6104'),
('6000', '6105'),
('6000', '6106'),
('6000', '6201'),
('6000', '6202'),
('6000', '6203'),
('6000', '6301'),
('7000', '7000'),
('8000', '8000');

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
(1, '1000','1','1','1','1','1'),(1, '1001','1','1','1','1','1'),(1, '1002','1','1','1','1','1'),
(1, '1003','1','1','1','1','1'),(1, '1004','1','1','1','1','1'),(1, '1101','1','1','1','1','1'),
(1, '1102','1','1','1','1','1'),(1, '1103','1','1','1','1','1'),(1, '1201','1','1','1','1','1'),
(1, '1301','1','1','1','1','1'),(1, '2000','1','1','1','1','1'),(1, '2001','1','1','1','1','1'),
(1, '2002','1','1','1','1','1'),(1, '2003','1','1','1','1','1'),(1, '3000','1','1','1','1','1'),
(1, '5000','1','1','1','1','1'),(1, '6000','1','1','1','1','1'),(1, '7000','1','1','1','1','1'),
(1, '8000','1','1','1','1','1'),
(2, '2000','1','1','1','1','1'),(2, '2001','1','1','1','1','1'),(2, '2002','1','1','1','1','1'),
(2, '2003','1','1','1','1','1'),(2, '2004','1','1','1','1','1'),(2, '2005','1','1','1','1','1'),
(2, '2006','1','1','1','1','1'),(2, '2007','1','1','1','1','1'),(2, '2101','1','1','1','1','1'),
(2, '2102','1','1','1','1','1'),(2, '2103','1','1','1','1','1'),(2, '2201','1','1','1','1','1'),
(2, '2202','1','1','1','1','1'),(2, '2301','1','1','1','1','1'),(2, '2401','1','1','1','1','1'),
(3, '3000','1','1','1','1','1'),(3, '3001','1','1','1','1','1'),(3, '3002','1','1','1','1','1'),
(3, '3003','1','1','1','1','1'),
(4, '5000','1','1','1','1','1'),('4', '5001', '1', '1', '1', '1', '1'),('4', '5002', '1', '1', '1', '1', '1'),
(4, '5101', '1','1','1','1','1'),('4', '5003', '1', '1', '1', '1', '1'),('4', '5004', '1', '1', '1', '1', '1'),
(4, '5102', '1','1','1','1','1'),('4', '5005', '1', '1', '1', '1', '1'),('4', '5006', '1', '1', '1', '1', '1'),
(4, '5103', '1','1','1','1','1'),('4', '5301', '1', '1', '1', '1', '1'),('4', '5302', '1', '1', '1', '1', '1'),
(4, '5303', '1','1','1','1','1'),('4', '5304', '1', '1', '1', '1', '1'),('4', '5401', '1', '1', '1', '1', '1'),
(5, '6000','1','1','1','1','1'),(5, '6001','1','1','1','1','1'),(5, '6002','1','1','1','1','1'),
(5, '6003','1','1','1','1','1'),(5, '6005','1','1','1','1','1'),(5, '6006','1','1','1','1','1'),
(5, '6007','1','1','1','1','1'),(5, '6008','1','1','1','1','1'),(5, '6101','1','1','1','1','1'),
(5, '6102','1','1','1','1','1'),(5, '6103','1','1','1','1','1'),(5, '6104','1','1','1','1','1'),
(5, '6105','1','1','1','1','1'),(5, '6106','1','1','1','1','1'),(5, '6201','1','1','1','1','1'),
(5, '6202','1','1','1','1','1'),(5, '6203','1','1','1','1','1'),(5, '6301','1','1','1','1','1'),
(5, '6401','1','1','1','1','1'),
(6, '7000','1','1','1','1','1'),(6, '7101','1','1','1','1','1'),
(7, '8000','1','1','1','1','1'),
(9, '1000','1','1','1','1','1'),(9, '1001','1','1','1','1','1'),(9, '1002','1','1','1','1','1'),
(9, '1003','1','1','1','1','1'),(9, '1004','1','1','1','1','1'),(9, '1101','1','1','1','1','1'),
(9, '1102','1','1','1','1','1'),(9, '1103','1','1','1','1','1'),(9, '1201','1','1','1','1','1'),
(9, '1301','1','1','1','1','1');

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1'),('2', '2'),('3', '3'),('4', '4'),
('5', '5'),('6', '6'),('7', '7'),('8', '8'),
('9', '9');
        