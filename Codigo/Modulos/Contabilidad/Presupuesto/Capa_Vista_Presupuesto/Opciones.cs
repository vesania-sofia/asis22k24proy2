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
using Capa_Controlador_Seguridad;
using System.IO;//Para Ayudas

namespace Capa_Vista_Presupuesto
{
    public partial class Opciones : Form
    {
        Controlador control = new Controlador();
        ToolTip toolTip = new ToolTip();
        logica logicaSeg = new logica();
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        public string sIdUsuario { get; set; } //Para Bitacora-------------!!!
        public string sOperacion;
        public int iIdPresupuesto;
        public string sNombre;
        public string sLlenado;
        public int sPrellenado;
        public int iEjercicio;

        public Opciones()
        {
            InitializeComponent();
            toolTip.SetToolTip(Btn_crear, "Haz clic para crear un presupuesto");
            toolTip.SetToolTip(Btn_Modificar, "Haz clic para modificar un presupuesto");
            toolTip.SetToolTip(Btn_ver, "Haz clic para ver un presupuesto");
            toolTip.SetToolTip(Btn_ayuda, "Haz clic para ver ayuda");
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            Cb_Base.Enabled = false;
            control.CargarPresupuestosActivos(Cb_modificar);
            control.CargarPresupuestosGeneral(Cb_Ver);
            control.CargarPresupuestosGeneral(Cb_Base);
            LlenarComboBoxAnios(Cb_ejercicio);
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtbx_nombre.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para el presupuesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detenemos la ejecución si el campo está vacío
            }

            if (Cb_ejercicio.SelectedIndex == -1)
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
            if (!control.PuedeCrearPresupuesto())
            {
                MessageBox.Show("No puedes crear un presupuesto porque no hay cuentas disponibles.", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (Chb_plantilla.Checked)
                {
                    iIdPresupuesto = control.CrearPresupuesto(Txtbx_nombre.Text, Convert.ToInt32(Cb_ejercicio.Text));
                    //MessageBox.Show("Id Creado: " + Convert.ToString(iIdPresupuesto));----Bandera
                    sOperacion = "crearPlantilla";
                    AbrirFormularioPresupuestoLlenado(sOperacion,iIdPresupuesto,PresupuestoLlenado(Cb_Base));
                }
                else
                {
                    iIdPresupuesto = control.CrearPresupuesto(Txtbx_nombre.Text, Convert.ToInt32(Cb_ejercicio.Text));
                    //MessageBox.Show("Id Creado: " + Convert.ToString(iIdPresupuesto));---Bandera
                    sOperacion = "crear";
                    AbrirFormularioPresupuestoCREAR(sOperacion, iIdPresupuesto);
                    
                }
                logicaSeg.funinsertarabitacora(sIdUsuario, $"Se creo presupuesto {iIdPresupuesto}", "Opciones", "8000");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirFormularioPresupuestoCREAR(string sOperacionF, int iIdPresupuestoF)
        {
            sOperacion = sOperacionF;
            iIdPresupuesto = iIdPresupuestoF;
            sNombre = Txtbx_nombre.Text;
            sLlenado = Cb_LlenadoCrear.Text;
            iEjercicio = control.ObtenerEjercicioPresupuesto(iIdPresupuestoF);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void AbrirFormularioPresupuestoLlenado(string sOperacionF, int iIdPresupuestoF,int iIdPrepLlenado)
        {
            sOperacion = sOperacionF;
            iIdPresupuesto = iIdPresupuestoF;
            sNombre = Txtbx_nombre.Text;
            sLlenado = Cb_LlenadoCrear.Text;
            sPrellenado = iIdPrepLlenado;
            iEjercicio = control.ObtenerEjercicioPresupuesto(iIdPresupuestoF);
            this.DialogResult = DialogResult.OK;
            this.Hide();
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

                sNombre = sNombrePresupuesto;
                iIdPresupuesto = int.Parse(sIdPresupuesto);
                sOperacion = sAccion;
                sLlenado = Cb_LlenadoMod.Text;
                iEjercicio = control.ObtenerEjercicioPresupuesto(int.Parse(sIdPresupuesto)); //Se Agrego
                //MessageBox.Show("Codigo: " + sIdPresupuesto + " " + sAccion); //Bandera
                this.DialogResult = DialogResult.OK;
                logicaSeg.funinsertarabitacora(sIdUsuario, $"Se Modificara/Vera presupuesto {iIdPresupuesto}", "Opciones", "8000");//Bitacora ====!!!
                this.Hide();            }
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

        private void LlenarComboBoxAnios(ComboBox cbCombo)
        {
            // Limpiar el ComboBox antes de llenarlo
            cbCombo.Items.Clear();

            // Obtener el año actual
            int iAnioActual = DateTime.Now.Year;

            // Llenar el ComboBox con años desde el año actual hasta +5 años
            for (int i = 0; i <= 5; i++)
            {
                cbCombo.Items.Add(iAnioActual + i);
            }

            // Opcional: seleccionar el primer elemento
            if (cbCombo.Items.Count > 0)
            {
                cbCombo.SelectedIndex = 0;
            }
        }

        private void Txt_ejercicio_Click(object sender, EventArgs e)
        {

        }

        private void Cb_ejercicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_trabajar_Click(object sender, EventArgs e)
        {

        }

        private void Cb_LlenadoCrear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_verPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Contabilidad", "AyudaPresupuesto", "AyudaModPresupuesto.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Help.ShowHelp(this, sAyudaPath, "AyudaOpciones.html");

                //Bitacora--------------!!!
                logicaSeg.funinsertarabitacora(sIdUsuario, $"Se presiono Ayuda", "Opciones", "8000");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }
    }
}
