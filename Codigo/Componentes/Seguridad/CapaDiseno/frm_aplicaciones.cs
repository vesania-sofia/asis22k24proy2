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
namespace CapaDiseno
{

    public partial class frm_aplicaciones : Form
    {

        logica logic;

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public frm_aplicaciones(string idUsuario)
        {
            InitializeComponent();
            btn_cancelar.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            logic = new logica(idUsuario);
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(btn_nuevo, "Crear aplicación");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(btn_ingresar, "Guardar aplicación");
            ToolTip tactualizar = new ToolTip();
            tactualizar.SetToolTip(btn_modificar, "Actualizar Cambios");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(btn_bsucar, "Buscar aplicación");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(btn_modificar, "Modificar aplicación");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(btn_eliminar, "Eliminar aplicación");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(btn_cancelar, "Cancelar Cambios");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(btn_salir, "Salir Mantenimiento de aplicaciones");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(btn_ayuda, "Ayuda");
        }
     
        public frm_aplicaciones()
        {
        }


        void limpiar()
        {
            txt_idaplicacion.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_buscar.Text = "";
            Rdb_activo.Checked = false;
            Rdb_inactivo.Checked = false;
            txt_idaplicacion.Focus();
        }


        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_aplicaciones_Load(object sender, EventArgs e)
        {

        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoAplicaciones.chm", "Mantenimiento_Aplicaciones.html");
        }

        private void btn_bsucar_Click(object sender, EventArgs e)
        {
            string aplicacion = txt_buscar.Text;

            if (string.IsNullOrWhiteSpace(aplicacion))
            {
                MessageBox.Show("Por favor, ingrese un ID de una aplicacion.");
                return;
            }

            try
            {
                DataTable dtAplicacion = logic.consultaLogicaAplicaciones(aplicacion);

                if (dtAplicacion == null || dtAplicacion.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraro la aplicacion.");
                    return;
                }

                foreach (DataRow row in dtAplicacion.Rows)
                {
                    if (row[0] != DBNull.Value) txt_idaplicacion.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) txt_nombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) txt_descripcion.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string estado = row[3].ToString();
                        if (estado == "1")
                        {
                            Rdb_activo.Checked = true;
                            Rdb_inactivo.Checked = false;
                        }
                        else if (estado == "0")
                        {
                            Rdb_activo.Checked = false;
                            Rdb_inactivo.Checked = true;
                        }
                    }
                }

                btn_modificar.Enabled = true;
                btn_cancelar.Enabled = true;
                btn_ingresar.Enabled = false;
                txt_idaplicacion.Enabled = false;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
                Rdb_activo.Enabled = false;
                Rdb_inactivo.Enabled = false;
                btn_eliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Rdb_activo.Checked = true;
            Gpb_estado.Enabled = true;
            btn_ingresar.Enabled = true;
            btn_cancelar.Enabled = true;
            txt_idaplicacion.Enabled = true;
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            gb_buscar.Enabled = false;
            btn_modificar.Enabled = false;
            



            try
            {
                DataTable dtValidarID = logic.validarIDAplicacion();
                if (dtValidarID == null || dtValidarID.Rows.Count == 0)
                {

                    return;
                }
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0] != DBNull.Value)
                    {
                        txt_idaplicacion.Text = row[0].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;

            if (txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion");
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }
            else if (txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion");
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }

            else
            {
                string estado = "";
                if (Rdb_activo.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inactivo.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.insertaraplicaciones(txt_idaplicacion.Text.ToString(), txt_nombre.Text.ToString(), txt_descripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente");
                limpiar();
                gb_buscar.Enabled = true;
                btn_ingresar.Enabled = false;
                btn_nuevo.Enabled = true;
                txt_idaplicacion.Enabled = false;
            }
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            Rdb_activo.Checked = true;
            Gpb_estado.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = true;
            gb_buscar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_cancelar.Enabled = true;
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion");
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }
            else if (txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion");
                btn_nuevo.Enabled = true;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
            }

            else
            {
                string estado = "";
                if (Rdb_activo.Checked)
                {
                    estado = "1";
                }

                if (Rdb_inactivo.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.actualizaraplicaciones(txt_idaplicacion.Text.ToString(), txt_nombre.Text.ToString(), txt_descripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Modificado Correctamente");
                limpiar();
                btn_cancelar.Enabled = false;
                btn_bsucar.Enabled = true;
                btn_nuevo.Enabled = true;
                btn_ingresar.Enabled = false;
                btn_actualizar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = false;
                txt_idaplicacion.Enabled = false;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
                Gpb_estado.Enabled = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_idaplicacion.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.eliminaraplicaciones(txt_idaplicacion.Text);

                    // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
                    txt_buscar.Enabled = true;
                    btn_bsucar.Enabled = false;
                    btn_modificar.Enabled = false;
                    btn_nuevo.Enabled = true;
                    txt_idaplicacion.Enabled = false;
                    txt_descripcion.Enabled = false;
                    Gpb_estado.Enabled = false;
                    limpiar();  // Limpiar campos
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btn_nuevo.Enabled = true;
            gb_buscar.Enabled = true;
            btn_bsucar.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_modificar.Enabled = false;
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
        }
    }
}

//###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################