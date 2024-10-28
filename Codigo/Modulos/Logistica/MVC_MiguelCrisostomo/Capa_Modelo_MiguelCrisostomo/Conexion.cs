using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Capa_Modelo_MiguelCrisostomo;


namespace Capa_Modelo_MiguelCrisostomo
{
    public class conexion
    {
        public OdbcConnection Conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conexion.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conexion;
        }

        public void desconexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }
    }
}
