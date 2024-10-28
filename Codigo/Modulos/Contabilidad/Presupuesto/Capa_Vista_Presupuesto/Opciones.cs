using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Presupuesto;

namespace Capa_Vista_Presupuesto
{
    public partial class Opciones : Form
    {
        Controlador control = new Controlador();
        ToolTip toolTip = new ToolTip();
        public Opciones()
        {
            InitializeComponent();
            toolTip.SetToolTip(Btn_crear, "Haz clic para crear un presupuesto");
            toolTip.SetToolTip(Btn_Modificar, "Haz clic para modificar un presupuesto");
            toolTip.SetToolTip(Btn_ver, "Haz clic para ver un presupuesto");

        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtbx_nombre.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para el presupuesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detenemos la ejecución si el campo está vacío
            }

            if (cb_ejercicio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un ejercicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cb_LlenadoCrear.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una opción de llenado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (Chb_plantilla.Checked)
            {
                if (Cb_Base.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona una opción de prellenado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }
            //int iIdPresupuesto;
            //string sOperacion;
            try
            {
                int iIdPresupuesto;
                string sOperacion;
                if (Chb_plantilla.Checked)
                {
                    iIdPresupuesto = control.CrearPresupuesto(Txtbx_nombre.Text, Convert.ToInt32(cb_ejercicio.Text));
                    MessageBox.Show("Id Creado: " + Convert.ToString(iIdPresupuesto));
                    sOperacion = "crearPlantilla";
                    AbrirFormularioPresupuestoLlenado(sOperacion,iIdPresupuesto,PresupuestoLlenado(Cb_Base));
                }
                else
                {
                    iIdPresupuesto = control.CrearPresupuesto(Txtbx_nombre.Text, Convert.ToInt32(cb_ejercicio.Text));
                    MessageBox.Show("Id Creado: " + Convert.ToString(iIdPresupuesto));
                    sOperacion = "crear";
                    AbrirFormularioPresupuestoCREAR(sOperacion, iIdPresupuesto);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirFormularioPresupuestoCREAR(string sOperacion, int iIdPresupuesto)
        {
            this.Hide();
            Presupuesto formularioPresupuesto = new Presupuesto(sOperacion, iIdPresupuesto, Txtbx_nombre.Text, Cb_LlenadoCrear.Text);
            formularioPresupuesto.Show();
        }
        private void AbrirFormularioPresupuesto(string sOperacion, int iIdPresupuesto)
        {
            this.Hide();
            Presupuesto formularioPresupuesto = new Presupuesto(sOperacion, iIdPresupuesto, Txtbx_nombre.Text, Cb_LlenadoMod.Text);
            formularioPresupuesto.Show();
        }

        private void AbrirFormularioPresupuestoLlenado(string sOperacion, int iIdPresupuesto,int iIdPrepLlenado)
        {
            this.Hide();
            Presupuesto formularioPresupuesto = new Presupuesto(sOperacion, iIdPresupuesto, Txtbx_nombre.Text, Cb_LlenadoCrear.Text);

            formularioPresupuesto.idPrepLlenado = iIdPrepLlenado;
            formularioPresupuesto.Show();
        }

        private int PresupuestoLlenado(ComboBox cbCombo)
        {
            if (cbCombo.SelectedItem != null)
            {
                // Obtener el ID del presupuesto seleccionado
                var vItemSeleccionado = (KeyValuePair<string, string>)cbCombo.SelectedItem;
     
                string sIdPresupuesto = vItemSeleccionado.Key;
                MessageBox.Show("Codigo: " + sIdPresupuesto); //Bandera
                return int.Parse(sIdPresupuesto);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un presupuesto.");
                return 0;
            }
        }

        private void PasoForm(ComboBox cbCombo,string sAccion)
        {

            if (cbCombo.SelectedItem != null)
            {
                // Obtener el ID del presupuesto seleccionado
                var vItemSeleccionado = (KeyValuePair<string, string>)cbCombo.SelectedItem;
                string sNombrePresupuesto = vItemSeleccionado.Value;
                string sIdPresupuesto = vItemSeleccionado.Key;
                MessageBox.Show("Codigo: " + sIdPresupuesto+" "+sAccion); //Bandera
                // Abrir el siguiente formulario y enviar el ID
                Presupuesto formDestino = new Presupuesto(sAccion, int.Parse(sIdPresupuesto),sNombrePresupuesto, Cb_LlenadoMod.Text);
                formDestino.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un presupuesto.");
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Cb_LlenadoMod.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una opción de llenado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Cb_modificar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un presupuesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                PasoForm(Cb_modificar, "modificar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            Cb_Base.Enabled = false;
            control.CargarPresupuestos(Cb_modificar);
            control.CargarPresupuestos(Cb_Ver);
            control.CargarPresupuestos(Cb_Base);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cb_Ver.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un presupuesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                PasoForm(Cb_Ver, "ver");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Chb_plantilla_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_plantilla.Checked == true)
            {
                Cb_Base.Enabled = true;
            }else if (Chb_plantilla.Checked == false)
            { 
                Cb_Base.Enabled = false; 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
