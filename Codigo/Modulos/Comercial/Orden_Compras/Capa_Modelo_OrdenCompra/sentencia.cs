using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using System.Net;

namespace Capa_Modelo_OrdenCompra
{
    public class sentencia
    {
        conexion cn = new conexion();
        private string idUsuario;

        public sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public sentencia()
        {

        }


        public string[] funllenarCmb(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int i = 0;

            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo1);
            }

            return sCampos;
        }


        public DataTable funobtener(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + ", " + scampo2 + " FROM " + stabla + " WHERE clasificacion = 'Compra'";

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }

        public DataTable funobtener2(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + ", " + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }

        public DataTable funobtener1(string stabla, string scampo1)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }




        public OdbcDataAdapter funProductos()
        {
            cn.conectar();
            string sqlProductos = "SELECT Pk_id_Producto AS Id_Producto, codigoProducto AS Codigo, nombreProducto AS Nombre, pesoProducto AS Peso, precioUnitario AS Precio_Unitario, clasificacion AS Clasificacion, estado AS Estado, stock AS Stock, empaque AS Empaque FROM Tbl_Productos";
            OdbcDataAdapter dataProducto = new OdbcDataAdapter(sqlProductos, cn.conectar());
            return dataProducto;

        }

        public OdbcDataAdapter funProveedores()
        {
            cn.conectar();
            string sqlProveedores = "SELECT Pk_prov_id  AS Id_Proveedor, Prov_nombre AS Nombre, Prov_direccion AS Direccion, Prov_telefono AS Telefono, Prov_email AS email, Prov_fechaRegistro AS Fecha, Prov_estado AS Estado FROM Tbl_proveedores";
            OdbcDataAdapter dataProv = new OdbcDataAdapter(sqlProveedores, cn.conectar());
            return dataProv;
        }







        /*public DataTable funMostrarOrdenesGeneradas(string sTablaOrdenesCompra)
        {
            cn.conectar();
            DataTable dtOrden = new DataTable();
            try
            {
                string sql = @"
                            SELECT 
                        doc.Pk_detOrCom_id AS ID_Detalle,
                        oc.Pk_encOrCom_id AS ID_Encabezado,
                        p.Pk_id_Producto AS Producto,
                        p.precioUnitario AS Precio_Unitario,
                        doc.DetOrCom_cantidad AS Cantidad,
                        doc.DetOrCom_total AS Total
                    FROM 
                        Tbl_detalle_ordenes_compra doc
                    JOIN 
                        Tbl_ordenes_compra oc ON doc.Fk_encOrCom_id = oc.Pk_encOrCom_id
                    JOIN 
                        Tbl_Productos p ON doc.Fk_id_producto = p.Pk_id_Producto;
            ";

                // Crear el adaptador de datos con la conexión
                using (OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar()))
                {
                    dataTable.Fill(dtOrden);
                }

                if (!string.IsNullOrEmpty(sTablaOrdenesCompra))
                {
                    DataView dv = new DataView(dtOrden);
                    dv.RowFilter = $"tipo = '{sTablaOrdenesCompra}'";
                    dtOrden = dv.ToTable();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return null;
            }
            return dtOrden;
        }
        */





        public OdbcDataAdapter funMostrarOrdenCompras()
        {
            cn.conectar();
            // Consulta para obtener usuarios y permisos aplicaciones segun modulos
            string sqlEncabezado = "SELECT doc.PK_encOrCom_numeroOC AS 'NoCompra', " +
                       "pv.Pk_prov_id AS 'IdProveedor', " +
                       "doc.EncOrCom_fechaEntrega AS 'Fecha', " +
                       "doc.total AS 'Total' " +  // Eliminada la coma adicional
                       "FROM Tbl_EncabezadoOrdenCompra doc " +  // Agregado espacio después del nombre de la tabla
                       "JOIN Tbl_proveedores pv ON doc.Fk_prov_id = pv.Pk_prov_id";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlEncabezado, cn.conectar());
            return dataTable;
        }

        private string funObtenerDireccionIPLocal()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "No se pudo determinar la dirección IP local";
        }
        public void funInsertarBitacora(string idUsuario, string sAccion, string sTabla, string sIdAplicacion)
        {
            try
            {
                string sipLocal = funObtenerDireccionIPLocal();
                string snombreHost = Dns.GetHostName();

                using (OdbcConnection conexion = cn.conectar())
                {
                    string obtenerIdUsuarioQuery = "SELECT Pk_id_usuario FROM Tbl_usuarios WHERE username_usuario = ?";
                    OdbcCommand obtenerIdUsuarioCmd = new OdbcCommand(obtenerIdUsuarioQuery, conexion);
                    obtenerIdUsuarioCmd.Parameters.AddWithValue("?", idUsuario);



                    object resultado = obtenerIdUsuarioCmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        string susuario = resultado.ToString();

                        string sconsulta = @"INSERT INTO tbl_bitacora 
                                (Fk_id_usuario, Fk_id_aplicacion, fecha_bitacora, hora_bitacora, host_bitacora, ip_bitacora, accion_bitacora, tabla) 
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(sconsulta, conexion))
                        {
                            cmd.Parameters.AddWithValue("?", susuario);
                            cmd.Parameters.AddWithValue("?", sIdAplicacion);
                            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("HH:mm:ss"));
                            cmd.Parameters.AddWithValue("?", snombreHost);
                            cmd.Parameters.AddWithValue("?", sipLocal);
                            cmd.Parameters.AddWithValue("?", sAccion);
                            cmd.Parameters.AddWithValue("?", sTabla);


                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Registrar la excepción o manejarla apropiadamente
                MessageBox.Show("Error al insertar en la bitácora: " + ex.Message);
            }
        }



        /* public void proinsertarOrdenCompra(string sCodigoDetalle, string sCodigoEncabezado, string sCodigoProducto, string sCantidad, string sPrecioUni, string sTotal)
         {
             try
             {
                 // Crear la conexión y el comando
                 using (OdbcConnection connection = cn.conectar())
                 {
                     string query = "INSERT INTO Tbl_detalle_ordenes_compra (" +
                                    "Pk_detOrCom_id, " +
                                    "Fk_encOrCom_id, " +
                                    "Fk_id_producto, " +
                                    "DetOrCom_cantidad) " +
                                    "DetOrCom_preUni, " +
                                    "DetOrCom_total) " +
                                    "VALUES (?, ?, ?, ?, ?, ?)";

                     using (OdbcCommand cmd = new OdbcCommand(query, connection))
                     {
                         // Agregar los parámetros al comando
                         cmd.Parameters.AddWithValue("@Pk_detOrCom_id", sCodigoDetalle);
                         cmd.Parameters.AddWithValue("@Fk_encOrCom_id", sCodigoEncabezado);
                         cmd.Parameters.AddWithValue("@Fk_id_producto", sCodigoProducto);
                         cmd.Parameters.AddWithValue("@DetOrCom_cantidad", sCantidad);
                         cmd.Parameters.AddWithValue("@DetOrCom_preUni", sPrecioUni);
                         cmd.Parameters.AddWithValue("@DetOrCom_total", sTotal);

                         // Ejecutar el comando
                         cmd.ExecuteNonQuery();

                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al insertar módulo: " + ex.Message);
             }
         }*/


        public string[] funllenarCmb1(string stabla, string scampo)
        {
            conexion cn = new conexion();
            string[] sCampos = new string[300];
            int i = 0;

            // Modificar la consulta para que solo seleccione un campo
            string ssql = "SELECT DISTINCT " + scampo + " FROM " + stabla;

            /* La sentencia consulta el modelo de la base de datos con el campo proporcionado */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(ssql);
                MessageBox.Show(ssql);

                OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Almacenar solo el valor del campo seleccionado
                    sCampos[i] = reader.GetValue(0).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + stabla + "\n -" + scampo);
            }

            return sCampos;
        }

        public DataTable funobtener11(string stabla, string scampo)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt1 = new DataTable();
            adaptador.Fill(dt1);

            return dt1;
        }


        public void proinsertarEncabezadoOrdenCompra(string sNoEncabezado, string sProveedor, DateTime sFecha)
        {
            try
            {
                // Crear la conexión y el comando
                using (OdbcConnection connection = cn.conectar())
                {

                    string query = "INSERT INTO Tbl_EncabezadoOrdenCompra (" +
                        "EncOrCom_numero, " +
                        "Fk_prov_id, " +
                        "EncOrCom_fechaEntrega) " +
                        "VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@EncOrCom_numero", sNoEncabezado);
                        cmd.Parameters.AddWithValue("@Fk_prov_id", sProveedor);
                        cmd.Parameters.AddWithValue("@EncOrCom_fechaEntrega", sFecha);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar módulo: " + ex.Message);
            }
        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public OdbcDataAdapter funConsultarProducto(int CodigoProducto)
        {
            cn.conectar();
            string sqlProducto = "SELECT nombreProducto, costo_compra FROM tbl_productos WHERE codigoProducto = " + CodigoProducto;
            OdbcDataAdapter dataProducto = new OdbcDataAdapter(sqlProducto, cn.conectar());
            //funInsertarBitacora(idUsuario, "Realizó una consulta a producto por ID", "Tbl_Productos", "1000");
            return dataProducto;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public bool InsertarOrdenCompleta(string numeroOC, int proveedorId, DateTime fechaEntrega, decimal total, List<Tuple<string, int, decimal, int, decimal>> detalles)
        {
            using (OdbcConnection connection = cn.conectar())
            {
                try
                {
                    connection.Open();
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        // Insertar en la tabla de encabezado
                        string queryEncabezado = "INSERT INTO Tbl_EncabezadoOrdenCompra (PK_encOrCom_numeroOC, Fk_prov_id, EncOrCom_fechaEntrega, total) VALUES (?, ?, ?, ?)";
                        using (OdbcCommand cmdEncabezado = new OdbcCommand(queryEncabezado, connection, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", numeroOC);
                            cmdEncabezado.Parameters.AddWithValue("?", proveedorId);
                            cmdEncabezado.Parameters.AddWithValue("?", fechaEntrega);
                            cmdEncabezado.Parameters.AddWithValue("?", total);
                            cmdEncabezado.ExecuteNonQuery();
                        }

                        // Insertar en la tabla de detalles
                        string queryDetalle = "INSERT INTO Tbl_DetalleOrdenesCompra (FK_encOrCom_numeroOC, FK_codigoProducto, DetOrCom_precioU, DetOrCom_cantidad, DetOrCom_total) VALUES (?, ?, ?, ?, ?)";
                        foreach (var detalle in detalles)
                        {
                            using (OdbcCommand cmdDetalle = new OdbcCommand(queryDetalle, connection, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("?", numeroOC);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.Item1); // FK_codigoProducto
                                cmdDetalle.Parameters.AddWithValue("?", detalle.Item2); // DetOrCom_precioU
                                cmdDetalle.Parameters.AddWithValue("?", detalle.Item3); // DetOrCom_cantidad
                                cmdDetalle.Parameters.AddWithValue("?", detalle.Item4); // DetOrCom_total
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                        return true; // Inserción exitosa
                    }
                }
                catch (OdbcException ex)
                {
                    LastErrorMessage = ex.Message; // Guardar el mensaje de error
                    return false; // Indica que la operación falló
                }
                catch (Exception ex)
                {
                    LastErrorMessage = ex.Message; // Guardar el mensaje de error
                    return false; // Indica que la operación falló
                }
            }
        }

        public string LastErrorMessage { get; private set; } // Propiedad para almacenar el último mensaje de error

        public bool InsertOrder(string numeroOC, int proveedorId, DateTime fechaEntrega, decimal total, List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles)
        {
            // Comprobamos si hay detalles antes de continuar
            if (detalles.Count == 0)
            {
                Console.WriteLine("No hay detalles para insertar.");
                return false; // Si no hay detalles, retorna false
            }

            using (OdbcConnection conn = cn.conectar())
            {
                if (conn == null)
                {
                    Console.WriteLine("No se pudo abrir la conexión.");
                    return false; // Si la conexión no pudo abrirse, retorna false
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        Console.WriteLine("Conexión abierta, comenzando transacción...");

                        // Insertar encabezado
                        string encabezadoQuery = "INSERT INTO Tbl_EncabezadoOrdenCompra (PK_encOrCom_numeroOC, Fk_prov_id, EncOrCom_fechaEntrega, total) " +
                                                 "VALUES (?, ?, ?, ?)";

                        using (var cmdEncabezado = new OdbcCommand(encabezadoQuery, conn, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", numeroOC);
                            cmdEncabezado.Parameters.AddWithValue("?", proveedorId);
                            cmdEncabezado.Parameters.AddWithValue("?", fechaEntrega);
                            cmdEncabezado.Parameters.AddWithValue("?", total);
                            cmdEncabezado.ExecuteNonQuery();
                        }

                        Console.WriteLine("Encabezado insertado, ahora insertando detalles...");

                        // Insertar detalles
                        string detalleQuery = "INSERT INTO Tbl_DetalleOrdenesCompra (FK_encOrCom_numeroOC, FK_codigoProducto, DetOrCom_precioU, DetOrCom_cantidad, DetOrCom_total) " +
                                              "VALUES (?, ?, ?, ?, ?)";

                        foreach (var detalle in detalles)
                        {
                            using (var cmdDetalle = new OdbcCommand(detalleQuery, conn, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("?", numeroOC);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.codigoProducto);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.precioU);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.cantidad);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.totalDetalle);
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        Console.WriteLine("Detalles insertados, confirmando transacción...");

                        // Si todo es exitoso, confirmar la transacción
                        transaction.Commit();
                        return true; // Inserción exitosa
                    }
                    catch (OdbcException ex)
                    {
                        LastErrorMessage = ex.Message; // Capturar el mensaje de error
                        Console.WriteLine("Error ODBC: " + LastErrorMessage);
                        transaction.Rollback(); // Deshacer la transacción
                        return false; // La inserción falló
                    }
                    catch (Exception ex)
                    {
                        LastErrorMessage = ex.Message; // Capturar el mensaje de error
                        Console.WriteLine("Error genérico: " + LastErrorMessage);
                        transaction.Rollback(); // Deshacer la transacción
                        return false; // La inserción falló
                    }
                }
            }
        }



        public bool EliminarOrden(string numeroOC)
        {
            using (OdbcConnection conn = cn.conectar())
            {
                if (conn == null)
                {
                    Console.WriteLine("No se pudo abrir la conexión.");
                    return false; // Si la conexión no pudo abrirse, retorna false
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        Console.WriteLine("Conexión abierta, comenzando transacción para eliminar...");

                        // Eliminar detalles de la orden de compra
                        string detalleQuery = "DELETE FROM Tbl_DetalleOrdenesCompra WHERE FK_encOrCom_numeroOC = ?";
                        using (var cmdDetalle = new OdbcCommand(detalleQuery, conn, transaction))
                        {
                            cmdDetalle.Parameters.AddWithValue("?", numeroOC);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        Console.WriteLine("Detalles eliminados, ahora eliminando encabezado...");

                        // Eliminar encabezado de la orden de compra
                        string encabezadoQuery = "DELETE FROM Tbl_EncabezadoOrdenCompra WHERE PK_encOrCom_numeroOC = ?";
                        using (var cmdEncabezado = new OdbcCommand(encabezadoQuery, conn, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", numeroOC);
                            cmdEncabezado.ExecuteNonQuery();
                        }

                        Console.WriteLine("Encabezado eliminado, confirmando transacción...");

                        // Si todo es exitoso, confirmar la transacción
                        transaction.Commit();
                        return true; // Eliminación exitosa
                    }
                    catch (OdbcException ex)
                    {
                        LastErrorMessage = ex.Message; // Capturar el mensaje de error
                        Console.WriteLine("Error ODBC: " + LastErrorMessage);
                        transaction.Rollback(); // Deshacer la transacción
                        return false; // La eliminación falló
                    }
                    catch (Exception ex)
                    {
                        LastErrorMessage = ex.Message; // Capturar el mensaje de error
                        Console.WriteLine("Error genérico: " + LastErrorMessage);
                        transaction.Rollback(); // Deshacer la transacción
                        funInsertarBitacora(idUsuario, "Realizo una eliminacion de orden de compra", "Tbl_detalle_ordenes_compra;", "3000");

                        return false; // La eliminación falló

                       
                    }
                }
            }
        }



        public bool ActualizarOrdenDetalle(string numeroOC, decimal nuevoTotal, List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles)
        {
            // Comprobamos si hay detalles antes de continuar
            if (detalles.Count == 0)
            {
                Console.WriteLine("No hay detalles para actualizar.");
                return false;
            }

            using (OdbcConnection conn = cn.conectar())
            {
                if (conn == null)
                {
                    Console.WriteLine("No se pudo abrir la conexión.");
                    return false;
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Actualizar solo el precio (total) en el encabezado
                        string encabezadoQuery = "UPDATE Tbl_EncabezadoOrdenCompra " +
                                                 "SET total = ? " +
                                                 "WHERE PK_encOrCom_numeroOC = ?";

                        using (var cmdEncabezado = new OdbcCommand(encabezadoQuery, conn, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", nuevoTotal);
                            cmdEncabezado.Parameters.AddWithValue("?", numeroOC);
                            cmdEncabezado.ExecuteNonQuery();
                        }

                        // Eliminar los detalles existentes de la orden de compra
                        string deleteDetallesQuery = "DELETE FROM Tbl_DetalleOrdenesCompra WHERE FK_encOrCom_numeroOC = ?";
                        using (var cmdEliminarDetalles = new OdbcCommand(deleteDetallesQuery, conn, transaction))
                        {
                            cmdEliminarDetalles.Parameters.AddWithValue("?", numeroOC);
                            cmdEliminarDetalles.ExecuteNonQuery();
                        }

                        // Insertar los nuevos detalles
                        string detalleQuery = "INSERT INTO Tbl_DetalleOrdenesCompra (FK_encOrCom_numeroOC, FK_codigoProducto, DetOrCom_precioU, DetOrCom_cantidad, DetOrCom_total) " +
                                              "VALUES (?, ?, ?, ?, ?)";

                        foreach (var detalle in detalles)
                        {
                            using (var cmdDetalle = new OdbcCommand(detalleQuery, conn, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("?", numeroOC);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.codigoProducto);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.precioU);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.cantidad);
                                cmdDetalle.Parameters.AddWithValue("?", detalle.totalDetalle);
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                        return true;
                    }
                    catch (OdbcException ex)
                    {
                        // Verificar si el error es por duplicado
                        if (ex.Message.Contains("Duplicate entry"))
                        {
                            Console.WriteLine("No se puede actualizar porque ya existe un registro con el mismo código de producto.");
                        }
                        else
                        {
                            Console.WriteLine("Error al actualizar la orden de compra.");
                        }

                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error al actualizar la orden de compra.");
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable ObtenerEncabezadoPorNumeroCompra(string noCompra)
        {
            DataTable encabezadoData = new DataTable();
            string query = "SELECT Fk_prov_id AS idProveedor, Fecha, Total " +
                           "FROM Tbl_EncabezadoOrdenCompra " +
                           "WHERE PK_encOrCom_numeroOC = ?";

            try
            {
                using (OdbcConnection conexion = cn.conectar()) // cn es la instancia de conexión
                {
                    using (OdbcCommand comando = new OdbcCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", noCompra);

                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(comando))
                        {
                            adapter.Fill(encabezadoData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el encabezado de la orden: " + ex.Message);
            }

            return encabezadoData;
        }


        public DataTable CargarDetalles(string noCompra)
        {
            cn.conectar();
            DataTable tableDetalles = new DataTable(); // Crear un DataTable para almacenar los resultados

            try
            {
                string sqlDetalles = "SELECT FK_codigoProducto, DetOrCom_precioU, DetOrCom_cantidad, DetOrCom_total " +
                                     "FROM Tbl_DetalleOrdenesCompra " +
                                     "WHERE FK_encOrCom_numeroOC = ?";

                using (OdbcConnection conexion = cn.conectar())
                {
                    using (OdbcCommand comando = new OdbcCommand(sqlDetalles, conexion))
                    {
                        comando.Parameters.AddWithValue("?", noCompra);

                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(comando))
                        {
                            adapter.Fill(tableDetalles); // Llenar el DataTable con los resultados
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null; // Retornar null en caso de error
            }

            return tableDetalles; // Retornar el DataTable con los detalles
        }



        public bool GetOrder(string numeroOC, out int proveedorId, out DateTime fechaEntrega, out decimal total, out List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles)
        {
            proveedorId = 0;
            fechaEntrega = DateTime.MinValue;
            total = 0;
            detalles = new List<(int, decimal, int, decimal)>();

            using (OdbcConnection conn = cn.conectar())
            {
                if (conn == null)
                {
                    Console.WriteLine("No se pudo abrir la conexión.");
                    return false;
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Consulta de encabezado
                        string encabezadoQuery = "SELECT Fk_prov_id, EncOrCom_fechaEntrega, total FROM Tbl_EncabezadoOrdenCompra WHERE PK_encOrCom_numeroOC = ?";
                        using (var cmdEncabezado = new OdbcCommand(encabezadoQuery, conn, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", numeroOC);
                            using (var reader = cmdEncabezado.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    proveedorId = reader.GetInt32(0);
                                    fechaEntrega = reader.GetDateTime(1);
                                    total = reader.GetDecimal(2);
                                }
                                else
                                {
                                    return false; // No se encontró la orden
                                }
                            }
                        }

                        // Consulta de detalles
                        string detalleQuery = "SELECT FK_codigoProducto, DetOrCom_precioU, DetOrCom_cantidad, DetOrCom_total FROM Tbl_DetalleOrdenesCompra WHERE FK_encOrCom_numeroOC = ?";
                        using (var cmdDetalle = new OdbcCommand(detalleQuery, conn, transaction))
                        {
                            cmdDetalle.Parameters.AddWithValue("?", numeroOC);
                            using (var reader = cmdDetalle.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var detalle = (
                                        codigoProducto: reader.GetInt32(0),
                                        precioU: reader.GetDecimal(1),
                                        cantidad: reader.GetInt32(2),
                                        totalDetalle: reader.GetDecimal(3)
                                    );
                                    detalles.Add(detalle); // Agregar el objeto detalle a la lista
                                }
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public bool ActualizarStock(int codigoProducto, int cantidad)
        {
            try
            {
                // Verificar si el producto existe antes de intentar actualizar el stock
                string consultaProductoQuery = "SELECT COUNT(*) FROM Tbl_Productos WHERE CodigoProducto = ?";
                using (OdbcConnection conn = cn.conectar()) // Establecer la conexión con la base de datos
                {
                    using (OdbcCommand cmdConsultaProducto = new OdbcCommand(consultaProductoQuery, conn))
                    {
                        cmdConsultaProducto.Parameters.AddWithValue("?", codigoProducto); // Parámetro para el código del producto
                        int productoExistente = Convert.ToInt32(cmdConsultaProducto.ExecuteScalar()); // Verificar si el producto existe

                        if (productoExistente == 0)
                        {
                            Console.WriteLine("El producto no existe.");
                            return false; // Si el producto no existe, no actualizar
                        }
                    }

                    // Actualizar el stock del producto
                    string sql = "UPDATE Tbl_Productos SET Stock = Stock + ? WHERE CodigoProducto = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", cantidad); // Parámetro para la cantidad
                        cmd.Parameters.AddWithValue("?", codigoProducto); // Parámetro para el código del producto

                        // Ejecutar la actualización
                        int filasAfectadas = cmd.ExecuteNonQuery(); // Ejecutar la consulta de actualización

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Stock actualizado correctamente.");
                            return true; // El stock se actualizó correctamente
                        }
                        else
                        {
                            Console.WriteLine("No se pudo actualizar el stock.");
                            return false; // Si no se pudo actualizar
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el stock: " + ex.Message);
                return false; // En caso de error, se captura la excepción
            }
        }



        public bool ActualizarDeudaProveedor(int proveedorId, decimal totalOrden)
        {
            try
            {
                // Consulta para actualizar la deuda del proveedor sumando el total de la orden
                string sql = "UPDATE Tbl_proveedores SET Proveedor_deuda = Proveedor_deuda + ? WHERE Pk_prov_id = ?";

                using (OdbcConnection conn = cn.conectar())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        // Añadir parámetros: total de la orden y el ID del proveedor
                        cmd.Parameters.AddWithValue("?", totalOrden);
                        cmd.Parameters.AddWithValue("?", proveedorId);

                        // Ejecutar la actualización
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine($"Deuda del proveedor {proveedorId} actualizada correctamente.");
                            return true; // La deuda se actualizó correctamente
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró el proveedor con ID {proveedorId} o no se actualizó la deuda.");
                            return false; // Si no se encontró el proveedor o no se pudo actualizar
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la deuda del proveedor: {ex.Message}");
                return false;
            }
        }





        public bool GuardarCompraRealizada(string numeroOC, int proveedorId, DateTime fechaCompra, decimal totalCompra, int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)
        {
            using (OdbcConnection conn = cn.conectar()) // Aquí se establece la conexión con la base de datos
            {
                try
                {
                    // Definimos la consulta SQL para insertar la compra
                    string insertCompraQuery = @"
                INSERT INTO Tbl_ComprasRealizadas 
                (PK_noCompra, Fk_prov_id, CR_FechaCompra, CR_TotalCompra, CR_CodigoProducto, CR_PrecioU, CR_Cantidad, CR_TotalDetalle)
                VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                    // Creamos el comando OdbcCommand con la consulta y la conexión
                    using (OdbcCommand cmdCompra = new OdbcCommand(insertCompraQuery, conn))
                    {
                        // Añadimos los parámetros a la consulta SQL
                        cmdCompra.Parameters.AddWithValue("?", numeroOC);
                        cmdCompra.Parameters.AddWithValue("?", proveedorId);
                        cmdCompra.Parameters.AddWithValue("?", fechaCompra);
                        cmdCompra.Parameters.AddWithValue("?", totalCompra);
                        cmdCompra.Parameters.AddWithValue("?", codigoProducto);
                        cmdCompra.Parameters.AddWithValue("?", precioU);
                        cmdCompra.Parameters.AddWithValue("?", cantidad);
                        cmdCompra.Parameters.AddWithValue("?", totalDetalle);

                        // Ejecutamos la consulta para insertar los datos

                        int rowsAffected = cmdCompra.ExecuteNonQuery();
                        

                        // Verificamos si se insertaron filas (rowsAffected > 0)
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Compra guardada correctamente.");
                            funInsertarBitacora(idUsuario, "Realizo una compra", "Tbl_ComprasRealizadas;", "3000");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se pudo guardar la compra.");
                            return false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar la compra: " + ex.Message);
                    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                    return false;
                }
                finally
                {
                    // Cerrar la conexión explícitamente
                    conn.Close();
                }
            }
        }







        public int BuscarStockProducto(int codigoProducto)
        {
            int stock = 0;

            try
            {
                string sql = "SELECT stock FROM tbl_productos WHERE codigoProducto = ?";
                using (OdbcConnection conn = cn.conectar())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", codigoProducto);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            stock = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarStockProducto: " + ex.Message);
            }

            return stock;
        }


        public DataTable BuscarProveedorPorId(int idProveedor)
        {
            DataTable tableProveedor = new DataTable();
            try
            {
                string sql = "SELECT Pk_prov_id, Prov_nombre FROM Tbl_proveedores WHERE Pk_prov_id = ?";
                using (OdbcConnection conn = cn.conectar())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idProveedor);
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                        {
                            adapter.Fill(tableProveedor); // Llena el DataTable
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarProveedorPorId: " + ex.Message);
            }
            return tableProveedor; // Retorna el DataTable con los datos
        }



            // Método para eliminar el detalle de la orden de compra
            public bool EliminarDetalleCompra(string numeroOC, int codigoProducto)
            {
                OdbcConnection conn = null;

                try
                {
                    // Obtener la conexión desde la clase 'conexion'
                    conn = cn.conectar();  // Aquí se utiliza la función de la clase conexion

                    if (conn == null)
                    {
                        // Si la conexión no se pudo abrir, devolver false
                        MessageBox.Show("No se pudo abrir la conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Eliminar el detalle de la base de datos
                    string query = "DELETE FROM Tbl_DetalleOrdenesCompra WHERE FK_encOrCom_numeroOC = ? AND FK_codigoProducto = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", numeroOC);
                        cmd.Parameters.AddWithValue("?", codigoProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            // Si se eliminó con éxito, devolver true
                            return true;
                        }
                        else
                        {
                            // Si no se eliminó ninguna fila, devolver false
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir
                    MessageBox.Show("Error al eliminar detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    // Asegurarse de que la conexión se cierre
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();  // Cerrar la conexión si está abierta
                    }
                }
            }
        }
   
}

