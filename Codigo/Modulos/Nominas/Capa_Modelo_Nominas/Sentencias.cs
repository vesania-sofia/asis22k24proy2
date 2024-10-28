using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using  Capa_Modelo_Nominas;
using Capa_Modelo_Seguridad;


using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms; // Para expresiones regulares


namespace Capa_Modelo_Nominas
{
    public class Sentencias
    {
        conexion cn = new conexion();
        //Sentencias sn = new Sentencias();

        ///********0901-21-13093 - Brandon Alejandro Boch Lopez*********************/
        //// Método para llamar al SP calcular_anticipo
        //// Método para llamar al SP calcular_anticipo
      


        ///*************************************************************************/


        ///********0901-21-1278 - Gabriela Alejandra Suc Gomez**********************/
      

        ///*************************************************************************/


        ///********0901-21-4866 - Kateryn Johana De León Hernández******************/
        //// Método para llamar al SP Calcular_Horas_Extras
        //// Método para llamar al SP Calcular_Horas_Extras
      



        ///*************************************************************************/


        ///********0901-21-843 - Marco Alejandro Monroy Rousselin*******************/
        //// Método para llamar al SP calcular_deduccion_faltas
       
        ///*************************************************************************/


        ///********0901-21-581 - Fernando José García de León***********************/
        
        ///*************************************************************************/


        ///********0901-21-506 - Ismar Leonel Cortez Sanchez************************/

        public OdbcDataAdapter ObtenerIdsEmpleados()
            {
                string query = "SELECT pk_clave FROM tbl_empleados WHERE estado = 1";

                try
                {
                    OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());
                    return adapter; // Devuelve el OdbcDataAdapter con la consulta
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error en la consulta: " + ex.Message);
                    return null;
                }

            }


        //// Método para obtener las deducciones calculadas
        public OdbcDataAdapter ObtenerPercepciones()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"
                SELECT 
                    emp.empleados_nombre AS empleados_nombre, 
                    emp.empleados_apellido AS empleados_apellido, 
                    ded.dedu_perp_concepto AS dedu_perp_concepto, 
                    ded.dedu_perp_tipo AS dedu_perp_tipo, 
                    dp.dedu_perp_emp_cantidad AS dedu_perp_emp_cantidad
                FROM 
                    tbl_dedu_perp_emp dp
                INNER JOIN 
                    tbl_empleados emp ON dp.Fk_clave_empleado = emp.pk_clave
                INNER JOIN 
                    tbl_dedu_perp ded ON dp.fk_dedu_perp = ded.pk_dedu_perp
                WHERE 
                    dp.estado = 1
                    AND ded.dedu_perp_clase = 'Percepcion';";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter ObtenerDeducciones()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"
                SELECT 
                    emp.empleados_nombre AS empleados_nombre, 
                    emp.empleados_apellido AS empleados_apellido, 
                    ded.dedu_perp_concepto AS dedu_perp_concepto, 
                    ded.dedu_perp_tipo AS dedu_perp_tipo, 
                    dp.dedu_perp_emp_cantidad AS dedu_perp_emp_cantidad
                FROM 
                    tbl_dedu_perp_emp dp
                INNER JOIN 
                    tbl_empleados emp ON dp.Fk_clave_empleado = emp.pk_clave
                INNER JOIN 
                    tbl_dedu_perp ded ON dp.fk_dedu_perp = ded.pk_dedu_perp
                WHERE 
                    dp.estado = 1
                    AND ded.dedu_perp_clase = 'Deduccion';";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }



        public OdbcDataAdapter ObtenerEncabezado()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"select* from tbl_planilla_Encabezado;";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter ObtenerDetalle()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"select* from tbl_planilla_Detalle;";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conectar());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al obtener las deducciones: " + ex.Message);
                return null;
            }
        }


        public bool CalcularTotalMes(string idEncabezado)
        {
            try
            {
                // Crear el comando para ejecutar el SP
                using (OdbcCommand comando = new OdbcCommand("{CALL sp_sumar_percepciones_a_encabezado(?)}", cn.conectar()))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_fk_id_registro_planilla_Encabezado", idEncabezado);

                    // Ejecutar el SP
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si el SP afectó alguna fila y retornar true o false
                    if (filasAfectadas > 0)
                    {
                        return true;  // Operación exitosa, afectó filas
                    }
                    else
                    {
                        return false; // Operación no afectó filas
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al ejecutar SP calcular_anticipo para empleado {idEncabezado}: {ex.Message}");
                return false; // Hubo un error, retornamos false
            }
        }

        ///*************************************************************************/




    }





}








