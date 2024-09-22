using System;
using System.Data;
using CapaDatos;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaLogica
{
    public class logica
    {

        sentencia sn;

        public logica(string idUsuario)
        {
            sn = new sentencia(idUsuario);
        }

        public DataTable funconsultaLogicaUsuarios()
        {

            try
            {
                OdbcDataAdapter dtUsuario = sn.funconsultarUsuarios();
                DataTable tableUsuario = new DataTable();
                dtUsuario.Fill(tableUsuario);
                return tableUsuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public DataTable funconsultalogicamodulos()
        {
            try
            {
                OdbcDataAdapter dtModulos = sn.funconsultarmodulos();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funconsultalogicaperfiles()
        {
            try
            {
                OdbcDataAdapter dtPerfiles = sn.funconsultarperfiles();
                DataTable tablePerfiles = new DataTable();
                dtPerfiles.Fill(tablePerfiles);
                return tablePerfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public DataTable funconsultaLogicaAplicaciones(string sID_aplicacion)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.proconsultaraplicaciones(sID_aplicacion)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableAplicaciones = new DataTable();
                    cmpsAplicaciones.Fill(tableAplicaciones);
                    return tableAplicaciones;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }

        }

        //Trabajado por Alysson y María José
        public DataTable funConsultaLogicaAplicaciones(string sID_aplicacion)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.funconsultarAplicaciones(sID_aplicacion)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableAplicaciones = new DataTable();
                    cmpsAplicaciones.Fill(tableAplicaciones);
                    return tableAplicaciones;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }

        }

        public DataTable funconsultaLogicaPerfilesUsuarios()
        {


            try
            {
                OdbcDataAdapter dt = sn.funmostrarPerfilesDeUsuario();
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }


        }

        public bool funconsultaLogicaInsertarPerfilUsuario(string scodigoUsuario, string scodigoPerfil)
        {
            try
            {
                sn.proinsertarPerfilUsuario(scodigoUsuario, scodigoPerfil);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el asignacion: " + ex.Message);
                return false;
            }
        }

        public DataTable funvalidarIDAplicacion()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.funvalidarIDAplicacion();
                DataTable tableValidacionIdAplicacion = new DataTable();
                dtValidarIDAplicacion.Fill(tableValidacionIdAplicacion);
                return tableValidacionIdAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public bool funinsertaraplicaciones(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {

                sn.proinsertaraplicacion(scodigo, snombre, sdescripcion, sestado);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el aplicacion: " + ex.Message);
                return false;
            }
        }


        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //Trabajado María José Véliz
        //Se cambiaron de lugar los parámetros por la base de datos
        public DataTable funConsultaLogicaPermisosUsuarioAplicacion(string sCodigoUsuario, string sNombreAplicacion, string sIngresar, string sConsulta, string sModificar, string sEliminar, string sImprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosUA = sn.funInsertarPermisosUA(sCodigoUsuario, sNombreAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);
                DataTable tablePermisosUA = new DataTable();
                dtPermisosUA.Fill(tablePermisosUA);
                return tablePermisosUA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //termina

        //Trabajado por ALyson Rodriguez 9959-21-829
      
        public DataTable funConsultaLogicaUsuarios(string sAplicacionUsuario)
        {

            // Llamar al método que retorna un DataTable
            DataTable table = new DataTable();
            OdbcDataAdapter dt = sn.funMostrarUsuariosYPermisos(sAplicacionUsuario); // Cambio en el nombre del método para reflejar permisos
            dt.Fill(table);
            return table;
        }
        //Finaliza

 

        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------- 

        public bool ModificarUsuario(string idUsuario, string nombre, string apellido, string correo, int estado_usuario, string respuesta)
        {
            return sn.ModificarUsuario(idUsuario, nombre, apellido, correo, estado_usuario, respuesta);
        }

        //---------------------------------------------------- Fin: GABRIELA SUC ---------------------------------------------------- 

        /* creado por Emerzon Garcia  0901-21-9182 ...... */

        public bool funeliminarperfil(string sID_perfil)
        {
            try
            {
                bool result = sn.funeliminarperfil1(sID_perfil);
                if (result)
                {
                    MessageBox.Show("Perfil eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el perfil.");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        /*----------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        // cambiado ingresar datos
        //Kateryn de leon
        public DataTable usuarios(string nombre, string apellido, string id, string clave, string correo, string fecha, string estadousuario, string pregunta, string respuesta)//int boton
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.insertarusuario(nombre, apellido, id, clave, correo, fecha, estadousuario, pregunta, respuesta);//boton
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //ACA 

        public DataTable clave(string id, string nombre, string apellido, string clave)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.insertarclaves(id, nombre, apellido, clave);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable updateclave(string usuario)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.update(usuario);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable updatecliente(string clave, string usuario)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.clienteupdate(clave, usuario);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


   

        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------- 

        // Método para eliminar (inactivar) un usuario
        public bool EliminarUsuario(string idUsuario)
        {
            // Llama al método de la capa de datos para actualizar el estado
            return sn.CambiarEstadoUsuario(idUsuario, 0);
        }

        //---------------------------------------------------- Fin: GABRIELA SUC ---------------------------------------------------- 

        //Esta parte fue echa por Carlos Hernandez
        public DataTable actualizaraplicaciones(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtModificar = sn.actualizaraplicacion(codigo, nombre, descripcion, estado);
                DataTable tableAplicacion = new DataTable();
                dtModificar.Fill(tableAplicacion);
                return tableAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //termina lo que hizo carlos hernandez 

        public bool eliminaraplicaciones(string codigo)
        {
            try
            {
                bool result = sn.eliminaraplicacion(codigo);
                if (result)
                {
                    MessageBox.Show("Perfil eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el perfil.");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }


        //BUSCARRRRRR
        //kateryn de leon
        public DataTable buscar(string id)
        {
            try
            {

                OdbcDataAdapter dtusuario = sn.mostrar(id);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                if (tableusuarios == null)
                    return null;
                else
                    return tableusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable buscaraplicacion(string id)
        {
            try
            {

                OdbcDataAdapter dtusuario = sn.mostraraplicacion(id);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                if (tableusuarios == null)
                    return null;
                else
                    return tableusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

    

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable funcValidarIdModulos()
        {
            try
            {
                OdbcDataAdapter dtValidarIDModulo = sn.funcValidarIdModulos();
                DataTable tableValidacionIdModulo = new DataTable();
                dtValidarIDModulo.Fill(tableValidacionIdModulo);
                return tableValidacionIdModulo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // termina


        //--------mantenimiento perfiles

        //+1
        public DataTable funagregar()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.funagregarperfil();
                DataTable tableValidacionIdAplicacion = new DataTable();
                dtValidarIDAplicacion.Fill(tableValidacionIdAplicacion);
                return tableValidacionIdAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable funingresarperfiles(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                OdbcDataAdapter ingresoperfil = sn.proinsertarperfil(scodigo, snombre, sdescripcion, sestado);
                DataTable tableperfiles = new DataTable();
                ingresoperfil.Fill(tableperfiles);
                return tableperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable funconsultarperfil(string sID_perfil)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sn.proconsultar(sID_perfil);
                DataTable tablaperfiles = new DataTable();
                cmpsperfiles.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable funactualizar(string sID_perfil, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                OdbcDataAdapter dtperfil = sn.funactualizarperfil(sID_perfil, snombre, sdescripcion, sestado);
                DataTable tablaperfiles = new DataTable();
                dtperfil.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }


        }


        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public bool funcIngresarModulo(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                // Ejecutar la inserción
                sn.funcInsertarModulo(codigo, nombre, descripcion, estado);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar el módulo: " + ex.Message);
                return false;
            }
        } // termina



        //*****************************MODIFICADO POR JOSUÉ PAZ*******************************************************
        public DataTable funguardarpermisosperfil(string scodigoPerfil, string snombreAplicacion, string singresar, string smodificar, string seliminar, string sconsulta, string simprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosPerfilA = sn.proinsertarpermisosperfil(scodigoPerfil, snombreAplicacion, singresar, smodificar, seliminar, sconsulta, simprimir);
                DataTable tablePermisosPerfilA = new DataTable();
                dtPermisosPerfilA.Fill(tablePermisosPerfilA);
                return tablePermisosPerfilA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //*****************************ACA TERMINA********************************************************************


        //-----------------------Emerzon Garcia --------------------------------------------------
        public DataTable funconsultarPerfiles(string sTablaPerfilUsuario)
        {
            DataTable table = new DataTable();
            OdbcDataAdapter dt = sn.funmostrarperfilesypermisos(sTablaPerfilUsuario);
            dt.Fill(table);

            // Convertir los valores booleanos a string "0" o "1"
            foreach (DataRow row in table.Rows)
            {
                row["guardar_permiso"] = (Convert.ToBoolean(row["guardar_permiso"]) ? "1" : "0");
                row["buscar_permiso"] = (Convert.ToBoolean(row["buscar_permiso"]) ? "1" : "0");
                row["modificar_permiso"] = (Convert.ToBoolean(row["modificar_permiso"]) ? "1" : "0");
                row["eliminar_permiso"] = (Convert.ToBoolean(row["eliminar_permiso"]) ? "1" : "0");
                row["imprimir_permiso"] = (Convert.ToBoolean(row["imprimir_permiso"]) ? "1" : "0");
            }

            return table;
        }

        //----------------------------------------------------------------------------------------

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable funcConsultaLogicaModulo(string ID_modulo)
        {
            try
            {
                using (OdbcDataAdapter cmpsModulos = sn.funcConsultarModulos(ID_modulo))
                {
                    DataTable tablaModulos = new DataTable();
                    cmpsModulos.Fill(tablaModulos);
                    return tablaModulos;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return null;
            }
        }
        // termina



        public DataTable funcActualizarModulo(string ID_modulo, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.funcActualizarModulo(ID_modulo, nombre, descripcion, estado);
                DataTable tablamodulos = new DataTable();
                dtmodulo.Fill(tablamodulos);
                return tablamodulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        // Fernando García - 0901-21-581 
        public DataSet consultaLogicaBitacora()
        {
            return sn.consultarBitacora();
        }

        // Nuevo método para la búsqueda filtrada de bitácora
        public DataSet consultaLogicaBitacoraFiltrada(string campo, string valor)
        {
            return sn.consultarBitacoraFiltrada(campo, valor);
        }
        //FIN ###########

        //ELIMINAR MODULO ALYSON ##########################################
        public DataTable funcEliminarModulo(string ID_modulo, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.funcEliminarModulo(ID_modulo, nombre, descripcion, estado);
                DataTable tablamodulos = new DataTable();
                dtmodulo.Fill(tablamodulos);
                return tablamodulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //FIN ####################################################################


        /*********************Ismar Leonel Cortez Sanchez -0901-21-560************/
        /***********************Combo box inteligente*****************************/

        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmb(tabla, campo1, campo2);
            /*Este arreglo lo obtiene y retorna de la clase senencias del modelo*/
            return Items;

            /*Aqui viene a parar lo de sentencias*/


        }

        public DataTable enviar(string tabla, string campo1, string campo2)
        {


  
            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }
        /**************************************************************************/

        /*********************Ismar Leonel Cortez Sanchez -0901-21-560************/
        /***********************Combo box inteligente 2*****************************/

        public string[] items2(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmb2(tabla, campo1, campo2);
            /*Este arreglo lo obtiene y retorna de la clase senencias del modelo*/
            return Items;

            /*Aqui viene a parar lo de sentencias*/


        }

        public DataTable enviar2(string tabla, string campo1, string campo2)
        {


            /**/
            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }
        /**************************************************************************/

        /**************************************************************************/

        //*************KaterynDeLeon*************************
        //buscar
        public DataTable consultaLogicaAsigncacionModuloAplicaciones()
        {
            try
            {
                OdbcDataAdapter dtModulos = sn.consultarAsignacion_moduloAplicaciones();
                DataTable tableModulosApli = new DataTable();
                dtModulos.Fill(tableModulosApli);
                return tableModulosApli;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //*************************************************************************************/
        //*************KaterynDeLeon************************
        // Inicio ( crear)

        public int ObtenerOInsertarModulo(string nombreModulo)
        {
            return sn.ObtenerIdModulo(nombreModulo);
        }

        public int ObtenerOInsertarAplicacion(string nombreAplicacion)
        {
            return sn.ObtenerIdAplicacion(nombreAplicacion);
        }

        public bool InsertarLogicaAsignacionModuloAplicacion(int idModulo, int idAplicacion)
        {
            return sn.InsertarAsignacionModuloAplicacion(idModulo, idAplicacion);
        }
    
    //*****************Fin********************************************************************



    //###################  empieza lo que hizo Karla  Sofia Gómez Tobar #######################
    // combo usuario y perfil 
    public string[] funitemsUsuario(string tabla, string campo1, string campo2)
    {
        string[] Items = sn.funllenarCmbUsuario(tabla, campo1, campo2);

        return Items;




    }

    public DataTable funenviarUsuario(string tabla, string campo1, string campo2)
    {

        var dt1 = sn.funobtenerUsuario(tabla, campo1, campo2);

        return dt1;
    }

    public string[] funitemsPerfiles(string tabla, string campo1, string campo2)
    {
        string[] Items = sn.funllenarCmbPerfiles(tabla, campo1, campo2);

        return Items;




    }

    public DataTable funenviarPerfiles(string tabla, string campo1, string campo2)
    {



        var dt1 = sn.funobtenerPerfiles(tabla, campo1, campo2);

        return dt1;
    }


    public string[] funitemsAsigUP(string tabla, string campo1)
    {
        string[] Items = sn.funllenarCboAsigUP(tabla, campo1);

        return Items;




    }

    public DataTable funenviarAsigUP(string tabla, string campo1)
    {


        /**/
        var dt1 = sn.funobtenerAsigUP(tabla, campo1);

        return dt1;
    }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

//********************************KEVIN LOPEZ*************************************************
        public DataTable funconsultaLogicaaplicacionesP(string snombreModulo)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.funconsultaraplicacionesP(snombreModulo)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableAplicaciones = new DataTable();
                    cmpsAplicaciones.Fill(tableAplicaciones);
                    return tableAplicaciones;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }
        }
//********************************FIN KEVIN LOPEZ*************************************************

    }



}


