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
    public partial class frmMantemientoMódulos : Form
    {
        logica logic;

        public frmMantemientoMódulos(string idUsuario)
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false; //se agrega
            logic = new logica(idUsuario);
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
            btnGuardar.Enabled = false;
            gbxEstado.Enabled = false;
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(btnNuevo, "Crear Módulo");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(btnGuardar, "Guardar Módulo");
            ToolTip tactualizar = new ToolTip();
            tactualizar.SetToolTip(btnModificar, "Actualizar Cambios");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(btnBuscar, "Buscar Módulo");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(btnModificar, "Modificar Módulo");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(btnEliminar, "Eliminar Módulo");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(btnCancelar, "Limpiar/Cancelar");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(btnSalir, "Salir Mantenimiento Módulos");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(btnAyuda, "Ayuda");
        }

        public frmMantemientoMódulos()
        {
        }

        void limpiar()
        {
            txtBuscarModulo.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            rbtnHabilitado.Checked = false;
            rbtnInhabilitado.Checked = false;
            txtCodigo.Focus();
        }


        private void Frm_modulos_Load(object sender, EventArgs e)
        {

        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            gbxBuscar.Enabled = false;
            btnModificar.Enabled = false;
            rbtnHabilitado.Checked = true;
            gbxEstado.Enabled = true;
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            //habilitando para ingresar id
            txtCodigo.Enabled = true;
            btnEliminar.Enabled = false; //se agrega


            //para errores tipo null
            try
            {
                DataTable dtValidarID = logic.funcValidarIdModulos();
                if (dtValidarID == null || dtValidarID.Rows.Count == 0)
                {
                    //txtcodigo.Text = ""; // Asigna un valor por defecto si no se encuentra ningún ID
                    return;
                }
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0] != DBNull.Value)
                    {
                        txtCodigo.Text = row[0].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }
        // FIN ####################################

        private void rbtnHabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;


            if (txtNombre.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo");
                btnNuevo.Enabled = true;
                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;

            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo");
                btnNuevo.Enabled = true;
                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;

            }

            else
            {
                string estado = "";
                if (rbtnHabilitado.Checked)
                {
                    estado = "1";
                }

                if (rbtnInhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.funcIngresarModulo(txtCodigo.Text.ToString(), txtNombre.Text.ToString(), txtDescripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente");
                limpiar();
                gbxBuscar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                txtCodigo.Enabled = false;
                btnEliminar.Enabled = false; //se agrega
            }
        }


        //Trabajado por Alyson Rodríguez, 9959-21-829
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Falta Nombre de Modulo");

                btnNuevo.Enabled = true;
                txtDescripcion.Enabled = false;
                txtNombre.Enabled = false;


            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Falta Descripcion del modulo");

                btnNuevo.Enabled = true;
                txtDescripcion.Enabled = false;
                txtNombre.Enabled = false;

            }

            else
            {
                string estado = "";
                if (rbtnHabilitado.Checked)
                {
                    estado = "1";
                }

                if (rbtnInhabilitado.Checked)
                {
                    estado = "0";
                }
                else
                {
                    estado = "1";
                }

                logic.funcActualizarModulo(txtCodigo.Text.ToString(), txtDescripcion.Text.ToString(), txtNombre.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Actualizado Correctamente");
                btnModificar.Enabled = false;
                btnActualizar.Enabled = false;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                gbxEstado.Enabled = false;
                btnNuevo.Enabled = true;
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = false;
                txtNombre.Enabled = false;
                btnEliminar.Enabled = false; //se agrega  ALyson #####################
                limpiar();
            }
        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string modulo = txtBuscarModulo.Text;

            if (string.IsNullOrWhiteSpace(modulo))
            {
                MessageBox.Show("Por favor, ingrese un ID de módulo.");
                return;
            }
            //Para errores null del DataTable
            try
            {
                DataTable dtModulos = logic.funcConsultaLogicaModulo(modulo);

                if (dtModulos == null || dtModulos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron módulos.");
                    return;
                }

                foreach (DataRow row in dtModulos.Rows)
                {// Asigna el valor de cada columna a su respectivo control en la interfaz si no es nulo
                    if (row[0] != DBNull.Value) txtCodigo.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) txtDescripcion.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) txtNombre.Text = row[2].ToString();
                    if (row[3] != DBNull.Value)
                    {
                        string estado = row[3].ToString();
                        if (estado == "1")
                        {
                            rbtnHabilitado.Checked = true;
                            rbtnInhabilitado.Checked = false;
                        }
                        else if (estado == "0")
                        {
                            rbtnHabilitado.Checked = false;
                            rbtnInhabilitado.Checked = true;
                        }
                    }
                }

                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = false;
                txtNombre.Enabled = false;
                rbtnHabilitado.Enabled = false;
                rbtnInhabilitado.Enabled = false;
                btnCancelar.Enabled = true;
                btnEliminar.Enabled = true; //se agrega

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        //Trabajado por Alyson Rodríguez, 9959-21-829
        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            btnCancelar.Enabled = true;
            btnActualizar.Enabled = true;
            btnModificar.Enabled = false;
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            rbtnHabilitado.Enabled = true;
            rbtnInhabilitado.Enabled = true;
            btnNuevo.Enabled = false;
            gbxEstado.Enabled = true;
            btnEliminar.Enabled = false; //se agrega
        }

        //Trabajado por Alyson Rodríguez, 9959-21-829
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Deshabilitar botones y campos según sea necesario
            btnNuevo.Enabled = true;
            btnActualizar.Enabled = false;
            gbxBuscar.Enabled = true;
            btnModificar.Enabled = false;
            rbtnHabilitado.Checked = false;
            gbxEstado.Enabled = false;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtCodigo.Enabled = false;
            btnEliminar.Enabled = false;

            // Validar el estado seleccionado
            string estado;
            if (rbtnHabilitado.Checked)
            {
                estado = "1"; // Habilitado
            }
            else if (rbtnInhabilitado.Checked)
            {
                estado = "0"; // Inhabilitado
            }
            else
            {
                // Asignar un valor predeterminado si ninguno está seleccionado
                estado = "0"; // O "1", dependiendo de tu lógica
            }

            // Validar que se haya ingresado el ID del módulo
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Falta ID del Módulo");
                return; // Salir del método si falta el ID
            }

            try
            {
                // Llamar al método de la lógica de negocio para realizar el borrado lógico
                logic.funcEliminarModulo(txtCodigo.Text.ToString(), txtDescripcion.Text.ToString(), txtNombre.Text.ToString(), estado);

                MessageBox.Show("Módulo eliminado correctamente.");
                limpiar(); // Limpia los campos del formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el módulo: " + ex.Message);
            }
        }
        // FIN BOTON ELIMINAR ####################################

        //María José para deshabilitar txt código
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnModificar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
            gbxBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            gbxEstado.Enabled = false;
            txtCodigo.Enabled = false;
            btnEliminar.Enabled = false; //se agrega
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoModulos.chm", "AyudaMantenimientoModulos.html");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }

}
    



