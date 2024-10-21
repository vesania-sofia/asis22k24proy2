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
        Conexion cn = new Conexion();

        // Método para cargar las existencias de una bodega en particular (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            OdbcDataReader dr = null;
            OdbcConnection conn = null; // Declarar la conexión aquí

            try
            {
                conn = cn.conexion();
                string query = $"SELECT * FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = '{idBodega}'";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener existencias: " + ex.Message);
                // Asegurarse de que dr sea null en caso de error
                dr = null;
            }
            finally
            {
                // Si se produce un error, cerramos la conexión
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Cerrar la conexión si está abierta
                }
            }

            return dr;
        }

        // Método para insertar una auditoría de inventario (Realizado por Daniel Sierra 0901-21-12740)
        public void InsertarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            OdbcConnection conn = cn.conexion();
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
            OdbcConnection conn = cn.conexion();
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

        public OdbcDataReader ObtenerProductosPorBodega(string idBodega) //realizado por José Daniel Sierra
        {
            OdbcDataReader dr = null;
            OdbcConnection conn = null;

            try
            {
                conn = cn.conexion(); // Establecer la conexión
                string query = "SELECT * FROM Tbl_Productos WHERE Fk_id_bodega = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fk_id_bodega", idBodega);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos: " + ex.Message);
                dr = null;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return dr;
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
                OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion());
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
                OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion());
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
                OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion());
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

                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
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
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
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
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
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
    }
}