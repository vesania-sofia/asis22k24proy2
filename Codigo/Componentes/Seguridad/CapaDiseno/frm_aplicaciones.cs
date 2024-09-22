﻿using System;
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
            Btn_cancelar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_eliminar.Enabled = false;
            logic = new logica(idUsuario);
            Txt_idaplicacion.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_nuevo, "Crear aplicación");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_ingresar, "Guardar aplicación");
            ToolTip tactualizar = new ToolTip();
            tactualizar.SetToolTip(Btn_modificar, "Actualizar Cambios");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_bsucar, "Buscar aplicación");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(Btn_modificar, "Modificar aplicación");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(Btn_eliminar, "Eliminar aplicación");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Cancelar Cambios");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir Mantenimiento de aplicaciones");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
        }
     
        public frm_aplicaciones()
        {
        }


        void prolimpiar()
        {
            Txt_idaplicacion.Text = "";
            Txt_nombre.Text = "";
            Txt_descripcion.Text = "";
            Txt_buscar.Text = "";
            Rdb_activo.Checked = false;
            Rdb_inactivo.Checked = false;
            Txt_idaplicacion.Focus();
        }



        private void Frm_aplicaciones_Load(object sender, EventArgs e)
        {

        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            prolimpiar();
        }


        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "MantenimientoAplicaciones.chm", "Mantenimiento_Aplicaciones.html");
        }

        private void Btn_bsucar_Click(object sender, EventArgs e)
        {
            string aplicacion = Txt_buscar.Text;

            if (string.IsNullOrWhiteSpace(aplicacion))
            {
                MessageBox.Show("Por favor, ingrese un ID de una aplicacion.");
                return;
            }

            try
            {
                DataTable dtAplicacion = logic.funconsultaLogicaAplicaciones(aplicacion);

                if (dtAplicacion == null || dtAplicacion.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraro la aplicacion.");
                    return;
                }

                foreach (DataRow row in dtAplicacion.Rows)
                {
                    if (row[0] != DBNull.Value) Txt_idaplicacion.Text = row[0].ToString();
                    if (row[1] != DBNull.Value) Txt_nombre.Text = row[1].ToString();
                    if (row[2] != DBNull.Value) Txt_descripcion.Text = row[2].ToString();
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

                Btn_modificar.Enabled = true;
                Btn_cancelar.Enabled = true;
                Btn_ingresar.Enabled = false;
                Txt_idaplicacion.Enabled = false;
                Btn_nuevo.Enabled = false;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
                Rdb_activo.Enabled = false;
                Rdb_inactivo.Enabled = false;
                Btn_eliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Rdb_activo.Checked = true;
            Gpb_estado.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Txt_idaplicacion.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_descripcion.Enabled = true;
            Btn_nuevo.Enabled = false;
            Btn_actualizar.Enabled = false;
            Gpb_buscar.Enabled = false;
            Btn_modificar.Enabled = false;
            



            try
            {
                DataTable dtValidarID = logic.funvalidarIDAplicacion();
                if (dtValidarID == null || dtValidarID.Rows.Count == 0)
                {

                    return;
                }
                foreach (DataRow row in dtValidarID.Rows)
                {
                    if (row[0] != DBNull.Value)
                    {
                        Txt_idaplicacion.Text = row[0].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;

            if (Txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
            }
            else if (Txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
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

                logic.funinsertaraplicaciones(Txt_idaplicacion.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descripcion.Text.ToString(), estado.ToString());
                MessageBox.Show("Modulo Ingresado Correctamente");
                prolimpiar();
                Gpb_buscar.Enabled = true;
                Btn_ingresar.Enabled = false;
                Btn_nuevo.Enabled = true;
                Txt_idaplicacion.Enabled = false;
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            Rdb_activo.Checked = true;
            Gpb_estado.Enabled = true;
            Btn_nuevo.Enabled = false;
            Btn_actualizar.Enabled = true;
            Gpb_buscar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_cancelar.Enabled = true;
            Txt_idaplicacion.Enabled = false;
            Txt_nombre.Enabled = true;
            Txt_descripcion.Enabled = true;
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Txt_nombre.Text == "")
            {

                MessageBox.Show("Falta Nombre de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
            }
            else if (Txt_descripcion.Text == "")
            {
                MessageBox.Show("Falta Descripcion de Aplicacion");
                Btn_nuevo.Enabled = true;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
            }

            else
            {
                string sestado = "";
                if (Rdb_activo.Checked)
                {
                    sestado = "1";
                }

                if (Rdb_inactivo.Checked)
                {
                    sestado = "0";
                }
                else
                {
                    sestado = "1";
                }

                logic.funactualizaraplicaciones(Txt_idaplicacion.Text.ToString(), Txt_nombre.Text.ToString(), Txt_descripcion.Text.ToString(), sestado.ToString());
                MessageBox.Show("Modulo Modificado Correctamente");
                prolimpiar();
                Btn_cancelar.Enabled = false;
                Btn_bsucar.Enabled = true;
                Btn_nuevo.Enabled = true;
                Btn_ingresar.Enabled = false;
                Btn_actualizar.Enabled = false;
                Btn_modificar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Txt_idaplicacion.Enabled = false;
                Txt_nombre.Enabled = false;
                Txt_descripcion.Enabled = false;
                Gpb_estado.Enabled = false;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_idaplicacion.Text))
            {
                // Confirmar antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este perfil?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la capa lógica para eliminar el perfil
                    logic.funeliminaraplicaciones(Txt_idaplicacion.Text);

                    // Opcionalmente, puedes desactivar botones o limpiar campos después de la eliminación
                    Txt_buscar.Enabled = true;
                    Btn_bsucar.Enabled = false;
                    Btn_modificar.Enabled = false;
                    Btn_nuevo.Enabled = true;
                    Txt_idaplicacion.Enabled = false;
                    Txt_descripcion.Enabled = false;
                    Gpb_estado.Enabled = false;
                    prolimpiar();  // Limpiar campos
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un perfil para eliminar.");
            }
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            prolimpiar();
            Btn_nuevo.Enabled = true;
            Gpb_buscar.Enabled = true;
            Btn_bsucar.Enabled = true;
            Btn_cancelar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_actualizar.Enabled = false;
            Btn_modificar.Enabled = false;
            Txt_idaplicacion.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_descripcion.Enabled = false;
            Gpb_estado.Enabled = false;
        }
    }
}

//###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################