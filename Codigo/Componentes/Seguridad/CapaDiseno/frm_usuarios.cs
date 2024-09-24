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
using System.Security.Cryptography;
using System.IO; // Necesario para Directory, File, Path y SearchOption
using System.Windows.Forms; // Necesario para MessageBox y Help

/*---------------------------Creador: Diego Gomez------------------------------*/
namespace CapaDiseno
{
    public partial class frm_usuarios : Form
    {
        logica logica1;

        bool boton_ingreso = false;
        bool boton_eliminar = false;
        bool boton_modificar = false;

        public frm_usuarios(string idUsuario)
        {
            InitializeComponent();
            logica1 = new logica(idUsuario);

            // Configurar el ComboBox con las opciones exactas que se usan en la base de datos
            cmb_Pregunta.Items.Clear();
            cmb_Pregunta.Items.AddRange(new string[] {
            "Color favorito",
            "Nombre de familiar",
            "Nombre de mascota"
        });
            cmb_Pregunta.DropDownStyle = ComboBoxStyle.DropDownList;
            // Asociar el evento KeyPress a los TextBox
            txt_nomb.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txt_apellido.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txt_respuesta.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txt_buscar.KeyPress += new KeyPressEventHandler(txt_buscar_KeyPress);
        }

        public frm_usuarios()
        {
        }

        private void Dgv_asignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string buscar;


        void limpiar()
        {
            txt_id.Text = "";
            txt_nombreusername.Text = "";
            txt_buscar.Text = "";
            txt_clave.Text = "";
            txt_apellido.Text = "";
            txt_nomb.Text = "";

            txt_correo.Text = "";
            rb_habilitado.Checked = false;
            rb_inhabilitado.Checked = false;
            Dgv_usuarios.Columns.Clear();
            //txt_estadousuario.Text = "";
            // txt_pregunta.Text = "";
            txt_respuesta.Text = "";
            cmb_Pregunta.SelectedIndex = -1;

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            buscar = txt_buscar.Text.Trim();

            try
            {
                DataTable dtusuario;

                if (string.IsNullOrEmpty(buscar))
                {
                    dtusuario = logica1.funconsultaLogicaUsuarios();
                }
                else
                {
                    dtusuario = logica1.buscar(buscar);
                }

                if (dtusuario == null || dtusuario.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dgv_usuarios.DataSource = dtusuario;

                    if (dtusuario != null && dtusuario.Rows.Count > 0)
                    {
                        DataRow row = dtusuario.Rows[0];

                        txt_id.Text = row["Usuario"].ToString();
                        txt_nomb.Text = row["Nombre"].ToString();
                        txt_apellido.Text = row["Apellido"].ToString();
                        txt_correo.Text = row["Email"].ToString();
                        txt_respuesta.Text = row["Respuesta"].ToString();
                        txt_nombreusername.Text = row["Username"].ToString();
                        txt_clave.Text = row["Password"].ToString();

                        if (row["Estado"].ToString() == "1")
                        {
                            rb_habilitado.Checked = true;
                        }
                        else
                        {
                            rb_inhabilitado.Checked = true;
                        }

                        // Asignar la pregunta al ComboBox de manera simple
                        string preguntaDB = row["Pregunta"].ToString();
                        cmb_Pregunta.SelectedItem = preguntaDB;

                        // Si la pregunta no está en la lista, añadirla
                        if (cmb_Pregunta.SelectedIndex == -1)
                        {
                            cmb_Pregunta.Items.Add(preguntaDB);
                            cmb_Pregunta.SelectedItem = preguntaDB;
                        }

                        txt_nomb.Enabled = true;
                        txt_apellido.Enabled = true;
                        txt_correo.Enabled = true;
                        txt_estadousuario.Enabled = true;
                        txt_nombreusername.Enabled = false;
                        txt_clave.Enabled = false;
                        cmb_Pregunta.Enabled = true;
                        txt_respuesta.Enabled = true;
                        Btn_modificar.Enabled = true;
                        Btn_eliminar.Enabled = true;
                        btn_salir.Enabled = true;
                        btn_guardar.Enabled = false;
                        btn_nuevo.Enabled = true;
                        rb_habilitado.Enabled = true;
                        rb_inhabilitado.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {
            txt_buscar.Enabled = true;
            txt_id.Enabled = false;
            btn_buscar.Enabled = true;
            txt_nombreusername.Enabled = false;
            txt_clave.Enabled = false;
            txt_apellido.Enabled = false;
            btn_guardar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;

            txt_nombreusername.Enabled = false;
            txt_nomb.Enabled = false;

            txt_correo.Enabled = false;
            txt_estadousuario.Enabled = false;
            //txt_pregunta.Enabled = false;
            txt_respuesta.Enabled = false;
            cmb_Pregunta.Enabled = false;
            rb_habilitado.Enabled = false;
            rb_inhabilitado.Enabled = false;
            Dgv_usuarios.CellClick += Dgv_usuarios_CellClick;
            btn_buscar.Click += Button1_Click_1;

            // Orden de tabulaciones
            btn_buscar.TabIndex = 0;
            btn_nuevo.TabIndex = 1; // Botón Nuevo
            btn_guardar.TabIndex = 2;
            Btn_modificar.TabIndex = 3;
            Btn_eliminar.TabIndex = 4;
            btn_salir.TabIndex = 5;

            txt_nombreusername.TabIndex = 6;
            txt_clave.TabIndex = 7;
            txt_nomb.TabIndex = 8;
            txt_apellido.TabIndex = 9;
            txt_correo.TabIndex = 10;

            rb_habilitado.TabIndex = 11;
            rb_inhabilitado.TabIndex = 12;

            cmb_Pregunta.TabIndex = 13;
            txt_respuesta.TabIndex = 14;

            //limitar caracteres
            txt_nomb.MaxLength = 50; // Limita el texto a 50 caracteres
            txt_apellido.MaxLength = 50;
            txt_nombreusername.MaxLength = 20;
            txt_correo.MaxLength = 50;
            txt_respuesta.MaxLength = 50;
            txt_clave.MaxLength = 50;


        }


        //---------------------------------------------------- Inicio: GABRIELA SUC ----------------------------------------------------

        private void Button2_Click(object sender, EventArgs e)
        {   //Botón ELIMINAR

            // Botón ELIMINAR
            string idUsuario = txt_id.Text.Trim(); // Eliminar usando el ID real del usuario

            if (string.IsNullOrEmpty(idUsuario))
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                // Llamar a la capa lógica para cambiar el estado del usuario
                bool resultado = logica1.EliminarUsuario(idUsuario);

                if (resultado)
                {
                    MessageBox.Show("El usuario ha sido eliminado correctamente (cambiado a estado Inactivo).", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar(); // Limpiar los campos después de la actualización
                    Dgv_usuarios.DataSource = logica1.funconsultaLogicaUsuarios(); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            limpiar();
            txt_nomb.Enabled = false;
            txt_apellido.Enabled = false;
            txt_correo.Enabled = false;
            rb_habilitado.Enabled = false;
            rb_inhabilitado.Enabled = false;
            cmb_Pregunta.Enabled = false;
            txt_respuesta.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            // Botón MODIFICAR
            // Valida todos los campos antes de continuar
            if (!ValidarCampos())
            {
                return; // Si hay un error, no continúa
            }
            DialogResult result = MessageBox.Show("¿Está seguro de modificar este registro?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                // Obtener los valores de los controles
                string idUsuario = txt_id.Text.Trim();
                string nombre = txt_nomb.Text.Trim();
                string apellido = txt_apellido.Text.Trim();
                string correo = txt_correo.Text.Trim();
                string respuesta = txt_respuesta.Text.Trim();
                int estado_usuario = rb_habilitado.Checked ? 1 : 0; // Estado del usuario

                // Asegúrate de obtener la pregunta del ComboBox
                string preguntaSeleccionada = cmb_Pregunta.SelectedItem?.ToString(); // Si no está seleccionada, retorna null

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("Debe seleccionar un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica si la pregunta es válida antes de proceder
                if (string.IsNullOrEmpty(preguntaSeleccionada))
                {
                    MessageBox.Show("Debe seleccionar una pregunta de seguridad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar a la lógica para modificar
                bool exito = logica1.ModificarUsuario(idUsuario, nombre, apellido, correo, estado_usuario, preguntaSeleccionada, respuesta);

                if (exito)
                {
                    MessageBox.Show("Registro modificado con éxito.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    //Dgv_usuarios.DataSource = logica1.consultaLogicaUsuarios(); // Actualizar el DataGridView después de la modificación
                    Btn_modificar.Enabled = false;
                    Btn_eliminar.Enabled = false;
                    txt_nomb.Enabled = false;
                    txt_apellido.Enabled = false;
                    txt_correo.Enabled = false;
                    rb_habilitado.Enabled = false;
                    rb_inhabilitado.Enabled = false;
                    cmb_Pregunta.Enabled = false;
                    txt_respuesta.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al intentar modificar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //---------------------------------------------------- Fin: GABRIELA SUC ----------------------------------------------------

        public string id, nombre, apellido, clave, correo, estadousuario, pregunta, respuesta;

        private void txt_estadousuario_TextChanged(object sender, EventArgs e)
        {

        }
        //********************** KATERYN DE LEON y Gabriela Suc ******************************
        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "CreacionUsuario.chm", "Creacion_Usuario.html");
            // Define el directorio base desde donde comenzar la búsqueda
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // Usando el directorio base del ejecutable

            // Imprime la ruta base para verificar
            MessageBox.Show("Ruta base: " + baseDirectory);

            // Busca el archivo .chm en el directorio base y sus subdirectorios
            string pathAyuda = FindFileInDirectory(baseDirectory, "Ayuda_Seguridad", "ayudaUsuarios.chm");

            // Imprimir la ruta generada para verificar
            MessageBox.Show("Ruta de ayuda: " + pathAyuda);

            // Verifica si el archivo existe antes de intentar abrirlo
            if (!string.IsNullOrEmpty(pathAyuda))
            {
                MessageBox.Show("El archivo sí está.");
                // Abre el archivo de ayuda .chm en la sección especificada
                Help.ShowHelp(this, pathAyuda, "Asignacion_Aplicaciones_Perfiles.html");
            }
            else
            {
                // Si el archivo no existe, muestra un mensaje de error
                MessageBox.Show("El archivo de ayuda no se encontró.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //********************** KATERYN DE LEON y Gabriela Suc ******************************
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
        //************************************** Fin KATERYN DE LEON y Gabriela Suc *********************************************************************

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.CampoAlfanumerico(e);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //BOTON NUEVO

            txt_id.Enabled = false;

            txt_clave.Enabled = true;
            txt_nomb.Enabled = true;
            txt_apellido.Enabled = true;
            txt_nombreusername.Enabled = true;

            txt_buscar.Enabled = true;
            btn_buscar.Enabled = true;
            Btn_eliminar.Enabled = false;
            Btn_modificar.Enabled = false;
            boton_ingreso = true;
            btn_guardar.Enabled = true;


            rb_inhabilitado.Enabled = true;
            rb_habilitado.Enabled = true;
            txt_correo.Enabled = true;
            txt_estadousuario.Enabled = true;
            cmb_Pregunta.Enabled = true;
            txt_respuesta.Enabled = true;


            //limpiar

            limpiar();

        }

        private string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void cmb_Pregunta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //**********************Kateryn De León************************/
            // BOTON GUARDAR

            // Valida todos los campos antes de continuar
            if (!ValidarCampos())
            {
                return; // Si hay un error, no continúa
            }

            nombre = txt_nomb.Text;////nombre usuario
            apellido = txt_apellido.Text;
            id = txt_nombreusername.Text;// nombre username
            clave = txt_clave.Text;
            correo = txt_correo.Text;  // Nueva línea para el correo
            DateTime fechaActual = DateTime.Now;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
            // estadousuario = txt_estadousuario.Text;  // Nueva línea para el estado del usuario
            string estadousuario = "";//guarda lo del txt

            pregunta = cmb_Pregunta.SelectedItem.ToString(); // Asignar la pregunta seleccionada en cmb;  // Nueva línea para la pregunta de seguridad
            respuesta = txt_respuesta.Text;  // Nueva línea para la respuesta de seguridad

            // int boton;

            if (txt_nomb.Text == " " || txt_nombreusername.Text == "" || txt_apellido.Text == "" || txt_clave.Text == "")//corregir aca
            {
                MessageBox.Show("Faltan Campos Por Llenar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (clave.Length < 8)
            {
                MessageBox.Show("La contraseña debe de contener 8 caracteres como mínimo", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (boton_ingreso == true)//boton_ingreso
                {
                    // boton = 1;

                    try
                    {
                        // Hash de la clave con SHA-256
                        string claveHasheada = HashPasswordSHA256(clave);

                        // Asegúrate de pasar la clave hasheada a la lógica

                        if (rb_habilitado.Checked)
                        {
                            estadousuario = "1";
                        }

                        if (rb_inhabilitado.Checked)
                        {
                            estadousuario = "0";
                        }
                        else
                        {
                            estadousuario = "1";
                        }

                        // Asegúrate de pasar todos los parámetros necesarios
                        DataTable dtusuario = logica1.usuarios(nombre, apellido, id, claveHasheada, correo, fecha, estadousuario, pregunta, respuesta);
                        string mensaje = //$"ID: {idd}\n" +//id del guardar
                       $"Nombre: {nombre}\n" +
                       $"Apellido: {apellido}\n" +
                       $"UserName: {id}\n" +
                       $"Clave Hasheada: {claveHasheada}\n" +
                       $"Correo: {correo}\n" +
                       $"Estado Usuario: {estadousuario}\n" +
                       $"Pregunta: {pregunta}\n" +
                       $"Respuesta: {respuesta}";

                        // Mostrar el mensaje en un MessageBox
                        MessageBox.Show(mensaje, "Detalles del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Usuario creado correctamente", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        return;
                    }
                }


                limpiar();
                txt_clave.Enabled = false;
                txt_nomb.Enabled = false;
                txt_apellido.Enabled = false;
                txt_nombreusername.Enabled = false;
                txt_buscar.Enabled = true;
                btn_guardar.Enabled = false;
                btn_buscar.Enabled = true;
                Btn_eliminar.Enabled = false;
                Btn_modificar.Enabled = false;
                btn_nuevo.Enabled = true;
                btn_salir.Enabled = true;
                btn_ayuda.Enabled = true;
                txt_correo.Enabled = false;
                txt_estadousuario.Enabled = false;
                txt_respuesta.Enabled = false;
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fernando Gárcía - 0901-21-581
        private void Dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya seleccionado una fila válida
            {
                DataGridViewRow row = Dgv_usuarios.Rows[e.RowIndex];

                txt_id.Text = row.Cells["Usuario"].Value.ToString();
                txt_nomb.Text = row.Cells["Nombre"].Value.ToString();
                txt_apellido.Text = row.Cells["Apellido"].Value.ToString();
                txt_correo.Text = row.Cells["Email"].Value.ToString();
                txt_respuesta.Text = row.Cells["Respuesta"].Value.ToString();
                txt_nombreusername.Text = row.Cells["Username"].Value.ToString();
                txt_clave.Text = row.Cells["Password"].Value.ToString();

                // Asigna el estado a los RadioButton
                if (row.Cells["Estado"].Value.ToString() == "1")
                {
                    rb_habilitado.Checked = true;
                }
                else
                {
                    rb_inhabilitado.Checked = true;
                }

                // Asigna la pregunta de seguridad al ComboBox
                cmb_Pregunta.SelectedItem = row.Cells["Pregunta"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            // Validar campos de texto
            if (string.IsNullOrWhiteSpace(txt_nomb.Text) ||
                string.IsNullOrWhiteSpace(txt_apellido.Text) ||
                string.IsNullOrWhiteSpace(txt_nombreusername.Text) ||
                string.IsNullOrWhiteSpace(txt_clave.Text) ||
                string.IsNullOrWhiteSpace(txt_correo.Text) ||
                string.IsNullOrWhiteSpace(txt_respuesta.Text))
            {
                MessageBox.Show("Todos los campos de texto son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar ComboBox de pregunta de seguridad
            if (cmb_Pregunta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una pregunta de seguridad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que un RadioButton esté seleccionado
            if (!rb_habilitado.Checked && !rb_inhabilitado.Checked)
            {
                MessageBox.Show("Debe seleccionar el estado del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar el formato del correo electrónico
            if (!EsCorreoValido(txt_correo.Text))
            {
                MessageBox.Show("El formato del correo electrónico es incorrecto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Todos los campos son válidos
        }

        // Función auxiliar para validar el formato del correo electrónico
        private bool EsCorreoValido(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
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

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es un número o si es la tecla de Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número o la tecla de retroceso, cancelar el evento
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
