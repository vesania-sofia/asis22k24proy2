INSERT INTO `tbl_permisosaplicacionperfil` VALUES 
(1, '1000','1','1','1','1','1'),(1, '1001','1','1','1','1','1'),(1, '1002','1','1','1','1','1'),
(1, '1003','1','1','1','1','1'),(1, '1004','1','1','1','1','1'),(1, '1101','1','1','1','1','1'),
(1, '1102','1','1','1','1','1'),(1, '1103','1','1','1','1','1'),(1, '1201','1','1','1','1','1'),
(1, '1301','1','1','1','1','1'),(1, '2000','1','1','1','1','1'),(1, '2001','1','1','1','1','1'),
(1, '2002','1','1','1','1','1'),(1, '2003','1','1','1','1','1'),(1, '3000','1','1','1','1','1'),
(1, '5000','1','1','1','1','1'),(1, '6000','1','1','1','1','1'),(1, '7000','1','1','1','1','1'),
(1, '8000','1','1','1','1','1'),
(2, '2000','1','1','1','1','1'),(2, '2001','1','1','1','1','1'),(2, '2002','1','1','1','1','1'),
(2, '2003','1','1','1','1','1'),(2, '2004','1','1','1','1','1'),(2, '2005','1','1','1','1','1'),
(2, '2006','1','1','1','1','1'),(2, '2005','1','1','1','1','1'),(2, '2007','1','1','1','1','1'),
(2, '2101','1','1','1','1','1'),(2, '2102','1','1','1','1','1'),(2, '2103','1','1','1','1','1'),
(2, '2201','1','1','1','1','1'),(2, '2202','1','1','1','1','1'),(2, '2301','1','1','1','1','1'),
(2, '2401','1','1','1','1','1'),
(3, '3000','1','1','1','1','1'),(3, '3001','1','1','1','1','1'),(3, '3002','1','1','1','1','1'),
(3, '3002','1','1','1','1','1'),
(4, '5000','1','1','1','1','1'),
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

/*Produccion*/
INSERT INTO `tbl_aplicaciones` VALUES 
(5001, 'Receta', 'Proceso','1'),
(5002, 'Agregar Receta', 'Proceso','1'),
(5003, 'Ordenes', 'Proceso','1'),
(5004, 'Agregar Orden', 'Proceso','1'),
(5005, 'Proceso de Produccion', 'Proceso','1'),
(5006, 'Proceso de Produccion', 'Proceso','1'),
(5101, 'Ver Recetas', 'Mantenimientos','1'),
(5102, 'Ver Ordenes', 'Mantenimientos','1'),
(5103, 'Proceso de Producción', 'Mantenimientos','1'),
(5101, 'Ver Recetas', 'Mantenimientos','1'),
(5301, 'Seguridad', 'Seguridad','1'),
(5302, 'Seguridad', 'Seguridad','1'),
(5303, 'Seguridad', 'Seguridad','1'),
(5304, 'Seguridad', 'Seguridad','1'),
(5401, 'Seguridad', 'Seguridad','1');

INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5001', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5002', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5101', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5003', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5004', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5102', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5005', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5006', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5103', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5301', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5302', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5303', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5304', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('4', '5401', '1', '1', '1', '1', '1');


/*Contabilidad */
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8001', 'Catalogos', 'Mantenimientos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8002', 'Catalogos', 'Mantenimientos Clases Cuentas', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8003', 'Catalogos', 'Mantenimiento Poliza Contable', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8004', 'Catalogos', 'Mantenimientos Tipo Cuenta', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8005', 'Catalogos', 'Mantenimientos Activos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8006', 'Catalogos', 'Mantenimientos Estado Financiero', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8007', 'Catalogos', 'Mantenimientos Estado Financiero', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8008', 'Catalogos', 'Pendiente', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8009', 'Catalogos', 'Pendiente', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8010', 'Catalogos', 'Pendiente', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8030', 'Procesos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8031', 'Procesos', 'Proceso', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8032', 'Procesos', 'Proceso', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8033', 'Procesos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8034', 'procesos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8035', 'Procesos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8036', 'Procesos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8037', 'Procesos ', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8038', 'Procesos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8039', 'Procesos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8401', 'Reportes', 'Reporte', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8301', 'Seguridad', 'Seguridad', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('8402', 'Ayuda', 'Ayuda', '1');

INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8001', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8002', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8003', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8004', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8005', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8006', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8007', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8008', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8009', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8010', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8030', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8031', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8032', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8033', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8034', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8035', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8036', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8037', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8038', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8401', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8301', '1', '1', '1', '1', '1');
INSERT INTO `seguridad`.`tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES ('7', '8402', '1', '1', '1', '1', '1');


INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7002', 'Banc Cuentas Bancarias', 'Mantenimientos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7003', 'Bac Moneda ', 'Mantenimientos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7004', 'Bac Concepto Bancario', 'Mantenimientos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7101', 'Bac Cheques', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7102', 'Bac Depositos', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7103', 'Bac Disponibilidad', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7104', 'Bac Movimientos Bancarios', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7105', 'Bac Bitacora', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7106', 'Bac Concilacion Bancaria', 'Procesos', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7201', 'Bac Polizas', 'Partidas Contables', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7202', 'Bac Ingresos & Egresos', 'Partidas Contables', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7203', 'Bac Ordenes de Compra', 'Partidas Contables', '1');
INSERT INTO `seguridad`.`tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES ('7300', 'Bac Reportes Bancos', 'Reportes', '1');
