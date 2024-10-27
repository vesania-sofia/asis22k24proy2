using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;
using System.Data.Odbc;
using System.IO;
namespace Capa_Vista_Seguridad
{

    public partial class frm_aplicaciones : Form
    {

        logica logic;

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public frm_aplicaciones(string idUsuario)
        {
            InitializeComponent();
            Btn_cancelar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;
            logic = new logica(idUsuario);
            Txt_idaplicacion.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
            Rdb_habilitado.Checked = false;
            Rdb_inhabilitado.Checked = false;

            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_nuevo, "Crear aplicación");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_ingresar, "Guardar aplicación");
            ToolTip tactualizar = new ToolTip();
            tactualizar.SetToolTip(Btn_actualizar, "Actualizar Cambios");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_bsucar, "Buscar aplicación");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(Btn_modificar, "Modificar aplicación");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(Btn_eliminar, "Eliminar aplicación");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Cancelar Cambios");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir Mantenimiento de aplicaciones");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
            mostraraplicaciones();
        }

        public frm_aplicaciones()
        {
        }


        void prolimpiar()
        {
            Txt_idaplicacion.Text = "";
            Txt_nombre.Text = "";
            Txt_descripcion.Text = "";
            Txt_buscar.Text = "";
            Rdb_habilitado.Checked = false;
            Rdb_inhabilitado.Checked = false;
            Txt_idaplicacion.Focus();
        }

        /**************Ismar Cortez*********************/
        /***************Mostrar aplicaciones**************/
        void mostraraplicaciones(){
            try
            {
                DataTable dtaplicaciones;
           
                dtaplicaciones = logic.Funmostraraplicaciones();
                

                if (dtaplicaciones == null || dtaplicaciones.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dgv_aplicaciones.DataSource = dtaplicaciones;

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }
        /*************************************************/


        private void Frm_aplicaciones_Load(object sender, EventArgs e)
        {

        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            prolimpiar();
        }


        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoAplicaciones.chm", "Mantenimiento_Aplicaciones.html");
        }

        private void Btn_bsucar_Click(object sender, EventArgs e)
        {
            string aplicacion = Txt_buscar.Text;

            if (string.IsNullOrWhiteSpace(aplicacion))
            {
                MessageBox.Show("Por favor, ingrese un ID de una aplicacion.");
                return;
            }

            try
            {
                DataTable dtAplicacion = logic.funconsultaLogicaAplicaciones(aplicacion);

                if (dtAplicacion == null || dtAplicacion.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraro la aplicacion.");
                    return;
                }

                foreach (DataRow row in dtAplicacion.Rows)
                {
                    if (row[0] != DBNull.Value) Txt_idaplicacion.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) Txt_nombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) Txt_descripcion.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string estado = row[3].ToString();
                        if (estado == "1")
                        {
                            Rdb_habilitado.Checked = true;
                            Rdb_inhabilitado.Checked = false;
                        }
                        else if (estado == "0")
                        {
                            Rdb_habilitado.Checked = false;
                            Rdb_inhabilitado.Checked = true;
                        }
                    }
                }

                Btn_modificar.Enabled = true;
                Btn_cancelar.Enabled = true;
                Btn_ingresar.Enabled = false;
                Txt_idaplicacion.Enabled = false;
                Btn_nuevo.Enabled = false;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
                Rdb_habilitado.Enabled = false;
                Rdb_inhabilitado.Enabled = false;
                Btn_eliminar.Enabled = true;
                Gpb_estado.Enabled = false;
                Rdb_habilitado.Enabled = true;
                Rdb_inhabilitado.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Gpb_estado.Enabled = true;
            Rdb_habilitado.Checked = true;
            Rdb_inhabilitado.Checked = false;
            Btn_ingresar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Txt_idaplicacion.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_descripcion.Enabled = true;
            Btn_nuevo.Enabled = false;
            Btn_actualizar.Enabled = false;
            Gpb_buscar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;





            //try
            //{
            //    DataTable dtValidarID = logic.funvalidarIDAplicacion();
            //    if (dtValidarID == null || dtValidarID.Rows.Count == 0)
            //    {

            //        return;
            //    }
            //    foreach (DataRow row in dtValidarID.Rows)
            //    {
            //        if (row[0] != DBNull.Value)
            //        {
            //            Txt_idaplicacion.Text = row[0].ToString();
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex);
            //    return;
            //}
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;

            if (Txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
            }
            else if (Txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
            }

            else
            {
                string estado = "";
                if (Rdb_habilitado.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.funinsertaraplicaciones(Txt_idaplicacion.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente");
                prolimpiar();
                Gpb_buscar.Enabled = true;
                Btn_ingresar.Enabled = false;
                Btn_nuevo.Enabled = true;
                Txt_idaplicacion.Enabled = false;
                mostraraplicaciones();
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            Rdb_habilitado.Enabled = true;
            Rdb_inhabilitado.Enabled = false;
            Gpb_estado.Enabled = true;
            Btn_nuevo.Enabled = false;
            Btn_actualizar.Enabled = true;
            Gpb_buscar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_cancelar.Enabled = true;
            Txt_idaplicacion.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_descripcion.Enabled = true;
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
            }
            else if (Txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
            }

            else
            {
                string estado = "";
                if (Rdb_habilitado.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.funactualizaraplicaciones(Txt_idaplicacion.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Modificado Correctamente");
                mostraraplicaciones();
                prolimpiar();
                Btn_cancelar.Enabled = false;
                Btn_bsucar.Enabled = true;
                Btn_nuevo.Enabled = true;
                Btn_ingresar.Enabled = false;
                Btn_actualizar.Enabled = false;
                Btn_modificar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Txt_idaplicacion.Enabled = false;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
                Gpb_estado.Enabled = true;
                Gpb_buscar.Enabled = true;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_idaplicacion.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.funeliminaraplicaciones(Txt_idaplicacion.Text);

                    // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
                    Txt_buscar.Enabled = true;
                    Btn_bsucar.Enabled = false;
                    Btn_modificar.Enabled = false;
                    Btn_nuevo.Enabled = true;
                    Txt_idaplicacion.Enabled = false;
                    Txt_descripcion.Enabled = false;
                    Gpb_estado.Enabled = false;
                    mostraraplicaciones();
                    prolimpiar();  // Limpiar campos
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.");
            }
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            prolimpiar();
            Btn_nuevo.Enabled = true;
            Gpb_buscar.Enabled = true;
            Btn_cancelar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_modificar.Enabled = false;
            Txt_idaplicacion.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
            Rdb_habilitado.Enabled = true;
            Rdb_inhabilitado.Enabled = true;
        }
        //*****************KATERYN DE LEON y Gabriela Suc*************
        private void Btn_ayuda_Click_1(object sender, EventArgs e)
        {

            // Obtener la ruta del directorio del ejecutable
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;

            // Retroceder a la carpeta del proyecto
            string projectPath = Path.GetFullPath(Path.Combine(executablePath, @"..\..\"));
            

            // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
            //string basePath = Path.Combine(projectPath, @"asis22k24proy2\Codigo\Componentes\Seguridad");
            //MessageBox.Show("2" + basePath);


            string ayudaFolderPath = Path.Combine(projectPath, "Ayuda_Seguridad");

            // Imprimir la ruta de ayuda para verificar
            //MessageBox.Show("3: " + ayudaFolderPath);

            // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
            string pathAyuda = FindFileInDirectory(ayudaFolderPath, "frmAplicaciones.chm");

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(null, pathAyuda, "Aplicaciones.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }
        }

        private string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.chm", SearchOption.TopDirectoryOnly);

                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        private void Txt_idaplicacion_TextChanged(object sender, EventArgs e)
        {

        }
        //************* Fin KATERYN DE LEON y Gabriela Suc ************************


    }
}

//###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################