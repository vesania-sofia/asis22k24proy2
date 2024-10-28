using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Movimientos;

namespace Capa_Vista_Movimientos
{
    public partial class frm_movimiento_bancario : Form
    {
        public DataTable tiposDeCambio;
        private Controlador Capa_Controlador_Movimientos = new Controlador();

        public frm_movimiento_bancario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // Cambiar el tamaño del formulario para simular la ventana completa
            this.WindowState = FormWindowState.Maximized;
            CargarDatos();
        }

        private void frm_movimiento_bancario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                tiposDeCambio = Capa_Controlador_Movimientos.ObtenerMovi();
                Dgv_Mov.DataSource = tiposDeCambio;
                Dgv_Mov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lógica adicional si es necesaria
        }
    }
}
