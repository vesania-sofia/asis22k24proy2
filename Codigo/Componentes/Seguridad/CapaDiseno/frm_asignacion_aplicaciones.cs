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
            string tabla = "tbl_modulos";
            string campo1 = "Pk_id_modulos";
            string campo2 = "nombre_modulo";

            string tablaApli = "tbl_aplicaciones";
            string campo1Apli = "Pk_id_aplicacion";
            string campo2Apli = "nombre_aplicacion";

            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
            llenarseApli(tablaApli, campo1Apli, campo2Apli);

            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            cbo_modulos.SelectedIndexChanged += new EventHandler(Cbo_modulos_SelectedIndexChanged);
            cbo_aplicaciones.SelectedIndexChanged += new EventHandler(Cbo_aplicaciones_SelectedIndexChanged);
        }
        //####  FINALIZA ALYSON RODRIGUEZ 9959-21-829

        public frm_asignacion_aplicaciones()
        {
        }



        //Trabajado María José Véliz
        private void Frm_asignacion_aplicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenar el ComboBox de usuarios
                DataTable dtUsuario = logic.consultaLogicaUsuarios();
                foreach (DataRow row in dtUsuario.Rows)
                {
                    cbo_usuarios.Items.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                // Llenar el ComboBox de módulos
                llenarseModulos("tbl_modulos", "Pk_id_modulos", "nombre_modulo");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }
        //termina

        void limpieza()
        {
            cbo_usuarios.Text = " ";
            cbo_modulos.Text = " ";
            cbo_aplicaciones.Text = " ";
        }

        ///### INICIA ALYSON RODRIGUEZ 9959-21-829  ##################################
        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_modulos.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem)cbo_modulos.SelectedItem;
                string nombreModulo = selectedItem.Display; // Asumiendo que Display contiene el nombre del módulo

                var dtAplicaciones = logic.consultaLogicaAplicaciones(nombreModulo);

                // Limpia el ComboBox de aplicaciones antes de llenarlo
                cbo_aplicaciones.Items.Clear();

                foreach (DataRow row in dtAplicaciones.Rows)
                {
                    // Agrega el elemento mostrando el formato "ID-Nombre"
                    cbo_aplicaciones.Items.Add(new ComboBoxItem
                    {
                        Value = row["Pk_id_aplicacion"].ToString(),
                        Display = row["nombre_aplicacion"].ToString()
                    });
                }

                // Configura AutoComplete para el ComboBox con el formato deseado
                AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
                foreach (DataRow row in dtAplicaciones.Rows)
                {
                    coleccion2.Add(Convert.ToString(row["Pk_id_aplicacion"]) + "-" + Convert.ToString(row["nombre_aplicacion"]));
                    coleccion2.Add(Convert.ToString(row["nombre_aplicacion"]) + "-" + Convert.ToString(row["Pk_id_aplicacion"]));
                }

                cbo_aplicaciones.AutoCompleteCustomSource = coleccion2;
                cbo_aplicaciones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbo_aplicaciones.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        //####  FINALIZA ALYSON RODRIGUEZ 9959-21-829

        ///### INICIA ALYSON RODRIGUEZ 9959-21-829  ##################################
        public void llenarseModulos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logic.enviarUsuario(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            cbo_modulos.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cbo_modulos.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }
            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cbo_modulos.AutoCompleteCustomSource = coleccion;
            cbo_modulos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_modulos.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }
        ///### FINALIZA ALYSON RODRIGUEZ 9959-21-829  ##############################################

        //Trabajado por María José Véliz
        public void llenarseApli(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logic.enviarUsuario(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            cbo_aplicaciones.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cbo_aplicaciones.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion2.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion2.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cbo_aplicaciones.AutoCompleteCustomSource = coleccion2;
            cbo_aplicaciones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_aplicaciones.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem2
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_aplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_modulos.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)cbo_aplicaciones.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }

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

                string sAplicacion = cbo_aplicaciones.SelectedItem.ToString();
                string sUsuario = cbo_usuarios.SelectedItem.ToString();


                if (iContadorFila == 0)
                {
                    dgv_asignaciones.Rows.Add(sAplicacion, sUsuario);

                    iContadorFila++;


                }
                else
                {
                    foreach (DataGridViewRow Fila in dgv_asignaciones.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == cbo_aplicaciones.SelectedItem.ToString() &&
                           Fila.Cells[1].Value.ToString() == cbo_usuarios.SelectedItem.ToString())
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
                        dgv_asignaciones.Rows.Add(sAplicacion, sUsuario);
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

        // INICIO ALYSON RODRIGUEZ 9959-21-829 ##################################
        private void Btn_finalizar_Click(object sender, EventArgs e)
        {

            string sIngresar;
            string sModificar;
            string sEliminar;
            string sConsulta;
            string sImprimir;
            try
            {
                foreach (DataGridViewRow Fila in dgv_asignaciones.Rows)
                {


                    string sAplicacion = Fila.Cells[0].Value.ToString();
                    string sUsuario = Fila.Cells[1].Value.ToString();


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

                    DataTable dtAplicaciones = logic.consultaLogicaPermisosUsuarioAplicacion(sAplicacion, sUsuario, sIngresar, sModificar, sEliminar, sConsulta, sImprimir);

                }

                MessageBox.Show("Datos ingresados exitosamente");
                limpieza();
                //dgv_asignaciones.Rows.Clear();
                iContadorFila = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        // FINALIZA ALYSON RODRIGUEZ 9959-21-829 ##################################

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
    }
}
