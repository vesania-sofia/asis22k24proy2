using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Enlace_RRHH : Form
    {
        private Capa_Controlador_Produccion.Control_RRHH controlador = new Capa_Controlador_Produccion.Control_RRHH();

        public Frm_Enlace_RRHH()
        {
            InitializeComponent();
            InicializarFormulario();
            CargarDatos();
            CargarEmpleados();

        }

        private void InicializarFormulario()
        {
            DeshabilitarCampos();
            CargarEmpleados();
            Txt_id_RRHH_prod.Text = controlador.ObtenerUltimoID().ToString();
        }

        private void CargarDatos()
        {
            DataTable dt = controlador.ObtenerTodosLosRegistros(); 
            dgv_empleados.DataSource = dt;
        }

        private void DeshabilitarCampos()
        {
            txt_salario.Enabled = true;
            txt_horas_extras.Enabled = true;
            txt_Dias.Enabled = true;
            txt_Horas.Enabled = true;
            txt_Total_Dias.Enabled = true;
            txt_Total_Horas.Enabled = true;
            txt_Total_Mano_de_Obra.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Modificar.Enabled = true; 
            btn_Eliminar.Enabled = true; 
            btn_Calcular.Enabled = false; 
        }

        private void CargarEmpleados()
        {
            DataTable empleados = controlador.ObtenerEmpleados();
            cbo_Empleado.DataSource = empleados;
            cbo_Empleado.DisplayMember = "nombre";
            cbo_Empleado.ValueMember = "pk_clave";

        }


        private void cbo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cbo_Empleado.SelectedItem != null)
            {
                // Obtener el ID del empleado seleccionado
                var empleadoSeleccionado = (dynamic)cbo_Empleado.SelectedItem;
                int empleadoID = empleadoSeleccionado.Value;

         
                txt_Dias.Enabled = true;
                txt_Horas.Enabled = true;
                btn_Calcular.Enabled = true; 
            }
            else
            {
                DeshabilitarCampos();
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();
            CargarEmpleados();

            if (cbo_Empleado.Items.Count > 0)
            {
                cbo_Empleado.SelectedIndex = 0; 
            }
        }

        private void LimpiarCampos()
        {
            txt_salario.Text = string.Empty;
            txt_horas_extras.Text = string.Empty;
            txt_Dias.Text = string.Empty;
            txt_Horas.Text = string.Empty;
            txt_Total_Dias.Text = string.Empty;
            txt_Total_Horas.Text = string.Empty;
            txt_Total_Mano_de_Obra.Text = string.Empty;
        }


        private void HabilitarCampos()
        {
            txt_Dias.Enabled = true;
            txt_Horas.Enabled = true;
            btn_Calcular.Enabled = true;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salario = decimal.Parse(txt_salario.Text);
                int dias = int.Parse(txt_Dias.Text);
                int horas = int.Parse(txt_Horas.Text);
                int horasExtras = int.Parse(txt_horas_extras.Text);

                // Cálculo de totalDias
                decimal totalDias = salario / dias;
                txt_Total_Dias.Text = totalDias.ToString("F2");

                // Cálculo de totalHoras: dividir totalDias por horas
                decimal totalHoras = totalDias / horas;
                txt_Total_Horas.Text = totalHoras.ToString("F2");

                // Cálculo de totalHorasExtras
                decimal totalHorasExtras = horasExtras * 1.5m;
                txt_Total_Horas_Extras.Text = totalHorasExtras.ToString("F2");  

                // Cálculo de totalManoObra: suma de totalHoras y totalHorasExtras
                decimal totalManoObra = totalHoras + totalHorasExtras;
                txt_Total_Mano_de_Obra.Text = totalManoObra.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message);
            }
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idRRHH = int.Parse(Txt_id_RRHH_prod.Text);
                controlador.EliminarRegistro(idRRHH);
                MessageBox.Show("Registro eliminado exitosamente.");
                CargarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }

        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idRRHH = int.Parse(Txt_id_RRHH_prod.Text);
                int empleadoID = (int)cbo_Empleado.SelectedValue;
                decimal salario = decimal.Parse(txt_salario.Text);
                int dias = int.Parse(txt_Dias.Text);
                decimal horas = decimal.Parse(txt_Horas.Text);
                decimal totalDias = decimal.Parse(txt_Total_Dias.Text);
                decimal totalHoras = decimal.Parse(txt_Total_Horas.Text);
                int horasExtras = int.Parse(txt_horas_extras.Text);
                decimal totalHorasExtras = decimal.Parse(txt_Total_Horas.Text);
                decimal totalManoObra = decimal.Parse(txt_Total_Mano_de_Obra.Text);

                controlador.ModificarRegistro(idRRHH, empleadoID, salario, dias, totalDias, horas, totalHoras, horasExtras, totalHorasExtras, totalManoObra);
                MessageBox.Show("Registro modificado exitosamente.");
                CargarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message);
            }

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int empleadoID = Convert.ToInt32(cbo_Empleado.SelectedValue);
            decimal salario = decimal.Parse(txt_salario.Text);
            int dias = int.Parse(txt_Dias.Text);
            decimal totalDias = decimal.Parse(txt_Total_Dias.Text);
            decimal horas = decimal.Parse(txt_Horas.Text);
            decimal totalHoras = decimal.Parse(txt_Total_Horas.Text);
            int horasExtra = int.Parse(txt_horas_extras.Text);
            decimal totalHorasExtras = decimal.Parse(txt_Total_Horas.Text);
            decimal totalManoObra = decimal.Parse(txt_Total_Mano_de_Obra.Text);

            controlador.GuardarRegistro(empleadoID, salario, dias, totalDias, horas, totalHoras, horasExtra, totalHorasExtras, totalManoObra);
            MessageBox.Show("Registro guardado exitosamente.");
            CargarDatos();
        }

        private void dgv_empleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedRows.Count > 0)
            {
                // Obtener datos de la fila seleccionada y cargarlos en los campos
                Txt_id_RRHH_prod.Text = dgv_empleados.SelectedRows[0].Cells["id_RRHH"].Value.ToString();
                cbo_Empleado.SelectedValue = dgv_empleados.SelectedRows[0].Cells["id_empleado"].Value;
                txt_salario.Text = dgv_empleados.SelectedRows[0].Cells["salario"].Value.ToString();
                txt_Dias.Text = dgv_empleados.SelectedRows[0].Cells["dias"].Value.ToString();
                txt_Horas.Text = dgv_empleados.SelectedRows[0].Cells["horas"].Value.ToString();
                txt_Total_Dias.Text = dgv_empleados.SelectedRows[0].Cells["total_dias"].Value.ToString();
                txt_Total_Horas.Text = dgv_empleados.SelectedRows[0].Cells["total_horas"].Value.ToString();
                txt_horas_extras.Text = dgv_empleados.SelectedRows[0].Cells["horas_extras"].Value.ToString();
                txt_Total_Mano_de_Obra.Text = dgv_empleados.SelectedRows[0].Cells["total_mano_obra"].Value.ToString();

                btn_Modificar.Enabled = true;
                btn_Eliminar.Enabled = true;
            }
        }
    }
}
