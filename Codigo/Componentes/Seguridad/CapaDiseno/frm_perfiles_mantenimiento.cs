using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Necesario para Directory, File, Path y SearchOption
using System.Windows.Forms; // Necesario para MessageBox y Help

namespace CapaDiseno
{
    public partial class frm_perfiles_mantenimiento : Form
    {
        logica logic;

        public frm_perfiles_mantenimiento(string idUsuario)
        {
            InitializeComponent();
            btn_modif.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_cancel.Enabled = false;
            logic = new logica(idUsuario);
            txtcodigo.Enabled = false;
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;
            btn_ingresar.Enabled = false;
            gbestado.Enabled = false;
            btn_eli.Enabled = false;   // se agrega el boton eliminar 

        }

        public frm_perfiles_mantenimiento()
        {
        }

        void limpiar()
        {
            txt_buscarperfil.Text = "";
            txtcodigo.Text = "";
            txtdesc.Text = "";
            txtnombre.Text = "";
            rbhabilitado.Checked = false;
            rbinhabilitado.Checked = false;
            txtcodigo.Focus();
        }
     
        //Fernando García - 0901-21-581
        private void Frm_perfiles_mantenimiento_Load(object sender, EventArgs e)
        {
            txt_buscarperfil.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtcodigo.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtnombre.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txtdesc.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            // Orden de tabulaciones
            txt_buscarperfil.TabIndex = 0;
            btn_bsucarperfil.TabIndex = 1;
            txtcodigo.TabIndex = 2;
            txtnombre.TabIndex = 3;
            txtdesc.TabIndex = 4;
            btn_nuevo.TabIndex = 5;
            btn_ingresar.TabIndex = 6;
            btn_modif.TabIndex = 7;
            btn_actualizar.TabIndex = 8;
            btn_eli.TabIndex = 9;
            btn_cancel.TabIndex = 10;

            //limitar caracteres
            txtnombre.MaxLength = 50; // Limita el texto a 50 caracteres
            txtdesc.MaxLength = 150;
            txtcodigo.MaxLength = 20;
        }


        private void btn_bsucarperfil_Click_1(object sender, EventArgs e)
        {
            string perfil = txt_buscarperfil.Text;
            bool modificar = false;
            bool eliminar = false;
            try
            {
                DataTable dtModulos = logic.ConsultaLogicaPerfil(perfil);

                foreach (DataRow row in dtModulos.Rows)
                {
                    if (row[0] != null)
                        modificar = true;
                    eliminar = true;

                    txtcodigo.Text = (row[0].ToString());
                    txtnombre.Text = (row[1].ToString());
                    txtdesc.Text = (row[2].ToString());
                    if (row[3].ToString() == "1")
                    {
                        rbhabilitado.Checked = true;
                        rbinhabilitado.Checked = false;

                    }
                    if (row[3].ToString() == "0")
                    {
                        rbinhabilitado.Checked = true;
                        rbhabilitado.Checked = false;

                    }
                }

                if (modificar == true)
                {
                    btn_modif.Enabled = true;
                    btn_ingresar.Enabled = false;
                    txtcodigo.Enabled = false;
                    txtnombre.Enabled = false;
                    txtdesc.Enabled = false;
                    rbhabilitado.Enabled = false;
                    rbinhabilitado.Enabled = false;
                }

                if (eliminar == true)             // se crean las ventanas aviertas para el boton eliminar 
                {
                    btn_eli.Enabled = true;
                    btn_ingresar.Enabled = false;
                    txtcodigo.Enabled = false;
                    txtnombre.Enabled = false;
                    txtdesc.Enabled = false;
                    rbhabilitado.Enabled = false;
                    rbinhabilitado.Enabled = false;
                }

                else
                {
                    btn_modif.Enabled = false;
                    MessageBox.Show("No se encontró el perfil buscado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eli.Enabled = false;
            gbbuscar.Enabled = false;
            btn_modif.Enabled = false;
            rbhabilitado.Checked = true;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            btn_ingresar.Enabled = true;
            btn_cancel.Enabled = true;
            gbestado.Enabled = true;
            Gpb_datos.Enabled = true;
            txtcodigo.Enabled = true;
            rbinhabilitado.Enabled = true;
            rbhabilitado.Enabled = true;

            try
            {
                DataTable dtValidarID = logic.validarIDperfiles();
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0].ToString() == "")
                    {
                        txtcodigo.Text = "1";
                    }
                    else
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

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;
            Gpb_datos.Enabled = false;
            gbestado.Enabled = false;


            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btn_nuevo.Enabled = true;

            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_nuevo.Enabled = true;

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

                logic.ingresarperfiles(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                MessageBox.Show("Perfil Ingresado Correctamente", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                gbbuscar.Enabled = true;
                btn_nuevo.Enabled = true;
                btn_ingresar.Enabled = false;
            }
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_nuevo.Enabled = true;

            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_nuevo.Enabled = true;

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
                    logic.Actualizarperfil(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                    MessageBox.Show("Perfil Actualizado Correctamente", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha modificado el perfil seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btn_modif.Enabled = false;
                btn_actualizar.Enabled = false;
                btn_cancel.Enabled = false;
                btn_ingresar.Enabled = false;
                btn_nuevo.Enabled = true;
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;
                gbestado.Enabled = false;
                btn_eli.Enabled = false;
                limpiar();
            }
        }

        private void btn_modif_Click_1(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_cancel.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_modif.Enabled = false;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            rbhabilitado.Enabled = true;
            rbinhabilitado.Enabled = true;
            gbestado.Enabled = true;
            Gpb_datos.Enabled = true;
        }

        /* creado por Emerzon Garcia */
        private void btn_eli_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcodigo.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.Eliminarperfil(txtcodigo.Text);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
            btn_modif.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_cancel.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_nuevo.Enabled = true;
            txtcodigo.Enabled = false;
            gbestado.Enabled = false;  // Desactiva el grupo de radio buttons
            btn_eli.Enabled = false;
            Gpb_datos.Enabled = false;
            gbbuscar.Enabled = true;
            limpiar();  // Limpiar campos
        }

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
            btn_eli.Enabled = false;
            Gpb_datos.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbhabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }
        //********************** KATERYN DE LEON y Gabriela Suc ********************************************
        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoPerfiles.chm", "AyudaMantenimientoPerfiles.html");
            // Define el directorio base desde donde comenzar la búsqueda
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // Usando el directorio base del ejecutable

            // Imprime la ruta base para verificar
            MessageBox.Show("Ruta base: " + baseDirectory);

            // Busca el archivo en el directorio base y sus subdirectorios
            string pathAyuda = FindFileInDirectory(baseDirectory, "Ayuda_Seguridad", "ayudaPerfiles.chm");

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
        //********************** KATERYN DE LEON y Gabriela Suc  ********************************************
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

        //******** Fin KATERYN DE LEON y Gabriela Suc ********************************************************************

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
