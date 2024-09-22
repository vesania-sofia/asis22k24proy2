using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using System.Data.Odbc;

using System.IO; // Necesario para Directory, File, Path y SearchOption
using System.Windows.Forms; // Necesario para MessageBox y Help

namespace CapaDiseno
{

    public partial class frm_aplicaciones : Form
    {

        logica logic;

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public frm_aplicaciones(string idUsuario)
        {
            InitializeComponent();
            btn_cancel.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_modif.Enabled = false;
            btn_eliminar.Enabled = false;
            logic = new logica(idUsuario);
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################
        public frm_aplicaciones()
        {
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        void limpiar()
        {
            txt_idaplicacion.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_buscar.Text = "";
            Rdb_activo.Checked = false;
            Rdb_inactivo.Checked = false;
            txt_idaplicacion.Focus();
        }

        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################
        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_aplicaciones_Load(object sender, EventArgs e)
        {
            txt_buscar.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txt_idaplicacion.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txt_nombre.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txt_idaplicacion.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            // Orden de tabulaciones
            txt_buscar.TabIndex = 0;
            btn_bsucarap.TabIndex = 1;
            txt_idaplicacion.TabIndex = 2;
            txt_nombre.TabIndex = 3;
            txt_descripcion.TabIndex = 4;
            btn_nuevo.TabIndex = 5;
            btn_ingresar.TabIndex = 6;
            btn_modif.TabIndex = 7;
            btn_actualizar.TabIndex = 8;
            btn_eliminar.TabIndex = 9;
            btn_cancel.TabIndex = 10;

            //limitar caracteres
            txt_nombre.MaxLength = 50; // Limita el texto a 50 caracteres
            txt_descripcion.MaxLength = 150;
            txt_idaplicacion.MaxLength = 20;
        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar ######################


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_bsucarap_Click(object sender, EventArgs e)
        {
            string aplicacion = txt_buscar.Text;

            if (string.IsNullOrWhiteSpace(aplicacion))
            {
                MessageBox.Show("Por favor, ingrese un ID de una aplicación.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataTable dtAplicacion = logic.consultaLogicaAplicaciones(aplicacion);

                if (dtAplicacion == null || dtAplicacion.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la aplicación.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach (DataRow row in dtAplicacion.Rows)
                {
                    if (row[0] != DBNull.Value) txt_idaplicacion.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) txt_nombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) txt_descripcion.Text = row[2].ToString(); // Asegúrate de que esta columna exista en la consulta
                }

                btn_modif.Enabled = true;
                btn_ingresar.Enabled = false;
                txt_idaplicacion.Enabled = false;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false; // Asegúrate de que este campo esté habilitado si quieres mostrar la descripción

                btn_eliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }



        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            Rdb_activo.Checked = true;
            Gpb_estado.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            gb_buscar.Enabled = false;
            gb_datosaplicacion.Enabled = true;
            btn_modif.Enabled = false;
            btn_ingresar.Enabled = true;
            btn_cancel.Enabled = true;
            txt_idaplicacion.Enabled = true;
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
            btn_eliminar.Enabled = false;
            txt_idaplicacion.Text = "";
            txt_descripcion.Text = "";
           
            try
            {
                DataTable dtValidarID = logic.validarIDAplicacion();
                if (dtValidarID == null || dtValidarID.Rows.Count == 0)
                {

                    return;
                }
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0] != DBNull.Value)
                    {
                        txt_idaplicacion.Text = row[0].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;

            if (txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion", "Nombre de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }
            else if (txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion", "Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }

            else
            {
                string estado = "";
                if (Rdb_activo.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inactivo.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.insertaraplicaciones(txt_idaplicacion.Text.ToString(), txt_nombre.Text.ToString(), txt_descripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente", "Modulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                gb_buscar.Enabled = true;
                btn_ingresar.Enabled = false;
                btn_nuevo.Enabled = true;
                txt_idaplicacion.Enabled = false;
                btn_bsucarap.Enabled = true;
                gb_datosaplicacion.Enabled = false;
                Gpb_estado.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_cancel.Enabled = false;
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //esto fue echo por Carlos hernandez
        private void btn_modif_Click_1(object sender, EventArgs e)
        {
            Rdb_activo.Checked = true;
            Gpb_estado.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = true;
            gb_buscar.Enabled = false;
            btn_modif.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_cancel.Enabled = true;
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
            btn_eliminar.Enabled = false;
        }
        //termina lo que hizo carlos hernandez 
        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }
            else if (txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion", "Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }

            else
            {
                string estado = "";
                if (Rdb_activo.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inactivo.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de modificar este perfil?",
                                                        "Confirmar Modificación",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmResult == DialogResult.Yes)
                {
                    logic.actualizaraplicaciones(txt_idaplicacion.Text.ToString(), txt_nombre.Text.ToString(), txt_descripcion.Text.ToString(), estado.ToString());
                    MessageBox.Show("Modulo Modificado Correctamente", "Modulo", MessageBoxButtons.OK, MessageBoxIcon.Information);         
                }       
                else
                {
                    MessageBox.Show("No se ha modificado el perfil seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiar();
                btn_cancel.Enabled = false;
                btn_bsucarap.Enabled = true;
                btn_nuevo.Enabled = true;
                btn_ingresar.Enabled = false;
                btn_actualizar.Enabled = false;
                btn_modif.Enabled = false;
                btn_eliminar.Enabled = false;
                txt_idaplicacion.Enabled = false;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
                Gpb_estado.Enabled = false;
                gb_buscar.Enabled = true;

            }
        }

        //aqui inica lo que hizo Carlos Hernandez
        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_idaplicacion.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.eliminaraplicaciones(txt_idaplicacion.Text);                
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
            txt_buscar.Enabled = true;
            btn_bsucarap.Enabled = false;
            btn_modif.Enabled = false;
            btn_nuevo.Enabled = true;
            txt_idaplicacion.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
            btn_bsucarap.Enabled = true;
            btn_eliminar.Enabled = false;
            limpiar();  // Limpiar campos
        }
        //aqui termina la parte de Carlos Hernandez

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            limpiar();
            btn_nuevo.Enabled = true;
            gb_buscar.Enabled = true;
            btn_bsucarap.Enabled = true;
            btn_cancel.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_modif.Enabled = false;
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
            btn_eliminar.Enabled = false;

        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################


        //****************************KATERYN DE LEON-******************************
        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoAplicaciones.chm", "Mantenimiento_Aplicaciones.html");


            // Define el directorio base desde donde comenzar la búsqueda
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // Usando el directorio base del ejecutable

            // Imprime la ruta base para verificar
            MessageBox.Show("Ruta base: " + baseDirectory);

            // Busca el archivo en el directorio base y sus subdirectorios
            string pathAyuda = FindFileInDirectory(baseDirectory, "Ayuda_Seguridad", "frmAplicaciones.chm");

            // Imprimir la ruta generada para verificar
            MessageBox.Show("Ruta de ayuda: " + pathAyuda);

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm
                Help.ShowHelp(this, pathAyuda);
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }
        }

        //**********************KATERYN DE LEON ******************************
        private string FindFileInDirectory(string rootDirectory, string folderName, string fileName)
        {
            try
            {
                // Imprime la ruta raíz para verificar
                MessageBox.Show("Buscando en: " + rootDirectory);

                // Busca la carpeta y el archivo
                foreach (string directory in Directory.GetDirectories(rootDirectory, folderName, SearchOption.AllDirectories))
                {
                    MessageBox.Show("Carpeta encontrada: " + directory); // Imprime las carpetas encontradas
                    string filePath = Path.Combine(directory, fileName);
                    if (File.Exists(filePath))
                    {
                        return filePath; // Devuelve la primera coincidencia encontrada
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }
            return null; // No se encontró el archivo
        }

        //*************FIN KATERYN DE LEON***********************************************************

        //Fernando García 0901-21-581
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es un número o si es la tecla de Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número o la tecla de retroceso, cancelar el evento
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra o una tecla de control como backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es una letra, espacio o tecla de control, cancela el evento
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
