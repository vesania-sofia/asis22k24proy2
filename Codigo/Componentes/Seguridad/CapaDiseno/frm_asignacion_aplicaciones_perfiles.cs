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

namespace CapaDiseno
{
    public partial class frm_asignacion_aplicaciones_perfiles : Form
    {
        logica logic;
        public frm_asignacion_aplicaciones_perfiles(string idUsuario)
        {
            InitializeComponent();
            logic = new logica(idUsuario);
        }

        public frm_asignacion_aplicaciones_perfiles()
        {
        }

//****************************************Kevin López***************************************************
        // Método para cargar los perfiles
        private void CargarPerfiles()
        {
            try
            {
                DataTable dtPerfiles = logic.consultaLogicaPerfiles();
                cbo_perfiles.Items.Clear();
                foreach (DataRow row in dtPerfiles.Rows)
                {
                    cbo_perfiles.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar perfiles: " + ex.Message);
            }
        }

        // Método para cargar los módulos
        private void CargarModulos()
        {
            try
            {
                DataTable dtModulos = logic.consultaLogicaModulos();
                cbo_modulos.Items.Clear();
                foreach (DataRow row in dtModulos.Rows)
                {
                    cbo_modulos.Items.Add(row[0].ToString());
                }
                // Vincular el evento de selección de módulo
                cbo_modulos.SelectedIndexChanged += new EventHandler(Cbo_modulos_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        }

        // Método para cargar aplicaciones según el módulo seleccionado
        private void CargarAplicaciones(string nombreModulo)
        {
            try
            {
               DataTable dtAplicaciones = logic.consultaLogicaAplicacionesP(nombreModulo);
                cbo_aplicaciones.Items.Clear();
                foreach (DataRow row in dtAplicaciones.Rows)
                {
                    cbo_aplicaciones.Items.Add(row["nombre_aplicacion"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar aplicaciones: " + ex.Message);
            }
        }

        //**************************************** FIN Kevin López***************************************************
//****************************************Kevin López***************************************************
        private void Frm_asignacion_aplicaciones_perfiles_Load(object sender, EventArgs e)
        {

            CargarPerfiles();
            CargarModulos();
        }
//****************************************FIN Kevin López***************************************************
        void limpieza()
        {
            cbo_perfiles.Text = " ";
            cbo_modulos.Text = " ";
            cbo_aplicaciones.Text = " ";
        }

//****************************************Kevin López***************************************************
        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Limpiar las aplicaciones antes de agregar nuevas


            if (cbo_modulos.SelectedIndex != -1)
            {
                string moduloSeleccionado = cbo_modulos.SelectedItem.ToString();
                CargarAplicaciones(moduloSeleccionado); // Cargar las aplicaciones del módulo seleccionado
            }
            /*
            if (cbo_modulos.SelectedItem != null)
            {
                string nombreModulo = cbo_modulos.SelectedItem.ToString();
                string ID_aplicacion = null;
                CargarAplicaciones(ID_aplicacion);
            }*/
            
        }
        //****************************************FIN Kevin López***************************************************


        //****** HECHO POR JOSUE PAZ Y KEVIN LOPEZ*************************************
        public static int iContadorFila = 0;

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //*******************TRABAJADO POR JOSUE PAZ 0901-21-5560**********************************************************
        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
            string ingresar;
            string consulta;
            string modificar;
            string eliminar;
            string imprimir;
            try
            {
                foreach (DataGridViewRow Fila in dgv_asignacionesperfiles.Rows)
                {

                    string codigoperfil = Fila.Cells[0].Value.ToString();
                    string nombreaplicacion = Fila.Cells[1].Value.ToString();


                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    if (cheked)
                        ingresar = "1";
                    else
                        ingresar = "0";

                    bool chekedM = ((bool)(Fila.Cells["Modificar"].EditedFormattedValue));
                    if (chekedM)
                        modificar = "1";
                    else
                        modificar = "0";

                    bool chekedE = ((bool)(Fila.Cells["Eliminar"].EditedFormattedValue));
                    if (chekedE)
                        eliminar = "1";
                    else
                        eliminar = "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    if (chekedC)
                        consulta = "1";
                    else
                        consulta = "0";

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    if (chekedI)
                        imprimir = "1";
                    else
                        imprimir = "0";

                    DataTable dtAplicaciones = logic.consultaLogicaPermisosPerfilAplicacion(codigoperfil, nombreaplicacion, ingresar, modificar, eliminar, consulta, imprimir);

                }

                MessageBox.Show("Datos ingresados exitosamente");
                limpieza();
                dgv_asignacionesperfiles.Rows.Clear();
                iContadorFila = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //******************ACA TERMINA********************************************************

        //***************************HECHO POR KEVIN LOPEZ********************************************

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (cbo_perfiles.SelectedItem == null || cbo_aplicaciones.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado nada aún");
            }
            else
            {
                bool bUsuario_aplicacion_existente = false;

                string sPerfil = cbo_perfiles.SelectedItem.ToString();
                string sAplicacion = cbo_aplicaciones.SelectedItem.ToString();

                if (iContadorFila == 0)
                {
                    dgv_asignacionesperfiles.Rows.Add(sPerfil, sAplicacion);

                    iContadorFila++;


                }
                else
                {
                    foreach (DataGridViewRow Fila in dgv_asignacionesperfiles.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == cbo_perfiles.SelectedItem.ToString() && Fila.Cells[1].Value.ToString() == cbo_aplicaciones.SelectedItem.ToString())
                        {
                            bUsuario_aplicacion_existente = true;
                        }
                    }

                    if (bUsuario_aplicacion_existente == true)
                    {
                        MessageBox.Show("Ya existe una relacion del Perfil con la aplicacion");
                    }
                    else
                    {
                        dgv_asignacionesperfiles.Rows.Add(sPerfil, sAplicacion);
                        iContadorFila++;
                    }
                }

                limpieza();
            }
        }
        //***************************HECHO POR KEVIN LOPEZ********************************************

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            if (iContadorFila > 0)
            {
                dgv_asignacionesperfiles.Rows.RemoveAt(dgv_asignacionesperfiles.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
                MessageBox.Show("No hay relaciones que eliminar");
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "AyudaAsignacionAplicacionesPerfiles.chm", "Asignacion_Aplicaciones_Perfiles.html");
        }

        private void dgv_asignacionesperfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 //****************************************Kevin López***************************************************
        private void cbo_aplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_aplicaciones.SelectedItem != null)
            {
                string nombreAplicacion = cbo_aplicaciones.SelectedItem.ToString();
                Console.WriteLine("Aplicación seleccionada: " + nombreAplicacion);
            }

        }
//****************************************FIN Kevin López***************************************************
        private void cbo_perfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar el DataGridView antes de cargar los nuevos datos
                dgv_asignacionesperfiles.Rows.Clear();

                // Obtener el valor ingresado en el TextBox de búsqueda (txt_buscar)
                string id = txt_buscar.Text;

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Debe ingresar un ID para buscar.");
                    return;
                }

                // Realizar la búsqueda en la base de datos usando el ID
                DataTable dtPermisosPerfilAplicacion = logic.buscardatid(id); // Se usa ID en lugar de perfil

                // Verificar si hay resultados
                if (dtPermisosPerfilAplicacion != null && dtPermisosPerfilAplicacion.Rows.Count > 0)
                {
                    foreach (DataRow row in dtPermisosPerfilAplicacion.Rows)
                    {
                        // Agregar las filas obtenidas al DataGridView
                        dgv_asignacionesperfiles.Rows.Add(
                            id,
                            row["Aplicacion"].ToString(),
                            Convert.ToBoolean(row["guardar_permiso"]),
                            Convert.ToBoolean(row["modificar_permiso"]),
                            Convert.ToBoolean(row["eliminar_permiso"]),
                            Convert.ToBoolean(row["imprimir_permiso"])
                        );
                    }

                    MessageBox.Show("Búsqueda realizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontraron permisos para el ID ingresado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ocurrió un error al realizar la búsqueda.");
            }

        }

    }
}
