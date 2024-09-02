using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;


namespace CapaVistaReporteria
{
    public partial class Inicio : Form
    {
        CapaControladorReporteria.Controlador controlador = new CapaControladorReporteria.Controlador();
        Boolean confirmRuta = true;
        public Inicio()
        {
            InitializeComponent();
            actualizarVistaReportes();
            cargarCategorias();
            cargarEstados();
            getId();
        }

        private void actualizarVistaReportes()
        {
            DataTable data = controlador.MostrarReportes();
            tbl_regreporteria.DataSource = data;
            tbl_regreporteria.Columns[0].HeaderText = "Id";
            tbl_regreporteria.Columns[1].HeaderText = "Ruta";
            tbl_regreporteria.Columns[2].HeaderText = "Nombre";
            tbl_regreporteria.Columns[3].HeaderText = "Aplicación";
            tbl_regreporteria.Columns[4].HeaderText = "Estado";
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
                 
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "All files (*.*)|*.*";
            if (v1.ShowDialog() == DialogResult.OK)
            {
                txt_ruta.Text = v1.FileName;
                string[] separatingStrings = { "\\" };
                string text = txt_ruta.Text;
                string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string db = "";
                Boolean ruta = false;
                for (int i = 0; i < words.Length; i++)
                {
                    if (ruta)
                    {
                        if (i < words.Length - 1)
                        {
                            db += words[i] + '\\'+ '\\';
                        }
                        else
                        {
                            db += words[i];
                        }
                    }
                    if (words[i].Equals("Reportes"))
                    {
                        ruta = true;
                    }
                }
                txt_ruta.Text = db;
                confirmRuta = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string[] datosReporte = { txt_ruta.Text, txt_nombre.Text, txt_aplicacion.Text, txt_estado.Text };
            controlador.guardarReporte(datosReporte);
            actualizarVistaReportes();
            confirmRuta = true;
            getId();
        }

        private void btn_ver_reporte_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idReporte.Text))
            {
                // creamos una variable para que se le asigne lo que esta escrito en el estado del reporte
                string estado = txt_estado.Text.ToLower();

                // aqui realizamos una comprobacion de ver si el reporte esta en estado visible y el usuario lo pueda ver si no esta visible entonces le saldra un mensaje al usuario
                if (estado == "visible")
                {
                    string ruta = txt_ruta.Text;
                    visualizar ver = new visualizar(ruta);
                    ver.Show();
                }
                else
                {
                    MessageBox.Show("Reporte No_visible");
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaReportes();
            cargarCategorias();
            getId();

            btn_guardar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;

            txt_ruta.Text = "";
            txt_nombre.Text = "";
            txt_aplicacion.SelectedIndex = 0;
            txt_estado.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrar_reporte(idReporte);
            actualizarVistaReportes();
            confirmRuta = true;
            getId();
        }

        void getId()
        {
            idReporte.Text = controlador.getNextId();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la funcion de modificar y eliminar para el reporte seleccionado 
            if (tbl_regreporteria.CurrentRow.Index != -1)
            {

                btn_guardar.Enabled = false;
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;

                idReporte.Text = tbl_regreporteria.CurrentRow.Cells[0].Value.ToString();
                txt_ruta.Text = tbl_regreporteria.CurrentRow.Cells[1].Value.ToString();
                txt_nombre.Text = tbl_regreporteria.CurrentRow.Cells[2].Value.ToString();
                txt_aplicacion.Text = tbl_regreporteria.CurrentRow.Cells[3].Value.ToString();
                txt_estado.Text = tbl_regreporteria.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //aqui recibimos los nuevos datos en los diferente txtbox y se lo mandamos a la funcion ModReporteador que esta en controlador.cs
            if (confirmRuta)
            {
                txt_ruta.Text = txt_ruta.Text.Replace("\\", "\\\\");
            }
            controlador.ModReporteria(txt_ruta.Text, txt_nombre.Text, txt_aplicacion.Text,txt_estado.Text, idReporte);
            actualizarVistaReportes();
            getId();
            confirmRuta = true;
        }

        private void cargarCategorias()
        {
            List<string> limpiarTexbox = new List<string>();
            txt_aplicacion.DataSource = limpiarTexbox;
            List<string> applicationCodes = controlador.listadoAplicaciones();
            txt_aplicacion.DataSource = applicationCodes;
        }
        private void cargarEstados()
        {
            List<string> estados = new List<string>();
            estados.Add("visible");
            estados.Add("no visible");
            txt_estado.DataSource = estados;
        }

    }
}
