using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Movimientos;


namespace Capa_Vista_Movimientos
{
    public partial class frm_movimiento_bancario : Form
    {
        public DataTable tiposDeCambio;
        private readonly Controlador _controlador; // Cambiar el nombre para seguir las convenciones

        public frm_movimiento_bancario(Controlador controlador)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            _controlador = controlador; // Asignar el controlador a la variable
            CargarDatos();
        }

        public void CargarDatos() // Cambiar a público para facilitar las pruebas
        {
            try
            {
                tiposDeCambio = _controlador.ObtenerMovi();
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

