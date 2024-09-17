using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Consulta;
using System.Data.Odbc;

/*

    Forma creada por Carlos González 

 */

namespace Capa_Vista_Consulta
{
    public partial class ConsultaSimple : Form
    {
        consultaControlador csControlador = new consultaControlador();
        private string[] datos;
        private string[] tipos;
        public string BD;
        public ConsultaSimple(string Tabla)
        {
            InitializeComponent();
            BD = Tabla;
            tipos = new string[] { "nombre_consulta", "tipo_consulta", "consulta_SQLE", "consulta_estatus" };
            csControlador.CargarTablas(cboTabla2, BD);
            cboTabla2.SelectedIndexChanged += new EventHandler(cboTabla_SelectedIndexChanged);
            ActualizarComboBox();
        }
        private void ActualizarComboBox()
        {
            csControlador.CargarTablas(cboTabla2, BD);
        }
        string tabla = "tbl_consultaInteligente";
        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una tabla
            if (!string.IsNullOrEmpty(cboTabla2.Text))
            {
                // Llama al método para llenar el segundo ComboBox con las columnas de la tabla seleccionada
                csControlador.obtenerColumbasPorTabla(cboCampos2, cboTabla2.Text);
            }
        }
        private void ConsultaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            //boton agregar, consulta simple
            datos = new string[] { txtNombreConsulta2.Text, "0", cboTabla2.Text, chbTodosCampos2.Text, txtQueryFinal2.Text, "1" };
            string camposSeleccionados;// Inicializamos la variable para los campos que se mostrarán en el query
            if (chbTodosCampos2.Checked)// Verificamos si el CheckBox de 'Todos los campos' está marcado
            {
                camposSeleccionados = "*";// Si está marcado, mostramos "Todos los campos"
            }
            else
            {
                // Si no está marcado, verificamos si hay un campo seleccionado en el ComboBox
                if (!string.IsNullOrEmpty(cboCampos2.Text))
                {
                    // Si hay un campo seleccionado, lo mostramos
                    camposSeleccionados = cboCampos2.Text;
                }
                else
                {
                    // Si no hay campo seleccionado, dejamos un valor vacío o un mensaje de advertencia
                    MessageBox.Show("Debe seleccionar o un campo o todos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtQuery2.Text))
            {
                // Si txtQuery está vacío, asignamos el valor inicial
                txtQuery2.Text = camposSeleccionados + " + " + txtAlias2.Text + " + ";
                datos[4] = txtQuery2.Text;
            }
            else
            {
                // Si txtQuery ya tiene texto, agregamos el nuevo valor sin repetir el nombre de la consulta y el tipo
                txtQuery2.Text += Environment.NewLine + camposSeleccionados + " + " + txtAlias2.Text + " + ";
                datos[4] += txtQuery2.Text;
            }
            // Procesar los datos en la tabla correspondiente
            csControlador.ingresar(tipos, datos, tabla);
        }

        private void btnAgregarConsultaSimple2_Click(object sender, EventArgs e)
        {
            string queryGenerado = csControlador.GenerarQuerySimple(datos);
            txtQueryFinal2.Text = queryGenerado;
        }

        private void btnCancelarSimple2_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            txtNombreConsulta2.Clear();
            cboTabla2.ResetText();
            cboCampos2.ResetText();
            txtAlias2.Clear();
            chbTodosCampos2.Checked = false;
            txtQuery2.Clear();
        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {
            csControlador.InsertarDatos(tipos, datos, tabla);
            ActualizarComboBox();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            txtNombreConsulta2.Clear();
            cboTabla2.ResetText();
            cboCampos2.ResetText();
            txtAlias2.Clear();
            chbTodosCampos2.Checked = false;
            txtQuery2.Clear();
            txtQueryFinal2.Clear();
            dgvConsultar2.DataSource = null;
            dgvConsultar2.Rows.Clear();
        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            consultaControlador controlador = new consultaControlador();
            string querySeleccionado = txtNombreConsulta2.Text;
            controlador.BuscarQuerySeleccionado(querySeleccionado, dgvConsultar2, txtQueryFinal2);
        }
    }
}
