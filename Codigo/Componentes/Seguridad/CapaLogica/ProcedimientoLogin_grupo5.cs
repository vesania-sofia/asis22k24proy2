using System;
using System.Data;
using System.Data.Odbc;
using CapaDatos;

namespace CapaLogica
{
    public class ProcedimientoLogin_grupo5
    {
        //Fernando García - 0901-21-581
        public bool llamarProcedimiento(string usuario, string clave)
        {
            try
            {
                conexion_grupo5 con = new conexion_grupo5();
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

        }/////////////////////////////////////////////////////////////////////////////////////////////////////

        // Procedimientos siguientes por Brandon Boch 0901-21-13093------------------------------------
        public bool cambioContrasenia(string usuario, string respuesta)
        {
            try
            {
                conexion_grupo5 con = new conexion_grupo5();
                using (OdbcCommand cmd = new OdbcCommand("CALL cambioContrasenia(?, ?)", con.conectar()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@usuario", OdbcType.VarChar).Value = usuario;
                    cmd.Parameters.Add("@respuesta", OdbcType.VarChar).Value = respuesta;

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resu = reader.GetString(0);
                            return resu == "Usuario encontrado";
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


        public bool cambiarContrasenia(string usuario, string nuevaContrasenia)
        {
            try
            {
                conexion_grupo5 con = new conexion_grupo5();
                using (OdbcCommand cmd = new OdbcCommand("CALL cambiarContrasenia(?, ?)", con.conectar()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Los parámetros se agregan en el mismo orden en que aparecen en el SP
                    cmd.Parameters.Add(new OdbcParameter("@usuario", OdbcType.VarChar)).Value = usuario;
                    cmd.Parameters.Add(new OdbcParameter("@nuevaContrasenia", OdbcType.VarChar)).Value = nuevaContrasenia;

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resultado = reader.GetString(0);
                            // Comparar el resultado con el mensaje del SP
                            return resultado == "Contraseña actualizada con éxito";
                        }
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return false;
        }//////////////////////////////////////////////////////////////////////////////////////////////////

    }
        
}