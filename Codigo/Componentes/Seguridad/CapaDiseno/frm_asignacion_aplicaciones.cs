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


/*---------------------------Creador: Allan Letona------------------------------*/

namespace CapaDiseno
{
    public partial class frm_asignacion_aplicaciones : Form
    {
        logica logic;

        //########## INICIA ALYSON RODRIGUEZ 9959-21-829
        public frm_asignacion_aplicaciones(string idUsuario)
        {
            InitializeComponent();
            logic = new logica(idUsuario);
            
        }
        //####  FINALIZA ALYSON RODRIGUEZ 9959-21-829

        public frm_asignacion_aplicaciones()
        {
        }


        //María José Véliz 
        // Método para cargar los usuarios
        private void CargarUsuarios()
        {
            try
            {
                DataTable dtPerfiles = logic.consultaLogicaUsuarios();
                cbo_usuarios.Items.Clear();
                foreach (DataRow row in dtPerfiles.Rows)
                {
                    cbo_usuarios.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar usuarios: " + ex.Message);
            }
        }
        //termina

        //Trabajado María José Véliz
        private void Frm_asignacion_aplicaciones_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarModulos();
        }           
        //termina

        void limpieza()
        {
            cbo_usuarios.Text = " ";
            cbo_modulos.Text = " ";
            cbo_aplicaciones.Text = " ";
        }

        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
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
                cbo_modulos.SelectedIndexChanged += new EventHandler(Cbo_modulos_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        }
        //FIN ALYSON RODRIGURZ 9959-21-829

        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
        // Método para cargar aplicaciones según el módulo seleccionado
        private void CargarAplicaciones(string nombreModulo)
        {
            try
            {
                DataTable dtAplicaciones = logic.consultaLogicaAplicaciones(nombreModulo);
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
        //FIN ALYSON RODRIGURZ 9959-21-829


        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Limpiar las aplicaciones antes de agregar nuevas

            if (cbo_modulos.SelectedIndex != -1)
            {
                string moduloSeleccionado = cbo_modulos.SelectedItem.ToString();
                CargarAplicaciones(moduloSeleccionado);
            }

        }
        //FIN ALYSON RODRIGURZ 9959-21-829



        //Trabajado María José Véliz
        private void Cbo_aplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_aplicaciones.SelectedItem != null)
            {
                string nombreAplicacion = cbo_aplicaciones.SelectedItem.ToString();
                Console.WriteLine("Aplicación seleccionada: " + nombreAplicacion);
            }

        }
        //Termina


        public static int iContadorFila = 0;
        //Trabajado María José Véliz
        private void Btn_agregar_Click(object sender, EventArgs e)
        {

            if (cbo_aplicaciones.SelectedItem == null || cbo_usuarios.SelectedItem == null)
            {
                MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool bUsuario_aplicacion_existente = false;

                string sUsuario = cbo_usuarios.SelectedItem.ToString();
                string sAplicacion = cbo_aplicaciones.SelectedItem.ToString();



                if (iContadorFila == 0)
                {
                    dgv_asignaciones.Rows.Add(sUsuario, sAplicacion);

                    iContadorFila++;


                }
                else
                {
                    foreach (DataGridViewRow Fila in dgv_asignaciones.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == cbo_usuarios.SelectedItem.ToString() && Fila.Cells[1].Value.ToString() == cbo_aplicaciones.SelectedItem.ToString())

                        {
                            bUsuario_aplicacion_existente = true;
                        }
                    }

                    if (bUsuario_aplicacion_existente == true)
                    {
                        MessageBox.Show("Ya existe una relacion del usuario con la aplicacion");
                    }
                    else
                    {
                        dgv_asignaciones.Rows.Add(sUsuario, sAplicacion);
                        iContadorFila++;
                    }
                }

                limpieza();
            }

        }
        //Tremina


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void Btn_remover_Click(object sender, EventArgs e)
        {
            if (iContadorFila > 0)
            {
                dgv_asignaciones.Rows.RemoveAt(dgv_asignaciones.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
                MessageBox.Show("No hay relaciones que eliminar");
            }
        }

        // INICIO ALYSON RODRIGUEZ 9959-21-829 
        private void Btn_finalizar_Click(object sender, EventArgs e)
        {

            string sIngresar;
            string sConsulta;
            string sModificar;
            string sEliminar;
            string sImprimir;
            try
            {
                foreach (DataGridViewRow Fila in dgv_asignaciones.Rows)
                {
                    string sUsuario = Fila.Cells[0].Value.ToString();
                    string sAplicacion = Fila.Cells[1].Value.ToString();


                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    if (cheked)
                        sIngresar = "1";
                    else
                        sIngresar = "0";

                    bool chekedM = ((bool)(Fila.Cells["Modificar"].EditedFormattedValue));
                    if (chekedM)
                        sModificar = "1";
                    else
                        sModificar = "0";

                    bool chekedE = ((bool)(Fila.Cells["Eliminar"].EditedFormattedValue));
                    if (chekedE)
                        sEliminar = "1";
                    else
                        sEliminar = "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    if (chekedC)
                        sConsulta = "1";
                    else
                        sConsulta = "0";

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    if (chekedI)
                        sImprimir = "1";
                    else
                        sImprimir = "0";

                    // Mostrar mensaje con los datos de cada fila antes de insertar
                    MessageBox.Show(
                        $"Datos de la fila:\n" +
                        $"Usuario: {sUsuario}\n" +
                        $"Aplicación: {sAplicacion}\n" +
                        $"Ingresar: {sIngresar}\n" +
                        $"Consultar: {sConsulta}\n" +
                        $"Modificar: {sModificar}\n" +
                        $"Eliminar: {sEliminar}\n" +
                        $"Imprimir: {sImprimir}",
                        "Datos de la Fila",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DataTable dtAplicaciones = logic.consultaLogicaPermisosUsuarioAplicacion(sUsuario, sAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);

                }

                MessageBox.Show("Datos ingresados exitosamente");
                limpieza();
                dgv_asignaciones.Rows.Clear();
                iContadorFila = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        // FINALIZA ALYSON RODRIGUEZ 9959-21-829 


        //Trabajado María José Véliz   //Cambios Trabajados por Alyson Rodriguez 9959-21-829
        // Método para configurar CheckBoxColumns en el DataGridView
        private void ConfigurarColumnasCheckBox()
        {

            // Asegurarte de que el DataGridView esté vacío antes de configurar columnas
            dgv_asignaciones.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Fk_id_usuario", HeaderText = "Usuario" });
            dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "nombre_aplicacion", HeaderText = "Aplicación" });
            dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "guardar_permiso", HeaderText = "Ingresar" });
            dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "buscar_permiso", HeaderText = "Consultar" });
            dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "modificar_permiso", HeaderText = "Modificar" });
            dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "eliminar_permiso", HeaderText = "Eliminar" });
            dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "imprimir_permiso", HeaderText = "Imprimir" });


            // Lista de las columnas que son CheckBox y necesitan configuración
            string[] permisosColumnas = { "Ingresar", "Consultar", "Modificar", "Eliminar", "Imprimir" };

            foreach (string columna in permisosColumnas)
            {
                // Verificar si la columna existe en el DataGridView
                if (dgv_asignaciones.Columns.Contains(columna))
                {
                    if (dgv_asignaciones.Columns[columna] is DataGridViewCheckBoxColumn checkBoxColumn)
                    {
                        // Configurar permisos habilitados o deshabilitados para cada columna CheckBox
                        checkBoxColumn.TrueValue = 1;
                        checkBoxColumn.FalseValue = 0;
                    }
                }
            }
        }
        //Termina

        //Trabajado por Alyson Rodriguez 9959-21-829
        public void ActualizarDataGridView()
        {
            // Obtener los datos desde la base de datos
            DataTable dt = logic.consultaLogicaUsuarios("Tbl_permisos_aplicaciones_usuario");

            // Verificar si hay datos
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Datos recibidos: " + dt.Rows.Count.ToString());

                // Mensaje con los datos obtenidos
                string datosObtenidos = "Datos recibidos:\n";

                // Recorrer las filas y columnas para mostrar los datos
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        datosObtenidos += $"{column.ColumnName}: {row[column]}\n";
                    }
                    datosObtenidos += "-------------------\n"; // Separador entre filas
                }

                // Asignar el DataTable al DataGridView directamente
                dgv_asignaciones.DataSource = dt;

                // Actualizar el DataGridView para reflejar los nuevos datos
                dgv_asignaciones.Refresh();
                ConfigurarColumnasCheckBox();
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }
        //##################Finaliza##################


        private void Dgv_asignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
           
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "AyudaAsignacionAplicacionesUsuarios.chm", "Asignacion_Aplicaciones_Usuarios.html");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
    }
}
