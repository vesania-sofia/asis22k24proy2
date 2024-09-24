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
        public frm_asignacion_aplicaciones_perfiles(string sidUsuario)
        {
            InitializeComponent();
            logic = new logica(sidUsuario);
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
                DataTable dtPerfiles = logic.funconsultalogicaperfiles();
                Cbo_perfiles.Items.Clear();
                foreach (DataRow row in dtPerfiles.Rows)
                {
                    Cbo_perfiles.Items.Add(row[0].ToString());
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
                DataTable dtModulos = logic.funconsultalogicamodulos();
                Cbo_modulos.Items.Clear();
                foreach (DataRow row in dtModulos.Rows)
                {
                    Cbo_modulos.Items.Add(row[0].ToString());
                }
                // Vincular el evento de selección de módulo
                Cbo_modulos.SelectedIndexChanged += new EventHandler(Cbo_modulos_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        }

        // Método para cargar aplicaciones según el módulo seleccionado
        private void CargarAplicaciones(string snombreModulo)
        {
            try
            {
               DataTable dtAplicaciones = logic.funconsultaLogicaaplicacionesP(snombreModulo);
                Cbo_aplicaciones.Items.Clear();
                foreach (DataRow row in dtAplicaciones.Rows)
                {
                    Cbo_aplicaciones.Items.Add(row["nombre_aplicacion"].ToString());
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
            Cbo_perfiles.Text = " ";
            Cbo_modulos.Text = " ";
            Cbo_aplicaciones.Text = " ";
        }

//****************************************Kevin López***************************************************
        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Limpiar las aplicaciones antes de agregar nuevas


            if (Cbo_modulos.SelectedIndex != -1)
            {
                string smoduloSeleccionado = Cbo_modulos.SelectedItem.ToString();
                CargarAplicaciones(smoduloSeleccionado); // Cargar las aplicaciones del módulo seleccionado
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

            if (Cbo_aplicaciones.SelectedItem != null)
            {
                string snombreAplicacion = Cbo_aplicaciones.SelectedItem.ToString();
                Console.WriteLine("Aplicación seleccionada: " + snombreAplicacion);
            }

        }
//****************************************FIN Kevin López***************************************************
        private void cbo_perfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        // ------------------------- Emerzon Garcia ----------------------------------------------

        public void actualizardatagriew()
        {
            DataTable dt = logic.funconsultarPerfiles("Tbl_permisos_aplicacion_perfil");

            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Datos recibidos: " + dt.Rows.Count.ToString());

                // Asignar los nombres de las columnas en el DataGridView
                Dgv_asignacionesperfiles.Columns["Perfil"].DataPropertyName = "Fk_id_perfil";
                Dgv_asignacionesperfiles.Columns["Aplicacion"].DataPropertyName = "nombre_aplicacion";
                Dgv_asignacionesperfiles.Columns["Ingresar"].DataPropertyName = "guardar_permiso";
                Dgv_asignacionesperfiles.Columns["Consultar"].DataPropertyName = "buscar_permiso"; // Asumo que 'Consultar' es 'buscar_permiso'
                Dgv_asignacionesperfiles.Columns["Modificar"].DataPropertyName = "modificar_permiso";
                Dgv_asignacionesperfiles.Columns["Eliminar"].DataPropertyName = "eliminar_permiso";
                Dgv_asignacionesperfiles.Columns["Imprimir"].DataPropertyName = "imprimir_permiso";

                // Configurar CheckBoxColumn para los permisos booleanos
                ConfigurarColumnasCheckBox();

                // Asignar el DataTable al DataGridView
                Dgv_asignacionesperfiles.DataSource = dt;
                Dgv_asignacionesperfiles.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        // Método para configurar CheckBoxColumns en el DataGridView
        private void ConfigurarColumnasCheckBox()
        {
            if (Dgv_asignacionesperfiles.Columns["Ingresar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Ingresar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Ingresar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Consultar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Consultar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Consultar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Modificar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Modificar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Modificar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Eliminar"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Eliminar"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Eliminar"]).FalseValue = 0;
            }

            if (Dgv_asignacionesperfiles.Columns["Imprimir"] is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Imprimir"]).TrueValue = 1;
                ((DataGridViewCheckBoxColumn)Dgv_asignacionesperfiles.Columns["Imprimir"]).FalseValue = 0;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();

        }



        private void btn_remover_Click_1(object sender, EventArgs e)
        {
            // Verificar si hay filas en el DataGridView
            if (Dgv_asignacionesperfiles.Rows.Count > 0)
            {
                // Verificar si hay una fila seleccionada
                if (Dgv_asignacionesperfiles.CurrentRow != null)
                {
                    // Eliminar la fila seleccionada
                    Dgv_asignacionesperfiles.Rows.RemoveAt(Dgv_asignacionesperfiles.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No hay filas en el DataGridView.");
            }
        }



        //***************************HECHO POR KEVIN LOPEZ********************************************
        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            if (Cbo_perfiles.SelectedItem == null || Cbo_aplicaciones.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado nada aún");
            }
            else
            {
                bool bUsuario_aplicacion_existente = false;

                string sPerfil = Cbo_perfiles.SelectedItem.ToString();
                string sAplicacion = Cbo_aplicaciones.SelectedItem.ToString();

                if (iContadorFila == 0)
                {
                    Dgv_asignacionesperfiles.Rows.Add(sPerfil, sAplicacion);

                    iContadorFila++;


                }
                else
                {
                    foreach (DataGridViewRow Fila in Dgv_asignacionesperfiles.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == Cbo_perfiles.SelectedItem.ToString() && Fila.Cells[1].Value.ToString() == Cbo_aplicaciones.SelectedItem.ToString())
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
                        Dgv_asignacionesperfiles.Rows.Add(sPerfil, sAplicacion);
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
            string singresar;
            string sconsulta;
            string smodificar;
            string seliminar;
            string simprimir;
            try
            {
                foreach (DataGridViewRow Fila in Dgv_asignacionesperfiles.Rows)
                {

                    string scodigoperfil = Fila.Cells[0].Value.ToString();
                    string snombreaplicacion = Fila.Cells[1].Value.ToString();


                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    if (cheked)
                        singresar = "1";
                    else
                        singresar = "0";

                    bool chekedM = ((bool)(Fila.Cells["Modificar"].EditedFormattedValue));
                    if (chekedM)
                        smodificar = "1";
                    else
                        smodificar = "0";

                    bool chekedE = ((bool)(Fila.Cells["Eliminar"].EditedFormattedValue));
                    if (chekedE)
                        seliminar = "1";
                    else
                        seliminar = "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    if (chekedC)
                        sconsulta = "1";
                    else
                        sconsulta = "0";

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    if (chekedI)
                        simprimir = "1";
                    else
                        simprimir = "0";

                    DataTable dtAplicaciones = logic.funguardarpermisosperfil(scodigoperfil, snombreaplicacion, singresar, smodificar, seliminar, sconsulta, simprimir);

                }

                MessageBox.Show("Datos ingresados exitosamente");
                limpieza();
                Dgv_asignacionesperfiles.Rows.Clear();
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
            DataTable dt = logic.funconsultarPerfiles("Tbl_permisos_aplicacion_perfil");

            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Datos recibidos: " + dt.Rows.Count.ToString());

                // Limpiar las columnas anteriores
                Dgv_asignacionesperfiles.Columns.Clear();

                // Crear y agregar las columnas manualmente
                Dgv_asignacionesperfiles.Columns.Add("Perfil", "Perfil");
                Dgv_asignacionesperfiles.Columns["Perfil"].DataPropertyName = "Fk_id_perfil";

                Dgv_asignacionesperfiles.Columns.Add("Aplicacion", "Aplicación");
                Dgv_asignacionesperfiles.Columns["Aplicacion"].DataPropertyName = "nombre_aplicacion";

                // Agregar columnas de permisos como TextBox
                Dgv_asignacionesperfiles.Columns.Add("Ingresar", "Ingresar");
                Dgv_asignacionesperfiles.Columns["Ingresar"].DataPropertyName = "guardar_permiso";

                Dgv_asignacionesperfiles.Columns.Add("Consultar", "Consultar");
                Dgv_asignacionesperfiles.Columns["Consultar"].DataPropertyName = "buscar_permiso";

                Dgv_asignacionesperfiles.Columns.Add("Modificar", "Modificar");
                Dgv_asignacionesperfiles.Columns["Modificar"].DataPropertyName = "modificar_permiso";

                Dgv_asignacionesperfiles.Columns.Add("Eliminar", "Eliminar");
                Dgv_asignacionesperfiles.Columns["Eliminar"].DataPropertyName = "eliminar_permiso";

                Dgv_asignacionesperfiles.Columns.Add("Imprimir", "Imprimir");
                Dgv_asignacionesperfiles.Columns["Imprimir"].DataPropertyName = "imprimir_permiso";

                // Asegúrate de que las columnas son de texto y centrar el contenido
                foreach (var column in new[] { "Ingresar", "Consultar", "Modificar", "Eliminar", "Imprimir" })
                {
                    Dgv_asignacionesperfiles.Columns[column].ValueType = typeof(string);
                    Dgv_asignacionesperfiles.Columns[column].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Asignar el DataTable al DataGridView
                Dgv_asignacionesperfiles.DataSource = dt;

                // Convertir booleanos a "0" o "1"
                foreach (DataRow row in dt.Rows)
                {
                    row["guardar_permiso"] = (Convert.ToBoolean(row["guardar_permiso"]) ? "1" : "0");
                    row["buscar_permiso"] = (Convert.ToBoolean(row["buscar_permiso"]) ? "1" : "0");
                    row["modificar_permiso"] = (Convert.ToBoolean(row["modificar_permiso"]) ? "1" : "0");
                    row["eliminar_permiso"] = (Convert.ToBoolean(row["eliminar_permiso"]) ? "1" : "0");
                    row["imprimir_permiso"] = (Convert.ToBoolean(row["imprimir_permiso"]) ? "1" : "0");
                }

                Dgv_asignacionesperfiles.Refresh();
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

        private void Dgv_asignacionesperfiles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    //******************ACA TERMINA********************************************************
}
