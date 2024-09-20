using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class frm_perfiles_mantenimiento : Form
    {
        logica logic;

        public frm_perfiles_mantenimiento(string idUsuario)
        {
            InitializeComponent();
            btn_modif.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_cancel.Enabled = false;
            logic = new logica(idUsuario);
            txtcodigo.Enabled = false;
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;
            btn_ingresar.Enabled = false;
            gbestado.Enabled = false;
            btn_eli.Enabled = false;   // se agrega el boton eliminar 

        }

        public frm_perfiles_mantenimiento()
        {
        }

        void limpiar()
        {
            tbx_buscarperfil.Text = "";
            txtcodigo.Text = "";
            txtdesc.Text = "";
            txtnombre.Text = "";
            rbhabilitado.Checked = false;
            rbinhabilitado.Checked = false;
            txtcodigo.Focus();
        }
     

        private void Frm_perfiles_mantenimiento_Load(object sender, EventArgs e)
        {

        }

      

    

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil");
                btn_nuevo.Enabled = true;

            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil");
                btn_nuevo.Enabled = true;

            }

            else
            {
                string estado = "";
                if (rbhabilitado.Checked)
                {
                    estado = "1";
                }

                if (rbinhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.Actualizarperfil(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                MessageBox.Show("Perfil Actualizado Correctamente");
                btn_modif.Enabled = false;
                btn_actualizar.Enabled = false;
                btn_cancel.Enabled = false;
                btn_ingresar.Enabled = false;
                btn_nuevo.Enabled = true;
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;
                gbestado.Enabled = false;
                limpiar();

            }
        }

        private void btn_modif_Click_1(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_cancel.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_modif.Enabled = false;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            rbhabilitado.Enabled = true;
            rbinhabilitado.Enabled = true;
            gbestado.Enabled = true;
        }

        private void rbhabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoPerfiles.chm", "AyudaMantenimientoPerfiles.html");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            gbbuscar.Enabled = false;
            btn_modif.Enabled = false;
            rbhabilitado.Checked = true;
            rbinhabilitado.Checked = true;
            gbestado.Enabled = true;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            btn_ingresar.Enabled = true;
            btn_cancel.Enabled = true;

            try
            {
                DataTable dtValidarID = logic.validarIDperfiles();
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0].ToString() == "")
                    {
                        txtcodigo.Text = "1";
                    }
                    else
                    {
                        txtcodigo.Text = row[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;



            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil");

                btn_nuevo.Enabled = true;

            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil");
                btn_nuevo.Enabled = true;

            }

            else
            {
                string estado = "";
                if (rbhabilitado.Checked)
                {
                    estado = "1";
                }

                if (rbinhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.ingresarperfiles(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                MessageBox.Show("Perfil Ingresado Correctamente");
                limpiar();
                gbbuscar.Enabled = true;
                btn_nuevo.Enabled = true;
                btn_ingresar.Enabled = false;
            }
        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string perfil = tbx_buscarperfil.Text;

            if (string.IsNullOrWhiteSpace(perfil))
            {
                MessageBox.Show("Por favor, ingrese un ID de una aplicacion.");
                return;
            }

            try
            {
                DataTable dtModulos = logic.ConsultaLogicaPerfil(perfil);

                if (dtModulos == null || dtModulos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraro la aplicacion.");
                    return;
                }

                foreach (DataRow row in dtModulos.Rows)
                {
                    if (row[0] != DBNull.Value) txtcodigo.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) txtnombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) txtdesc.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string estado = row[3].ToString();
                        if (estado == "1")
                        {
                            rbhabilitado.Checked = true;
                            rbinhabilitado.Checked = false;
                        }
                        else if (estado == "0")
                        {
                            rbhabilitado.Checked = false;
                            rbinhabilitado.Checked = true;
                        }
                    }
                }

                btn_modif.Enabled = true;
                btn_ingresar.Enabled = false;
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;
                rbhabilitado.Enabled = false;
                rbinhabilitado.Enabled = false;
                btn_eli.Enabled = true;
                btn_nuevo.Enabled = false;
                btn_cancel.Enabled = true;
                gbestado.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            limpiar();
            btn_modif.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_cancel.Enabled = false;
            btn_ingresar.Enabled = false;
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;
            gbbuscar.Enabled = true;
            btn_nuevo.Enabled = true;
            gbestado.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoPerfiles.chm", "AyudaMantenimientoPerfiles.html");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil");
                btn_nuevo.Enabled = true;

            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil");
                btn_nuevo.Enabled = true;

            }

            else
            {
                string estado = "";
                if (rbhabilitado.Checked)
                {
                    estado = "1";
                }

                if (rbinhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.Actualizarperfil(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                MessageBox.Show("Perfil Actualizado Correctamente");
                btn_modif.Enabled = false;
                btn_actualizar.Enabled = false;
                btn_cancel.Enabled = false;
                btn_ingresar.Enabled = false;
                btn_nuevo.Enabled = true;
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;
                gbestado.Enabled = false;
                limpiar();

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_cancel.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_modif.Enabled = false;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            rbhabilitado.Enabled = true;
            rbinhabilitado.Enabled = true;
            gbestado.Enabled = true;
        }
        /* creado por Emerzon Garcia */
        private void button1_Click_3(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcodigo.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.Eliminarperfil(txtcodigo.Text);

                    // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
                    btn_modif.Enabled = false;
                    btn_actualizar.Enabled = false;
                    btn_cancel.Enabled = false;
                    btn_ingresar.Enabled = false;
                    btn_nuevo.Enabled = true;
                    txtcodigo.Enabled = false;
                    gbestado.Enabled = false;  // Desactiva el grupo de radio buttons
                    limpiar();  // Limpiar campos
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.");
            }
        }
    }
}
