using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;


namespace Capa_Modelo_Logistica
{
    public class Sentencias
    {
        string sTabla_chofer = "Tbl_chofer";
        Conexion con = new Conexion();

        // Método para cargar las existencias de una bodega en particular (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            OdbcDataReader dr = null;
            OdbcConnection conn = con.conexion(); // Mover la conexión aquí

            try
            {
                string query = $"SELECT * FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = '{idBodega}'";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener existencias: " + ex.Message);
                dr = null; // Asegurarse de que dr sea null en caso de error
            }

            // La conexión se cerrará cuando el DataReader haya sido cerrado en el controlador
            return dr;
        }



        // Método para insertar una auditoría de inventario (Realizado por Daniel Sierra 0901-21-12740)
        public void InsertarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            OdbcConnection conn = con.conexion();
            try
            {
                string query = "INSERT INTO Auditorias (BodegaID, ProductoID, CantidadFisica, CantidadRegistrada, Discrepancia) VALUES (?, ?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@BodegaID", idBodega);
                cmd.Parameters.AddWithValue("@ProductoID", idProducto);
                cmd.Parameters.AddWithValue("@CantidadFisica", cantidadFisica);
                cmd.Parameters.AddWithValue("@CantidadRegistrada", cantidadRegistrada);
                cmd.Parameters.AddWithValue("@Discrepancia", discrepancia);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar auditoría: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Asegurarse de cerrar la conexión
                }
            }
        }


        public void InsertarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            OdbcConnection conn = con.conexion();
            try
            {
                string query = "INSERT INTO tbl_mantenimiento VALUES (Pk_id_Mantenimiento, nombre_Solicitante, tipo_de_Mantenimiento, componente_Afectado, fecha, responsable_Asignado, codigo_Error_Problema, Estado, tiempo_Estimado, Fk_id_movimiento)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pk_id_Mantenimiento", idMantenimiento);
                cmd.Parameters.AddWithValue("@nombre_Solicitante", nombreSolicitante);
                cmd.Parameters.AddWithValue("@tipo_de_mantenimiento", tipoMantenimiento);
                cmd.Parameters.AddWithValue("@componente_Afectado", componenteAfectado);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@responsable_Asignado", responsableAsignado);
                cmd.Parameters.AddWithValue("@codigo_Error_Problema", codigo_error_Problema);
                cmd.Parameters.AddWithValue("@Estado", estadoMantenimiento);
                cmd.Parameters.AddWithValue("@tiempo_Estimado", tiempoEstimado);
                cmd.Parameters.AddWithValue("@Fk_id_movimiento", id_Movimiento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar solicitud de mantenimiento: " + ex.Message);

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Asegurarse de cerrar la conexión
                }
            }
        }
        // Método para obtener Bodegas en la tabla (Realizado por Daniel Sierra 0901-21-12740)

        public List<KeyValuePair<int, string>> GetBodegas()
        {
            string sQuery = "SELECT Pk_ID_BODEGA, NOMBRE_BODEGA FROM TBL_BODEGAS;";
            List<KeyValuePair<int, string>> bodegas = new List<KeyValuePair<int, string>>();

            using (OdbcConnection conn = con.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        int idBodega = Convert.ToInt32(row["Pk_ID_BODEGA"]);
                        string nombreBodega = row["NOMBRE_BODEGA"].ToString();
                        bodegas.Add(new KeyValuePair<int, string>(idBodega, nombreBodega));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla TBL_BODEGAS");
                }
            }

            return bodegas;
        }
        // Método para obtener Productos en la tabla (Realizado por Daniel Sierra 0901-21-12740)

        public List<KeyValuePair<int, string>> GetProductos()
        {
            string sQuery = "SELECT Pk_id_Producto, nombreProducto FROM Tbl_Productos;";
            List<KeyValuePair<int, string>> productos = new List<KeyValuePair<int, string>>();

            using (OdbcConnection conn = con.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        int idProducto = Convert.ToInt32(row["Pk_id_Producto"]);
                        string nombreProducto = row["nombreProducto"].ToString();
                        productos.Add(new KeyValuePair<int, string>(idProducto, nombreProducto));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla Tbl_Productos");
                }
            }

            return productos;
        }

        public List<string> GetProductosPorBodega(string idBodega)
        {
            string sQuery = $"SELECT Pk_ID_PRODUCTO, NOMBRE_PRODUCTO FROM Tbl_Productos WHERE Fk_ID_BODEGA = '{idBodega}';"; // Asegúrate de que esta consulta sea correcta según tu esquema
            List<string> productos = new List<string>();

            using (OdbcConnection conn = con.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        productos.Add(row["NOMBRE_PRODUCTO"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla Tbl_Productos");
                }
            }

            return productos;
        }
        // Método para insertar auditorías (Realizado por José daniel sierra cruz)

        public string InsertarAuditoria(int idBodega, int idProducto, DateTime fechaAuditoria, string observaciones, int cantidadRegistrada, int cantidadFisica, bool discrepancia)
        {
            using (OdbcConnection conn = con.conexion())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO TBL_AUDITORIAS (Fk_ID_BODEGA, Fk_ID_PRODUCTO, FECHA_AUDITORIA, OBSERVACIONES, CANTIDAD_REGISTRADA, CANTIDAD_FISICA, DISCREPANCIA_DETECTADA) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        // Establecer los parámetros
                        cmd.Parameters.AddWithValue("?", idBodega);
                        cmd.Parameters.AddWithValue("?", idProducto);
                        cmd.Parameters.AddWithValue("?", fechaAuditoria);
                        cmd.Parameters.AddWithValue("?", observaciones);
                        cmd.Parameters.AddWithValue("?", cantidadRegistrada);
                        cmd.Parameters.AddWithValue("?", cantidadFisica);
                        cmd.Parameters.AddWithValue("?", discrepancia);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0 ? "Auditoría realizada con éxito" : "No se insertaron registros en la auditoría.";
                    }
                }
                catch (OdbcException ex)
                {
                    return "Error al realizar auditoría: " + ex.Message;
                }
                catch (Exception ex)
                {
                    return "Error inesperado: " + ex.Message;
                }
            }
        }

        // Método para obtener auditorías (Realizado por José daniel sierra cruz)
        public DataTable ObtenerAuditorias()
        {
            DataTable dtAuditorias = new DataTable();

            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    string query = "SELECT * FROM TBL_AUDITORIAS";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(dtAuditorias); // Llenar el DataTable con los datos de auditorías
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener auditorías: " + ex.Message);
            }

            return dtAuditorias;
        }


        // Realizado  Metodo de ingreso de chofer por Ammy Patricia Catún López - 0901-21-4857
        public void registrarChofer(string id_chofer, string nombreEmp, string numeroIdent, string nombre, string licencia, string telefono, string direccion)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                int ingreso = 0;
                string sCampos = "Pk_id_chofer, nombreEmpresa, numeroIdentificacion, nombre, licencia, telefono, direccion";
                string sSql = "INSERT INTO " + sTabla_chofer + " (" + sCampos + ") VALUES ('" + id_chofer + "', '" + nombreEmp + "', '" + numeroIdent + "', '" + nombre + "', '" + licencia + "', '" + telefono + "', '" + direccion + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, con.conexion());
                ingreso = cmd.ExecuteNonQuery();
                if (ingreso > 0)
                {
                    MessageBox.Show("Datos Ingresados Correctamente");
                }
                else
                {
                    MessageBox.Show("Datos No Ingresados Correctamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_chofer);
            }
        }
        public int getMaxIdChofer()
        {
            int iIdRegistro = 0;
            string sSql = "SELECT max(Pk_id_chofer) FROM " + sTabla_chofer + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, con.conexion());
                iIdRegistro = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_chofer);
            }
            return iIdRegistro;
        }


        // Boton eliminado de chofer realizado por Ammy Patricia Catún López - 0901-21-4857
        public void eliminarChofer(string idChofer)
        {
            try
            {
                string sSql = "DELETE FROM " + sTabla_chofer + " WHERE Pk_id_chofer = '" + idChofer + "';";
                OdbcCommand cmd = new OdbcCommand(sSql, con.conexion());
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Chofer eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el chofer para eliminar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo eliminar el registro en la tabla " + sTabla_chofer);
            }
        }
        //Metodo de modificar chofer realizado por Ammy Patricia Catún López - 0901-21-4857
        public void modificarChofer(string idChofer, string nombreEmp, string numeroIdent, string nombre, string licencia, string telefono, string direccion)
        {
            try
            {
                string sSql = "UPDATE " + sTabla_chofer + " SET nombreEmpresa = @nombreEmp, numeroIdentificacion = @numeroIdent, nombre = @nombre, licencia = @licencia, telefono = @telefono, direccion = @direccion WHERE Pk_id_chofer = @idChofer;";

                using (OdbcCommand cmd = new OdbcCommand(sSql, con.conexion()))
                {
                    cmd.Parameters.AddWithValue("@idChofer", idChofer);
                    cmd.Parameters.AddWithValue("@nombreEmp", nombreEmp);
                    cmd.Parameters.AddWithValue("@numeroIdent", numeroIdent);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@licencia", licencia);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);

                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Chofer modificado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el chofer para modificar.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo modificar el registro en la tabla " + sTabla_chofer);
            }
        }


        //Metodo de buscar chofer realizado por Ammy Patricia Catún López - 0901-21-4857
        public DataTable buscarChofer(string idChofer)
        {
            DataTable dt = new DataTable();
            try
            {
                string sSql = "SELECT * FROM " + sTabla_chofer + " WHERE Pk_id_chofer = @idChofer;";
                using (OdbcCommand cmd = new OdbcCommand(sSql, con.conexion()))
                {
                    cmd.Parameters.AddWithValue("@idChofer", idChofer);
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo buscar el registro en la tabla " + sTabla_chofer);
            }
            return dt;
        }
        public DataTable cargarChoferes()
        {
            DataTable dt = new DataTable();
            try
            {
                string sSql = "SELECT * FROM " + sTabla_chofer + ";";
                using (OdbcCommand cmd = new OdbcCommand(sSql, con.conexion()))
                {
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo cargar los choferes desde la tabla " + sTabla_chofer);
            }
            return dt;
        }

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------
        public string[] llenarCmbCuentas(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }

            return Campos;
        }

        public DataTable obtenerCuentas(string tabla, string campo1, string campo2)
        {
            try
            {
                using (OdbcConnection conexion = con.conexion())
                {
                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open(); // Asegúrate de abrir la conexión
                    }

                    string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(sql, conexion);
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Verificar si la tabla tiene datos
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, muestra el mensaje de error
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }

        // ---------------------------------- COMBO BOX TIPO POLIZA ----------------------------------

        public string[] llenarCmbTP(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }

            return Campos;
        }

        public DataTable obtenerTP(string tabla, string campo1, string campo2)
        {
            try
            {
                using (OdbcConnection conexion = con.conexion())
                {
                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open(); // Asegúrate de abrir la conexión
                    }

                    string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(sql, conexion);
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Verificar si la tabla tiene datos
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, muestra el mensaje de error
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public string[] llenarCmbOP(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }

            return Campos;
        }

        public DataTable obtenerOP(string tabla, string campo1, string campo2)
        {
            try
            {
                using (OdbcConnection conexion = con.conexion())
                {
                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open(); // Asegúrate de abrir la conexión
                    }

                    string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(sql, conexion);
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Verificar si la tabla tiene datos
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, muestra el mensaje de error
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }

        public void ActulizarCuentas(int idCuenta, string tipoOperacion, decimal valor)
        {
            //Obtener las variables a llenar
            decimal cargoMesActual = 0;
            decimal abonoMesActual = 0;
            decimal saldoActual = 0;
            int? idCuentaEnlace = null;  // Aquí se lee la cuanta padre

            string consulta = "SELECT cargo_mes, abono_mes, saldo_act, Pk_id_cuenta_enlace FROM tbl_cuentas WHERE Pk_id_cuenta = ?";
            try
            {
                using (OdbcCommand cmdSelect = new OdbcCommand(consulta, con.conexion()))
                {
                    cmdSelect.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);

                    using (OdbcDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los valores actuales de la base de datos
                            cargoMesActual = Convert.ToDecimal(reader["cargo_mes"]);
                            abonoMesActual = Convert.ToDecimal(reader["abono_mes"]);
                            saldoActual = Convert.ToDecimal(reader["saldo_act"]);

                            //Obtiene la cuenta padre 
                            idCuentaEnlace = reader["Pk_id_cuenta_enlace"] != DBNull.Value
                                ? (int?)Convert.ToInt32(reader["Pk_id_cuenta_enlace"])
                                : null;
                        }
                    }
                }

                //Condicion para sumar cargo o en abono.
                if (tipoOperacion == "Cargo")
                {
                    cargoMesActual += valor; // Sumar el valor al cargo mensual
                }
                else if (tipoOperacion == "Abono")
                {
                    abonoMesActual += valor; // Sumar el valor al abono mensual
                }

                //Calculo del saldo actual
                saldoActual = cargoMesActual - abonoMesActual;

                //Integrar los datos dentro de la base de datos.
                string updateQuery = @"UPDATE tbl_cuentas SET cargo_mes = ?, abono_mes = ?, saldo_act = ? WHERE Pk_id_cuenta = ?";

                using (OdbcCommand cmdUpdate = new OdbcCommand(updateQuery, con.conexion()))
                {
                    cmdUpdate.Parameters.AddWithValue("@cargo_mes", cargoMesActual);
                    cmdUpdate.Parameters.AddWithValue("@abono_mes", abonoMesActual);
                    cmdUpdate.Parameters.AddWithValue("@saldo_act", saldoActual);
                    cmdUpdate.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);

                    cmdUpdate.ExecuteNonQuery();
                }

                //AQUI COMIENZA LA MAGIA -  Si en caso la variable idCuentaEnlace no es nulo repite esta función
                if (idCuentaEnlace.HasValue)
                {
                    ActulizarCuentas(idCuentaEnlace.Value, tipoOperacion, valor);
                }

                ActualizarHistorico(idCuenta, valor, tipoOperacion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void LlenarEncabezado(string fechaSeleccionada, string concepto, int tipoPoli)
        {
            int idtipopoliza = tipoPoli; // ID del tipo de póliza
            string fecha = fechaSeleccionada; // Fecha de la póliza
            string cnp = concepto; // Concepto de la póliza

            using (OdbcConnection conexion = con.conexion())
            {
                // Se crea una transacción
                using (OdbcTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Insertar en tbl_polizaencabezado y obtener el ID UNA SOLA VEZ
                        string insertEncabezado = @"INSERT INTO tbl_polizaencabezado(fechaPoliza, concepto, Pk_id_tipopoliza) VALUES(?, ?, ?) ON DUPLICATE KEY UPDATE concepto = VALUES(concepto);";

                        using (OdbcCommand cmdEncabezado = new OdbcCommand(insertEncabezado, conexion, transaction))
                        {
                            /*cmdEncabezado.Parameters.Add("@fechaPoliza", OdbcType.VarChar).Value = fecha;
                            cmdEncabezado.Parameters.Add("@concepto", OdbcType.VarChar).Value = cnp;
                            cmdEncabezado.Parameters.Add("@Pk_id_tipopoliza", OdbcType.Int).Value = idtipopoliza;*/

                            cmdEncabezado.Parameters.AddWithValue("@fechaPoliza", fecha);
                            cmdEncabezado.Parameters.AddWithValue("@concepto", cnp);
                            cmdEncabezado.Parameters.AddWithValue("@Pk_id_tipopoliza", idtipopoliza);

                            // Ejecutar la inserción del encabezado SOLO UNA VEZ
                            cmdEncabezado.ExecuteNonQuery();
                        }

                        // Confirmar la transacción si todo sale bien
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                    }
                }
            }

        }

        public void LlenarDetalle(string fechaSeleccionada, string concepto, List<object[]> detalles)
        {
            int nuevoIdEncabezado;
            string cnp = concepto; // Concepto de la póliza

            using (OdbcConnection conexion = con.conexion())
            {
                // Se crea una transacción
                using (OdbcTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Obtener el último ID insertado
                        string lastIdQuery = @"SELECT Pk_id_polizaencabezado FROM tbl_polizaencabezado WHERE concepto = ? ORDER BY Pk_id_polizaencabezado DESC LIMIT 1;";

                        using (OdbcCommand cmdLastId = new OdbcCommand(lastIdQuery, conexion, transaction))
                        {
                            cmdLastId.Parameters.AddWithValue("?", cnp);
                            nuevoIdEncabezado = Convert.ToInt32(cmdLastId.ExecuteScalar());
                        }

                        // Insertar en tbl_polizadetalle usando el ID del encabezado
                        string insertDetalle = @"INSERT INTO tbl_polizadetalle (Pk_id_polizaencabezado, Pk_id_cuenta, Pk_id_tipooperacion, valor) VALUES (?, ?, ?, ?)";
                        string checkDetalleExists = @"SELECT COUNT(*) FROM tbl_polizadetalle WHERE Pk_id_polizaencabezado = ? AND Pk_id_cuenta = ? AND Pk_id_tipooperacion = ?";

                        foreach (var detalle in detalles)
                        {
                            // Verificar si ya existe el registro en tbl_polizadetalle
                            using (OdbcCommand cmdCheck = new OdbcCommand(checkDetalleExists, conexion, transaction))
                            {
                                cmdCheck.Parameters.AddWithValue("?", nuevoIdEncabezado);
                                cmdCheck.Parameters.AddWithValue("?", detalle[0]);
                                cmdCheck.Parameters.AddWithValue("?", detalle[1]);

                                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                                if (count > 0)
                                {
                                    // Si ya existe, simplemente continúa a la siguiente iteración
                                    continue; // Salta a la siguiente iteración si ya existe
                                }
                            }

                            // Si no existe, proceder a insertar
                            using (OdbcCommand cmdDetalle = new OdbcCommand(insertDetalle, conexion, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("?", nuevoIdEncabezado);
                                cmdDetalle.Parameters.AddWithValue("?", detalle[0]);
                                cmdDetalle.Parameters.AddWithValue("?", detalle[1]);
                                cmdDetalle.Parameters.AddWithValue("?", detalle[2]);

                                // Ejecutar la inserción
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                    }
                }
            }


        }

        public void ActualizarHistorico(int idCuenta, decimal val, string tipoOperacion)
        {
            int mesActual = DateTime.Now.Month;
            int anioActual = DateTime.Now.Year;

            int CuentaID = idCuenta;
            decimal valor = val;

            // Variables para almacenar los valores actuales
            decimal cargoMesHistorico = 0;
            decimal abonoMesHistorico = 0;
            decimal saldoHistorico = 0;
            bool existeHistorico = false;

            // Paso 1: Consultar los valores actuales del histórico para esa cuenta, mes y año
            string selectHistorico = @"SELECT cargo_mes, abono_mes, saldo_act 
                               FROM tbl_historico_cuentas 
                               WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";

            try
            {
                using (OdbcCommand cmdHistorico = new OdbcCommand(selectHistorico, con.conexion()))
                {
                    cmdHistorico.Parameters.AddWithValue("@Pk_id_cuenta", CuentaID);
                    cmdHistorico.Parameters.AddWithValue("@mes", mesActual);
                    cmdHistorico.Parameters.AddWithValue("@anio", anioActual);

                    using (OdbcDataReader readerHistorico = cmdHistorico.ExecuteReader())
                    {
                        if (readerHistorico.Read())
                        {
                            // Si existe un registro, obtener los valores
                            cargoMesHistorico = Convert.ToDecimal(readerHistorico["cargo_mes"]);
                            abonoMesHistorico = Convert.ToDecimal(readerHistorico["abono_mes"]);
                            saldoHistorico = Convert.ToDecimal(readerHistorico["saldo_act"]);
                            existeHistorico = true;
                        }
                    }
                }

                // Paso 2: Si existe el registro en tbl_historico_cuentas, lo actualizamos
                if (existeHistorico)
                {
                    if (tipoOperacion == "Cargo")
                    {
                        cargoMesHistorico += valor; // Sumar al cargo del mes
                    }
                    else if (tipoOperacion == "Abono")
                    {
                        abonoMesHistorico += valor; // Sumar al abono del mes
                    }

                    saldoHistorico = cargoMesHistorico - abonoMesHistorico; // Recalcular saldo

                    // Actualizar el registro existente
                    string updateHistorico = @"UPDATE tbl_historico_cuentas SET cargo_mes = ?, abono_mes = ?, saldo_act = ? WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";

                    using (OdbcCommand cmdUpdateHistorico = new OdbcCommand(updateHistorico, con.conexion()))
                    {
                        cmdUpdateHistorico.Parameters.AddWithValue("@cargo_mes", cargoMesHistorico);
                        cmdUpdateHistorico.Parameters.AddWithValue("@abono_mes", abonoMesHistorico);
                        cmdUpdateHistorico.Parameters.AddWithValue("@saldo_act", saldoHistorico); ;
                        cmdUpdateHistorico.Parameters.AddWithValue("@Pk_id_cuenta", CuentaID);
                        cmdUpdateHistorico.Parameters.AddWithValue("@mes", mesActual);
                        cmdUpdateHistorico.Parameters.AddWithValue("@anio", anioActual);

                        cmdUpdateHistorico.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Paso 3: Si no existe el registro, lo insertamos como nuevo
                    string insertHistorico = @"INSERT INTO tbl_historico_cuentas(Pk_id_cuenta, mes, anio, cargo_mes, abono_mes, saldo_act) VALUES (?, ?, ?, ?, ?, ?)";

                    if (tipoOperacion == "Cargo")
                    {
                        cargoMesHistorico = valor;
                    }
                    else if (tipoOperacion == "Abono")
                    {
                        abonoMesHistorico = valor;
                    }

                    saldoHistorico = cargoMesHistorico - abonoMesHistorico;

                    using (OdbcCommand cmdInsertHistorico = new OdbcCommand(insertHistorico, con.conexion()))
                    {
                        cmdInsertHistorico.Parameters.AddWithValue("@Pk_id_cuenta", CuentaID);
                        cmdInsertHistorico.Parameters.AddWithValue("@mes", mesActual);
                        cmdInsertHistorico.Parameters.AddWithValue("@anio", anioActual);
                        cmdInsertHistorico.Parameters.AddWithValue("@cargo_mes", cargoMesHistorico);
                        cmdInsertHistorico.Parameters.AddWithValue("@abono_mes", abonoMesHistorico);
                        cmdInsertHistorico.Parameters.AddWithValue("@saldo_act", saldoHistorico);

                        cmdInsertHistorico.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el histórico: " + ex.Message);
            }
        }
    }
}