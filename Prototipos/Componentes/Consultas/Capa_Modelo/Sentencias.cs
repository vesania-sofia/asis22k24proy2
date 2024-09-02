using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
//capa modelo sentencias comentado por azael sierra
namespace Capa_ModeloConsultas
{
    public class Sentencias
    {
        Conexion con = new Conexion();
        protected Conexion conn;
        private static string baseDatos = "";

        public Sentencias()
        {
            this.conn = new Conexion();
            baseDatos = this.conn.connection().Database;
        }
        public OdbcDataAdapter buscartbl(string BD)
        {
            string sql = "SELECT TABLE_NAME From INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = '" + BD + "'";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.connection());

            return datatable;
        }
        //insertar datos
        public void insertar(string dato, string tipo, string tabla)
        {
            try
            {
                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                OdbcCommand cmd = new OdbcCommand(sql, con.connection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        //modificar
        public void actualizar(string dato, string condicion, string tabla)
        {
            try
            {
                string sql = "Update " + tabla + " " + dato + " where " + condicion;
                OdbcCommand cmd = new OdbcCommand(sql, con.connection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void insertarconsulta(string cadena)
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.connection());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo" + Error);
            }
        }
        public OdbcDataAdapter llenartb2(string sql) {
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.connection());
            return datatable;
        }

        public List<string> ObtenerColumnas(string tabla)
        {
            
            List<string> columns = new List<string>();
            try
            {
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + baseDatos + "' AND TABLE_NAME='" + tabla + "';";
                OdbcCommand cmd = new OdbcCommand(query, this.conn.connection());
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string column = reader.GetString(0);
                    columns.Add(column);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return columns;
        }

        public string ObtenerTipoDeDato(string seleccion, string tablaN1)
        {
            string Tipo = string.Empty;
            using (OdbcConnection conn = con.connection())
            {
                string query = "SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA ='" + baseDatos + "' AND TABLE_NAME = '"+tablaN1+"' AND COLUMN_NAME = '"+seleccion+"'";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        Tipo = result.ToString();
                    }
                }
            }
            return Tipo;
        }

        public DataTable BuscarPor2(string datobuscar, string buscaren,string operador, string tableN, DataTable dt, Label lbl_cadena)
        {
            OdbcConnection con = new OdbcConnection("Dsn=HotelSConexion");
            if (string.IsNullOrEmpty(buscaren))
            {
                String textalert = " El campo buscar, se encuentra vacio ";
                MessageBox.Show(textalert);
            }
            else
            {
                try
                {
                    String cadenaB = "";
                    con.Open();
                    cadenaB = "SELECT * FROM " + tableN + " WHERE " + buscaren + " " + operador + " '" + datobuscar + "';";
                    lbl_cadena.Text = "Buscando : " + datobuscar + " En Columna : " + buscaren;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                    datos.Fill(dt);
                    OdbcCommand comando = new OdbcCommand(cadenaB, con);
                    OdbcDataReader leer;
                    leer = comando.ExecuteReader();

                }
                catch(Exception ex)
                {
                    String textalert = "No se pudo";
                    MessageBox.Show("Error: " + ex.Message);
                    MessageBox.Show(textalert);
                }

                con.Close();
            }
            return dt;
        }



    }
}




