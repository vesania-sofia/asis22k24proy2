using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace Capa_Modelo_Logistica
{
    public class Sentencias
    {
        private Conexion cn = new Conexion(); // Instancia de la clase de conexión

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
    }
}