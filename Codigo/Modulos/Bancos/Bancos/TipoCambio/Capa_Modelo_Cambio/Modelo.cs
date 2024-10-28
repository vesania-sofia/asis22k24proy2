using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Cambio
{
    public class Modelo
    {
        private string connectionString = "DSN=colchoneria";
        public DataTable ObtenerTipoCambio()
        {
            string query = "SELECT tipoCambio_nombre_moneda AS Moneda, tipoCambio_valorCambio_moneda AS Precio FROM tbl_tipoCambio WHERE tipoCambio_estatus = 1";
            DataTable dataTable = new DataTable();
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                try
                {
                    connection.Open();
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
        public List<string> ObtenerNombresMonedas()
        {
            string query = "SELECT tipoCambio_nombre_moneda FROM tbl_tipoCambio WHERE tipoCambio_estatus = 1";
            List<string> nombresMonedas = new List<string>();
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nombresMonedas.Add(reader["tipoCambio_nombre_moneda"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los nombres de las monedas: " + ex.Message);
                }
            }
            return nombresMonedas;
        }
    }
}
