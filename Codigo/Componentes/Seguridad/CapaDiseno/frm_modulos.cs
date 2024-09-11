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
    public partial class frm_modulos : Form
    {
        logica logic;

        public frm_modulos(string idUsuario)
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
        }

        public frm_modulos()
        {
        }

        void limpiar()
        {
            tbx_buscarmodulo.Text = "";
            txtcodigo.Text = "";
            txtdesc.Text = "";
            txtnombre.Text = "";
            rbhabilitado.Checked = false;
            rbinhabilitado.Checked = false;
            txtcodigo.Focus();
        }

     

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtdesc.Enabled = false;

       
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo");
                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;

            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo");
                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;

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

                logic.ingresarmodulos(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente");
                limpiar();
                gbbuscar.Enabled = true;
                btn_nuevo.Enabled = true;
                btn_ingresar.Enabled = false;
                
            }
        }


        //María José para deshabilitar txt código
        private void Btn_cancel_Click(object sender, EventArgs e)
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
            txtcodigo.Enabled = false;

        }
        // termina María José
        private void Button1_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void Btn_modif_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            btn_cancel.Enabled = true;
            btn_actualizar.Enabled = true;
           btn_modif.Enabled = false;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            rbhabilitado.Enabled = true;
            rbinhabilitado.Enabled = true;
        btn_nuevo.Enabled = false;
            gbestado.Enabled = true;
        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        private void Btn_bsucarmodulo_Click(object sender, EventArgs e)
        {
            string modulo = tbx_buscarmodulo.Text;

            if (string.IsNullOrWhiteSpace(modulo))
            {
                MessageBox.Show("Por favor, ingrese un ID de módulo.");
                return;
            }
            //Para errores null del DataTable
            try
            {
                DataTable dtModulos = logic.ConsultaLogicaModulo(modulo);

                if (dtModulos == null || dtModulos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron módulos.");
                    return;
                }

                foreach (DataRow row in dtModulos.Rows)
                {// Asigna el valor de cada columna a su respectivo control en la interfaz si no es nulo
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
                btn_cancel.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        // termina María José
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo");

                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;


            }
            else if (txtdesc.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo");

                btn_nuevo.Enabled = true;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;

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

                logic.Actualizarmodulo(txtcodigo.Text.ToString(), txtnombre.Text.ToString(), txtdesc.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Actualizado Correctamente");
                btn_modif.Enabled = false;
                btn_actualizar.Enabled = false;
                btn_cancel.Enabled = false;
                btn_ingresar.Enabled = false;
                gbestado.Enabled = false;
                btn_nuevo.Enabled = true;
                txtcodigo.Enabled = false;
                txtnombre.Enabled = false;
                txtdesc.Enabled = false;
                limpiar();
            }
        }

        private void Frm_modulos_Load(object sender, EventArgs e)
        {

        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            gbbuscar.Enabled = false;
            btn_modif.Enabled = false;
            rbhabilitado.Checked = true;
            gbestado.Enabled = true;
            txtnombre.Enabled = true;
            txtdesc.Enabled = true;
            btn_ingresar.Enabled = true;
            btn_cancel.Enabled = true;
            //habilitando para ingresar id
            txtcodigo.Enabled = true;



            //para errores tipo null
            try
            {
                DataTable dtValidarID = logic.validarIDModulos();
                if (dtValidarID == null || dtValidarID.Rows.Count == 0)
                {
                    //txtcodigo.Text = ""; // Asigna un valor por defecto si no se encuentra ningún ID
                    return;
                }
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0] != DBNull.Value)
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
        //Termina María José

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoModulos.chm", "AyudaMantenimientoModulos.html");
        }
    }
}
