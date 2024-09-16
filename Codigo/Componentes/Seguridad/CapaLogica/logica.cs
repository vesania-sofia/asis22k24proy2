﻿using System;
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

        public DataTable consultaLogicaUsuarios()
        {
            
            try
            {
                OdbcDataAdapter dtUsuario = sn.consultarUsuarios();
                DataTable tableUsuario = new DataTable();
                dtUsuario.Fill(tableUsuario);
                return tableUsuario;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }

        public DataTable consultaLogicaModulos()
        {
            try
            {
                OdbcDataAdapter dtModulos = sn.consultarModulos();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaPerfiles()
        {
            try
            {
                OdbcDataAdapter dtPerfiles = sn.consultarPerfiles();
                DataTable tablePerfiles = new DataTable();
                dtPerfiles.Fill(tablePerfiles);
                return tablePerfiles;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public DataTable consultaLogicaAplicaciones(string ID_aplicacion)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.consultaraplicaciones(ID_aplicacion))
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
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        public DataTable consultaLogicaPermisosUsuarioAplicacion(string codigoUsuario, string nombreAplicacion, string ingresar, string consulta, string modificar, string eliminar, string imprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosUA = sn.insertarPermisosUA(codigoUsuario, nombreAplicacion, ingresar, consulta, modificar, eliminar, imprimir);
                DataTable tablePermisosUA = new DataTable();
                dtPermisosUA.Fill(tablePermisosUA);
                return tablePermisosUA;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public DataTable consultaLogicaPerfilesUsuarios(string TablaPerfilUsuario)
        {
            DataTable table = new DataTable();
            OdbcDataAdapter dt = sn.mostrarPerfilesDeUsuario(TablaPerfilUsuario);
            dt.Fill(table);
            return table;


        }

        public bool consultaLogicaEliminarPerfilUsuario(string Id_Perfil_Usuario)
        {
            try
            {
                bool result = sn.eliminarPerfilUsuario(Id_Perfil_Usuario);
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

        public bool consultaLogicaInsertarPerfilUsuario(string codigoUsuario, string codigoPerfil)
        {
            try
            {
                sn.insertarPerfilUsuario(codigoUsuario, codigoPerfil);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el asignacion: " + ex.Message);
                return false;
            }
        }
   //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################



        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public DataTable validarIDAplicacion()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.validarIDAplicacion();
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
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------- 
        public void ActualizarUsuario(int idUsuario, string nombre, string apellido, string correo, string estado, string pregunta, string respuesta)
        {
            try
            {
                // Se llama a la capa de datos para actualizar el usuario
                int filasAfectadas = sn.ActualizarUsuario(idUsuario, nombre, apellido, correo, estado, pregunta, respuesta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la capa lógica al actualizar: " + ex.Message);
            }
        }
        //---------------------------------------------------- Fin: GABRIELA SUC ---------------------------------------------------- 

        /* creado por Emerzon Garcia  0901-21-9182 ...... */

        public bool Eliminarperfil(string ID_perfil)
        {
            try
            {
                bool result = sn.EliminarPerfil1(ID_perfil);
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

        public DataTable updatecliente(string clave,string usuario)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.clienteupdate(clave,usuario);
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


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public bool insertaraplicaciones(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {

                sn.insertaraplicacion(codigo, nombre, descripcion, estado);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el aplicacion: " + ex.Message);
                return false;
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //---------------------------------------------------- Inicio: GABRIELA SUC ---------------------------------------------------- 

        public int eliminarusuario(int idUsuario)
        {
            return sn.eliminarusuario(idUsuario.ToString()); // Llamar al método de la capa de datos y devolver el número de filas afectadas
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

        /* public DataTable consultaLogicaaplicaciones()
         {

             try
             {
                 OdbcDataAdapter dt = sn.consultaraplicaciones();
                 DataTable table = new DataTable();
                 dt.Fill(table);
                 return table;
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex);
                 return null;
             }

         }*/

        /*----------------------------------------------------------------------------------------------------------------------------------------------------------------*/


        //+1 modulos

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable validarIDModulos()
        {
            try
            {
                OdbcDataAdapter dtValidarIDModulo = sn.validarIDModulos();
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
        public DataTable validarIDperfiles()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.validarIDperfiles();
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


        public DataTable ingresarperfiles(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter ingresoperfil = sn.insertarPerfil(codigo, nombre, descripcion, estado);
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

        public DataTable ConsultaLogicaPerfil(string ID_perfil)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sn.ConsultarPerfil(ID_perfil);
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


        public DataTable Actualizarperfil(string ID_perfil, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtperfil = sn.ActualizarPerfil(ID_perfil, nombre, descripcion, estado);
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
        public bool ingresarmodulos(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                // Ejecutar la inserción
                sn.insertarModulo(codigo, nombre, descripcion, estado);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar el módulo: " + ex.Message);
                return false;
            }
        } // termina


        //*****************************MODIFICADO POR JOSUÉ PAZ*******************************************************
        public DataTable consultaLogicaPermisosPerfilAplicacion(string codigoPerfil, string nombreAplicacion, string ingresar, string modificar, string eliminar, string consulta, string imprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosPerfilA = sn.insertarPermisosPerfilA(codigoPerfil, nombreAplicacion, ingresar, modificar, eliminar, consulta, imprimir);
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
        public DataTable buscardatid(string bperfil)
        {
            try
            {
                OdbcDataAdapter dtPermisosPerfilA = sn.buscarid(bperfil);
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

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable ConsultaLogicaModulo(string ID_modulo)
        {
            try
            {
                using (OdbcDataAdapter cmpsModulos = sn.ConsultarModulos(ID_modulo))
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



        public DataTable Actualizarmodulo(string ID_modulo,string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.ActualizarModulo(ID_modulo,nombre,descripcion,estado);
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

        public DataSet consultaLogicaBitacora()
        {
            return sn.consultarBitacora();
        }

        //ELIMINAR MODULO ALYSON ##########################################
        public DataTable EliminarModulo(string ID_modulo, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.EliminarModulo(ID_modulo, nombre, descripcion, estado);
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


        //###################  empieza lo que hizo Karla  Sofia Gómez Tobar #######################
        // combo usuario y perfil 
        public string[] itemsUsuario(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbUsuario(tabla, campo1, campo2);

            return Items;




        }

        public DataTable enviarUsuario(string tabla, string campo1, string campo2)
        {


            /**/
            var dt1 = sn.obtenerUsuario(tabla, campo1, campo2);

            return dt1;
        }

        public string[] itemsPerfiles(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbPerfiles(tabla, campo1, campo2);

            return Items;




        }

        public DataTable enviarPerfiles(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.obtenerPerfiles(tabla, campo1, campo2);

            return dt1;
        }


        public string[] itemsAsigUP(string tabla, string campo1)
        {
            string[] Items = sn.llenarCboAsigUP(tabla, campo1);

            return Items;




        }

        public DataTable enviarAsigUP(string tabla, string campo1)
        {


            /**/
            var dt1 = sn.obtenerAsigUP(tabla, campo1);

            return dt1;
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################




    }

}