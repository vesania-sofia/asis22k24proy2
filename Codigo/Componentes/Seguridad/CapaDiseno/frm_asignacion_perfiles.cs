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
    public partial class frm_asignacion_perfiles : Form
    {
        logica logic;
        string TablaPerfilUsuario = "Tbl_asignaciones_perfils_usuario";

        //###################  empieza lo que hizo Karla  Sofia Gómez Tobar #######################
        public frm_asignacion_perfiles(string sidUsuario)
        {
            InitializeComponent();

            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Crea nueva asignación");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_guardar, "Guardar nueva asignación");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar todas las asignaciones");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "reestablecer");
            ToolTip tremover = new ToolTip();
            tcancelar.SetToolTip(Btn_remover, "Quita la nueva asignación");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir de asignacion perfil");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");

            logic = new logica(sidUsuario);
            string stablaU = "Tbl_usuarios";
            string scampo1U = "Pk_id_usuario";
            string scampo2U = "nombre_usuario";

            string stablaP = "Tbl_perfiles";
            string scampo1P = "Pk_id_perfil";
            string scampo2P = "nombre_perfil";


            string sTablaA = "Tbl_asignaciones_perfils_usuario";
            string scampo1A= "PK_id_Perfil_Usuario";







            prollenarseUsuario(stablaU, scampo1U, scampo2U);
            prollenarsePerfil(stablaP, scampo1P, scampo2P);



            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            Cbo_usuario.SelectedIndexChanged += new EventHandler(Cbo_usuario_SelectedIndexChanged);
            Cbo_perfiles.SelectedIndexChanged += new EventHandler(Cbo_perfiles_SelectedIndexChanged2);
            

        }



        public void prollenarseUsuario(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logic.funenviarUsuario(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_usuario.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_usuario.Items.Add(new ComboBoxItemU
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

            Cbo_usuario.AutoCompleteCustomSource = coleccion;
            Cbo_usuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_usuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItemU
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_usuario.SelectedItem != null)
            {
                
                var selectedItem = (ComboBoxItemU)Cbo_usuario.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }


// /////////////////////////////////////////////////////////////////////////////////
        public void prollenarsePerfil(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logic.funenviarPerfiles(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_perfiles.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_perfiles.Items.Add(new ComboBoxItemP
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

            Cbo_perfiles.AutoCompleteCustomSource = coleccion2;
            Cbo_perfiles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_perfiles.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItemP
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Cbo_perfiles_SelectedIndexChanged2(object sender, EventArgs e)
        {
            if (Cbo_perfiles.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItemP)Cbo_perfiles.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }



        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        public frm_asignacion_perfiles()
        {
        }

        private void Frm_asignacion_perfiles_Load(object sender, EventArgs e)
        {
           
        }

        private void Dgv_perfiles_asignados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void prolimpieza()
        {
            Cbo_usuario.Text = " ";
            Cbo_perfiles.Text = " ";
            
            Dgv_perfiles_asignados.Columns.Clear();
            

            if (iContadorFila > 0)
            {
                Dgv_asignacion_perfiles.Rows.RemoveAt(Dgv_asignacion_perfiles.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
                
            }
        }

        void prolimpiezaIngreso()
        {
            Cbo_usuario.Text = " ";
            Cbo_perfiles.Text = " ";
 
        }

        public static int iContadorFila = 0;




        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "ayudaAsignacionPerfiles.chm", "Asignacion_Perfil_Usuarios.html");
        }



        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Cbo_usuario.Enabled = true;
            Cbo_perfiles.Enabled = true;
            Btn_agregar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_remover.Enabled = false;
            Gpb_consulta.Enabled = true;
            prolimpieza();
        }

        public void proactualizardatagriew()
        {
            
            
            try
            {
                // Llamar a la capa lógica para obtener los datos de la asignación (modulo-aplicación)
                DataTable dt = logic.funconsultaLogicaPerfilesUsuarios();

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    Dgv_perfiles_asignados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar los datos: {ex.Message}");
            }
        }



        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (Cbo_usuario.SelectedItem == null || Cbo_perfiles.SelectedItem == null)
            {
                MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool bUsuario_perfil_existente = false;

                string sUsuario = Cbo_usuario.SelectedItem.ToString();
                string sPerfil = Cbo_perfiles.SelectedItem.ToString();

                if (iContadorFila == 0)
                {
                    Dgv_asignacion_perfiles.Rows.Add(sUsuario, sPerfil);

                    iContadorFila++;

                }
                else
                {
                    foreach (DataGridViewRow Fila in Dgv_asignacion_perfiles.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == Cbo_usuario.SelectedItem.ToString() && Fila.Cells[1].Value.ToString() == Cbo_perfiles.SelectedItem.ToString())
                        {
                            bUsuario_perfil_existente = true;
                        }
                    }

                    if (bUsuario_perfil_existente == true)
                    {
                        MessageBox.Show("Ya existe una relacion del usuario con el perfil");
                    }
                    else
                    {
                        Dgv_asignacion_perfiles.Rows.Add(sUsuario, sPerfil);
                        iContadorFila++;
                    }
                    Btn_agregar.Enabled = true;
                    Btn_remover.Enabled = true;
                    Btn_guardar.Enabled = true;
                    Btn_buscar.Enabled = false;
                    Btn_cancelar.Enabled = false;
                    Gpb_consulta.Enabled = false;
                }

                prolimpiezaIngreso();
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // Deshabilitar los ComboBox después de la selección
            Cbo_usuario.Enabled = false;
            Cbo_perfiles.Enabled = false;

            // Validar si los ComboBox están vacíos
            if (Cbo_usuario.SelectedItem == null)
            {
                MessageBox.Show("Falta seleccionar un usuario.");
                Btn_agregar.Enabled = false;
                Cbo_usuario.Enabled = false;
                Cbo_perfiles.Enabled = false;
            }
            else if (Cbo_perfiles.SelectedItem == null)
            {
                MessageBox.Show("Falta seleccionar un perfil.");
                Btn_agregar.Enabled = false;
                Cbo_usuario.Enabled = false;
                Cbo_perfiles.Enabled = false;
            }
            else
            {
                // Obtener los valores seleccionados de los ComboBox
                string susuarioSeleccionado = Cbo_usuario.SelectedItem.ToString();
                string sperfilSeleccionado = Cbo_perfiles.SelectedItem.ToString();

                // Insertar en la base de datos utilizando los valores de los ComboBox
                logic.funconsultaLogicaInsertarPerfilUsuario(susuarioSeleccionado, sperfilSeleccionado);

                MessageBox.Show("Asignación de usuario y perfil ingresada correctamente.");
                prolimpieza();

                // Configuración de botones y controles después de la inserción


                Cbo_usuario.Enabled = true;
                Cbo_perfiles.Enabled = true;
                Btn_agregar.Enabled = true;
                Btn_guardar.Enabled = true;
                Btn_cancelar.Enabled = true;
                Btn_remover.Enabled = true;
                Btn_buscar.Enabled = true;
                Gpb_consulta.Enabled = true;
                prolimpieza();
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            if (iContadorFila > 0)
            {
                Dgv_asignacion_perfiles.Rows.RemoveAt(Dgv_asignacion_perfiles.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
                MessageBox.Show("No hay relaciones que eliminar");
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            proactualizardatagriew();
            Cbo_usuario.Enabled = false;
            Cbo_perfiles.Enabled = false;
            Btn_agregar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_remover.Enabled = false;
        }



        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Cbo_usuario.Enabled = true;
            Cbo_perfiles.Enabled = true;
            Btn_agregar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_buscar.Enabled = true;
            Btn_remover.Enabled = false;
            Gpb_consulta.Enabled = true;
            prolimpieza();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            prolimpieza();
        }
    }
}
