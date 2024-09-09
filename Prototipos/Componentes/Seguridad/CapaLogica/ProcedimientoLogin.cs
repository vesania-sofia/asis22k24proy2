using System;
using System.Data;
using System.Data.Odbc;
using CapaDatos;

namespace CapaLogica
{
    public class ProcedimientoLogin
    {
        //Fernando García - 0901-21-581
        public bool llamarProcedimiento(string usuario, string clave)
        {
            try
            {
                conexion con = new conexion();
                using (OdbcCommand cmd = new OdbcCommand("CALL procedimientoLogin(?, ?)", con.conectar()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@usuario", OdbcType.VarChar).Value = usuario;
                    cmd.Parameters.Add("@clave", OdbcType.VarChar).Value = clave;

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resultado = reader.GetString(0);
                            return resultado == "Inicio de sesión exitoso";
                        }
                    }
                }

                return false;
            }
            catch (OdbcException ex)
            {

                Console.WriteLine(ex);
                return false;

            }

        }
    }///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}