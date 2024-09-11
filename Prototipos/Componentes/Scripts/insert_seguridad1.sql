use seguridad;
/*drop database seguridad;*/
Select * from tbl_usuarios;

/*Insert Funcionanmieto Principal  */
INSERT INTO `tbl_usuarios` VALUES 
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('2', 'Logistica', 'Logistica', 'logisticas', 'X9yc1/l1b2A==', 'logistica@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('3', 'Compras', 'Compras', 'compras', 'X9yc1/l1b2A==', 'compras@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('4', 'Produccion', 'Produccion', 'produccion', 'X9yc1/l1b2A==', 'produccion@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('5', 'Nominas', 'Nominas', 'nominas', 'X9yc1/l1b2A==', 'nominas@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('6', 'Bancos', 'Bancos', 'bancos', 'X9yc1/l1b2A==', 'bancos@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('7', 'Contabilidad', 'Contabilidad', 'contabilidad', 'X9yc1/l1b2A==', 'contabilidad@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('8', 'Auditoria', 'Auditoria', 'auditoria', 'X9yc1/l1b2A==', 'auditoria@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('9', 'Seguridad', 'Seguridad', 'seguridad', 'X9yc1/l1b2A==', 'seguridad@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM=');

INSERT INTO `tbl_perfiles` VALUES 
('1', 'ADMINISTRADOR', 'Contiene todos los perfiles', '1'),
('2', 'Logistica', 'Todo Logisitca', '1'),
('3', 'Compras', 'Todo Compras', '1'),
('4', 'Produccion', 'Todo Produccion', '1'),
('5', 'Nominas', 'Todo Nominas', '1'),
('6', 'Bancos', 'Todo Bancos', '1'),
('7', 'Contabilidad', 'Todo Contabilidad', '1'),
('8', 'Auditoria', 'Todo Auditoria', '1'),
('9', 'Seguridad', 'Todo Seguridad', '1');


INSERT INTO `tbl_asignacionesperfilsusuario` VALUES 
('1', '1'),('2', '2'),('3', '3'),('4', '4'),
('5', '5'),('6', '6'),('7', '7'),('8', '8'),
('9', '9');


INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1000, 'MDI SEGURO', 'PARA Principal','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1001, 'Usuarios', 'Mantimientos Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1002, 'Aplicaciones', 'Mantenimientos Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1003, 'Modulos', 'Mantenimientos Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1004, 'Perfiles', 'Mantenimientos Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1101, 'Modulo Aplicaciones', 'Asignaciones Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1102, 'Aplicaciones Perfil', 'Asignaciones Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1103, 'Perfiles Usuarios', 'Asignaciones Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1201, 'Cambiar Contraseña', 'Asignaciones Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (1301, 'Bitacora', 'Asignaciones Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2000, 'MDI LOGISTICA', 'Para Logisitca','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2001, 'Marca', 'Catalogos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2002, 'Linea', 'Catalogos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2003, 'Bodega', 'Catalogos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2004, 'Productos', 'Catalogos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2005, 'Transporte', 'Catalogos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2006, 'Ruta', 'Catalogos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2007, 'Conductor', 'Catalogos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2101, 'Existencia Bodega', 'Procesos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2102, 'Lotes', 'Procesos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2103, 'Envios', 'Procesos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2201, 'Movimientos', 'Procesos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2202, 'Inventarios', 'Procesos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2301, 'Seguridad', 'Seguridad','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (2401, 'Informacion', 'Ayuda','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3000, 'MDI Compras y Ventas', 'Ayuda','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3001, 'Compras  Cliente', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3002, 'Compras Proveedores', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3003, 'Compras Vendedor', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3102, 'Compras precios', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3103, 'Compras caja cliente', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3104, 'Compras caja proveedor', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3105, 'Compras cotizaciones', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3106, 'Compras cotizaciones #2', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3107, 'Compras Facturas Clientes', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3108, 'Compras Facturas proveedores', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3109, 'Compras orden compra', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3110, 'Compras compras', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3111, 'Compras enlace Contabilidad', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3202, 'Compras reportes', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3203, 'Compras Balance Antiguedad', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3204, 'Compras movimiento clientes', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3205, 'Compras movimiento proveedor', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3302, 'Compras Seguridad', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (3402, 'Compras ayuda', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (5000, 'MDI PRODUCCION', 'Para Producción','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (6000, 'MDI NOMINAS', 'Para Nominas','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (6001, 'Nominas Catalagos', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (6002, 'Nominas Departamento', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (6003, 'Nominas Puestos de Trabajo', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (6004, 'Nominas Contratos', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (6005, 'Nominas Prestaciones Deducciones', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES (6006, 'Nominas Trabajadores', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6007, 'Nominas Horas Extra', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6008, 'Nominas Control Faltas', 'Mantenimiento','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6101, 'Nominas Procesos', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6102, 'Nominas Puestos Trabajo', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6103, 'Nominas Contrato Trabajador', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6104, 'Nominas Contrato Prestaciones', 'Asignaciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6105, 'Nominas Nominas', 'Persepciones & Deducciones','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6106, 'Nominas Nominas', 'Asignaciones Nominas','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6201, 'Nominas Planillas', 'Reportes Nominas','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6202, 'Nominas Contratos', 'Reportes Nominas','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6203, 'Nominas Bajas', 'Reportes Nominas','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6301, 'Nominas Bitacora', 'Seguridad Nominas','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(6401, 'Nominas Ayuda', 'Ayuda Nominas','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(7000, 'MDI BANCOS', 'Para Bancos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(7101, 'Bancos Cheques', 'Mantenimientos','1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES(8000, 'MDI CONTABILIDAD', 'Para Contabilidad','1');