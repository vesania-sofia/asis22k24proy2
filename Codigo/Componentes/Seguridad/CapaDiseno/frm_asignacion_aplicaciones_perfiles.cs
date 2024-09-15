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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        }

        // Método para cargar aplicaciones según el módulo seleccionado
        private void CargarAplicaciones()
        {
            try
            {
                DataTable dtAplicaciones = logic.consultaLogicaAplicaciones();
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

            if (cbo_modulos.SelectedItem != null)
            {
                string nombreModulo = cbo_modulos.SelectedItem.ToString();
                CargarAplicaciones();
            }
            
        }
//****************************************FIN Kevin López***************************************************


        public static int iContadorFila = 0;

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
            string sIngresar;
            string sConsulta;
            string sModificar;
            string sEliminar;
            string sImprimir;
            try
            {
                foreach (DataGridViewRow Fila in dgv_asignacionesperfiles.Rows)
                {

                    string sPerfil = Fila.Cells[0].Value.ToString();
                    string sAplicacion = Fila.Cells[1].Value.ToString();


                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    if (cheked)
                        sIngresar = "1";
                    else
                        sIngresar = "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    if (chekedC)
                        sConsulta = "1";
                    else
                        sConsulta = "0";

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

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    if (chekedI)
                        sImprimir = "1";
                    else
                        sImprimir = "0";

                    DataTable dtAplicaciones = logic.consultaLogicaPermisosPerfilAplicacion(sPerfil, sAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);

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
    }
}
