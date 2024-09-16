using System;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Net;
using System.Data;

namespace CapaDatos
{
    public class sentencia
    {
        conexion cn = new conexion();
        private string idUsuario;

        public sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public sentencia()
        {

        }
        //Kateryn De Leon
        //buscar usuarios
        public OdbcDataAdapter consultarUsuarios()
        {
            cn.conectar();
            string sqlUsuarios = "SELECT PK_id_usuario FROM tbl_usuario WHERE estado_usuario = 1 "; //WHERE estado_usuario = 1
            OdbcDataAdapter dataUsuarios = new OdbcDataAdapter(sqlUsuarios, cn.conectar());
            insertarBitacora(idUsuario, "Realizo una consulta a usuarios", "tbl_usuario");
            return dataUsuarios;

        }

//****************************************Kevin López***************************************************
        public OdbcDataAdapter consultarModulos()
        {
            cn.conectar();
            string sqlModulos = "SELECT nombre_modulo FROM Tbl_modulos WHERE estado_modulo = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, cn.conectar());
            insertarBitacora(idUsuario, "Realizo una consulta a modulos", "Tbl_modulos");
            return dataModulos;
        }
//****************************************FIN Kevin López***************************************************

//****************************************Kevin López***************************************************
        public OdbcDataAdapter consultarPerfiles()
        {
            cn.conectar();
            string sqlPerfiles = "SELECT nombre_perfil FROM Tbl_perfiles WHERE estado_perfil = 1";
            OdbcDataAdapter dataPerfiles = new OdbcDataAdapter(sqlPerfiles, cn.conectar());
            insertarBitacora(idUsuario, "Realizo una consulta a perfiles", "Tbl_perfiles");
            return dataPerfiles;
        }
//****************************************Kevin López***************************************************


        public OdbcDataAdapter consultarAplicaciones(string nombreModulo)
        {
            string sCodigoModulo = " ";
            try
            {
                OdbcCommand sqlCodigoModulo = new OdbcCommand("SELECT PK_id_Modulo FROM tbl_modulo WHERE nombre_modulo = '" + nombreModulo + "' ", cn.conectar());
                OdbcDataReader almacena = sqlCodigoModulo.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoModulo = almacena.GetString(0);
                }

                string sqlAplicaciones = "SELECT nombre_aplicacion FROM tbl_aplicacion WHERE PK_id_Modulo = '" + sCodigoModulo + "' ";
                OdbcDataAdapter dataAplicaciones = new OdbcDataAdapter(sqlAplicaciones, cn.conectar());

                almacena.Close();
                sqlCodigoModulo.Connection.Close();
                insertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicacion");
                return dataAplicaciones;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter insertarPermisosUA(string codigoUsuario, string nombreAplicacion, string ingresar, string consulta, string modificar, string eliminar, string imprimir)
        {
            string sCodigoAplicacion = " ";

            try
            {
                OdbcCommand sqlCodigoModulo = new OdbcCommand("SELECT PK_id_aplicacion FROM tbl_aplicacion WHERE nombre_aplicacion = '" + nombreAplicacion + "' ", cn.conectar());
                OdbcDataReader almacena = sqlCodigoModulo.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoAplicacion = almacena.GetString(0);
                }

                string sqlInsertarPermisosUA = "INSERT INTO tbl_usuario_aplicacion(PK_id_usuario, PK_id_aplicacion, ingresar, consulta, modificar, eliminar, imprimir) VALUES ('" + codigoUsuario + "', '" + sCodigoAplicacion + "', '" + ingresar + "', '" + consulta + "', '" + modificar + "', '" + eliminar + "', '" + imprimir + "');";
                insertarBitacora(idUsuario, "Asigno aplicacion: " + nombreAplicacion + " a usuario: " + codigoUsuario, "tbl_usuario_aplicacion");
                OdbcDataAdapter dataPermisosUA = new OdbcDataAdapter(sqlInsertarPermisosUA, cn.conectar());


                almacena.Close();
                sqlCodigoModulo.Connection.Close();

                return dataPermisosUA;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public OdbcDataAdapter mostrarPerfilesDeUsuario(string TablaPerfilUsuario)
        {
            string sql = "SELECT * FROM " + TablaPerfilUsuario + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar());
            return dataTable;
        }

        public bool eliminarPerfilUsuario(string Id_Perfil_Usuario)
        {

            try
            {

                cn.conectar();
                string sqlEliminarPerfilUsuario = "DELETE FROM Tbl_asignaciones_perfils_usuario WHERE PK_id_Perfil_Usuario = ?";
                using (OdbcCommand cmd = new OdbcCommand(sqlEliminarPerfilUsuario, cn.conectar()))
                {

                    cmd.Parameters.AddWithValue("@Id_Perfil_Usuario", Id_Perfil_Usuario);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        insertarBitacora(idUsuario, "Eliminó un perfil: " + Id_Perfil_Usuario, "Tbl_asignaciones_perfils_usuario");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }


        }

        public void insertarPerfilUsuario(string codigoUsuario, string codigoPerfil)
        {


            try
            {
                using (OdbcConnection connection = cn.conectar())

                {
                    //
                    string query = "INSERT INTO Tbl_asignaciones_perfils_usuario(" +
                                                     "Fk_id_usuario," +
                                                     "Fk_id_perfil)" +
                                                     "VALUES (?, ?) ";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@Fk_id_usuario", codigoUsuario);
                        cmd.Parameters.AddWithValue("@Fk_id_perfil", codigoPerfil);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();
                        insertarBitacora(idUsuario, "Inserto un nuevo modulo: " + codigoUsuario + " - " + codigoPerfil, "Tbl_asignaciones_perfils_usuario");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la asignacion: " + ex.Message);
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################




        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public OdbcDataAdapter validarIDAplicacion()
        {
            try
            {

                string sqlIDAplicacion = "SELECT MAX(Pk_id_aplicacion)+1 FROM tbl_aplicaciones";
                OdbcDataAdapter dataIDAplicacion = new OdbcDataAdapter(sqlIDAplicacion, cn.conectar());
                return dataIDAplicacion;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------

        public int ActualizarUsuario(int id, string nombre, string apellido, string correo, string estado, string pregunta, string respuesta)
        {
            OdbcConnection connection = cn.conectar();
            string sqlactualizarUsuario = "UPDATE tbl_usuarios SET nombre_usuario = ?, apellido_usuario = ?, email_usuario = ?, estado_usuario = ?, pregunta = ?, respuesta = ? WHERE PK_id_usuario = ?";

            OdbcCommand command = new OdbcCommand(sqlactualizarUsuario, connection);

            // Asignar los parámetros. Usar parámetros para evitar inyección SQL
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@estado", estado);
            command.Parameters.AddWithValue("@pregunta", pregunta);
            command.Parameters.AddWithValue("@respuesta", respuesta);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                // Ejecutar la consulta de actualización
                int filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas; // Se retorna el número de filas afectadas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                return 0; // En caso de error, se retorna 0
            }
            finally
            {
                connection.Close();
            }
        }

        //---------------------------------------------------- Fin: GABRIELA SUC ----------------------------------------------------

        /* Creado por Emerzon Garcia */

        public bool EliminarPerfil1(string ID_perfil)
        {
            try
            {
                // Conectar a la base de datos
                cn.conectar();

                // Crear la consulta SQL para eliminar
                string sqlEliminarPerfil = "DELETE FROM Tbl_perfiles WHERE PK_id_perfil = ?";

                // Usar OdbcCommand para ejecutar el DELETE
                using (OdbcCommand cmd = new OdbcCommand(sqlEliminarPerfil, cn.conectar()))
                {
                    // Agregar parámetro para evitar inyecciones SQL
                    cmd.Parameters.AddWithValue("@ID_perfil", ID_perfil);

                    // Ejecutar la consulta
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Insertar en bitácora si la eliminación fue exitosa
                    if (rowsAffected > 0)
                    {
                        insertarBitacora(idUsuario, "Eliminó un perfil: " + ID_perfil, "tbl_perfil");
                        return true; // Indica que la eliminación fue exitosa
                    }
                    else
                    {
                        return false; // No se afectó ninguna fila
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/



        //AGREGAR
        //KATERYN DE LEON

        //--------------------------------------------------------------- Inicio: Marco Monroy ---------------------------------------------------------------
        public OdbcDataAdapter insertarusuario(string nombre, string apellido, string id, string clave, string correo, string fecha, string estadousuario, string pregunta, string respuesta)
        {
            // Consulta SQL con concatenación de valores (esto es menos seguro, pero funciona en tu caso)
            string sqlusuarios = "INSERT INTO tbl_usuarios (nombre_usuario, apellido_usuario, username_usuario, password_usuario, email_usuario, ultima_conexion_usuario, estado_usuario, pregunta, respuesta) " +
                                 "VALUES ('" + nombre + "', '" + apellido + "', '" + id + "', '" + clave + "', '" + correo + "', '" + fecha + "', '" + estadousuario + "', '" + pregunta + "', '" + respuesta + "')";

            // Crear el comando y asignar la conexión
            OdbcDataAdapter datausuarios = new OdbcDataAdapter(sqlusuarios, cn.conectar());

            try
            {

                return datausuarios; // Retorna si la inserción fue exitosa
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y manejarla
                Console.WriteLine("Error al insertar el usuario: " + ex.Message);

                // Retornar null o manejar de acuerdo a tus necesidades
                return null;
            }
        }


    //--------------------------------------------------------------- Fin: Marco Monroy ---------------------------------------------------------------


    public OdbcDataAdapter insertarclaves(string id, string nombre, string apellido, string clave)
        {
            cn.conectar();
            MessageBox.Show("Contraseña Actualizada");
            string sqlconsulta = "UPDATE tbl_usuario set PK_id_usuario='" + id + "',nombre_usuario='" + apellido + "',apellido_usuarios='" + nombre + "',password_usuario='" + clave + "',estado_usuario='1' where PK_id_usuario='" + id + "'";
            OdbcDataAdapter dataconsulta = new OdbcDataAdapter(sqlconsulta, cn.conectar());
            return dataconsulta;
        }

        public OdbcDataAdapter update(string usuario)
        {
            cn.conectar();
            string sqlconsulta = "select PK_id_perfil FROM tbl_usuario_perfil where PK_id_usuario = '" + usuario + "'";
            OdbcDataAdapter dataconsulta = new OdbcDataAdapter(sqlconsulta, cn.conectar());
            return dataconsulta;

        }


        public OdbcDataAdapter clienteupdate(string clave, string usuario)
        {
            cn.conectar();
            MessageBox.Show("Contraseña Actualizada");
            string sqlconsulta = "UPDATE tbl_usuario set password_usuario='" + clave + "' where PK_id_usuario='" + usuario + "'";
            OdbcDataAdapter dataconsulta = new OdbcDataAdapter(sqlconsulta, cn.conectar());
            return dataconsulta;
        }


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public void insertaraplicacion(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                // Crear la conexión y el comando
                using (OdbcConnection connection = cn.conectar())
                {
                    string query = "INSERT INTO tbl_aplicaciones (" +
                                   "Pk_id_aplicacion, " +
                                   "nombre_aplicacion, " +
                                   "descripcion_aplicacion, " +
                                   "estado_aplicacion) " +
                                   "VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@Pk_id_modulo", codigo);
                        cmd.Parameters.AddWithValue("@nombre_modulo", nombre);
                        cmd.Parameters.AddWithValue("@descripcion_modulo", descripcion);
                        cmd.Parameters.AddWithValue("@estado_modulo", estado);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        insertarBitacora(idUsuario, "Inserto un nuevo modulo: " + codigo + " - " + nombre, "tbl_aplicaciones");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la aplicación: " + ex.Message);
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //---------------------------------------------------- Inicio: GABRIELA SUC ----------------------------------------------------

        public int eliminarusuario(string id)
        {
            string sqleliminar = "DELETE FROM tbl_usuarios WHERE PK_id_usuario = ?";
            // '?' es un marcador de posición para un parámetro que será reemplazado posteriormente
            // Este método de parametrización protege contra inyecciones SQL y permite que el valor del parámetro (id) se inserte de manera segura en la consulta

            OdbcCommand cmd = new OdbcCommand(sqleliminar, cn.conectar());
            cmd.Parameters.AddWithValue("@id", id);

            int filasAfectadas = 0;

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery(); // Ejecutar el comando y devolver el número de filas afectadas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }

            return filasAfectadas; // Devolver el número de filas afectadas
        }

        //---------------------------------------------------- Fin: GABRIELA SUC ----------------------------------------------------


        // Esta parte fue echa por Carlos Hernandez
        public OdbcDataAdapter actualizaraplicacion(string codigo, string nombre, string descripcion, string estado)
        {
            Console.WriteLine("ESTO SE INGRESA EN LA SENTENCIA: " + codigo + ", " + nombre + ", " + descripcion + ", " + estado);
            try
            {
                cn.conectar();
                string sqlactualizaraplicacion = "UPDATE tbl_aplicaciones SET nombre_aplicacion = '" + nombre + "', descripcion_aplicacion = '" + descripcion + "', estado_aplicacion = '" + estado + "' WHERE Pk_id_aplicacion ='" + codigo + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlactualizaraplicacion, cn.conectar());
                insertarBitacora(idUsuario, "Actualizo una aplicacion: " + codigo + " - " + nombre, "tbl_aplicaciones");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }
        //termina lo que hizo carlos hernandez 


        public bool eliminaraplicacion(string codigo)
        {
            try
            {

                cn.conectar();


                string sqlEliminarAplicacion = "DELETE FROM tbl_aplicaciones WHERE Pk_id_aplicacion = ?";

                using (OdbcCommand cmd = new OdbcCommand(sqlEliminarAplicacion, cn.conectar()))
                {

                    cmd.Parameters.AddWithValue("@codigo", codigo);


                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        insertarBitacora(idUsuario, "Eliminó una aplicacion: " + codigo, "tbl_aplicaciones");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }

        //Kateryn De León
        //MOSTRAR PARA  EL BOTON BUSCAR 
        public OdbcDataAdapter mostrar(string id)
        {
            OdbcConnection connection = cn.conectar();

            string sqlusuarios = "SELECT pk_id_usuario, nombre_usuario, apellido_usuario, username_usuario, password_usuario, email_usuario, ultima_conexion_usuario, estado_usuario,pregunta,respuesta  FROM tbl_usuarios where pk_id_usuario = '" + id + "'";

            OdbcCommand command = new OdbcCommand(sqlusuarios, connection);

            try
            {
                // Ejecutar la consulta de inserción
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al insertar usuario: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }

            OdbcDataAdapter datausuarios = new OdbcDataAdapter(sqlusuarios, cn.conectar());

            if (datausuarios == null)
            {
                return null;
            }
            else
                return datausuarios;
        }
        public OdbcDataAdapter mostraraplicacion(string id)
        {

            cn.conectar();
            string sqlusuarios = "SELECT PK_id_aplicacion,PK_id_modulo,nombre_aplicacion,descripcion_aplicacion from tbl_aplicacion WHERE PK_id_aplicacion ='" + id + "'";
            OdbcDataAdapter datausuarios = new OdbcDataAdapter(sqlusuarios, cn.conectar());

            if (datausuarios == null)
            {
                return null;
            }
            else
                return datausuarios;
        }

        //****************************************Kevin López***************************************************
        public OdbcDataAdapter consultaraplicaciones(string aplicacion)
        {
            cn.conectar();
            string sqlAplicaciones = "SELECT Pk_id_aplicacion, nombre_aplicacion FROM Tbl_aplicaciones";
            insertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "Tbl_aplicaciones");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlAplicaciones, cn.conectar());
            return dataTable;
        }

        //**************************************** FIN Kevin López***************************************************

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/


        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public OdbcDataAdapter validarIDModulos()
        {
            try
            {

                string sqlIDmodulo = "SELECT MAX(Pk_id_modulo)+1 FROM tbl_modulos";
                OdbcDataAdapter dataIDmodulo = new OdbcDataAdapter(sqlIDmodulo, cn.conectar());
                return dataIDmodulo;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // termina
        public OdbcDataAdapter validarIDperfiles()
        {
            try
            {

                string sqlIDperfil = "SELECT MAX(Pk_id_perfil)+1 FROM Tbl_perfiles";
                OdbcDataAdapter dataIDperfil = new OdbcDataAdapter(sqlIDperfil, cn.conectar());
                return dataIDperfil;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }




        public OdbcDataAdapter insertarPerfil(string codigo, string nombre, string descripcion, string estado)
        {
            cn.conectar();
            try
            {
                string sqlPerfil = "INSERT INTO Tbl_perfiles (Pk_id_Perfil, nombre_perfil, descripcion_perfil, estado_perfil) VALUES ('" + codigo + "','" + nombre + "', '" + descripcion + "', " + estado + ");";
                OdbcDataAdapter datainsertarperfil = new OdbcDataAdapter(sqlPerfil, cn.conectar());
                insertarBitacora(idUsuario, "Inserto un nuevo perfil: " + codigo + " - " + nombre, "Tbl_perfiles");
                return datainsertarperfil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //*****************ACA TERMINA LA PRIMERA PARTE ACTUALIZADA POR JOSUÉ DAVID PAZ GÓMEZ*************************


        public OdbcDataAdapter ConsultarPerfil(string perfil)
        {
            cn.conectar();
            string sqlPerfil = "SELECT * FROM Tbl_perfiles WHERE Pk_id_perfil = " + perfil;
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlPerfil, cn.conectar());
            insertarBitacora(idUsuario, "Realizo una consulta a perfiles ", "Tbl_perfiles");

            return dataTable;
        }

        public OdbcDataAdapter ActualizarPerfil(string ID_perfil, string nombre, string descripcion, string estado)
        {
            try
            {
                cn.conectar();
                string sqlactualizarperfil = "UPDATE Tbl_perfiles SET nombre_perfil = '" + nombre + "', descripcion_perfil = '" + descripcion + "', estado_perfil = '" + estado + "' WHERE Pk_id_perfil ='" + ID_perfil + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlactualizarperfil, cn.conectar());
                insertarBitacora(idUsuario, "Actualizo un perfil: " + ID_perfil + " - " + nombre, "Tbl_perfiles");

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        //Trabajado por María José Véliz Ochoa 9959-21-5909
        //se optó por usar OdbcCommand en lugar de OdbcDataAdapter, cambió estructura
        public void insertarModulo(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                // Crear la conexión y el comando
                using (OdbcConnection connection = cn.conectar())
                {
                    string query = "INSERT INTO tbl_modulos (" +
                                   "Pk_id_modulos, " +
                                   "nombre_modulo, " +
                                   "descripcion_modulo, " +
                                   "estado_modulo) " +
                                   "VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@Pk_id_modulo", codigo);
                        cmd.Parameters.AddWithValue("@nombre_modulo", nombre);
                        cmd.Parameters.AddWithValue("@descripcion_modulo", descripcion);
                        cmd.Parameters.AddWithValue("@estado_modulo", estado);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        insertarBitacora(idUsuario, "Inserto un nuevo modulo: " + codigo + " - " + nombre, "tbl_modulos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar módulo: " + ex.Message);
            }
        }
        // termina
        //------------


        public OdbcDataAdapter insertarPermisosPerfilA(string codigoPerfil, string nombreAplicacion, string ingresar, string consulta, string modificar, string eliminar, string imprimir)
        {
            string sCodigoAplicacion = " ";
            string sCodigoPerfil = "";

            try
            {
                OdbcCommand sqlCodigoModulo = new OdbcCommand("SELECT PK_id_aplicacion FROM tbl_aplicacion WHERE nombre_aplicacion = '" + nombreAplicacion + "' ", cn.conectar());
                OdbcDataReader almacena = sqlCodigoModulo.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoAplicacion = almacena.GetString(0);
                }

                OdbcCommand sqlCodigoPerfil = new OdbcCommand("SELECT PK_id_perfil FROM tbl_perfil_encabezado WHERE nombre_perfil = '" + codigoPerfil + "' ", cn.conectar());
                OdbcDataReader almacenaPerfil = sqlCodigoPerfil.ExecuteReader();

                while (almacenaPerfil.Read() == true)
                {
                    sCodigoPerfil = almacenaPerfil.GetString(0);
                }

                string sqlInsertarPermisosPerfilApp = "INSERT INTO tbl_perfil_detalle(PK_id_perfil, PK_id_aplicacion, ingresar, consultar, modificar, eliminar, imprimir) VALUES ('" + sCodigoPerfil + "', '" + sCodigoAplicacion + "', '" + ingresar + "', '" + consulta + "', '" + modificar + "', '" + eliminar + "', '" + imprimir + "');";
                OdbcDataAdapter dataPermisosPerfilAplicacion = new OdbcDataAdapter(sqlInsertarPermisosPerfilApp, cn.conectar());
                insertarBitacora(idUsuario, "Asigno permiso: " + nombreAplicacion + " a perfil: " + codigoPerfil, "tbl_usuario_aplicacion");


                almacena.Close();
                sqlCodigoModulo.Connection.Close();

                return dataPermisosPerfilAplicacion;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }


        //------------Para formulario Mantenimiento Modulos---------

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public OdbcDataAdapter ConsultarModulos(string modulo)
        {
            cn.conectar();
            string sqlModulos = "SELECT * FROM tbl_modulos WHERE Pk_id_modulos = " + modulo;
            insertarBitacora(idUsuario, "Realizo una consulta a modulos", "tbl_modulos");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlModulos, cn.conectar());
            return dataTable;
        } //termina

        //###############ALYSON RODRIGUEZ BOTON ACTUALIZAR : creo que solo cambie que el nombre de la tabla estuviera bien
        public OdbcDataAdapter ActualizarModulo(string ID_modulo, string nombre, string descripcion, string estado)
        {
            Console.WriteLine("ESTO SE INGRESA EN LA SENTENCIA: " + ID_modulo + ", " + nombre + ", " + descripcion + ", " + estado);
            try
            {
                cn.conectar();
                string sqlactualizarmodulo = "UPDATE tbl_modulos SET nombre_modulo = '" + nombre + "', descripcion_modulo = '" + descripcion + "', estado_modulo = '" + estado + "' WHERE PK_id_modulos ='" + ID_modulo + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlactualizarmodulo, cn.conectar());
                insertarBitacora(idUsuario, "Actualizo un modulo: " + ID_modulo + " - " + nombre, "tbl_modulos");
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // ########### FIN  ##########################################



        // Inicio Fernando Garcia - Brandon Boch

        public DataSet consultarBitacora()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_id_bitacora as Id, FK_id_usuario as Usuario, fecha_bitacora, hora_bitacora, host_bitacora, ip_bitacora, accion_bitacora from tbl_bitacora"
                , cn.conectar());
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }

            return ds;
        }

        public void insertarBitacora(string idUsuario, string accion, string tabla)
        {
            try
            {
                string ipLocal = ObtenerDireccionIPLocal();
                string nombreHost = Dns.GetHostName();

                using (OdbcConnection conexion = cn.conectar())
                {
                    string obtenerIdUsuarioQuery = "SELECT Pk_id_usuario FROM Tbl_usuarios WHERE nombre_usuario = ?";
                    OdbcCommand obtenerIdUsuarioCmd = new OdbcCommand(obtenerIdUsuarioQuery, conexion);
                    obtenerIdUsuarioCmd.Parameters.AddWithValue("?", idUsuario);



                    object resultado = obtenerIdUsuarioCmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        string usuario = resultado.ToString();

                        string consulta = @"INSERT INTO tbl_bitacora 
                                (Fk_id_usuario, fecha_bitacora, hora_bitacora, host_bitacora, ip_bitacora, accion_bitacora) 
                                VALUES (?, ?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(consulta, conexion))
                        {
                            cmd.Parameters.AddWithValue("?", usuario);
                            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("HH:mm:ss"));
                            cmd.Parameters.AddWithValue("?", nombreHost);
                            cmd.Parameters.AddWithValue("?", ipLocal);
                            cmd.Parameters.AddWithValue("?", accion);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Registrar la excepción o manejarla apropiadamente
                MessageBox.Show("Error al insertar en la bitácora: " + ex.Message);
                // throw;
            }
        }
        private string ObtenerDireccionIPLocal()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "No se pudo determinar la dirección IP local";
        }

        //Fin


        public bool consultarPermisos(string idUsuario, string idAplicacion, int tipoPermiso)
        {

            try
            {
                switch (tipoPermiso)
                {
                    case 1:

                        OdbcCommand sql = new OdbcCommand("Select ingresar from tbl_usuario_aplicacion WHERE PK_id_usuario= '" + idUsuario + "' AND PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        OdbcDataReader almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select tbl_perfil_detalle.ingresar from tbl_perfil_detalle " +
                            "INNER JOIN tbl_usuario_perfil ON tbl_perfil_detalle.PK_id_perfil = tbl_usuario_perfil.PK_id_perfil" +
                            " WHERE tbl_usuario_perfil.PK_id_usuario= '" + idUsuario + "' AND tbl_perfil_detalle.PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                    case 2:

                        sql = new OdbcCommand("Select consultar from tbl_usuario_aplicacion WHERE PK_id_usuario= '" + idUsuario + "' AND PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select tbl_perfil_detalle.consultar from tbl_perfil_detalle " +
                            "INNER JOIN tbl_usuario_perfil ON tbl_perfil_detalle.PK_id_perfil = tbl_usuario_perfil.PK_id_perfil" +
                            " WHERE tbl_usuario_perfil.PK_id_usuario= '" + idUsuario + "' AND tbl_perfil_detalle.PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                    case 3:

                        sql = new OdbcCommand("Select modificar from tbl_usuario_aplicacion WHERE PK_id_usuario= '" + idUsuario + "' AND PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select tbl_perfil_detalle.modificar from tbl_perfil_detalle " +
                            "INNER JOIN tbl_usuario_perfil ON tbl_perfil_detalle.PK_id_perfil = tbl_usuario_perfil.PK_id_perfil" +
                            " WHERE tbl_usuario_perfil.PK_id_usuario= '" + idUsuario + "' AND tbl_perfil_detalle.PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                    case 4:

                        sql = new OdbcCommand("Select eliminar from tbl_usuario_aplicacion WHERE PK_id_usuario= '" + idUsuario + "' AND PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select tbl_perfil_detalle.eliminar from tbl_perfil_detalle " +
                            "INNER JOIN tbl_usuario_perfil ON tbl_perfil_detalle.PK_id_perfil = tbl_usuario_perfil.PK_id_perfil" +
                            " WHERE tbl_usuario_perfil.PK_id_usuario= '" + idUsuario + "' AND tbl_perfil_detalle.PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                    case 5:

                        sql = new OdbcCommand("Select imprimir from tbl_usuario_aplicacion WHERE PK_id_usuario= '" + idUsuario + "' AND PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        sql = new OdbcCommand("Select tbl_perfil_detalle.imprimir from tbl_perfil_detalle " +
                            "INNER JOIN tbl_usuario_perfil ON tbl_perfil_detalle.PK_id_perfil = tbl_usuario_perfil.PK_id_perfil" +
                            " WHERE tbl_usuario_perfil.PK_id_usuario= '" + idUsuario + "' AND tbl_perfil_detalle.PK_id_aplicacion ='" + idAplicacion + "'", cn.conectar());
                        almacena = sql.ExecuteReader();

                        if (almacena.Read() == true)
                        {
                            if (almacena.GetString(0) == "1")
                            {
                                almacena.Close();
                                sql.Connection.Close();
                                return true;
                            }
                        }

                        break;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return false;
        }

        //###############INICIA CÓDIGO PARA BOTON ELIMINAR ALYSON RODRÍGUEZ 
        public OdbcDataAdapter EliminarModulo(string ID_modulo, string nombre, string descripcion, string estado)
        {
            Console.WriteLine("ESTO SE INGRESA EN LA SENTENCIA: " + ID_modulo + ", " + nombre + ", " + descripcion + ", " + estado);
            try
            {
                using (OdbcConnection connection = cn.conectar())
                {
                    string sqlBorrarModulo = "UPDATE tbl_modulos SET nombre_modulo = ?, descripcion_modulo = ?, estado_modulo = '0' WHERE PK_id_modulos = ?";

                    using (OdbcCommand command = new OdbcCommand(sqlBorrarModulo, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("?", nombre);
                        command.Parameters.AddWithValue("?", descripcion);
                        command.Parameters.AddWithValue("?", ID_modulo);

                        // Crear un OdbcDataAdapter para ejecutar el comando de actualización
                        OdbcDataAdapter adapter = new OdbcDataAdapter();
                        adapter.UpdateCommand = command;

                        // Ejecutar el comando de actualización
                        adapter.UpdateCommand.ExecuteNonQuery();

                        // Registrar la acción en la bitácora
                        insertarBitacora(idUsuario, "Eliminó un módulo: " + ID_modulo + " - " + nombre, "tbl_modulos");

                        return adapter; // Aunque no se usa típicamente así, se retorna el adaptador
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar el borrado lógico del módulo: " + ex.Message);
                return null;
            }
        }
        //########################FINALIZA CÓDIGO BOTÓN ELIMINAR ALYSON RODRIGUEZ




        //###################  empieza lo que hizo Karla  Sofia Gómez Tobar #######################
        // combo usuario y perfil

        public string[] llenarCmbUsuario(string tabla, string campo1, string campo2)
        {
            conexion cn = new conexion();
            string[] Campos = new string[300];
            int i = 0;

            string sql = "SELECT DISTINCT " + campo1 + "," + campo2 + " FROM " + tabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(sql);
                MessageBox.Show(sql);

                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + tabla + "\n -" + campo1);
            }

            return Campos;
        }


        public DataTable obtenerUsuario(string tabla, string campo1, string campo2)
        {
            conexion cn = new conexion();
            string sql = "SELECT DISTINCT " + campo1 + "," + campo2 + " FROM " + tabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/

        public string[] llenarCmbPerfiles(string tabla, string campo1, string campo2)
        {
            conexion cn = new conexion();
            string[] Campos = new string[300];
            int i = 0;

            string sql = "SELECT DISTINCT " + campo1 + "," + campo2 + " FROM " + tabla;


            try
            {

                Console.Write(sql);
                MessageBox.Show(sql);

                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + tabla + "\n -" + campo1);
            }

            return Campos;
        }


        public DataTable obtenerPerfiles(string tabla, string campo1, string campo2)
        {
            conexion cn = new conexion();
            string sql = "SELECT DISTINCT " + campo1 + "," + campo2 + " FROM " + tabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }

        // ////////////////////////////////////////////////////////////////


        public string[] llenarCboAsigUP(string tabla, string campo1)
        {
            conexion cn = new conexion();
            string[] Campos = new string[300];
            int i = 0;

            string sql = "SELECT DISTINCT " + campo1 + " FROM " + tabla;


            try
            {

                Console.Write(sql);
                MessageBox.Show(sql);

                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + tabla + "\n -" + campo1);
            }

            return Campos;
        }


        public DataTable obtenerAsigUP(string tabla, string campo1)
        {
            conexion cn = new conexion();
            string sql = "SELECT DISTINCT " + campo1 + " FROM " + tabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################


    }
}