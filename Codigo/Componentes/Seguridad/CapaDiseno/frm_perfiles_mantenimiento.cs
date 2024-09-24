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

        public frm_perfiles_mantenimiento(string sidUsuario)
        {
            InitializeComponent();
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_cancelar.Enabled = false;
            logic = new logica(sidUsuario);
            Txt_codigo.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descipcion.Enabled = false;
            Btn_guardar.Enabled = false;
            Gpb_estado.Enabled = false;
            Btn_eliminar.Enabled = false;   // se agrega el boton eliminar 

        }

        public frm_perfiles_mantenimiento()
        {
        }

        void limpiar()
        {
            Tbx_buscarperfil.Text = "";
            Txt_codigo.Text = "";
            Txt_descipcion.Text = "";
            Txt_nombre.Text = "";
            Rdb_habilitado.Checked = false;
            Rdb_inhabilitado.Checked = false;
            Txt_codigo.Focus();
        }
     

        private void Frm_perfiles_mantenimiento_Load(object sender, EventArgs e)
        {

        }

     


        private void rbhabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Txt_nombre.Enabled = false;
            Txt_descipcion.Enabled = false;



            if (Txt_nombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil");

                Btn_ingreso.Enabled = true;

            }
            else if (Txt_descipcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil");
                Btn_ingreso.Enabled = true;

            }

            else
            {
                string sestado = "";
                if (Rdb_habilitado.Checked)
                {
                    sestado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                   sestado = "0";
                }
                else
                {
                    sestado = "1";
                }

                logic.funingresarperfiles(Txt_codigo.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descipcion.Text.ToString(), sestado.ToString());
                MessageBox.Show("Perfil Ingresado Correctamente");
                limpiar();
                Gpb_buscarperfiles.Enabled = true;
                Btn_ingreso.Enabled = true;
                Btn_guardar.Enabled = false;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Txt_nombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Perfil");
                Btn_ingreso.Enabled = true;

            }
            else if (Txt_descipcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion del Perfil");
                Btn_ingreso.Enabled = true;

            }

            else
            {
                string sestado = "";
                if (Rdb_habilitado.Checked)
                {
                    sestado = "1";
                }

                if (Rdb_inhabilitado.Checked)
                {
                    sestado = "0";
                }
                else
                {
                   sestado = "1";
                }

                logic.funactualizar(Txt_codigo.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descipcion.Text.ToString(), sestado.ToString());
                MessageBox.Show("Perfil Actualizado Correctamente");
                Btn_modificar.Enabled = false;
                Btn_actualizar.Enabled = false;
                Btn_cancelar.Enabled = false;
                Btn_guardar.Enabled = false;
                Btn_ingreso.Enabled = true;
                Txt_codigo.Enabled = false;
                Txt_nombre.Enabled = false;
                Txt_descipcion.Enabled = false;
                Gpb_estado.Enabled = false;
                limpiar();

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            Btn_ingreso.Enabled = false;
            Btn_actualizar.Enabled = false;
            Gpb_buscarperfiles.Enabled = false;
            Btn_modificar.Enabled = false;
            Rdb_habilitado.Checked = true;
            Rdb_inhabilitado.Checked = true;
            Gpb_estado.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_descipcion.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_cancelar.Enabled = true;

            try
            {
                DataTable dtValidarID = logic.funagregar();
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0].ToString() == "")
                    {
                        Txt_codigo.Text = "1";
                    }
                    else
                    {
                        Txt_codigo.Text = row[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            Txt_codigo.Enabled = false;
            Btn_ingreso.Enabled = false;
            Btn_cancelar.Enabled = true;
            Btn_actualizar.Enabled = true;
            Btn_modificar.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_descipcion.Enabled = true;
            Rdb_habilitado.Enabled = true;
            Rdb_inhabilitado.Enabled = true;
            Gpb_estado.Enabled = true;
        }
        /* creado por Emerzon Garcia */ 
        private void btn_eli_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_codigo.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.funeliminarperfil(Txt_codigo.Text);

                    // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
                    Btn_modificar.Enabled = false;
                    Btn_actualizar.Enabled = false;
                    Btn_cancelar.Enabled = false;
                    Btn_guardar.Enabled = false;
                    Btn_ingreso.Enabled = true;
                    Txt_codigo.Enabled = false;
                    Gpb_estado.Enabled = false;  // Desactiva el grupo de radio buttons
                    limpiar();  // Limpiar campos
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            limpiar();
            Btn_modificar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_guardar.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descipcion.Enabled = false;
            Gpb_buscarperfiles.Enabled = true;
            Btn_ingreso.Enabled = true;
            Gpb_estado.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoPerfiles.chm", "AyudaMantenimientoPerfiles.html");
        }

        private void btn_bsucarperfil_Click(object sender, EventArgs e)
        {
            string sperfil = Tbx_buscarperfil.Text;

            if (string.IsNullOrWhiteSpace(sperfil))
            {
                MessageBox.Show("Por favor, ingrese un ID de una aplicacion.");
                return;
            }

            try
            {
                DataTable dtModulos = logic.funconsultarperfil(sperfil);

                if (dtModulos == null || dtModulos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraro la aplicacion.");
                    return;
                }

                foreach (DataRow row in dtModulos.Rows)
                {
                    if (row[0] != DBNull.Value) Txt_codigo.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) Txt_nombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) Txt_descipcion.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string estado = row[3].ToString();
                        if (estado == "1")
                        {
                            Rdb_habilitado.Checked = true;
                            Rdb_inhabilitado.Checked = false;
                        }
                        else if (estado == "0")
                        {
                            Rdb_habilitado.Checked = false;
                            Rdb_inhabilitado.Checked = true;
                        }
                    }
                }

                Btn_modificar.Enabled = true;
                Btn_guardar.Enabled = false;
                Txt_codigo.Enabled = false;
                Txt_nombre.Enabled = false;
                Txt_descipcion.Enabled = false;
                Rdb_habilitado.Enabled = false;
                Rdb_inhabilitado.Enabled = false;
                Btn_eliminar.Enabled = true;
                Btn_ingreso.Enabled = false;
                Btn_cancelar.Enabled = true;
                Gpb_estado.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}
