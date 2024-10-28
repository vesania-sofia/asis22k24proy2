using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Movimientos
{
    public class Modelo
    {
        private Conexion conn;

        public Modelo()
        {
            this.conn = new Conexion();
        }

        public DataTable ObtenerMov()
        {
            string query = "SELECT fk_cuenta_id AS CuentaID, movimientobancario_fecha AS fecha, movimientobancario_tipo AS Tipo, movimientobancario_monto AS Monto,  movimientobancario_descripcion AS Descripcion, movimientobancario_metodo_pago AS metodo, movimientobancario_estado AS estado FROM tbl_movimientobancario";
            DataTable dataTable = new DataTable();

            using (OdbcConnection connection = conn.connection()) // Usando el método connection() de la clase Conexion
            {
                try
                {
                    OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los tipos de cambio: " + ex.Message);
                }
            }
            return dataTable;
        }

    }
}