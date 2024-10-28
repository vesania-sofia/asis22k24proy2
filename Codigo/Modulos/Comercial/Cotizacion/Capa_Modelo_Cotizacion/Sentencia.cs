using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Net;
using System.Data;


namespace Capa_Modelo_Cotizacion
{
    public class Sentencia
    {
        Conexion cn = new Conexion();
        //private string idUsuario;

        public Sentencia()
        {
            //this.idUsuario = idUsuario;
        }


        // combo de 3

        public string[] funllenarCmb(string stabla, string scampo1, string scampo2)
        {
            Conexion cn = new Conexion();
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
            Conexion cn = new Conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }



        public OdbcDataAdapter funvalidarIDCotizacionE()
        {
            try
            {

                string sqlIDCotizacion = "SELECT MAX(Pk_id_cotizacionEnc)+1 FROM Tbl_cotizacion_encabezado";
                OdbcDataAdapter dataIDCotizacion = new OdbcDataAdapter(sqlIDCotizacion, cn.conectar());
                //funInsertarBitacora(idUsuario, "Se selecciono una aplicación", "tbl_aplicaciones", "1000");
                return dataIDCotizacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public void proInsertarCotizacionE(string idCotizacion, string idVendedor, string idCliente, DateTime fechaVenc, string total)
        {
            try
            {
                // Crear la conexión y el comando
                using (OdbcConnection connection = cn.conectar())
                {
                    // Ajustar la consulta SQL
                    string query = "INSERT INTO Tbl_cotizacion_encabezado (" +
                                   "Pk_id_cotizacionEnc, " +
                                   "Fk_id_vendedor, " +
                                   "Fk_id_cliente, " +
                                   "CotizacionEnc_fechaVenc, " +
                                   "CotizacionEnc_total) " +
                                   "VALUES (?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar los parámetros con valores correspondientes
                        cmd.Parameters.AddWithValue("@Pk_id_cotizacionEnc", idCotizacion);
                        cmd.Parameters.AddWithValue("@Fk_id_vendedor", idVendedor);
                        cmd.Parameters.AddWithValue("@Fk_id_cliente", idCliente);
                        cmd.Parameters.AddWithValue("@CotizacionEnc_fechaVenc", fechaVenc);
                        cmd.Parameters.AddWithValue("@CotizacionEnc_total", total);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Registrar en bitácora si es necesario
                        // funInsertarBitacora(idUsuario, "Insertó una nueva cotización: " + idCotizacion, "Tbl_cotizacion_encabezado", "1000");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la cotización: " + ex.Message);
            }
        }




    }
}
