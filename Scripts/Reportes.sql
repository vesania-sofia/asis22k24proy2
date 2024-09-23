DROP DATABASE colchoneria;
CREATE DATABASE colchoneria;
use colchoneria;
-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-09-2024 a las 09:00:00
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `controlempleados`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `cambiarContraModulo` (IN `p_usuario` INT, IN `p_nueva_contrasenia` VARCHAR(100))   BEGIN
    -- Actualizar la contraseña del usuario
    UPDATE tbl_usuarios
    SET password_usuario = p_nueva_contrasenia
    WHERE pk_id_usuario = p_usuario;

    -- Confirmar que el cambio se realizó
    IF ROW_COUNT() > 0 THEN
        SELECT 'Contraseña actualizada con éxito' AS resultado;
    ELSE
        SELECT 'Usuario no encontrado' AS resultado;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cambiarContrasenia` (IN `usuario` VARCHAR(255), IN `nuevaContrasenia` VARCHAR(255), IN `respuestaSeguridad` VARCHAR(255))   BEGIN
    DECLARE respuestaGuardada VARCHAR(255);
    DECLARE usuarioExiste INT;

    -- Verificar si el usuario existe
    SELECT COUNT(*) INTO usuarioExiste 
    FROM tbl_usuarios 
    WHERE username_usuario = usuario;

    IF usuarioExiste = 0 THEN
        -- Si el usuario no existe, devolver mensaje de error
        SELECT 'Usuario no encontrado' AS resultado;
    ELSE
        -- Obtener la respuesta de seguridad desde la base de datos
        SELECT respuesta INTO respuestaGuardada 
        FROM tbl_usuarios 
        WHERE username_usuario = usuario;

        -- Verificar si la respuesta ingresada coincide con la guardada
        IF LOWER(respuestaGuardada) = LOWER(respuestaSeguridad) THEN
            -- Actualizar la contraseña
            UPDATE tbl_usuarios
            SET password_usuario = nuevaContrasenia
            WHERE username_usuario = usuario;
            
            -- Devolver el resultado exitoso
            SELECT 'Contraseña actualizada con éxito' AS resultado;
        ELSE
            -- Devolver resultado si la respuesta de seguridad es incorrecta
            SELECT 'Respuesta de seguridad incorrecta' AS resultado;
        END IF;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cambioContrasenia` (IN `p_usuario` VARCHAR(20))   BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN        
        SELECT 'Usuario encontrado' AS resu;
    ELSE
        SELECT 'Usuario no encontrado' AS resu;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin` (IN `p_usuario` VARCHAR(20), IN `p_clave` VARCHAR(100))   BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario AND password_usuario = p_clave;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN
        UPDATE tbl_usuarios
        SET ultima_conexion_usuario = NOW()
        WHERE username_usuario = p_usuario AND password_usuario = p_clave;
        
        SELECT 'Inicio de sesión exitoso' AS resultado;
    ELSE
        SELECT 'Inicio de sesión fallido' AS resultado;
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ayuda`
--

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` varchar(255) DEFAULT NULL,
  `indice` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`, `estado`) VALUES
(1, 'C:/Users/bhern/source/repos/ejecucion/ejecucion/AyudaHTML/AyudaNavegador.chm', 'AyudaNav.html', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `casas`
--

CREATE TABLE `casas` (
  `id_casa` int(11) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `telefono` int(11) NOT NULL,
  `ciudad` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `casas`
--

INSERT INTO `casas` (`id_casa`, `direccion`, `telefono`, `ciudad`, `estado`) VALUES
(1, 'direccion', 12345678, 'ciudad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `Pk_id_detalle_factura` int(11) NOT NULL,
  `fk_id_factura` int(11) DEFAULT NULL,
  `descripcion_factura` varchar(255) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `monto_factura` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `detallefactura`
--

INSERT INTO `detallefactura` (`Pk_id_detalle_factura`, `fk_id_factura`, `descripcion_factura`, `cantidad`, `monto_factura`, `estado`) VALUES
(1, 2, '2024-09-20', 100, 0.00, 1),
(2, 3, '2024-09-20', 200, 0.00, 1),
(3, 4, '2024-09-20', 1000, 0.00, 1),
(4, 5, '2024-09-20', 233, 0.00, 1),
(5, 6, '2024-09-20', 222, 1515.00, 1),
(6, 7, '2024-09-20', 999, 0.00, 1),
(7, 8, '2024-09-20', 300, 1313.00, 1),
(8, 9, '2024-09-20', 500, 0.00, 1),
(9, 9, '2024-09-20', 500, 0.00, 1),
(10, 10, '2024-09-21', 900, 0.00, 1),
(11, 10, '2024-09-21', 900, 0.00, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `codigo_empleado` int(11) NOT NULL,
  `nombre_completo` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `puesto` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `departamento` varchar(75) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`codigo_empleado`, `nombre_completo`, `puesto`, `departamento`, `estado`) VALUES
(1, 'JUAN GONZALEZ', 'GERENTE FINANCIERO', 'PRUEBA DEPARTAMENTO', 0),
(2, 'JOSE LUIS RODRIGUEZ', 'GERENTE COMERCIAL', 'PRUEBA DEPARTAMENTO', 1),
(3, 'JOSE FERNANDEZ', 'GERENTE DE MARKETING', 'PRUEBA DEPARTAMENTO', 0),
(4, 'MARIA GUADALUPE LOPEZ', 'DIRECTOR DE RECURSOS HUMANOS', 'PRUEBA DEPARTAMENTO', 1),
(5, 'FRANCISCO MARTINEZ', 'DIRECTOR GENERAL ', 'PRUEBA DEPARTAMENTO', 1),
(6, 'GUADALUPE SANCHEZ', 'DIRECTOR DE TECNOLOGIA', 'PRUEBA DEPARTAMENTO', 1),
(7, 'MARIA PEREZ', 'DIRECTOR EJECUTIVO', 'PRUEBA DEPARTAMENTO', 1),
(8, 'JUANA GOMEZ', 'ASISTENTE PERSONAL', 'PRUEBA DEPARTAMENTO', 1),
(9, 'ANTONIO MARTIN', 'AUXILIAR SE SERVICIOS', 'PRUEBA DEPARTAMENTO', 1),
(10, 'JESUS JIMENEZ', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(11, 'MIGUEL ANGEL RUIZ', 'SECRETARIA ', 'PRUEBA DEPARTAMENTO', 1),
(12, 'PEDRO HERNANDEZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(13, 'ALEJANDRO DIAZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(14, 'MANUEL MORENO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(15, 'MARGARITA MU?OZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(16, 'MARIA DEL CARMEN ALVAREZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(17, 'JUAN CARLOS ROMERO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(18, 'ROBERTO ALONSO', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(19, 'FERNANDO GUTIERREZ', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(20, 'DANIEL NAVARRO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(21, 'CARLOS TORRES', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(22, 'JORGE DOMINGUEZ', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(23, 'RICARDO VAZQUEZ', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(24, 'MIGUEL RAMOS', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(25, 'EDUARDO GIL', 'PROMOTOR', 'PRUEBA DEPARTAMENTO', 1),
(26, 'JAVIER RAMIREZ', 'ANALISTA DE VENTAS', 'PRUEBA DEPARTAMENTO', 1),
(27, 'RAFAEL SERRANO', 'DESARROLLADOR DE NEGOCIOS', 'PRUEBA DEPARTAMENTO', 1),
(28, 'MARTIN BLANCO', 'ANALISTA DE MARKETING', 'PRUEBA DEPARTAMENTO', 1),
(29, 'RAUL MOLINA', 'SUPERVISOR DE VENTAS', 'PRUEBA DEPARTAMENTO', 1),
(30, 'DAVID MORALES', 'GERENTE ADMINISTRATIVO Y FINANCIERO ', 'PRUEBA DEPARTAMENTO', 1),
(31, 'JOSEFINA SUAREZ', 'GERENTE ADMINISTRATIVO/ OPERACIONAL', 'PRUEBA DEPARTAMENTO', 1),
(32, 'JOSE ANTONIO ORTEGA', 'SUPERVISOR ADMINISTRATIVO/ OPERACIONES', 'PRUEBA DEPARTAMENTO', 1),
(33, 'ARTURO DELGADO', 'AUXILIAR ADMINISTRATIVO', 'PRUEBA DEPARTAMENTO', 1),
(34, 'MARCO ANTONIO CASTRO', 'GERENTE DEPARTAMENTAL/ SUCURSAL ', 'PRUEBA DEPARTAMENTO', 1),
(35, 'JOSE MANUEL ORTIZ', 'ANALISTA DE CONTROL DE GESTION', 'PRUEBA DEPARTAMENTO', 1),
(36, 'FRANCISCO JAVIER RUBIO', 'OPERADOR DE GARANTIAS POST VENTA', 'PRUEBA DEPARTAMENTO', 1),
(37, 'ENRIQUE MARIN', 'CONTADOR GENERAL', 'PRUEBA DEPARTAMENTO', 1),
(38, 'VERONICA SANZ', 'SUPERVISOR DE CONTABILIDAD', 'PRUEBA DEPARTAMENTO', 1),
(39, 'GERARDO NU?EZ', 'AUXILIAR CONTABLE ', 'PRUEBA DEPARTAMENTO', 1),
(40, 'MARIA ELENA IGLESIAS', 'ANALISTA DE IMPUESTOS ', 'PRUEBA DEPARTAMENTO', 1),
(41, 'LETICIA MEDINA', 'ASISTENTE DE IMPUESTOS', 'PRUEBA DEPARTAMENTO', 1),
(42, 'ROSA GARRIDO', 'ANALISTA DE COSTOS', 'PRUEBA DEPARTAMENTO', 1),
(43, 'MARIO CORTES', 'ENCARGADO DE CUENTAS A PAGAR', 'PRUEBA DEPARTAMENTO', 1),
(44, 'FRANCISCA CASTILLO', 'ENCARGADO/ AUXILIAR DE PATRIMONIO ', 'PRUEBA DEPARTAMENTO', 1),
(45, 'ALFREDO SANTOS', 'GERENTE FINANCIERO Y ADMINISTRATIVO ', 'PRUEBA DEPARTAMENTO', 1),
(46, 'TERESA LOZANO', 'GERENTE FINANCIERO', 'PRUEBA DEPARTAMENTO', 1),
(47, 'ALICIA GUERRERO', 'SUPERVISOR DE FINANZAS', 'PRUEBA DEPARTAMENTO', 1),
(48, 'MARIA FERNANDA CANO', 'ANALISTA DE FINANZAS', 'PRUEBA DEPARTAMENTO', 1),
(49, 'SERGIO PRIETO', 'ANALISTA DE FINANZAS JUNIOR ', 'PRUEBA DEPARTAMENTO', 1),
(50, 'ALBERTO MENDEZ', 'ENCARGADO DE FACTURACION Y/O CUENTAS CORRIENTES ', 'PRUEBA DEPARTAMENTO', 0),
(51, 'LUIS CRUZ', 'AUXILIAR DE FACTURACION Y/O CUENTAS CORRIENTES', 'PRUEBA DEPARTAMENTO', 1),
(52, 'ARMANDO CALVO', 'ENCARGADO DE CREDITOS', 'PRUEBA DEPARTAMENTO', 1),
(53, 'ALEJANDRA GALLEGO', 'AUXILIAR DE CREDITOS', 'PRUEBA DEPARTAMENTO', 1),
(54, 'MARTHA VIDAL', 'SUPERVISOR DE COBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(55, 'SANTIAGO LEON', 'SUPERVISOR DE TELECOBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(56, 'YOLANDA MARQUEZ', 'ENCARGADO/ AGENTE DE COBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(57, 'PATRICIA HERRERA', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(58, 'MARIA DE LOS ANGELES PE?A', 'AUXILIAR DE COBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(59, 'JUAN MANUEL FLORES', 'TELECOBRADOR/A JUNIOR', 'PRUEBA DEPARTAMENTO', 1),
(60, 'ROSA MARIA CABRERA', 'ANALISTA DE CREDITOS Y RIESGOS', 'PRUEBA DEPARTAMENTO', 1),
(61, 'ELIZABETH CAMPOS', 'ANALISTA DE CREDITOS Y RIESGOS JUNIOR ', 'PRUEBA DEPARTAMENTO', 1),
(62, 'GLORIA VEGA', 'TESORERO', 'PRUEBA DEPARTAMENTO', 1),
(63, 'ANGEL FUENTES', 'AUXILIAR DE TESORERIA ', 'PRUEBA DEPARTAMENTO', 1),
(64, 'GABRIELA CARRASCO', 'SUPERVISOR DE CAJAS ', 'PRUEBA DEPARTAMENTO', 1),
(65, 'SALVADOR DIEZ', 'CAJERO', 'PRUEBA DEPARTAMENTO', 1),
(66, 'VICTOR MANUEL CABALLERO', 'RECONTADOR DE BILLETES', 'PRUEBA DEPARTAMENTO', 1),
(67, 'SILVIA REYES', 'ASISTENTE PERSONAL', 'PRUEBA DEPARTAMENTO', 1),
(68, 'MARIA DE GUADALUPE NIETO', 'AUXILIAR SE SERVICIOS', 'PRUEBA DEPARTAMENTO', 1),
(69, 'MARIA DE JESUS AGUILAR', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(70, 'GABRIEL PASCUAL', 'SECRETARIA ', 'PRUEBA DEPARTAMENTO', 1),
(71, 'ANDRES SANTANA', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(72, 'OSCAR HERRERO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(73, 'GUILLERMO LORENZO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(74, 'ANA MARIA MONTERO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(75, 'RAMON HIDALGO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(76, 'MARIA ISABEL GIMENEZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(77, 'PABLO IBALEZ', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(78, 'RUBEN FERRER', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(79, 'ANTONIA DURAN', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(80, 'MARIA LUISA SANTIAGO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(81, 'LUIS ANGEL BENITEZ', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(82, 'MARIA DEL ROSARIO MORA', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(83, 'FELIPE VICENTE', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(84, 'JORGE JESUS VARGAS', 'PROMOTOR', 'PRUEBA DEPARTAMENTO', 1),
(85, 'JAIME ARIAS', 'CONSULTOR EN ADMINISTRACION DE EMPRESAS', 'PRUEBA DEPARTAMENTO', 1),
(86, 'JOSE GUADALUPE CARMONA', 'CONSULTOR AREA TECNICA ', 'PRUEBA DEPARTAMENTO', 1),
(87, 'JULIO CESAR CRESPO', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(88, 'JOSE DE JESUS ROMAN', 'COORDINADOR DE SISTEMAS', 'PRUEBA DEPARTAMENTO', 1),
(89, 'DIEGO PASTOR', 'ENCARGADO DE LA BASE DE DATOS', 'PRUEBA DEPARTAMENTO', 1),
(90, 'ARACELI SOTO', 'CAPACITADORES', 'PRUEBA DEPARTAMENTO', 1),
(91, 'ANDREA SAEZ', 'CIENTIFICO DE DATOS', 'PRUEBA DEPARTAMENTO', 1),
(92, 'ISABEL VELASCO', 'ANALISTA DE SEGURIDAD DE LA INFORMACION ', 'PRUEBA DEPARTAMENTO', 1),
(93, 'MARIA TERESA MOYA', 'INGENIERO DE SOFTWARE', 'PRUEBA DEPARTAMENTO', 1),
(94, 'IRMA SOLER', 'INGENIERO DE SOFTWARE', 'PRUEBA DEPARTAMENTO', 1),
(95, 'CARMEN PARRA', 'ANALISTA DE SISTMEAS COMPUTACIONALES', 'PRUEBA DEPARTAMENTO', 1),
(96, 'LUCIA ESTEBAN', 'DESARROLLADOR WEB ', 'PRUEBA DEPARTAMENTO', 1),
(97, 'ADRIANA BRAVO', 'DESARROLLADOR WEB ', 'PRUEBA DEPARTAMENTO', 1),
(98, 'AGUSTIN GALLARDO', 'DESARROLLADOR WEB ', 'PRUEBA DEPARTAMENTO', 1),
(99, 'MARIA DE LA LUZ ROJAS', 'ADMINISTRADOR DE REDES Y SISTEMAS INFORMATICOS', 'PRUEBA DEPARTAMENTO', 1),
(100, 'GUSTAVO GARCIA', 'ANALISTA DE CALIDAD', 'PRUEBA DEPARTAMENTO', 1),
(101, 'RANDY CHOC', 'ING SISTEMAS', 'IT', 1),
(102, 'GABRIEL', 'ANALISTA', 'IT', 1),
(103, 'GABRIEL', 'ING SIS', 'IT', 1),
(104, 'IRMA MONTES', 'BODEGA', 'VENTAS', 1),
(105, 'RANDALL CHOC', 'ANALISTA DE SISTEMAS', 'IT', 0),
(109, 'Edgar Casasola', 'Administrador', 'TI', 1),
(110, 'Brayan Hernandez', 'administrador', 'IT', 1),
(111, 'Josue David', 'adminsitrador', 'IT', 1),
(112, 'piki', 'Gerente', 'Ventas', 1),
(113, 'david', 'Gerente', 'Ventas', 1),
(114, 'Brayan', 'Administrador', 'IT', 1),
(115, 'qwe', 'qweq', 'qwe', 1),
(116, 'sadfa', 'asdf', 'sadf', 1),
(117, 'asdf', 'asdf', 'adf', 1),
(118, 'www', 'qwe', 'qwe', 1),
(119, 'opp', 'oppo', 'opop', 1),
(120, 'qwe', 'qweq', 'qwe', 1),
(121, 'asda', 'asd', 'asd', 1),
(122, 'asda', 'asda', 'asd', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `Pk_id_factura` int(11) NOT NULL,
  `fecha_factura` date DEFAULT NULL,
  `monto_factura` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`Pk_id_factura`, `fecha_factura`, `monto_factura`, `estado`) VALUES
(2, '2024-09-20', 100.00, NULL),
(3, '2024-09-20', 200.00, NULL),
(4, '2024-09-20', 1000.00, NULL),
(5, '2024-09-20', 233.00, 1),
(6, '2024-09-20', 1515.00, 1),
(7, '2025-03-20', 999.00, 1),
(8, '2024-09-20', 1313.00, 1),
(9, '2021-07-15', 555.00, 1),
(10, '2024-09-21', 900.00, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `Pk_id_pago` int(11) NOT NULL,
  `fk_id_factura` int(11) DEFAULT NULL,
  `fecha_pago` date DEFAULT NULL,
  `monto_factura` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`Pk_id_pago`, `fk_id_factura`, `fecha_pago`, `monto_factura`, `estado`) VALUES
(1, 2, '2024-09-20', 100.00, 1),
(2, 3, '2024-09-20', 200.00, 1),
(3, 4, '2024-09-20', 1000.00, 1),
(4, 5, '2024-09-20', 233.00, 1),
(5, 6, '2024-09-20', 1515.00, 1),
(6, 7, '2024-09-20', 999.00, 1),
(7, 8, '2024-09-20', 1313.00, 1),
(8, 9, '2024-09-20', 500.00, 1),
(9, 10, '2024-09-21', 900.00, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perro`
--

CREATE TABLE `perro` (
  `id_perro` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `id_raza` int(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `perro`
--

INSERT INTO `perro` (`id_perro`, `nombre`, `id_raza`, `estado`) VALUES
(2, 'Rodolfo', 1, 1),
(3, 'bolita', 5, 1),
(4, 'qwe', 3, 1),
(5, 'Tobi', 5, 1),
(6, 'Chispitas', 3, 1),
(7, 'manchas', 5, 1),
(8, 'pancho', 4, 1),
(9, 'chubasco', 2, 1),
(10, 'Sebastian', 5, 1),
(11, 'Letona', 3, 1),
(12, 'qwe', 2, 1),
(13, 'Pamcho', 4, 1),
(14, 'qweqwe', 3, 1),
(15, 'qqqq', 4, 0),
(16, 'ppp', 4, 1),
(17, 'Perro', 3, 0),
(18, 'defwe', 2, 0),
(19, 'Pancho', 5, 0),
(20, 'wefw', 3, 0),
(21, 'Juancho', 3, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `razas`
--

CREATE TABLE `razas` (
  `id_raza` int(11) NOT NULL,
  `nombre_raza` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `razas`
--

INSERT INTO `razas` (`id_raza`, `nombre_raza`, `estado`) VALUES
(1, 'Labrador', 1),
(2, 'Pastor Alemán', 1),
(3, 'Golden Retriever', 1),
(4, 'Bulldog', 1),
(5, 'Poodle', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registrocasas`
--

CREATE TABLE `registrocasas` (
  `id_registrocasa` int(11) NOT NULL,
  `telefono_casa` int(11) NOT NULL,
  `direccion_casa` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `registrocasas`
--

INSERT INTO `registrocasas` (`id_registrocasa`, `telefono_casa`, `direccion_casa`, `estado`) VALUES
(1, 0, '12345678', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registroperro`
--

CREATE TABLE `registroperro` (
  `id_registroperro` int(11) NOT NULL,
  `nombre_perro` varchar(50) NOT NULL,
  `raza_perro` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1,
  `id_perro` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `registroperro`
--

INSERT INTO `registroperro` (`id_registroperro`, `nombre_perro`, `raza_perro`, `estado`, `id_perro`) VALUES
(2, 'Rodolfo', 'Labrador', 0, 2),
(3, 'bolita', 'Poodle', 0, 3),
(4, 'qwe', 'Golden Retriever', 0, 4),
(5, 'Tobi', 'Poodle', 0, 5),
(6, 'Chispitas', 'Golden Retriever', 0, 6),
(7, 'manchas', 'Poodle', 0, 7),
(8, 'pancho', 'Bulldog', 0, 8),
(9, 'chubasco', 'Pastor Alemán', 0, 9),
(10, 'Sebastian', 'Poodle', 0, 10),
(11, 'Letona', 'Golden Retriever', 0, 11),
(12, 'qwe', 'Pastor Alemán', 0, 12),
(13, 'Pamcho', 'Bulldog', 0, 13),
(14, 'qweqwe', 'Golden Retriever', 0, 14),
(15, 'qqqq', 'Bulldog', 0, 15),
(16, 'ppp', 'Bulldog', 0, 16),
(17, 'Perro', 'Golden Retriever', 0, 17),
(18, 'defwe', 'Pastor Alemán', 0, 18),
(19, 'wefwf', 'Pastor Alemán', 0, 19),
(20, 'wefw', 'Golden Retriever', 0, 20),
(21, 'Juancho', 'Golden Retriever', 0, 21);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_empleados`
--

CREATE TABLE `registro_empleados` (
  `codigo_registro` int(11) NOT NULL,
  `codigo_empleado` int(11) NOT NULL,
  `fecha_registro` date NOT NULL,
  `hora_entrada` time NOT NULL,
  `hora_salida` time DEFAULT NULL,
  `total_de_horas` time DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `registro_empleados`
--

INSERT INTO `registro_empleados` (`codigo_registro`, `codigo_empleado`, `fecha_registro`, `hora_entrada`, `hora_salida`, `total_de_horas`, `estado`) VALUES
(1, 27, '2020-06-04', '18:19:00', '18:20:00', '00:01:00', 1),
(2, 10, '2020-06-01', '17:02:00', '18:46:00', '01:44:00', 1),
(3, 11, '2020-07-04', '18:45:00', '18:46:00', '00:01:00', 1),
(4, 12, '2020-07-04', '18:45:00', '18:46:00', '00:01:00', 1),
(5, 15, '2020-07-04', '18:45:00', '18:46:00', '00:01:00', 1),
(6, 20, '2020-06-04', '18:45:00', '18:46:00', '00:01:00', 1),
(7, 22, '2020-06-04', '18:46:00', '18:46:00', '192:00:00', 1),
(8, 40, '2020-07-04', '18:46:00', '18:46:00', '00:00:00', 1),
(9, 41, '2020-06-04', '18:46:00', '18:46:00', '00:00:00', 1),
(10, 10, '2020-06-04', '18:56:00', '19:40:00', '00:44:00', 1),
(11, 29, '2020-06-04', '20:59:00', '21:01:00', '00:02:00', 1),
(12, 12, '2020-06-04', '21:00:00', '21:01:00', '00:01:00', 1),
(13, 26, '2020-06-04', '21:19:00', '21:25:00', '00:06:00', 1),
(14, 77, '2020-05-01', '07:15:00', '10:15:00', '03:00:00', 1),
(15, 77, '2020-05-02', '07:15:00', '16:15:00', '09:00:00', 1),
(16, 77, '2020-05-03', '07:15:00', '16:15:00', '09:00:00', 1),
(17, 77, '2020-05-04', '07:15:00', '16:15:00', '09:00:00', 1),
(18, 77, '2020-05-05', '07:15:00', '16:15:00', '09:00:00', 1),
(19, 77, '2020-05-06', '07:15:00', '16:15:00', '09:00:00', 1),
(20, 77, '2020-05-07', '07:15:00', '16:15:00', '09:00:00', 1),
(21, 77, '2020-05-08', '07:15:00', '16:15:00', '09:00:00', 1),
(22, 77, '2020-05-09', '07:15:00', '16:15:00', '09:00:00', 1),
(23, 77, '2020-05-10', '07:15:00', '16:35:00', '09:20:00', 1),
(24, 77, '2020-05-11', '07:15:00', '16:15:00', '09:00:00', 1),
(25, 77, '2020-05-12', '07:15:00', '16:15:00', '09:00:00', 1),
(26, 77, '2020-05-13', '07:15:00', '16:15:00', '09:00:00', 1),
(27, 77, '2020-05-14', '07:15:00', '16:15:00', '09:00:00', 1),
(28, 77, '2020-05-15', '07:15:00', '16:15:00', '09:00:00', 1),
(29, 77, '2020-05-16', '07:15:00', '16:15:00', '09:00:00', 1),
(30, 77, '2020-05-17', '07:15:00', '16:15:00', '09:00:00', 1),
(31, 77, '2020-05-18', '07:15:00', '16:15:00', '09:00:00', 1),
(32, 77, '2020-05-19', '07:15:00', '16:15:00', '09:00:00', 1),
(33, 77, '2020-05-20', '07:15:00', '16:15:00', '09:00:00', 1),
(34, 77, '2020-05-21', '07:15:00', '16:15:00', '09:00:00', 1),
(35, 77, '2020-05-22', '07:15:00', '16:15:00', '09:00:00', 1),
(36, 77, '2020-05-23', '07:15:00', '16:15:00', '09:00:00', 1),
(37, 77, '2020-05-24', '07:15:00', '16:15:00', '09:00:00', 1),
(38, 77, '2020-05-25', '07:15:00', '16:15:00', '09:00:00', 1),
(39, 77, '2020-05-26', '07:15:00', '16:15:00', '09:00:00', 1),
(40, 77, '2020-05-27', '07:15:00', '16:15:00', '09:00:00', 1),
(41, 77, '2020-05-28', '07:15:00', '16:15:00', '09:00:00', 1),
(42, 77, '2020-05-29', '07:15:00', '16:15:00', '09:00:00', 1),
(43, 77, '2020-05-30', '07:15:00', '16:15:00', '09:00:00', 1),
(44, 77, '2020-05-31', '07:15:00', '16:15:00', '09:00:00', 1),
(45, 77, '2020-06-01', '07:15:00', '16:15:00', '09:00:00', 1),
(46, 77, '2020-06-02', '07:15:00', '16:15:00', '09:00:00', 1),
(47, 77, '2020-06-03', '07:15:00', '16:15:00', '09:00:00', 1),
(48, 77, '2020-06-04', '07:15:00', '16:15:00', '09:00:00', 1),
(49, 77, '2020-06-06', '07:15:00', '16:15:00', '09:00:00', 1),
(50, 77, '2020-06-07', '07:15:00', '16:15:00', '09:00:00', 1),
(51, 77, '2020-06-08', '07:15:00', '16:15:00', '09:00:00', 1),
(52, 77, '2020-06-09', '07:15:00', '16:15:00', '09:00:00', 1),
(53, 77, '2020-06-10', '07:15:00', '16:15:00', '09:00:00', 1),
(54, 77, '2020-06-11', '07:15:00', '16:15:00', '09:00:00', 1),
(55, 77, '2020-06-12', '07:15:00', '16:15:00', '09:00:00', 1),
(56, 77, '2020-06-13', '07:15:00', '16:15:00', '09:00:00', 1),
(57, 77, '2020-06-14', '07:15:00', '16:15:00', '09:00:00', 1),
(58, 77, '2020-06-15', '07:15:00', '16:15:00', '09:00:00', 1),
(59, 77, '2020-06-16', '07:15:00', '16:15:00', '09:00:00', 1),
(60, 77, '2020-06-17', '07:15:00', '16:15:00', '09:00:00', 1),
(61, 77, '2020-06-18', '07:15:00', '16:15:00', '09:00:00', 1),
(62, 77, '2020-06-19', '07:15:00', '16:15:00', '09:00:00', 1),
(63, 77, '2020-06-20', '07:15:00', '16:15:00', '09:00:00', 1),
(64, 77, '2020-06-21', '07:15:00', '16:15:00', '09:00:00', 1),
(65, 77, '2020-06-22', '07:15:00', '16:15:00', '09:00:00', 1),
(66, 77, '2020-06-23', '07:15:00', '16:15:00', '09:00:00', 1),
(67, 77, '2020-06-24', '07:15:00', '16:15:00', '09:00:00', 1),
(68, 77, '2020-06-25', '07:15:00', '16:15:00', '09:00:00', 1),
(69, 77, '2020-06-26', '07:15:00', '16:15:00', '09:00:00', 1),
(70, 77, '2020-06-27', '07:15:00', '16:15:00', '09:00:00', 1),
(71, 77, '2020-06-28', '07:05:00', '16:15:00', '09:10:00', 1),
(72, 77, '2020-06-29', '07:15:00', '16:15:00', '09:00:00', 1),
(73, 77, '2020-06-30', '07:15:00', '16:15:00', '09:00:00', 1),
(74, 99, '2020-06-05', '03:29:00', '18:46:00', '15:17:00', 1),
(75, 68, '2020-06-05', '19:55:00', NULL, NULL, 1),
(76, 66, '2020-06-06', '16:11:00', '16:12:00', '00:01:00', 1),
(77, 67, '2020-06-06', '16:11:00', '22:47:00', '06:36:00', 1),
(78, 104, '2020-06-06', '22:50:00', '22:54:00', '00:04:00', 1),
(79, 68, '2020-06-06', '22:54:00', '22:54:00', '00:00:00', 1),
(80, 105, '2020-06-06', '23:28:00', '23:29:00', '00:01:00', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reserva`
--

CREATE TABLE `reserva` (
  `id_reserva` int(11) NOT NULL,
  `nombre_cliente` varchar(50) NOT NULL,
  `monto_compra` int(11) NOT NULL,
  `sede_compra` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `reserva`
--

INSERT INTO `reserva` (`id_reserva`, `nombre_cliente`, `monto_compra`, `sede_compra`, `estado`) VALUES
(2, '2', 0, '', 0),
(3, '3', 0, '100', 0),
(4, '4', 0, '54', 0),
(5, '5', 0, '5555', 0),
(6, '6', 0, '222', 0),
(7, 'ddd', 7, '5555', 0),
(8, '8', 545544, 'qqqq', 0),
(9, 'cliente', 1111, '9', 0),
(10, 'cliente', 888, '10', 0),
(11, 'cliente', 111, '11', 0),
(12, '555', 0, 'cliente', 0),
(13, 'cliente', 8888, '13', 0),
(14, 'cliente', 777, '14', 0),
(15, '5454', 0, 'wwww', 0),
(16, 'cliente ', 888, 'sede', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicaciones`
--

CREATE TABLE `tbl_aplicaciones` (
  `Pk_id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_aplicaciones`
--

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1000, 'MDI SEGURIDAD', 'PARA SEGURIDAD', 1),
(1001, 'Mant. Usuario', 'PARA SEGURIDAD', 1),
(1002, 'Mant. Aplicación', 'PARA SEGURIDAD', 1),
(1003, 'Mant. Modulo', 'PARA SEGURIDAD', 1),
(1004, 'Mant. Perfil', 'PARA SEGURIDAD', 1),
(1101, 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', 1),
(1102, 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', 1),
(1103, 'Asign. Perfil Usuario', 'PARA SEGURIDAD', 1),
(1201, 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', 1),
(1301, 'Pcs. BITACORA', 'PARA SEGURIDAD', 1),
(2000, 'MDI LOGISTICA', 'PARA LOGISTICA', 1),
(3000, 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', 1),
(5000, 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', 1),
(6000, 'MDI NOMINAS', 'PARA NOMINAS', 1),
(6001, 'Mant. Trabajadores', 'PARA NOMINAS', 1),
(6002, 'Mant. Puestos de Trabajo', 'PARA NOMINAS', 1),
(6003, 'Mant. Departamentos', 'PARA NOMINAS', 1),
(6004, 'Mant. Contratos', 'PARA NOMINAS', 1),
(6005, 'Mant. Percepciones', 'PARA NOMINAS', 1),
(6006, 'Mant. Horas Extras', 'PARA NOMINAS', 1),
(6007, 'Mant. Faltas', 'PARA NOMINAS', 1),
(6101, 'Asgn. Puesto - Depto.', 'PARA NOMINAS', 1),
(6102, 'Asgn. Puesto - Trabajador', 'PARA NOMINAS', 1),
(6103, 'Asgn. Contrato Trabajador', 'PARA NOMINAS', 1),
(6104, 'Asgn. Prestaciones Contrato', 'PARA NOMINAS', 1),
(6105, 'Asgn. Prestaciones Individual', 'PARA NOMINAS', 1),
(6106, 'Prcs. Nomina', 'PARA NOMINAS', 1),
(6201, 'Rpt. Planillas', 'PARA NOMINAS', 1),
(6202, 'Rpt. Contratos', 'PARA NOMINAS', 1),
(6203, 'Rpt. Trabajadores', 'PARA NOMINAS', 1),
(6301, 'ACCESO SEGURIDAD', 'PARA NOMINAS', 1),
(7000, 'MDI BANCOS', 'PARA BANCOS', 1),
(8000, 'MDI CONTRABILIDAD', 'PARA CONTRABILIDAD', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignaciones_perfils_usuario`
--

CREATE TABLE `tbl_asignaciones_perfils_usuario` (
  `PK_id_Perfil_Usuario` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `tbl_asignaciones_perfils_usuario`
--

INSERT INTO `tbl_asignaciones_perfils_usuario` (`PK_id_Perfil_Usuario`, `Fk_id_usuario`, `Fk_id_perfil`) VALUES
(1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacion_modulo_aplicacion`
--

CREATE TABLE `tbl_asignacion_modulo_aplicacion` (
  `Fk_id_modulos` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `tbl_asignacion_modulo_aplicacion`
--

INSERT INTO `tbl_asignacion_modulo_aplicacion` (`Fk_id_modulos`, `Fk_id_aplicacion`) VALUES
(1000, 1000),
(1000, 1001),
(1000, 1002),
(1000, 1003),
(1000, 1004),
(1000, 1102),
(1000, 1103),
(1000, 1201),
(1000, 1301),
(2000, 2000),
(3000, 3000),
(5000, 5000),
(6000, 6000),
(6000, 6001),
(6000, 6002),
(6000, 6003),
(6000, 6004),
(6000, 6005),
(6000, 6006),
(6000, 6007),
(6000, 6101),
(6000, 6102),
(6000, 6103),
(6000, 6104),
(6000, 6105),
(6000, 6106),
(6000, 6201),
(6000, 6202),
(6000, 6203),
(6000, 6301),
(7000, 7000),
(8000, 8000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

CREATE TABLE `tbl_bitacora` (
  `Pk_id_bitacora` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(50) NOT NULL,
  `tabla` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `tbl_bitacora`
--

INSERT INTO `tbl_bitacora` (`Pk_id_bitacora`, `Fk_id_usuario`, `fecha_bitacora`, `hora_bitacora`, `host_bitacora`, `ip_bitacora`, `accion_bitacora`, `tabla`) VALUES
(1, 1, '2024-09-17', '15:40:35', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(2, 1, '2024-09-17', '15:40:39', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a usuarios', 'tbl_usuarios'),
(3, 1, '2024-09-17', '15:40:39', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(4, 1, '2024-09-17', '15:40:50', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a perfiles', 'Tbl_perfiles'),
(5, 1, '2024-09-17', '15:40:51', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(6, 1, '2024-09-17', '15:55:51', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(7, 1, '2024-09-17', '15:56:06', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a usuarios', 'tbl_usuarios'),
(8, 1, '2024-09-17', '15:56:06', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(9, 1, '2024-09-17', '15:56:49', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(10, 1, '2024-09-17', '15:56:49', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(11, 1, '2024-09-17', '16:00:49', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a perfiles', 'Tbl_perfiles'),
(12, 1, '2024-09-17', '16:00:49', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(13, 1, '2024-09-17', '16:00:53', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(14, 1, '2024-09-17', '16:00:53', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(15, 1, '2024-09-17', '16:54:50', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a usuarios', 'tbl_usuarios'),
(16, 1, '2024-09-17', '16:54:51', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(17, 1, '2024-09-17', '16:54:58', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(18, 1, '2024-09-17', '16:54:58', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(19, 1, '2024-09-17', '16:55:18', 'BeaglePC', '192.168.56.1', 'Asignó aplicación: MDI LOGISTICA a usuario: admin', 'Tbl_permisos_aplicaciones_usuario'),
(20, 1, '2024-09-17', '16:55:29', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a perfiles', 'Tbl_perfiles'),
(21, 1, '2024-09-17', '16:55:29', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(22, 1, '2024-09-17', '16:55:52', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a usuarios', 'tbl_usuarios'),
(23, 1, '2024-09-17', '16:55:52', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(24, 1, '2024-09-17', '16:56:22', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a perfiles', 'Tbl_perfiles'),
(25, 1, '2024-09-17', '16:56:22', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(26, 1, '2024-09-17', '16:59:19', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(27, 1, '2024-09-17', '16:59:21', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a usuarios', 'tbl_usuarios'),
(28, 1, '2024-09-17', '16:59:21', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(29, 1, '2024-09-17', '17:00:19', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(30, 1, '2024-09-17', '17:00:19', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(31, 1, '2024-09-17', '17:00:34', 'BeaglePC', '192.168.56.1', 'Asignó aplicación: MDI SEGURIDAD a usuario: admin', 'Tbl_permisos_aplicaciones_usuario'),
(32, 1, '2024-09-17', '17:02:10', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(33, 1, '2024-09-17', '17:02:10', 'BeaglePC', '192.168.56.1', 'Realizó una consulta a aplicaciones', 'tbl_aplicacion'),
(34, 1, '2024-09-17', '17:04:53', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a perfiles', 'Tbl_perfiles'),
(35, 1, '2024-09-17', '17:04:54', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(36, 1, '2024-09-17', '17:07:12', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a perfiles', 'Tbl_perfiles'),
(37, 1, '2024-09-17', '17:07:12', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(38, 1, '2024-09-17', '17:08:22', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a perfiles', 'Tbl_perfiles'),
(39, 1, '2024-09-17', '17:08:22', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(40, 1, '2024-09-17', '17:13:24', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(41, 1, '2024-09-17', '17:22:05', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(42, 1, '2024-09-17', '17:22:13', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a usuarios', 'tbl_usuarios'),
(43, 1, '2024-09-17', '17:22:13', 'BeaglePC', '192.168.56.1', 'Realizo una consulta a modulos', 'Tbl_modulos'),
(44, 1, '2024-09-17', '17:31:31', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(45, 1, '2024-09-17', '17:32:03', 'BeaglePC', '192.168.56.1', 'Se inserto el usuario con nombre: Ismar', 'tbl_usuarios'),
(46, 1, '2024-09-17', '17:33:46', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(47, 1, '2024-09-17', '17:47:14', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(48, 1, '2024-09-17', '17:47:45', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(49, 1, '2024-09-17', '17:48:32', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(50, 1, '2024-09-17', '18:30:27', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(51, 1, '2024-09-17', '18:31:26', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(52, 1, '2024-09-17', '18:33:06', 'BeaglePC', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(53, 1, '2024-09-18', '07:01:15', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(54, 1, '2024-09-18', '07:02:41', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(55, 1, '2024-09-18', '07:03:20', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(56, 1, '2024-09-18', '07:49:34', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(57, 1, '2024-09-18', '08:26:02', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(58, 1, '2024-09-18', '08:28:44', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(59, 1, '2024-09-18', '08:30:18', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(60, 1, '2024-09-18', '08:31:57', 'Brayan', '192.168.237.22', 'Se logeo al sistema', 'Login'),
(61, 1, '2024-09-18', '18:05:14', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(62, 1, '2024-09-18', '18:06:30', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(63, 1, '2024-09-18', '18:08:54', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(64, 1, '2024-09-18', '18:09:18', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(65, 1, '2024-09-18', '18:12:56', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(66, 1, '2024-09-18', '18:13:26', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(67, 1, '2024-09-18', '18:30:34', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(68, 1, '2024-09-18', '18:32:36', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(69, 1, '2024-09-18', '19:54:28', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(70, 1, '2024-09-18', '19:57:39', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(71, 1, '2024-09-18', '19:57:56', 'Brayan', '192.168.0.2', 'Se inserto en venta', 'venta'),
(72, 1, '2024-09-18', '19:57:56', 'Brayan', '192.168.0.2', 'Se inserto en factura', 'factura'),
(73, 1, '2024-09-18', '20:00:45', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(74, 1, '2024-09-18', '22:09:14', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(75, 1, '2024-09-18', '22:10:22', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(76, 1, '2024-09-18', '22:11:32', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(77, 1, '2024-09-18', '22:15:44', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(78, 1, '2024-09-18', '22:17:19', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(79, 1, '2024-09-18', '22:19:53', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(80, 1, '2024-09-18', '22:24:35', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(81, 1, '2024-09-19', '20:01:23', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(82, 1, '2024-09-19', '20:01:43', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(83, 1, '2024-09-19', '20:01:43', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(84, 1, '2024-09-19', '20:04:40', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(85, 1, '2024-09-19', '20:11:54', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(86, 1, '2024-09-19', '20:12:48', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(87, 1, '2024-09-19', '20:14:21', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(88, 1, '2024-09-19', '20:16:11', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(89, 1, '2024-09-19', '20:18:14', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(90, 1, '2024-09-19', '20:23:25', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(91, 1, '2024-09-19', '20:24:41', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(92, 1, '2024-09-19', '20:26:45', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(93, 1, '2024-09-19', '20:29:37', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(94, 1, '2024-09-19', '20:31:02', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(95, 1, '2024-09-19', '20:33:23', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(96, 1, '2024-09-19', '20:35:36', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(97, 1, '2024-09-19', '20:37:01', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(98, 1, '2024-09-19', '20:37:39', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(99, 1, '2024-09-19', '20:41:01', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(100, 1, '2024-09-19', '20:43:40', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(101, 1, '2024-09-19', '20:46:08', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(102, 1, '2024-09-19', '20:47:54', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(103, 1, '2024-09-19', '20:47:54', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(104, 1, '2024-09-19', '20:49:05', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(105, 1, '2024-09-19', '20:49:18', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(106, 1, '2024-09-19', '20:49:18', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(107, 1, '2024-09-19', '20:49:19', 'Brayan', '192.168.0.2', 'Se insertó en pago', 'pago'),
(108, 1, '2024-09-20', '22:13:28', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(109, 1, '2024-09-20', '22:15:03', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(110, 1, '2024-09-20', '22:16:03', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(111, 1, '2024-09-20', '22:17:43', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(112, 1, '2024-09-20', '22:18:06', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(113, 1, '2024-09-20', '22:18:06', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(114, 1, '2024-09-20', '22:18:07', 'Brayan', '192.168.0.2', 'Se insertó en pago', 'pago'),
(115, 1, '2024-09-20', '22:18:57', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(116, 1, '2024-09-20', '22:18:58', 'Brayan', '192.168.0.2', 'Actualizo un registro en factura', 'factura'),
(117, 1, '2024-09-20', '22:19:34', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(118, 1, '2024-09-20', '22:19:36', 'Brayan', '192.168.0.2', 'Actualizo un registro en factura', 'factura'),
(119, 1, '2024-09-20', '22:21:44', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(120, 1, '2024-09-20', '22:26:16', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(121, 1, '2024-09-20', '22:26:40', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(122, 1, '2024-09-20', '22:26:41', 'Brayan', '192.168.0.2', 'Actualizo un registro en factura', 'factura'),
(123, 1, '2024-09-20', '22:27:28', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(124, 1, '2024-09-20', '22:27:29', 'Brayan', '192.168.0.2', 'Actualizo un registro en factura', 'factura'),
(125, 1, '2024-09-20', '22:28:19', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(126, 1, '2024-09-20', '22:28:20', 'Brayan', '192.168.0.2', 'Actualizo un registro en factura', 'factura'),
(127, 1, '2024-09-20', '22:30:33', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(128, 1, '2024-09-20', '22:31:46', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(129, 1, '2024-09-20', '22:32:05', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(130, 1, '2024-09-20', '22:32:05', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(131, 1, '2024-09-20', '22:32:05', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(132, 1, '2024-09-20', '22:32:52', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(133, 1, '2024-09-20', '22:38:23', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(134, 1, '2024-09-20', '22:38:36', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(135, 1, '2024-09-20', '22:38:36', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(136, 1, '2024-09-20', '22:38:36', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(137, 1, '2024-09-20', '22:43:58', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(138, 1, '2024-09-20', '22:43:58', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(139, 1, '2024-09-20', '22:43:58', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(140, 1, '2024-09-20', '22:48:15', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(141, 1, '2024-09-20', '22:48:57', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(142, 1, '2024-09-20', '22:50:27', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(143, 1, '2024-09-20', '22:51:45', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(144, 1, '2024-09-20', '22:52:51', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(145, 1, '2024-09-20', '22:52:51', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(146, 1, '2024-09-20', '22:52:51', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(147, 1, '2024-09-20', '22:53:28', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(148, 1, '2024-09-20', '22:53:58', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(149, 1, '2024-09-20', '22:55:55', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(150, 1, '2024-09-20', '22:56:08', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(151, 1, '2024-09-20', '23:01:53', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(152, 1, '2024-09-20', '23:08:07', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(153, 1, '2024-09-20', '23:08:07', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(154, 1, '2024-09-20', '23:08:07', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(155, 1, '2024-09-20', '23:08:25', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(156, 1, '2024-09-20', '23:10:40', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(157, 1, '2024-09-20', '23:14:07', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(158, 1, '2024-09-20', '23:21:00', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(159, 1, '2024-09-20', '23:21:00', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(160, 1, '2024-09-20', '23:21:00', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(161, 1, '2024-09-20', '23:21:37', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(162, 1, '2024-09-20', '23:26:50', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(163, 1, '2024-09-20', '23:30:10', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(164, 1, '2024-09-20', '23:30:10', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(165, 1, '2024-09-20', '23:30:10', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(166, 1, '2024-09-20', '23:30:26', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(167, 1, '2024-09-20', '23:35:24', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(168, 1, '2024-09-20', '23:39:58', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(169, 1, '2024-09-20', '23:41:24', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(170, 1, '2024-09-20', '23:45:35', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(171, 1, '2024-09-20', '23:46:28', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(172, 1, '2024-09-20', '23:47:27', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(173, 1, '2024-09-20', '23:50:38', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(174, 1, '2024-09-20', '23:50:38', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(175, 1, '2024-09-20', '23:50:38', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos'),
(176, 1, '2024-09-20', '23:50:59', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(177, 1, '2024-09-20', '23:57:16', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(178, 1, '2024-09-20', '23:57:32', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(179, 1, '2024-09-21', '00:00:43', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(180, 1, '2024-09-21', '00:01:04', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(181, 1, '2024-09-21', '00:06:49', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(182, 1, '2024-09-21', '00:07:10', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(183, 1, '2024-09-21', '00:07:53', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(184, 1, '2024-09-21', '00:11:11', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(185, 1, '2024-09-21', '00:11:29', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(186, 1, '2024-09-21', '00:13:56', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(187, 1, '2024-09-21', '00:14:13', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(188, 1, '2024-09-21', '00:14:46', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(189, 1, '2024-09-21', '00:15:57', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(190, 1, '2024-09-21', '00:16:21', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(191, 1, '2024-09-21', '00:18:05', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(192, 1, '2024-09-21', '00:18:21', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(193, 1, '2024-09-21', '00:19:46', 'Brayan', '192.168.0.2', 'Se presiono el boton cancelar en factura', 'factura'),
(194, 1, '2024-09-21', '00:20:15', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(195, 1, '2024-09-21', '00:24:14', 'Brayan', '192.168.0.2', 'Actualizó registros en múltiples tablas', 'factura'),
(196, 1, '2024-09-21', '00:55:40', 'Brayan', '192.168.0.2', 'Se logeo al sistema', 'Login'),
(197, 1, '2024-09-21', '00:58:47', 'Brayan', '192.168.0.2', 'Se insertó en factura', 'factura'),
(198, 1, '2024-09-21', '00:58:47', 'Brayan', '192.168.0.2', 'Se insertó en detallefactura', 'detallefactura'),
(199, 1, '2024-09-21', '00:58:48', 'Brayan', '192.168.0.2', 'Se insertó en pagos', 'pagos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_consultainteligente`
--

CREATE TABLE `tbl_consultainteligente` (
  `Pk_consultaID` int(11) NOT NULL,
  `nombre_consulta` varchar(50) NOT NULL,
  `tipo_consulta` int(1) NOT NULL,
  `consulta_SQLE` varchar(100) NOT NULL,
  `consulta_estatus` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_consultainteligente`
--

INSERT INTO `tbl_consultainteligente` (`Pk_consultaID`, `nombre_consulta`, `tipo_consulta`, `consulta_SQLE`, `consulta_estatus`) VALUES
(1, '', 0, 'SELECT id_venta FROM venta;', 1),
(2, '', 0, 'SELECT SELECT id_venta FROM venta;id_venta AS * FROM venta;', 1),
(3, '', 0, 'SELECT * FROM venta;', 1),
(4, '', 0, 'SELECT * FROM venta;', 1),
(5, '', 0, 'SELECT * FROM venta;', 1),
(6, '', 0, 'SELECT * FROM venta;', 1),
(7, 'dsf', 0, 'SELECT * FROM venta;', 1),
(8, '', 0, 'SELECT * FROM venta;', 1),
(9, '', 0, 'SELECT * FROM venta;', 1),
(10, 'viccccccccc', 0, 'SELECT * FROM venta;', 1),
(11, 'consultaaaaa', 0, 'SELECT * FROM factura;', 1),
(12, '', 0, 'SELECT * FROM factura;', 1),
(13, 'jkjkkjk', 0, 'SELECT * FROM factura;', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulos`
--

CREATE TABLE `tbl_modulos` (
  `Pk_id_modulos` int(11) NOT NULL,
  `nombre_modulo` varchar(50) NOT NULL,
  `descripcion_modulo` varchar(150) NOT NULL,
  `estado_modulo` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_modulos`
--

INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1000, 'SEGURIDAD', 'Seguridad', 1),
(2000, 'LOGISTICA', 'Logistica', 1),
(3000, 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
(5000, 'PRODUCCIÓN', 'Produccion', 1),
(6000, 'NOMINAS', 'Nominas', 1),
(7000, 'BANCOS', 'Bancos', 1),
(8000, 'CONTABILIDAD', 'Contabilidad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfiles`
--

CREATE TABLE `tbl_perfiles` (
  `Pk_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(150) NOT NULL,
  `estado_perfil` tinyint(4) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_perfiles`
--

INSERT INTO `tbl_perfiles` (`Pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
(2, 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
(3, 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
(4, 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
(5, 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
(6, 'NOMINAS', 'contiene todos los permisos de nominas', 1),
(7, 'BANCOS', 'contiene todos los permisos de bancos', 1),
(8, 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1),
(9, 'AUDITOR', 'Permite la revisión y auditoría de actividades sin capacidad de modificar datos', 1),
(10, 'SOporte Técnico', 'Permite brindar asistencia técnica sin acceso completo a la administración', 1),
(11, 'ADMINISTRADOR', 'Acceso completo al sistema con ciertas restricciones según sea necesario', 1),
(12, 'GESTOR DE PROYECTOS', 'Permite gestionar proyectos y coordinar actividades sin acceso completo a la administración', 1),
(13, 'GESTOR DE DATOS', 'Permite gestionar y supervisar datos en distintos módulos sin acceso completo a la administración', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisos_aplicaciones_usuario`
--

CREATE TABLE `tbl_permisos_aplicaciones_usuario` (
  `PK_id_Aplicacion_Usuario` int(11) NOT NULL,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `tbl_permisos_aplicaciones_usuario`
--

INSERT INTO `tbl_permisos_aplicaciones_usuario` (`PK_id_Aplicacion_Usuario`, `Fk_id_usuario`, `Fk_id_aplicacion`, `guardar_permiso`, `buscar_permiso`, `modificar_permiso`, `eliminar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1002, 1, 1, 1, 1, 0),
(2, 1, 2000, 0, 0, 0, 0, 0),
(3, 1, 1000, 1, 1, 1, 1, 1),
(4, 1, 8000, 0, 0, 0, 0, 0),
(6, 1, 1000, 1, 1, 1, 1, 1),
(7, 2, 1000, 0, 0, 0, 0, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisos_aplicacion_perfil`
--

CREATE TABLE `tbl_permisos_aplicacion_perfil` (
  `PK_id_Aplicacion_Perfil` int(11) NOT NULL,
  `Fk_id_perfil` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT 0,
  `modificar_permiso` tinyint(1) DEFAULT 0,
  `eliminar_permiso` tinyint(1) DEFAULT 0,
  `buscar_permiso` tinyint(1) DEFAULT 0,
  `imprimir_permiso` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `tbl_permisos_aplicacion_perfil`
--

INSERT INTO `tbl_permisos_aplicacion_perfil` (`PK_id_Aplicacion_Perfil`, `Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1000, 1, 1, 1, 1, 1),
(2, 1, 1001, 1, 1, 1, 1, 1),
(3, 1, 1002, 1, 1, 1, 1, 1),
(4, 1, 1003, 1, 1, 1, 1, 1),
(5, 1, 1004, 1, 1, 1, 1, 1),
(6, 1, 1101, 1, 1, 1, 1, 1),
(7, 1, 1102, 1, 1, 1, 1, 1),
(8, 1, 1103, 1, 1, 1, 1, 1),
(9, 1, 1201, 1, 1, 1, 1, 1),
(10, 1, 1301, 1, 1, 1, 1, 1),
(11, 1, 2000, 1, 1, 1, 1, 1),
(12, 1, 3000, 1, 1, 1, 1, 1),
(13, 1, 5000, 1, 1, 1, 1, 1),
(14, 1, 6000, 1, 1, 1, 1, 1),
(15, 1, 6001, 1, 1, 1, 1, 1),
(16, 1, 6002, 1, 1, 1, 1, 1),
(17, 1, 6003, 1, 1, 1, 1, 1),
(18, 1, 6004, 1, 1, 1, 1, 1),
(19, 1, 6005, 1, 1, 1, 1, 1),
(20, 1, 6006, 1, 1, 1, 1, 1),
(21, 1, 6007, 1, 1, 1, 1, 1),
(22, 1, 6101, 1, 1, 1, 1, 1),
(23, 1, 6102, 1, 1, 1, 1, 1),
(24, 1, 6103, 1, 1, 1, 1, 1),
(25, 1, 6104, 1, 1, 1, 1, 1),
(26, 1, 6105, 1, 1, 1, 1, 1),
(27, 1, 6106, 1, 1, 1, 1, 1),
(28, 1, 6201, 1, 1, 1, 1, 1),
(29, 1, 6202, 1, 1, 1, 1, 1),
(30, 1, 6203, 1, 1, 1, 1, 1),
(31, 1, 6301, 1, 1, 1, 1, 1),
(32, 1, 7000, 1, 1, 1, 1, 1),
(33, 1, 8000, 1, 1, 1, 1, 1),
(34, 2, 1000, 1, 1, 1, 1, 1),
(35, 3, 2000, 1, 1, 1, 1, 1),
(36, 4, 3000, 1, 1, 1, 1, 1),
(37, 5, 5000, 1, 1, 1, 1, 1),
(38, 6, 6000, 1, 1, 1, 1, 1),
(39, 6, 6001, 1, 1, 1, 1, 1),
(40, 6, 6002, 1, 1, 1, 1, 1),
(41, 6, 6003, 1, 1, 1, 1, 1),
(42, 6, 6004, 1, 1, 1, 1, 1),
(43, 6, 6005, 1, 1, 1, 1, 1),
(44, 6, 6006, 1, 1, 1, 1, 1),
(45, 6, 6007, 1, 1, 1, 1, 1),
(46, 6, 6101, 1, 1, 1, 1, 1),
(47, 6, 6102, 1, 1, 1, 1, 1),
(48, 6, 6103, 1, 1, 1, 1, 1),
(49, 6, 6104, 1, 1, 1, 1, 1),
(50, 6, 6105, 1, 1, 1, 1, 1),
(51, 6, 6106, 1, 1, 1, 1, 1),
(52, 6, 6201, 1, 1, 1, 1, 1),
(53, 6, 6202, 1, 1, 1, 1, 1),
(54, 6, 6203, 1, 1, 1, 1, 1),
(55, 6, 6301, 1, 1, 1, 1, 1),
(56, 7, 7000, 1, 1, 1, 1, 1),
(57, 8, 8000, 1, 1, 1, 1, 1),
(58, 9, 1000, 1, 1, 1, 1, 1),
(59, 9, 1001, 1, 1, 1, 1, 1),
(60, 9, 1002, 1, 1, 1, 1, 1),
(61, 9, 1003, 1, 1, 1, 1, 1),
(62, 9, 1004, 1, 1, 1, 1, 1),
(63, 9, 1101, 1, 1, 1, 1, 1),
(64, 9, 1102, 1, 1, 1, 1, 1),
(65, 9, 1103, 1, 1, 1, 1, 1),
(66, 9, 1201, 1, 1, 1, 1, 1),
(67, 9, 1301, 1, 1, 1, 1, 1),
(68, 9, 2000, 1, 1, 1, 1, 1),
(69, 9, 3000, 1, 1, 1, 1, 1),
(70, 9, 5000, 1, 1, 1, 1, 1),
(71, 9, 6000, 1, 1, 1, 1, 1),
(72, 9, 6001, 1, 1, 1, 1, 1),
(73, 9, 6002, 1, 1, 1, 1, 1),
(74, 9, 6003, 1, 1, 1, 1, 1),
(75, 9, 6004, 1, 1, 1, 1, 1),
(76, 9, 6005, 1, 1, 1, 1, 1),
(77, 9, 6006, 1, 1, 1, 1, 1),
(78, 9, 6007, 1, 1, 1, 1, 1),
(79, 9, 6101, 1, 1, 1, 1, 1),
(80, 9, 6102, 1, 1, 1, 1, 1),
(81, 9, 6103, 1, 1, 1, 1, 1),
(82, 9, 6104, 1, 1, 1, 1, 1),
(83, 9, 6105, 1, 1, 1, 1, 1),
(84, 9, 6106, 1, 1, 1, 1, 1),
(85, 9, 6201, 1, 1, 1, 1, 1),
(86, 9, 6202, 1, 1, 1, 1, 1),
(87, 9, 6203, 1, 1, 1, 1, 1),
(88, 9, 6301, 1, 1, 1, 1, 1),
(89, 9, 7000, 1, 1, 1, 1, 1),
(90, 9, 8000, 1, 1, 1, 1, 1),
(91, 10, 1000, 1, 1, 1, 1, 1),
(92, 10, 1001, 1, 1, 1, 1, 1),
(93, 10, 1002, 1, 1, 1, 1, 1),
(94, 10, 1003, 1, 1, 1, 1, 1),
(95, 10, 1004, 1, 1, 1, 1, 1),
(96, 10, 1101, 1, 1, 1, 1, 1),
(97, 10, 1102, 1, 1, 1, 1, 1),
(98, 10, 1103, 1, 1, 1, 1, 1),
(99, 10, 1201, 1, 1, 1, 1, 1),
(100, 10, 1301, 1, 1, 1, 1, 1),
(101, 10, 2000, 1, 1, 1, 1, 1),
(102, 10, 3000, 1, 1, 1, 1, 1),
(103, 10, 5000, 1, 1, 1, 1, 1),
(104, 10, 6000, 1, 1, 1, 1, 1),
(105, 10, 6001, 1, 1, 1, 1, 1),
(106, 10, 6002, 1, 1, 1, 1, 1),
(107, 10, 6003, 1, 1, 1, 1, 1),
(108, 10, 6004, 1, 1, 1, 1, 1),
(109, 10, 6005, 1, 1, 1, 1, 1),
(110, 10, 6006, 1, 1, 1, 1, 1),
(111, 10, 6007, 1, 1, 1, 1, 1),
(112, 10, 6101, 1, 1, 1, 1, 1),
(113, 10, 6102, 1, 1, 1, 1, 1),
(114, 10, 6103, 1, 1, 1, 1, 1),
(115, 10, 6104, 1, 1, 1, 1, 1),
(116, 10, 6105, 1, 1, 1, 1, 1),
(117, 10, 6106, 1, 1, 1, 1, 1),
(118, 10, 6201, 1, 1, 1, 1, 1),
(119, 10, 6202, 1, 1, 1, 1, 1),
(120, 10, 6203, 1, 1, 1, 1, 1),
(121, 10, 6301, 1, 1, 1, 1, 1),
(122, 10, 7000, 1, 1, 1, 1, 1),
(123, 10, 8000, 1, 1, 1, 1, 1),
(124, 11, 1000, 1, 1, 1, 1, 1),
(125, 11, 1001, 1, 1, 1, 1, 1),
(126, 11, 1002, 1, 1, 1, 1, 1),
(127, 11, 1003, 1, 1, 1, 1, 1),
(128, 11, 1004, 1, 1, 1, 1, 1),
(129, 11, 1101, 1, 1, 1, 1, 1),
(130, 11, 1102, 1, 1, 1, 1, 1),
(131, 11, 1103, 1, 1, 1, 1, 1),
(132, 11, 1201, 1, 1, 1, 1, 1),
(133, 11, 1301, 1, 1, 1, 1, 1),
(134, 11, 2000, 1, 1, 1, 1, 1),
(135, 11, 3000, 1, 1, 1, 1, 1),
(136, 11, 5000, 1, 1, 1, 1, 1),
(137, 11, 6000, 1, 1, 1, 1, 1),
(138, 11, 6001, 1, 1, 1, 1, 1),
(139, 11, 6002, 1, 1, 1, 1, 1),
(140, 11, 6003, 1, 1, 1, 1, 1),
(141, 11, 6004, 1, 1, 1, 1, 1),
(142, 11, 6005, 1, 1, 1, 1, 1),
(143, 11, 6006, 1, 1, 1, 1, 1),
(144, 11, 6007, 1, 1, 1, 1, 1),
(145, 11, 6101, 1, 1, 1, 1, 1),
(146, 11, 6102, 1, 1, 1, 1, 1),
(147, 11, 6103, 1, 1, 1, 1, 1),
(148, 11, 6104, 1, 1, 1, 1, 1),
(149, 11, 6105, 1, 1, 1, 1, 1),
(150, 11, 6106, 1, 1, 1, 1, 1),
(151, 11, 6201, 1, 1, 1, 1, 1),
(152, 11, 6202, 1, 1, 1, 1, 1),
(153, 11, 6203, 1, 1, 1, 1, 1),
(154, 11, 6301, 1, 1, 1, 1, 1),
(155, 11, 7000, 1, 1, 1, 1, 1),
(156, 11, 8000, 1, 1, 1, 1, 1),
(157, 12, 1000, 1, 1, 1, 1, 1),
(158, 12, 1001, 1, 1, 1, 1, 1),
(159, 12, 1002, 1, 1, 1, 1, 1),
(160, 12, 1003, 1, 1, 1, 1, 1),
(161, 12, 1004, 1, 1, 1, 1, 1),
(162, 12, 1101, 1, 1, 1, 1, 1),
(163, 12, 1102, 1, 1, 1, 1, 1),
(164, 12, 1103, 1, 1, 1, 1, 1),
(165, 12, 1201, 1, 1, 1, 1, 1),
(166, 12, 1301, 1, 1, 1, 1, 1),
(167, 12, 2000, 1, 1, 1, 1, 1),
(168, 12, 3000, 1, 1, 1, 1, 1),
(169, 12, 5000, 1, 1, 1, 1, 1),
(170, 12, 6000, 1, 1, 1, 1, 1),
(171, 12, 6001, 1, 1, 1, 1, 1),
(172, 12, 6002, 1, 1, 1, 1, 1),
(173, 12, 6003, 1, 1, 1, 1, 1),
(174, 12, 6004, 1, 1, 1, 1, 1),
(175, 12, 6005, 1, 1, 1, 1, 1),
(176, 12, 6006, 1, 1, 1, 1, 1),
(177, 12, 6007, 1, 1, 1, 1, 1),
(178, 12, 6101, 1, 1, 1, 1, 1),
(179, 12, 6102, 1, 1, 1, 1, 1),
(180, 12, 6103, 1, 1, 1, 1, 1),
(181, 12, 6104, 1, 1, 1, 1, 1),
(182, 12, 6105, 1, 1, 1, 1, 1),
(183, 12, 6106, 1, 1, 1, 1, 1),
(184, 12, 6201, 1, 1, 1, 1, 1),
(185, 12, 6202, 1, 1, 1, 1, 1),
(186, 12, 6203, 1, 1, 1, 1, 1),
(187, 12, 6301, 1, 1, 1, 1, 1),
(188, 12, 7000, 1, 1, 1, 1, 1),
(189, 12, 8000, 1, 1, 1, 1, 1),
(190, 13, 1000, 1, 1, 1, 1, 1),
(191, 13, 1001, 1, 1, 1, 1, 1),
(192, 13, 1002, 1, 1, 1, 1, 1),
(193, 13, 1003, 1, 1, 1, 1, 1),
(194, 13, 1004, 1, 1, 1, 1, 1),
(195, 13, 1101, 1, 1, 1, 1, 1),
(196, 13, 1102, 1, 1, 1, 1, 1),
(197, 13, 1103, 1, 1, 1, 1, 1),
(198, 13, 1201, 1, 1, 1, 1, 1),
(199, 13, 1301, 1, 1, 1, 1, 1),
(200, 13, 2000, 1, 1, 1, 1, 1),
(201, 13, 3000, 1, 1, 1, 1, 1),
(202, 13, 5000, 1, 1, 1, 1, 1),
(203, 13, 6000, 1, 1, 1, 1, 1),
(204, 13, 6001, 1, 1, 1, 1, 1),
(205, 13, 6002, 1, 1, 1, 1, 1),
(206, 13, 6003, 1, 1, 1, 1, 1),
(207, 13, 6004, 1, 1, 1, 1, 1),
(208, 13, 6005, 1, 1, 1, 1, 1),
(209, 13, 6006, 1, 1, 1, 1, 1),
(210, 13, 6007, 1, 1, 1, 1, 1),
(211, 13, 6101, 1, 1, 1, 1, 1),
(212, 13, 6102, 1, 1, 1, 1, 1),
(213, 13, 6103, 1, 1, 1, 1, 1),
(214, 13, 6104, 1, 1, 1, 1, 1),
(215, 13, 6105, 1, 1, 1, 1, 1),
(216, 13, 6106, 1, 1, 1, 1, 1),
(217, 13, 6201, 1, 1, 1, 1, 1),
(218, 13, 6202, 1, 1, 1, 1, 1),
(219, 13, 6203, 1, 1, 1, 1, 1),
(220, 13, 6301, 1, 1, 1, 1, 1),
(221, 13, 7000, 1, 1, 1, 1, 1),
(222, 13, 8000, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_regreporteria`
--

CREATE TABLE `tbl_regreporteria` (
  `idregistro` int(11) NOT NULL,
  `ruta` varchar(500) NOT NULL,
  `nombre_archivo` varchar(45) NOT NULL,
  `aplicacion` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `Fk_id_modulos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuarios`
--

CREATE TABLE `tbl_usuarios` (
  `Pk_id_usuario` int(11) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `ultima_conexion_usuario` datetime DEFAULT NULL,
  `estado_usuario` tinyint(4) NOT NULL DEFAULT 0,
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_usuarios`
--

INSERT INTO `tbl_usuarios` (`Pk_id_usuario`, `nombre_usuario`, `apellido_usuario`, `username_usuario`, `password_usuario`, `email_usuario`, `ultima_conexion_usuario`, `estado_usuario`, `pregunta`, `respuesta`) VALUES
(1, 'admin', 'admin', 'admin', '52c88f064ed5ed9161d01f634f5e3bfcf5c77fec94fb398b6690e1b41178eb6c', 'esduardo@gmail.com', '2024-09-21 00:55:40', 1, 'COLOR FAVORITO', 'ROJO'),
(2, 'Ismar', 'Cortez', 'Ismar', 'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f', 'icortezs@miumg.edu.gt', '2024-09-17 17:32:03', 1, 'Nombre de familiar', 'Eunice');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `id_venta` int(11) NOT NULL,
  `monto` int(11) NOT NULL,
  `nombre_cliente` varchar(50) NOT NULL,
  `nombre_empleado` varchar(50) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id_venta`, `monto`, `nombre_cliente`, `nombre_empleado`, `estado`) VALUES
(1, 111, 'Josue', 'David', 1),
(2, 222, 'Fernando', 'David', 1),
(3, 100, 'Josue David', 'Joel Lopez', 1),
(4, 400, 'Sebastian', 'Victor', 1),
(5, 555, 'Brayan', 'Daniel', 1),
(6, 8888, 'pedro', 'perez', 1),
(7, 555, 'roro', 'pablo', 1),
(8, 444, 'shiro', 'rodolfo', 1),
(9, 999, 'Brayan', 'Daniel', 1),
(10, 111, 'shiro', 'sh', 1),
(11, 88, 'lol', 'lol', 1),
(12, 1111, 'lll', 'lll', 1),
(13, 1111, 'www', 'www', 1),
(14, 56456, 'wwww', 'qqq', 1),
(15, 111223, 'hola', 'hol', 1),
(16, 2222, 'yy', 'yyy', 1),
(17, 555, 'ggg', 'ggg', 1),
(18, 100, 'ahora', 'ddd', 1),
(19, 100, 'pedro', 'lucas', 1),
(20, 555, 'cliente', 'empleado', 1),
(21, 200, 'cliente', 'empleado', 1),
(22, 200, 'rrr', 'www', 1),
(23, 333, 'www', 'qqq', 1),
(24, 33, 'eee', 'xxx', 1),
(25, 600, 'ññ', 'lll', 1),
(26, 6456, 'qqq', 'fff', 1),
(27, 555, 'ddd', 'aaa', 1),
(28, 666, 'qqq', 'aaa', 1),
(29, 666, 'cliente', 'empleado', 1),
(30, 888, 'Cliente1', 'Empleado122', 1),
(31, 6666, 'ClientePrueba', 'EmpleadoPrueba', 1),
(32, 6666, 'qq', 'qqq', 1),
(33, 999, 'cliente', 'emple', 1),
(34, 333, 'cli', 'emp', 1),
(35, 65, 'pedro', 'juan', 1),
(36, 65656, 'djf', 'kjk', 1),
(37, 0, '', '', 1),
(38, 0, '', '', 1);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwaplicacionperfil`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwaplicacionperfil` (
`ID` int(11)
,`Perfil` varchar(50)
,`Aplicacion` int(11)
,`Insertar` tinyint(1)
,`Modificar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwaplicacionusuario`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwaplicacionusuario` (
`Aplicacion` int(11)
,`ID` int(11)
,`Usuario` varchar(50)
,`Insertar` tinyint(1)
,`Editar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwmoduloaplicacion`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwmoduloaplicacion` (
`ID` int(11)
,`Modulo` varchar(50)
,`Aplicacion` int(11)
,`Nombre` varchar(50)
,`Descripcion` varchar(150)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwperfilusuario`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwperfilusuario` (
`ID` int(11)
,`Usuario` varchar(50)
,`nickName` varchar(20)
,`perfil` int(11)
,`Nombre` varchar(50)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `vwaplicacionperfil`
--
DROP TABLE IF EXISTS `vwaplicacionperfil`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwaplicacionperfil`  AS SELECT `b`.`Fk_id_perfil` AS `ID`, `a`.`nombre_perfil` AS `Perfil`, `b`.`Fk_id_aplicacion` AS `Aplicacion`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Modificar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisos_aplicacion_perfil` `b` join `tbl_perfiles` `a` on(`a`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwaplicacionusuario`
--
DROP TABLE IF EXISTS `vwaplicacionusuario`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwaplicacionusuario`  AS SELECT `b`.`Fk_id_aplicacion` AS `Aplicacion`, `b`.`Fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Editar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisos_aplicaciones_usuario` `b` join `tbl_usuarios` `a` on(`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwmoduloaplicacion`
--
DROP TABLE IF EXISTS `vwmoduloaplicacion`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwmoduloaplicacion`  AS SELECT `b`.`Fk_id_modulos` AS `ID`, `a`.`nombre_modulo` AS `Modulo`, `b`.`Fk_id_aplicacion` AS `Aplicacion`, `c`.`nombre_aplicacion` AS `Nombre`, `c`.`descripcion_aplicacion` AS `Descripcion` FROM ((`tbl_asignacion_modulo_aplicacion` `b` join `tbl_modulos` `a` on(`a`.`Pk_id_modulos` = `b`.`Fk_id_modulos`)) join `tbl_aplicaciones` `c` on(`c`.`Pk_id_aplicacion` = `b`.`Fk_id_aplicacion`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwperfilusuario`
--
DROP TABLE IF EXISTS `vwperfilusuario`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwperfilusuario`  AS SELECT `b`.`Fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `a`.`username_usuario` AS `nickName`, `b`.`Fk_id_perfil` AS `perfil`, `c`.`nombre_perfil` AS `Nombre` FROM ((`tbl_asignaciones_perfils_usuario` `b` join `tbl_usuarios` `a` on(`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)) join `tbl_perfiles` `c` on(`c`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)) ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ayuda`
--
ALTER TABLE `ayuda`
  ADD PRIMARY KEY (`Id_ayuda`);

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD PRIMARY KEY (`Pk_id_detalle_factura`),
  ADD KEY `fk_id_factura` (`fk_id_factura`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`codigo_empleado`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`Pk_id_factura`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`Pk_id_pago`),
  ADD KEY `fk_id_factura` (`fk_id_factura`);

--
-- Indices de la tabla `perro`
--
ALTER TABLE `perro`
  ADD PRIMARY KEY (`id_perro`),
  ADD KEY `fk_id_raza` (`id_raza`);

--
-- Indices de la tabla `razas`
--
ALTER TABLE `razas`
  ADD PRIMARY KEY (`id_raza`);

--
-- Indices de la tabla `registrocasas`
--
ALTER TABLE `registrocasas`
  ADD PRIMARY KEY (`id_registrocasa`);

--
-- Indices de la tabla `registroperro`
--
ALTER TABLE `registroperro`
  ADD PRIMARY KEY (`id_registroperro`),
  ADD KEY `fk_registroperro_perro` (`id_perro`);

--
-- Indices de la tabla `registro_empleados`
--
ALTER TABLE `registro_empleados`
  ADD PRIMARY KEY (`codigo_registro`),
  ADD KEY `fk_codigo_empleado` (`codigo_empleado`);

--
-- Indices de la tabla `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`id_reserva`);

--
-- Indices de la tabla `tbl_aplicaciones`
--
ALTER TABLE `tbl_aplicaciones`
  ADD PRIMARY KEY (`Pk_id_aplicacion`);

--
-- Indices de la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  ADD PRIMARY KEY (`PK_id_Perfil_Usuario`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`),
  ADD KEY `Fk_id_perfil` (`Fk_id_perfil`);

--
-- Indices de la tabla `tbl_asignacion_modulo_aplicacion`
--
ALTER TABLE `tbl_asignacion_modulo_aplicacion`
  ADD PRIMARY KEY (`Fk_id_modulos`,`Fk_id_aplicacion`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD PRIMARY KEY (`Pk_id_bitacora`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`);

--
-- Indices de la tabla `tbl_consultainteligente`
--
ALTER TABLE `tbl_consultainteligente`
  ADD PRIMARY KEY (`Pk_consultaID`);

--
-- Indices de la tabla `tbl_modulos`
--
ALTER TABLE `tbl_modulos`
  ADD PRIMARY KEY (`Pk_id_modulos`);

--
-- Indices de la tabla `tbl_perfiles`
--
ALTER TABLE `tbl_perfiles`
  ADD PRIMARY KEY (`Pk_id_perfil`);

--
-- Indices de la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  ADD PRIMARY KEY (`PK_id_Aplicacion_Usuario`),
  ADD KEY `Fk_id_usuario` (`Fk_id_usuario`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  ADD PRIMARY KEY (`PK_id_Aplicacion_Perfil`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  ADD KEY `Fk_id_perfil` (`Fk_id_perfil`);

--
-- Indices de la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  ADD PRIMARY KEY (`idregistro`),
  ADD KEY `Fk_id_modulos` (`Fk_id_modulos`),
  ADD KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`);

--
-- Indices de la tabla `tbl_usuarios`
--
ALTER TABLE `tbl_usuarios`
  ADD PRIMARY KEY (`Pk_id_usuario`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id_venta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ayuda`
--
ALTER TABLE `ayuda`
  MODIFY `Id_ayuda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  MODIFY `Pk_id_detalle_factura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `codigo_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123;

--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `Pk_id_factura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `Pk_id_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `registro_empleados`
--
ALTER TABLE `registro_empleados`
  MODIFY `codigo_registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT de la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  MODIFY `PK_id_Perfil_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  MODIFY `Pk_id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=200;

--
-- AUTO_INCREMENT de la tabla `tbl_consultainteligente`
--
ALTER TABLE `tbl_consultainteligente`
  MODIFY `Pk_consultaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `tbl_perfiles`
--
ALTER TABLE `tbl_perfiles`
  MODIFY `Pk_id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  MODIFY `PK_id_Aplicacion_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  MODIFY `PK_id_Aplicacion_Perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=223;

--
-- AUTO_INCREMENT de la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  MODIFY `idregistro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tbl_usuarios`
--
ALTER TABLE `tbl_usuarios`
  MODIFY `Pk_id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `id_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD CONSTRAINT `detallefactura_ibfk_1` FOREIGN KEY (`fk_id_factura`) REFERENCES `factura` (`Pk_id_factura`);

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`fk_id_factura`) REFERENCES `factura` (`Pk_id_factura`);

--
-- Filtros para la tabla `perro`
--
ALTER TABLE `perro`
  ADD CONSTRAINT `fk_id_raza` FOREIGN KEY (`id_raza`) REFERENCES `razas` (`id_raza`);

--
-- Filtros para la tabla `registroperro`
--
ALTER TABLE `registroperro`
  ADD CONSTRAINT `fk_registroperro_perro` FOREIGN KEY (`id_perro`) REFERENCES `perro` (`id_perro`);

--
-- Filtros para la tabla `registro_empleados`
--
ALTER TABLE `registro_empleados`
  ADD CONSTRAINT `fk_codigo_empleado` FOREIGN KEY (`codigo_empleado`) REFERENCES `empleados` (`codigo_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `tbl_asignaciones_perfils_usuario`
--
ALTER TABLE `tbl_asignaciones_perfils_usuario`
  ADD CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  ADD CONSTRAINT `tbl_asignaciones_perfils_usuario_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`);

--
-- Filtros para la tabla `tbl_asignacion_modulo_aplicacion`
--
ALTER TABLE `tbl_asignacion_modulo_aplicacion`
  ADD CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  ADD CONSTRAINT `tbl_asignacion_modulo_aplicacion_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD CONSTRAINT `tbl_bitacora_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`);

--
-- Filtros para la tabla `tbl_permisos_aplicaciones_usuario`
--
ALTER TABLE `tbl_permisos_aplicaciones_usuario`
  ADD CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  ADD CONSTRAINT `tbl_permisos_aplicaciones_usuario_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_permisos_aplicacion_perfil`
--
ALTER TABLE `tbl_permisos_aplicacion_perfil`
  ADD CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_1` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`),
  ADD CONSTRAINT `tbl_permisos_aplicacion_perfil_ibfk_2` FOREIGN KEY (`Fk_id_perfil`) REFERENCES `tbl_perfiles` (`Pk_id_perfil`);

--
-- Filtros para la tabla `tbl_regreporteria`
--
ALTER TABLE `tbl_regreporteria`
  ADD CONSTRAINT `tbl_regreporteria_ibfk_1` FOREIGN KEY (`Fk_id_modulos`) REFERENCES `tbl_modulos` (`Pk_id_modulos`),
  ADD CONSTRAINT `tbl_regreporteria_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
