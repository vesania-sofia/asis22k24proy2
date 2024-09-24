using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Capa_Datos_Navegador
{
    public class sentencias
    {
        conexion cn = new conexion();

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método que llena una tabla con datos relacionados a otra tabla si es necesario.
        public OdbcDataAdapter llenaTbl(string tabla, string tablaRelacionada, string campoDescriptivo, string columnaForanea, string columnaPrimariaRelacionada)
        {
            OdbcConnection conn = cn.probarConexion();

            try
            {
                // Obtener los campos de la tabla principal
                string[] camposDesc = obtenerCampos(tabla);
                string camposSelect = tabla + "." + camposDesc[0];

                // Diccionario para evitar duplicados de columnas
                Dictionary<string, int> columnasRegistradas = new Dictionary<string, int>();
                columnasRegistradas[camposDesc[0]] = 1;

                // Obtener las propiedades de las columnas de la tabla principal
                var columnasPropiedades = obtenerColumnasYPropiedades(tabla);

                foreach (var (nombreColumna, esAutoIncremental, esClaveForanea, esTinyInt) in columnasPropiedades)
                {
                    // Evitar agregar la columna principal dos veces
                    if (nombreColumna == camposDesc[0])
                        continue;

                    // Si es una clave foránea, hacer join con la tabla relacionada
                    if (esClaveForanea && tablaRelacionada != null && campoDescriptivo != null && columnaForanea != null && columnaPrimariaRelacionada != null)
                    {
                        camposSelect += ", " + tablaRelacionada + "." + campoDescriptivo + " AS " + campoDescriptivo;
                        columnasRegistradas[campoDescriptivo] = 1;
                    }
                    else
                    {
                        camposSelect += ", " + tabla + "." + nombreColumna;
                        columnasRegistradas[nombreColumna] = 1;
                    }
                }

                // Crear el comando SQL para seleccionar los campos
                string sql = "SELECT " + camposSelect + " FROM " + tabla;

                // Agregar el LEFT JOIN si hay una tabla relacionada
                if (!string.IsNullOrEmpty(tablaRelacionada) && !string.IsNullOrEmpty(columnaForanea) && !string.IsNullOrEmpty(columnaPrimariaRelacionada))
                {
                    sql += " LEFT JOIN " + tablaRelacionada + " ON " + tabla + "." + columnaForanea + " = " + tablaRelacionada + "." + columnaPrimariaRelacionada;
                }

                // Filtrar por estado (activo o inactivo)
                sql += " WHERE " + tabla + ".estado = 0 OR " + tabla + ".estado = 1";

                // Ordenar por la columna principal en orden descendente
                sql += " ORDER BY " + camposDesc[0] + " DESC;";

                Console.WriteLine(sql);

                // Crear un adaptador de datos para ejecutar la consulta
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);

                return dataTable;
            }
            finally
            {
                // Cerrar la conexión después de ejecutar la consulta
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de llenar la tabla");
                }
            }
        }
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 
        // Método que obtiene el último ID de una tabla
        public string obtenerId(string tabla)
        {
            string[] camposDesc = obtenerCampos(tabla);
            string sql = "SELECT MAX(" + camposDesc[0] + ") FROM " + tabla + ";";
            string sid = "";
            OdbcCommand command = new OdbcCommand(sql, cn.probarConexion());
            OdbcDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == null || reader.GetValue(0).ToString() == "")
                    {
                        sid = "1";
                    }
                    else
                    {
                        sid = reader.GetValue(0).ToString();
                    }
                }
            }
            else
            {
                sid = "1";
            }
            return sid;
        }

        // Método para obtener datos adicionales de una tabla (no se especifica para qué se usan)
        public string[] obtenerExtra(string tabla)
        {
            string[] Campos = new string[30];
            int i = 0;
            OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", cn.probarConexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Campos[i] = reader.GetValue(5).ToString();
                i++;
            }
            return Campos;
        }

        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 



        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 
        // Método para obtener el ID de usuario basado en su nombre de usuario
        public string ObtenerIdUsuarioPorUsername(string username)
        {
            string sql = "SELECT Pk_id_usuario FROM tbl_usuarios WHERE username_usuario = ?";

            using (OdbcCommand command = new OdbcCommand(sql, cn.probarConexion()))
            {
                command.Parameters.AddWithValue("@username", username);

                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["Pk_id_usuario"].ToString();
                    }
                    else
                    {
                        return "-1";
                    }
                }
            }
        }

        // Método que cuenta los campos en una tabla
        public int contarAlias(string tabla)
        {
            int Campos = 0;

            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + tabla.ToUpper() + "\n -");
            }
            return Campos;
        }
        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 


        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 
        // Método para contar registros en la tabla de ayuda
        public int contarReg(string idindice)
        {
            int Campos = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM ayuda WHERE id_ayuda = " + idindice + ";", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + idindice.ToUpper() + "\n -");
            }
            return Campos;
        }


        public string modRuta(string idAyuda)
        {
            string ruta = "";
            string query = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(query, cn.probarConexion()))
            {
                command.Parameters.AddWithValue("id_ayuda", idAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ruta = reader.GetString(0); // Asignamos el valor de la columna Ruta
                    }
                }
            }

            return ruta;

        // Método para obtener la ruta de un recurso basado en su
        }
        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 


        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 
        // Método que obtiene la ruta del reporte basada en el ID de la aplicación
        public string rutaReporte(string idindice)
        {
            string indice2 = "";
            OdbcCommand command = new OdbcCommand("SELECT ruta FROM tbl_aplicaciones WHERE Pk_id_aplicacion = " + idindice + ";", cn.probarConexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                indice2 = reader["ruta"].ToString();
            }

            reader.Close();
            return indice2;
        }
        
        // Método para obtener un índice modificado basado en el ID de ayuda
        public string modIndice(string idindice)

        {
            string indice = "";
            string query = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(query, cn.probarConexion()))
            {
                command.Parameters.AddWithValue("Id_ayuda", idAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        indice = reader.GetString(0); // Asignamos el valor de la columna Indice
                    }
                }
            }

            return indice;
        }
        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 


        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 
        // Método para probar si una tabla existe en la base de datos
        public string ProbarTabla(string tabla)
        {
            string error = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM " + tabla + ";", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
            }
            catch (Exception)
            {
                error = "La tabla " + tabla.ToUpper() + " no existe.";
            }
            return error;
        }

        // Método para probar si una tabla tiene un campo de estado
        public string ProbarEstado(string tabla)
        {
            string error = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT estado FROM " + tabla + ";", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
            }
            catch (Exception)
            {
                error = "La tabla " + tabla.ToUpper() + " no contiene el campo de ESTADO";
            }
            return error;
        }

        // Método que cuenta los registros activos en una tabla
        public int ProbarRegistros(string tabla)
        {
            int registros = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM " + tabla + " where estado=1;", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    registros++;
                }
            }
            catch (Exception)
            {
            }

            return registros;
        }
        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método para obtener los nombres de los campos de una tabla
        public string[] obtenerCampos(string tabla)
        {
            string[] Campos = new string[30];
            int i = 0;
            OdbcConnection conn = null;

            try
            {
                conn = cn.probarConexion();
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", conn);
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    i++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parámetros \n -" + tabla);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de obtener los campos");
                }
            }

            return Campos;
        }
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 
        // Método para obtener las propiedades de las columnas de una tabla
        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> obtenerColumnasYPropiedades(string nombreTabla)
        {
            List<(string, bool, bool, bool)> columnas = new List<(string, bool, bool, bool)>();

            try
            {
                string queryColumnas = $"SHOW COLUMNS FROM {nombreTabla};";
                OdbcCommand comando = new OdbcCommand(queryColumnas, cn.probarConexion());
                OdbcDataReader lector = comando.ExecuteReader();

                HashSet<string> clavesForaneas = new HashSet<string>();

                string queryClavesForaneas = $@"
                    SELECT COLUMN_NAME
                    FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                    WHERE TABLE_NAME = '{nombreTabla}' AND REFERENCED_TABLE_NAME IS NOT NULL;";
                OdbcCommand comandoClaves = new OdbcCommand(queryClavesForaneas, cn.probarConexion());
                OdbcDataReader lectorClaves = comandoClaves.ExecuteReader();

                while (lectorClaves.Read())
                {
                    string nombreColumnaForanea = lectorClaves.GetString(0);
                    clavesForaneas.Add(nombreColumnaForanea);
                }

                lectorClaves.Close();

                while (lector.Read())
                {
                    string nombreColumna = lector.GetString(0);
                    string tipoColumna = lector.GetString(1);
                    string columnaExtra = lector.GetString(5);

                    bool esAutoIncremental = columnaExtra.Contains("auto_increment");
                    bool esClaveForanea = clavesForaneas.Contains(nombreColumna);
                    bool esTinyInt = tipoColumna.StartsWith("tinyint");

                    columnas.Add((nombreColumna, esAutoIncremental, esClaveForanea, esTinyInt));
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener columnas: " + ex.Message);
            }

            return columnas;
        }
        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 


        //******************************************** CODIGO HECHO POR PABLO FLORES ***************************** 
        // Método para ejecutar una serie de consultas SQL dentro de una transacción
        public void ejecutarQueryConTransaccion(List<string> queries)
        {
            OdbcConnection connection = cn.probarConexion();
            OdbcTransaction transaction = null;

            try
            {
                transaction = connection.BeginTransaction();

                foreach (string query in queries)
                {
                    OdbcCommand command = new OdbcCommand(query, connection, transaction);
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                Console.WriteLine("Error en la transacción: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener los tipos de datos de los campos en una tabla
        public string[] ObtenerTipo(string tabla)
        {
            string[] Campos = new string[30];
            int i = 0;
            OdbcConnection conn = null;

            try
            {
                conn = cn.probarConexion();
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", conn);
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos[i] = limpiarTipo(reader.GetValue(1).ToString());
                    i++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + tabla.ToUpper() + "\n -");
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de obtener el tipo de los campos");
                }
            }

            return Campos;
        }
        //******************************************** CODIGO HECHO POR PABLO FLORES ***************************** 


        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 
        // Método para obtener las llaves de los campos en una tabla
        public string[] obtenerLLave(string tabla)
        {
            string[] Campos = new string[30];
            int i = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(3).ToString();
                    i++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parametros de la tabla  \n -" + tabla + "\n -");
            }

            return Campos;
        }

        // Método para obtener los ítems de un ComboBox desde la base de datos
        public Dictionary<string, string> obtenerItems(string tabla, string campoClave, string campoDisplay)
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            try
            {
                OdbcCommand command = new OdbcCommand($"SELECT {campoClave}, {campoDisplay} FROM {tabla} WHERE estado = 1", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nError en obtenerItems, revise los parámetros \n -" + tabla + "\n -" + campoClave);
            }
            return items;
        }
        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 


        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 
        // Método que limpia el tipo de dato de una cadena, eliminando la dimensión del campo
        string limpiarTipo(string cadena)
        {
            bool dim = false;
            string nuevaCadena = "";

            for (int j = 0; j < cadena.Length; j++)
            {
                if (cadena[j] == '(')
                {
                    dim = true;
                }
            }

            if (dim == true)
            {
                int i = 0;

                int tam = cadena.Length;

                while (cadena[i] != '(')
                {
                    nuevaCadena += cadena[i];
                    i++;
                }

            }
            else
            {
                return cadena;
            }

            return nuevaCadena;
        }

        // Método para obtener la llave de un campo en la tabla
        public string llaveCampo(string tabla, string campo, string valor)
        {
            string llave = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM " + tabla + " where " + campo + " = '" + valor + "' ;", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                llave = reader.GetValue(0).ToString();
            }
            catch (Exception)
            {

            }
            return llave;
        }

        // Método para obtener la llave de un campo en reverso (no está claro para qué se usa)
        public string llaveCampoReverso(string tabla, string campo, string valor)
        {
            string llave = "";
            string[] Campos = obtenerCampos(tabla);
            try
            {
                string valorFormateado = "'" + valor + "'";

                string query = $"SELECT {campo} FROM {tabla} WHERE {Campos[0]} = {valorFormateado};";

                OdbcCommand command = new OdbcCommand(query, cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    llave = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dio errore: " + ex.ToString());
            }
            return llave;
        }
        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método para obtener el ID del módulo basado en el ID de la aplicación
        public string IdModulo(string aplicacion)
        {
            string llave = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_aplicacion" + " where" + " PK_id_aplicacion= " + aplicacion + " ;", cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                llave = reader.GetValue(0).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dio errore " + "SELECT * FROM tbl_aplicacion" + " where" + " PK_id_aplicacion= " + aplicacion + " ;" + ex.ToString());
            }
            return llave;
        }

        // Método para ejecutar una consulta SQL
        public void ejecutarQuery(string query)
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(query, cn.probarConexion());
                consulta.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 
        // Método para obtener la clave primaria de una tabla
        public string obtenerClavePrimaria(string nombreTabla)
        {
            string clavePrimaria = "";
            try
            {
                string query = $"SHOW KEYS FROM {nombreTabla} WHERE Key_name = 'PRIMARY';";

                OdbcCommand command = new OdbcCommand(query, cn.probarConexion());

                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    clavePrimaria = reader["Column_name"].ToString();
                    Console.WriteLine($"Clave primaria de {nombreTabla}: {clavePrimaria}");
                }
                else
                {
                    throw new Exception("No se encontró una clave primaria para la tabla: " + nombreTabla);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la clave primaria de la tabla " + nombreTabla + ": " + ex.ToString());
            }

            return clavePrimaria;
        }

        // Método para obtener la clave foránea que referencia a otra tabla
        public string ObtenerClaveForanea(string tablaOrigen, string tablaReferencia)
        {
            string claveForanea = null;

            try
            {
                string query = $@"
            SELECT COLUMN_NAME 
            FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
            WHERE TABLE_SCHEMA = DATABASE()
            AND TABLE_NAME = '{tablaOrigen}' 
            AND REFERENCED_TABLE_NAME = '{tablaReferencia}';";

                OdbcCommand command = new OdbcCommand(query, cn.probarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    claveForanea = reader.GetString(0);
                    Console.WriteLine($"Clave foránea de {tablaOrigen} que referencia a {tablaReferencia}: {claveForanea}");
                }
                else
                {
                    Console.WriteLine($"No se encontró clave foránea en {tablaOrigen} que referencia a {tablaReferencia}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener clave foránea: " + ex.Message);
            }

            return claveForanea;
        }
        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 
    }
}
