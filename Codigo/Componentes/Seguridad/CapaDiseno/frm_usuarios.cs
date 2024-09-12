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
            txt_estadousuario.Text = "";
            txt_pregunta.Text = "";
            txt_respuesta.Text = "";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //KaterynDeLeon
            //BOTON BUSCAR

            buscar = txt_buscar.Text.Trim();

            /*   if (boton_eliminar == true)
              {

                  txt_clave.Enabled = false;
                  txt_id.Enabled = false;
                  txt_nombre.Enabled = false;
                  txt_apellido.Enabled = false;
                  Gpb_estado.Enabled = false;
                    groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
              else
              {
                  txt_clave.Enabled = false;
                  txt_id.Enabled = false;
                  txt_nombre.Enabled = true;
                  txt_apellido.Enabled = true;
                  //Gpb_estado.Enabled = false;
                    groupBox1.Enabled = false;
            }*/


            try
            {
                DataTable dtusuario = logica1.buscar(buscar);

                //MessageBox.Show(dtusuario.ToString());

                if (dtusuario.ToString() == null)
                {
                    MessageBox.Show("No existe");

                }
                else
                {
                    foreach (DataRow dt in dtusuario.Rows)
                    {
                        txt_id.Text = (dt[0].ToString());
                        txt_nomb.Text = (dt[3].ToString());
                        txt_apellido.Text = (dt[2].ToString());

                        txt_nombreusername.Text = (dt[1].ToString());


                        txt_clave.Text = (dt[4].ToString());
                        txt_correo.Text = (dt[5].ToString());

                        txt_estadousuario.Text = (dt[7].ToString());

                        txt_pregunta.Text = (dt[8].ToString());
                        txt_respuesta.Text = (dt[9].ToString());

                    }
                    // Mensaje indicando que los datos fueron buscados correctamente
                    MessageBox.Show("Los datos fueron buscados correctamente.");

                    txt_nomb.Enabled = true;
                    txt_apellido.Enabled = true;
                    txt_correo.Enabled = true;
                    txt_estadousuario.Enabled = true;
                    txt_pregunta.Enabled = true;
                    txt_respuesta.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = true;
                    btn_salir.Enabled = true;
                    btn_guardar.Enabled = true;
                    button4.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }




            /* txt_clave.Enabled = true;
             txt_id.Enabled = true;
             txt_nombre.Enabled = true;
             txt_apellido.Enabled = true;
             Gpb_estado.Enabled = true;
             txt_buscar.Enabled = true;
             button1.Enabled = true;
             button2.Enabled = true;
             button3.Enabled = true;
             boton_ingreso = true;*/
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

            txt_nombreusername.Enabled = false;
            txt_nomb.Enabled = false;

            txt_correo.Enabled = false;
            txt_estadousuario.Enabled = false;
            txt_pregunta.Enabled = false;
            txt_respuesta.Enabled = false;
        }


        //---------------------------------------------------- Inicio: GABRIELA SUC ----------------------------------------------------

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idUsuario = Convert.ToInt32(txt_buscar.Text);
                    int filasAfectadas = logica1.eliminarusuario(idUsuario);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        limpiar(); // Limpiar los campos
                        txt_clave.Enabled = false;
                        txt_nombreusername.Enabled = false;
                        txt_apellido.Enabled = false;
                        txt_nomb.Enabled = false;
                        txt_buscar.Enabled = true;
                        txt_correo.Enabled = false;
                        txt_estadousuario.Enabled = false;
                        txt_pregunta.Enabled = false;
                        txt_respuesta.Enabled = false;
                        btn_guardar.Enabled = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button4.Enabled = true;
                        btn_salir.Enabled = true;
                        btn_buscar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario o no fue posible eliminarlo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }
            }

        }

        

        private void Button3_Click(object sender, EventArgs e)
        {

            // Botón MODIFICAR

            try
            {
                // Se captura el ID del usuario desde txt_buscar
                int idUsuario = Convert.ToInt32(txt_buscar.Text);

                // Se llama a la función de la capa lógica para actualizar el registro
                logica1.ActualizarUsuario(idUsuario, txt_nomb.Text, txt_apellido.Text, txt_correo.Text, txt_estadousuario.Text, txt_pregunta.Text, txt_respuesta.Text);

                MessageBox.Show("Usuario actualizado correctamente.");

                // Desactivar los controles nuevamente
                txt_clave.Enabled = false;
                txt_nombreusername.Enabled = false;
                txt_apellido.Enabled = false;
                txt_nomb.Enabled = false;
                txt_buscar.Enabled = true;
                txt_correo.Enabled = false;
                txt_estadousuario.Enabled = false;
                txt_pregunta.Enabled = false;
                txt_respuesta.Enabled = false;

                limpiar(); // Limpiar los campos después de la actualización
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }


        }

        //---------------------------------------------------- Fin: GABRIELA SUC ----------------------------------------------------

        public string id, nombre, apellido, clave, correo, estadousuario, pregunta, respuesta;

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "CreacionUsuario.chm", "Creacion_Usuario.html");
        }

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
            button2.Enabled = false;
            button3.Enabled = false;
            boton_ingreso = true;
            btn_guardar.Enabled = true;



            txt_correo.Enabled = true;
            txt_estadousuario.Enabled = true;
            txt_pregunta.Enabled = true;
            txt_respuesta.Enabled = true;


            //limpiar

            limpiar();

        }

        private void Button1_Click(object sender, EventArgs e)

        {
            //Kateryn De León
            // BOTON GUARDAR
           
            nombre = txt_nombreusername.Text;
            apellido = txt_apellido.Text;
            id = txt_nomb.Text; //Es el nombre del usuario
            clave = txt_clave.Text;
            correo = txt_correo.Text;  // Nueva línea para el correo
            DateTime fechaActual = DateTime.Now;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
            estadousuario = txt_estadousuario.Text;  // Nueva línea para el estado del usuario
            pregunta = txt_pregunta.Text;  // Nueva línea para la pregunta de seguridad
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
                        // Asegúrate de pasar todos los parámetros necesarios
                       DataTable dtusuario = logica1.usuarios(nombre, apellido,id, clave, correo,fecha, estadousuario,pregunta,respuesta);
                             string mensaje = $"ID: {id}\n" +
                            $"Nombre: {nombre}\n" +
                            $"Apellido: {apellido}\n" +
                            $"Clave: {clave}\n" +
                            $"Correo: {correo}\n" +
                            $"Estado Usuario: {estadousuario}\n" +
                            $"Pregunta: {pregunta}\n" +
                            $"Respuesta: {respuesta}";

                        // Mostrar el mensaje en un MessageBox
                        MessageBox.Show(mensaje, "Detalles del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Usuario Creado");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                      return;
                    }
                }
                

                limpiar();
                txt_clave.Enabled = true;
                txt_nomb.Enabled = true;
                txt_apellido.Enabled = true;
                txt_nombreusername.Enabled = true;
               
                txt_buscar.Enabled = true;

                btn_buscar.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

                txt_correo.Enabled = true;
                txt_estadousuario.Enabled = true;
                txt_pregunta.Enabled = true;
                txt_respuesta.Enabled = true;
            }
        }
         

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
