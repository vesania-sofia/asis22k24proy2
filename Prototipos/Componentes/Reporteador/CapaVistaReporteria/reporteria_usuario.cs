using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVistaReporteria
{
    public partial class reporteria_usuario : Form
    {
        CapaControladorReporteria.Controlador controlador = new CapaControladorReporteria.Controlador();
        String estado = "";

        public reporteria_usuario()
        {
            InitializeComponent();
            actualizarVistaReportes();
        }

        private void actualizarVistaReportes()
        {
            //mostramos todos los reportes que hay en la base de datos y la desplegamos
            DataTable data = controlador.MostrarReportes();
            tbl_regreporteria.DataSource = data;
            tbl_regreporteria.Columns[0].HeaderText = "Id";
            tbl_regreporteria.Columns[1].HeaderText = "Ruta";
            tbl_regreporteria.Columns[2].HeaderText = "Nombre";
            tbl_regreporteria.Columns[3].HeaderText = "Aplicación";
            tbl_regreporteria.Columns[4].HeaderText = "Estado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mostramos todos los reportes que hay en la base de datos segun lo introducido en el textbox y la desplegamos
            DataTable data = controlador.queryReporteria(txt_nombre);
            tbl_regreporteria.DataSource = data;
        }

        private void reporteria_usuario_Load(object sender, EventArgs e)
        {

        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la funcion de modificar y eliminar para el reporte seleccionado 
            if (tbl_regreporteria.CurrentRow.Index != -1)
            {
                txt_nombre.Text = tbl_regreporteria.CurrentRow.Cells[2].Value.ToString();
                txt_ruta.Text = tbl_regreporteria.CurrentRow.Cells[1].Value.ToString();
                estado = tbl_regreporteria.CurrentRow.Cells[4].Value.ToString().ToLower();

                if (estado.Equals("visible"))
                {
                    btn_VerReporte.Enabled = true;
                }
                else
                {
                    btn_VerReporte.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //si el reporte tiene estado visible entonces se ejecuta otra forma para mostrar el reporte
            if (estado.Equals("visible"))
            {
                string ruta = txt_ruta.Text;
                visualizar newFormVisualizar = new visualizar(ruta);
                newFormVisualizar.Show();
            }
            else
            {
                MessageBox.Show("No esta habilitado el reporte");
            }
        }
    }
}
