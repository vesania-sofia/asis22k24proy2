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

    Forma creada por Carlos González y Salvador Martínez

 */

namespace Capa_Vista_Consulta
{
    public partial class ConsultaSimple : Form
    {
        consultaControlador csControlador = new consultaControlador();
        private string[] datos;
        private string[] tipos;
        public string BD;
        private string consultaSeleccionada;

        public ConsultaSimple(string Tabla)
        {
            InitializeComponent();
            BD = Tabla;
            tipos = new string[] { "nombre_consulta", "tipo_consulta", "consulta_SQLE", "consulta_estatus" };
            //Agregado por sebastian luna
            var tt = new ToolTip();
            tt.SetToolTip(btnCancelar2, "Cancelar");
            tt.SetToolTip(btnConsultar2, "Consultar");
        }
        string tabla = "tbl_consultaInteligente";

        private void llenarComboLogico(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Seleccionar"); comboBox1.Items.Add("OR");
            comboBox1.Items.Add("AND"); comboBox1.Items.Add("NOT"); comboBox1.SelectedIndex = 0;
        }

        private void ConsultaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            datos = new string[0];
            dgvConsultar2.DataSource = null;
            dgvConsultar2.Rows.Clear();
        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            /*consultaControlador controlador = new consultaControlador();
            string querySeleccionado = txtNombreConsulta2.Text;
            controlador.BuscarQuerySeleccionado(querySeleccionado, dgvConsultar2, txtQueryFinal2);*/
        }

        private void cboConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
