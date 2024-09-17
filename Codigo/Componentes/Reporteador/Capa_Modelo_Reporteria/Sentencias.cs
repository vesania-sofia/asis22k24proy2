using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_Reporteria
{
    public class Sentencias
    {
        string tabla_reporteria = "tbl_aplicaciones";
        Conexion conexion = new Conexion();
        public OdbcDataAdapter DisplayReportes()// metodo que obtiene el contenido de la tabla reportes
        {
            string sql = "SELECT idregistro, ruta, nombre_archivo, aplicacion, estado FROM " + tabla_reporteria + " WHERE idregistro IS NOT NULL AND idregistro != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + tabla_reporteria);
            }
            return dataTable;
        }
        public void registrarReporte(string id_reporte, string ruta, string nombre_archivo, string aplicacion, string estado)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string campos = "idregistro, ruta, nombre_archivo, aplicacion, estado";
                string sql = "INSERT INTO " + tabla_reporteria + " (" + campos + ") VALUES ('" + id_reporte + "', '" + ruta + "', '" + nombre_archivo + "', '" + aplicacion + "', '" + estado + "');";
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + tabla_reporteria);
            }
        }
        public void eliminarReporte(string id_reporte)
        {
            //funcion para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el numero de reporte que se pasa por parametro.
            try
            {
                string sql = "delete from " + tabla_reporteria + " where idregistro = " + id_reporte + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + id_reporte + " en la tabla " + tabla_reporteria);
            }
        }
        public void ModificarReporte(string ruta, string nombre_archivo, string aplicacion, string estado, string id_reporte)
        {
            //aqui estamos haciendo la comprobacion de que si tuvo una conexion con la base de datos
            try
            {
                //aqui con los datos recibidos le mandamos la instruccion a la base de datos, para poderlo modificar lo buscamos por id
                string sql = "UPDATE " + tabla_reporteria + " SET " + "ruta = '" + ruta + "'," + " nombre_archivo = '" + nombre_archivo + "'," + " aplicacion = '" + aplicacion + "'," + " estado = '" + estado + "' " + " WHERE (idregistro = '" + id_reporte + "');";
                OdbcCommand consulta = new OdbcCommand(sql, conexion.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Modificado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en CapaModeloReporteria --> Sentencias" + e);
            }
        }
        public OdbcDataAdapter queryReportes(string query)
        {
            string sql = "SELECT * FROM " + tabla_reporteria + " WHERE ruta LIKE '%" + query + "%' OR nombre_archivo LIKE '%" + query + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }
        public List<string> getAplicaciones()
        {
            string query = "SELECT pk_id_aplicacion, estado_aplicacion FROM tbl_aplicaciones;";
            List<string> applicationCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(query, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_aplicacion"].ToString().Equals("1"))
                    {
                        string codigoAplicacion = row["pk_id_aplicacion"].ToString();
                        applicationCodes.Add(codigoAplicacion);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + tabla_reporteria);
            }

            return applicationCodes;
        }
        public int getMaxIdReport()
        {
            int idRegistro = 0;
            string sql = "SELECT max(idRegistro) FROM " + tabla_reporteria + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                idRegistro = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + tabla_reporteria);
            }
            return idRegistro;
        }

    }
}
