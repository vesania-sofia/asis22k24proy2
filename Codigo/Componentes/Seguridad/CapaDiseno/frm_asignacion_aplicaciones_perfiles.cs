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




        // ------------------------- Emerzon Garcia ----------------------------------------------

        public void actualizardatagriew()
        {
            DataTable dt = logic.consultaLogicaPerfiles("Tbl_permisos_aplicacion_perfil");

            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Datos recibidos: " + dt.Rows.Count.ToString());

                // Asignar los nombres de las columnas en el DataGridView
                dgv_asignacionesperfiles.Columns["Perfil"].DataPropertyName = "Fk_id_perfil";
                dgv_asignacionesperfiles.Columns["Aplicacion"].DataPropertyName = "nombre_aplicacion";
                dgv_asignacionesperfiles.Columns["Ingresar"].DataPropertyName = "guardar_permiso";
                dgv_asignacionesperfiles.Columns["Consultar"].DataPropertyName = "buscar_permiso"; // Asumo que 'Consultar' es 'buscar_permiso'
                dgv_asignacionesperfiles.Columns["Modificar"].DataPropertyName = "modificar_permiso";
                dgv_asignacionesperfiles.Columns["Eliminar"].DataPropertyName = "eliminar_permiso";
                dgv_asignacionesperfiles.Columns["Imprimir"].DataPropertyName = "imprimir_permiso";

                // Configurar CheckBoxColumn para los permisos booleanos
                ConfigurarColumnasCheckBox();

                // Asignar el DataTable al DataGridView
                dgv_asignacionesperfiles.DataSource = dt;
                dgv_asignacionesperfiles.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        // Método para configurar CheckBoxColumns en el DataGridView
        private void ConfigurarColumnasCheckBox()
        {
            if (dgv_asignacionesperfiles.Columns["Ingresar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Ingresar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Ingresar"]).FalseValue = 0;
            }

            if (dgv_asignacionesperfiles.Columns["Consultar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Consultar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Consultar"]).FalseValue = 0;
            }

            if (dgv_asignacionesperfiles.Columns["Modificar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Modificar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Modificar"]).FalseValue = 0;
            }

            if (dgv_asignacionesperfiles.Columns["Eliminar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Eliminar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Eliminar"]).FalseValue = 0;
            }

            if (dgv_asignacionesperfiles.Columns["Imprimir"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Imprimir"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)dgv_asignacionesperfiles.Columns["Imprimir"]).FalseValue = 0;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();

        }



        private void btn_remover_Click_1(object sender, EventArgs e)
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



        //***************************HECHO POR KEVIN LOPEZ********************************************
        private void btn_agregar_Click_1(object sender, EventArgs e)
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
            //***************************HECHO POR KEVIN LOPEZ********************************************
        }
        //*******************TRABAJADO POR JOSUE PAZ 0901-21-5560**********************************************************
        private void btn_finalizar_Click_1(object sender, EventArgs e)
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

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------- Emerzon Garcia ----------------------------------------------

        public void actualizardatagriew1()
        {
            DataTable dt = logic.consultaLogicaPerfiles("Tbl_permisos_aplicacion_perfil");

            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Datos recibidos: " + dt.Rows.Count.ToString());

                // Limpiar las columnas anteriores
                dgv_asignacionesperfiles.Columns.Clear();

                // Crear y agregar las columnas manualmente
                dgv_asignacionesperfiles.Columns.Add("Perfil", "Perfil");
                dgv_asignacionesperfiles.Columns["Perfil"].DataPropertyName = "Fk_id_perfil";

                dgv_asignacionesperfiles.Columns.Add("Aplicacion", "Aplicación");
                dgv_asignacionesperfiles.Columns["Aplicacion"].DataPropertyName = "nombre_aplicacion";

                // Agregar columnas de permisos como TextBox
                dgv_asignacionesperfiles.Columns.Add("Ingresar", "Ingresar");
                dgv_asignacionesperfiles.Columns["Ingresar"].DataPropertyName = "guardar_permiso";

                dgv_asignacionesperfiles.Columns.Add("Consultar", "Consultar");
                dgv_asignacionesperfiles.Columns["Consultar"].DataPropertyName = "buscar_permiso";

                dgv_asignacionesperfiles.Columns.Add("Modificar", "Modificar");
                dgv_asignacionesperfiles.Columns["Modificar"].DataPropertyName = "modificar_permiso";

                dgv_asignacionesperfiles.Columns.Add("Eliminar", "Eliminar");
                dgv_asignacionesperfiles.Columns["Eliminar"].DataPropertyName = "eliminar_permiso";

                dgv_asignacionesperfiles.Columns.Add("Imprimir", "Imprimir");
                dgv_asignacionesperfiles.Columns["Imprimir"].DataPropertyName = "imprimir_permiso";

                // Asegúrate de que las columnas son de texto y centrar el contenido
                foreach (var column in new[] { "Ingresar", "Consultar", "Modificar", "Eliminar", "Imprimir" })
                {
                    dgv_asignacionesperfiles.Columns[column].ValueType = typeof(string);
                    dgv_asignacionesperfiles.Columns[column].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Asignar el DataTable al DataGridView
                dgv_asignacionesperfiles.DataSource = dt;

                // Convertir booleanos a "0" o "1"
                foreach (DataRow row in dt.Rows)
                {
                    row["guardar_permiso"] = (Convert.ToBoolean(row["guardar_permiso"]) ? "1" : "0");
                    row["buscar_permiso"] = (Convert.ToBoolean(row["buscar_permiso"]) ? "1" : "0");
                    row["modificar_permiso"] = (Convert.ToBoolean(row["modificar_permiso"]) ? "1" : "0");
                    row["eliminar_permiso"] = (Convert.ToBoolean(row["eliminar_permiso"]) ? "1" : "0");
                    row["imprimir_permiso"] = (Convert.ToBoolean(row["imprimir_permiso"]) ? "1" : "0");
                }

                dgv_asignacionesperfiles.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }


        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            actualizardatagriew1();
        }

        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "AyudaAsignacionAplicacionesPerfiles.chm", "Asignacion_Aplicaciones_Perfiles.html");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    //******************ACA TERMINA********************************************************
}
