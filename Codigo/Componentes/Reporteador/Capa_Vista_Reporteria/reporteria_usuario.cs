using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_Reporteria
{
    public partial class reporteria_usuario : Form
    {
        Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();
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
            Dgv_regreporteria.DataSource = data;
            Dgv_regreporteria.Columns[0].HeaderText = "Id";
            Dgv_regreporteria.Columns[1].HeaderText = "Ruta";
            Dgv_regreporteria.Columns[2].HeaderText = "Nombre";
            Dgv_regreporteria.Columns[3].HeaderText = "Aplicación";
            Dgv_regreporteria.Columns[4].HeaderText = "Estado";
        }

        private void reporteria_usuario_Load(object sender, EventArgs e)
        {

        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la funcion de modificar y eliminar para el reporte seleccionado 
            if (Dgv_regreporteria.CurrentRow.Index != -1)
            {
                Txt_nombre.Text = Dgv_regreporteria.CurrentRow.Cells[2].Value.ToString();
                Txt_ruta.Text = Dgv_regreporteria.CurrentRow.Cells[1].Value.ToString();
                estado = Dgv_regreporteria.CurrentRow.Cells[4].Value.ToString();

                if (estado.Equals("Visible"))
                {
                    Btn_VerReporte.Enabled = true;
                }
                else
                {
                    Btn_VerReporte.Enabled = false;
                }
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //mostramos todos los reportes que hay en la base de datos segun lo introducido en el textbox y la desplegamos
            DataTable data = controlador.queryReporteria(Txt_nombre);
            Dgv_regreporteria.DataSource = data;
        }

        private void visualizar(string ruta)
        {
            System.Threading.Thread.Sleep(3000);
        }

        private async void Btn_VerReporte_Click(object sender, EventArgs e)
        {

            //si el reporte tiene estado visible entonces se ejecuta otra forma para mostrar el reporte
            if (estado.Equals("Visible"))
            {
                string ruta = Txt_ruta.Text;

                using (Cargar cargar = new Cargar())
                {
                    cargar.Show();

                    await Task.Run(() => visualizar(ruta));
                    visualizar newFormVisualizar = new visualizar(ruta);
                    newFormVisualizar.Show();

                    cargar.Close();
                }
            }
            else
            {
                MessageBox.Show("No esta habilitado el reporte");
            }
        }
    }
}
