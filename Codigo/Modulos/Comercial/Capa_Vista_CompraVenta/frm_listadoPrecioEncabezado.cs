using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_ListadoPrecios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Deshabilitar los TextBox
            Txt_codigo.Enabled = false;
            Txt_fecha.Enabled = false;

            // Establecer la fecha en el TextBox al mostrar el formulario
            this.Shown += new EventHandler(Txt_fecha_TextChanged);

            Dgv_listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Nueva Lista de Precios");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(Btn_guardar, "Eliminar Lista");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_eliminar, "Buscar Lista");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(Btn_editar, "Agregar Productos a la lista");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            frm_ListadoPrecioDetalle nuevoForm = new frm_ListadoPrecioDetalle(); // Instancia del nuevo formulario
            nuevoForm.Show(); // Muestra el formulario

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_fecha_TextChanged(object sender, EventArgs e)
        {
            Txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
