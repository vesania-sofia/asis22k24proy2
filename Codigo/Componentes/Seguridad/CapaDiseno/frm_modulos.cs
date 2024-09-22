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
    public partial class frm_modulos : Form
    {
        logica logic;

        public frm_modulos(string idUsuario)
        {
            InitializeComponent();
            btn_modif.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_cancel.Enabled = false;
            btn_eliminar.Enabled = false; //se agrega
            logic = new logica(idUsuario);
            txtcodigo.Enabled = false;
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;
            btn_ingresar.Enabled = false;
            gbestado.Enabled = false;
        }

        public frm_modulos()
        {
        }

        void limpiar()
        {
            txt_buscarmodulo.Text = "";
            txtcodigo.Text = "";
            txtdesc.Text = "";
            txtnombre.Text = "";
            rbhabilitado.Checked = false;
            rbinhabilitado.Checked = false;
            txtcodigo.Focus();
        }


        private void Frm_modulos_Load(object sender, EventArgs e)
        {
            txt_buscarmodulo.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtcodigo.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtnombre.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txtdesc.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            // Orden de tabulaciones
            txt_buscarmodulo.TabIndex = 0;
            btn_bsucarmodulo.TabIndex = 1;
            txtcodigo.TabIndex = 2;
            txtnombre.TabIndex = 3;
            txtdesc.TabIndex = 4;
            btn_nuevo.TabIndex = 5;
            btn_ingresar.TabIndex = 6;
            btn_modif.TabIndex = 7;
            btn_actualizar.TabIndex = 8;
            btn_eliminar.TabIndex = 9;
            btn_cancel.TabIndex = 10;

            //limitar caracteres
            txtnombre.MaxLength = 50; // Limita el texto a 50 caracteres
            txtdesc.MaxLength = 150;
            txtcodigo.MaxLength = 20;
        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        private void btn_bsucarmodulo_Click_1(object sender, EventArgs e)
        {
            string modulo = txt_buscarmodulo.Text;

            if (string.IsNullOrWhiteSpace(modulo))
            {
                MessageBox.Show("Por favor, ingrese un ID de módulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Para errores null del DataTable
            try
            {
                DataTable dtModulos = logic.ConsultaLogicaModulo(modulo);

                if (dtModulos == null || dtModulos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron módulos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (DataRow row in dtModulos.Rows)
                {// Asigna el valor de cada columna a su respectivo control en la interfaz si no es nulo
                    if (row[0] != DBNull.Value) txtcodigo.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) txtnombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) txtdesc.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string estado = row[3].ToString();
                        if (estado == "1")
                        {
                            rbhabilitado.Checked = true;
                            rbinhabilitado.Checked = false;
                        }
                        else if (estado == "0")
                        {
                            rbhabilitado.Checked = false;
                            rbinhabilitado.Checked = true;
                        }
                    }
                }

                btn_modif.Enabled = true;
                btn_ingresar.Enabled = false;
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;
                rbhabilitado.Enabled = false;
                rbinhabilitado.Enabled = false;
                btn_cancel.Enabled = true;
                btn_eliminar.Enabled = true; //se agrega

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            gbbuscar.Enabled = false;
            btn_modif.Enabled = false;
            rbhabilitado.Checked = true;
            gbestado.Enabled = true;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            btn_ingresar.Enabled = true;
            btn_cancel.Enabled = true;
            //habilitando para ingresar id
            txtcodigo.Enabled = true;
            btn_eliminar.Enabled = false; //se agrega


            //para errores tipo null
            try
            {
                DataTable dtValidarID = logic.validarIDModulos();
                if (dtValidarID == null || dtValidarID.Rows.Count == 0)
                {
                    //txtcodigo.Text = ""; // Asigna un valor por defecto si no se encuentra ningún ID
                    return;
                }
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0] != DBNull.Value)
                    {
                        txtcodigo.Text = row[0].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }
        // FIN ####################################

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;


            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;

            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;

            }

            else
            {
                string estado = "";
                if (rbhabilitado.Checked)
                {
                    estado = "1";
                }

                if (rbinhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.ingresarmodulos(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente", "Modulo", MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }
            limpiar();
            gbbuscar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_ingresar.Enabled = false;
            txtcodigo.Enabled = false;
            btn_eliminar.Enabled = false; //se agrega
            gbestado.Enabled = false;
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;


            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;

            }

            else
            {
                string estado = "";
                if (rbhabilitado.Checked)
                {
                    estado = "1";
                }

                if (rbinhabilitado.Checked)
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
                    logic.Actualizarmodulo(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                    MessageBox.Show("Modulo Actualizado Correctamente", "Modulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha modificado el modulo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 
                btn_modif.Enabled = false;
                btn_actualizar.Enabled = false;
                btn_cancel.Enabled = false;
                btn_ingresar.Enabled = false;
                gbestado.Enabled = false;
                btn_nuevo.Enabled = true;
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;
                btn_eliminar.Enabled = false; //se agrega  ALyson #####################
                limpiar();
            }
        }

        private void btn_modif_Click_1(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            btn_cancel.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_modif.Enabled = false;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            rbhabilitado.Enabled = true;
            rbinhabilitado.Enabled = true;
            btn_nuevo.Enabled = false;
            gbestado.Enabled = true;
            btn_eliminar.Enabled = false; //se agrega
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            // Deshabilitar botones y campos según sea necesario
            btn_nuevo.Enabled = true;
            btn_actualizar.Enabled = false;
            gbbuscar.Enabled = true;
            btn_modif.Enabled = false;
            rbhabilitado.Checked = false;
            gbestado.Enabled = false;
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_cancel.Enabled = false;
            txtcodigo.Enabled = false;
            btn_eliminar.Enabled = false;

            // Validar el estado seleccionado
            string estado;
            if (rbhabilitado.Checked)
            {
                estado = "1"; // Habilitado
            }
            else if (rbinhabilitado.Checked)
            {
                estado = "0"; // Inhabilitado
            }
            else
            {
                // Asignar un valor predeterminado si ninguno está seleccionado
                estado = "0"; // O "1", dependiendo de tu lógica
            }

            // Validar que se haya ingresado el ID del módulo
            if (string.IsNullOrEmpty(txtcodigo.Text))
            {
                MessageBox.Show("Falta ID del Módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si falta el ID
            }

            if (!string.IsNullOrEmpty(txtcodigo.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este modulo?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método de la lógica de negocio para realizar el borrado lógico
                        logic.EliminarModulo(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado);

                        MessageBox.Show("Módulo eliminado correctamente.", "Modulo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar(); // Limpia los campos del formulario
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar eliminar el módulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un perfil para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }
        // FIN BOTON ELIMINAR ####################################


        //María José para deshabilitar txt código
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            limpiar();
            btn_modif.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_cancel.Enabled = false;
            btn_ingresar.Enabled = false;
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;
            gbbuscar.Enabled = true;
            btn_nuevo.Enabled = true;
            gbestado.Enabled = false;
            txtcodigo.Enabled = false;
            btn_eliminar.Enabled = false; //se agrega
        }
        //termina
        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
        //********************** KATERYN DE LEON y Gabriela Suc ******************************
        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoModulos.chm", "AyudaMantenimientoModulos.html");


            // Define el directorio base desde donde comenzar la búsqueda
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // Usando el directorio base del ejecutable

            // Imprime la ruta base para verificar
            MessageBox.Show("Ruta base: " + baseDirectory);

            // Busca el archivo en el directorio base y sus subdirectorios
            string pathAyuda = FindFileInDirectory(baseDirectory, "Ayuda_Seguridad", "AyudaModulos.chm");

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
        //********************** KATERYN DE LEON y Gabriela Suc  ******************************
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

        //******** FIN KATERYN DE LEON y Gabriela Suc   ********************************************************************.

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

