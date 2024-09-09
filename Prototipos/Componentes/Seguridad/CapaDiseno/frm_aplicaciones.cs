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
            btn_cancel.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_modif.Enabled = false;
            btn_eliminar.Enabled = false;
            logic = new logica(idUsuario);
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################
        public frm_aplicaciones()
        {
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
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

        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################
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


        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
        //aqui inica lo que hizo Carlos Hernandez
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string idaplicacion = txt_idaplicacion.Text.Trim();
            string descripcion = txt_descripcion.Text.Trim();
            string aplicacion = txt_idaplicacion.Text.Trim();

            txt_buscar.Enabled = true;
            btn_bsucarap.Enabled = true;
            btn_modif.Enabled = false;
            btn_nuevo.Enabled = false;
            txt_idaplicacion.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;

            try
            {
               
                DataTable dtusuario = logic.eliminaraplicaciones(idaplicacion, descripcion, aplicacion);

                if (dtusuario == null || dtusuario.Rows.Count == 0)
                {
                    MessageBox.Show("No se eliminaron registros.");
                }
                else
                {
                    MessageBox.Show("Registro eliminado exitosamente.");
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
            txt_idaplicacion.Text = "";
            limpiar();

        }
        //aqui termina la parte de Carlos Hernandez

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            limpiar();
            btn_nuevo.Enabled = true;
            gb_buscar.Enabled = true;
            btn_bsucarap.Enabled = true;
            btn_cancel.Enabled = false;
            btn_ingresar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_modif.Enabled = false;
            txt_idaplicacion.Enabled = false;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;


        }
       
        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        //esto fue echo por Carlos hernandez
        private void btn_modif_Click(object sender, EventArgs e)
        {
            string idaplicacion = txt_idaplicacion.Text.Trim();
            string descripcion = txt_descripcion.Text.Trim();
            string aplicacion = txt_idaplicacion.Text.Trim();
            if (string.IsNullOrWhiteSpace(idaplicacion) ||
                string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(aplicacion))
            {
                MessageBox.Show("Faltan campos por llenar.");
                return;
            }
            txt_buscar.Enabled = false;
            btn_bsucarap.Enabled = true;
            btn_modif.Enabled = true;
            btn_nuevo.Enabled = true;
            txt_idaplicacion.Enabled = false;
            txt_descripcion.Enabled = true;
            txt_idaplicacion.Enabled = true;
            try
            {
                DataTable resultado = logic.modificaraplicaciones(idaplicacion, descripcion, aplicacion);
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    MessageBox.Show("Registro modificado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error durante la modificación: {ex.Message}");
            }
            txt_idaplicacion.Text = "";
            limpiar();
        }
        //termina lo que hizo carlos hernandez 


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_bsucarap_Click(object sender, EventArgs e)
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

                btn_modif.Enabled = true;
                btn_ingresar.Enabled = false;
                txt_idaplicacion.Enabled = false;
                txt_nombre.Enabled = false;
                txt_descripcion.Enabled = false;
                Rdb_activo.Enabled = false;
                Rdb_inactivo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar ####################### 
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Rdb_activo.Checked = true;
            Gpb_estado.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            gb_buscar.Enabled = false;
            btn_modif.Enabled = false;
            btn_ingresar.Enabled = true;
            btn_cancel.Enabled = true;
            txt_idaplicacion.Enabled = true;
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;



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

        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
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

        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoAplicaciones.chm", "Mantenimiento_Aplicaciones.html");
        }

    }


}
