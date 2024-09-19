using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_Navegador
{
    class conexion
    {
        public OdbcConnection probarConexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=colchoneria");// creacion de la conexion via ODBC
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }
    }
}
