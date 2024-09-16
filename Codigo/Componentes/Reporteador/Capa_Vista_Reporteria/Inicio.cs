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


namespace Capa_Vista_Reporteria
{
    public partial class Inicio : Form
    {
        Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();
        Boolean confirmRuta = true;
        public Inicio()
        {
            InitializeComponent();
            actualizarVistaReportes();
            cargarCategorias();
            getId();
        }

        private void actualizarVistaReportes()
        {
            DataTable data = controlador.MostrarReportes();
            Dgv_Regreporteria.DataSource = data;
            Dgv_Regreporteria.Columns[0].HeaderText = "Id";
            Dgv_Regreporteria.Columns[1].HeaderText = "Ruta";
            Dgv_Regreporteria.Columns[2].HeaderText = "Nombre";
            Dgv_Regreporteria.Columns[3].HeaderText = "Aplicación";
            Dgv_Regreporteria.Columns[4].HeaderText = "Estado";
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        void getId()
        {
            Txt_IDReporte.Text = controlador.getNextId();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la funcion de modificar y eliminar para el reporte seleccionado 
            if (Dgv_Regreporteria.CurrentRow.Index != -1)
            {

                Btn_Guardar.Enabled = false;
                Btn_Modificar.Enabled = true;
                Btn_Eliminar.Enabled = true;

                Txt_IDReporte.Text = Dgv_Regreporteria.CurrentRow.Cells[0].Value.ToString();
                Txt_Ruta.Text = Dgv_Regreporteria.CurrentRow.Cells[1].Value.ToString();
                Txt_NombreA.Text = Dgv_Regreporteria.CurrentRow.Cells[2].Value.ToString();
                Cbo_Aplicacion.Text = Dgv_Regreporteria.CurrentRow.Cells[3].Value.ToString();
                Cbo_Estado.Text = Dgv_Regreporteria.CurrentRow.Cells[4].Value.ToString();
            }
        }


        private void cargarCategorias()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_Aplicacion.DataSource = limpiarTexbox;
            List<string> applicationCodes = controlador.listadoAplicaciones();
            Cbo_Aplicacion.DataSource = applicationCodes;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarReporte(Txt_IDReporte, Txt_Ruta.Text, Txt_NombreA.Text, Cbo_Aplicacion.Text, Cbo_Estado.Text);
            actualizarVistaReportes();
            confirmRuta = true;
            getId();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            //aqui recibimos los nuevos datos en los diferente txtbox y se lo mandamos a la funcion ModReporteador que esta en controlador.cs
            if (confirmRuta)
            {
                Txt_Ruta.Text = Txt_Ruta.Text.Replace("\\", "\\\\");
            }
            controlador.ModReporteria(Txt_Ruta.Text, Txt_NombreA.Text, Cbo_Aplicacion.Text, Cbo_Estado.Text, Txt_IDReporte);
            actualizarVistaReportes();
            getId();
            confirmRuta = true;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrar_reporte(Txt_IDReporte);
            actualizarVistaReportes();
            confirmRuta = true;
            getId();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaReportes();
            cargarCategorias();
            getId();

            Btn_Guardar.Enabled = true;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

            Txt_Ruta.Text = "";
            Txt_NombreA.Text = "";
            Cbo_Aplicacion.SelectedIndex = 0;
            Cbo_Estado.SelectedIndex = 0;
        }
        private void visualizar(string ruta)
        {
            System.Threading.Thread.Sleep(3000);
        }

        private async void Btn_VerReporte_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_IDReporte.Text))
            {
                // creamos una variable para que se le asigne lo que esta escrito en el estado del reporte
                string estado = Convert.ToString(Cbo_Estado.Text);

                // aqui realizamos una comprobacion de ver si el reporte esta en estado visible y el usuario lo pueda ver si no esta visible entonces le saldra un mensaje al usuario
                if (estado == "Visible")
                {
                    string ruta = Txt_Ruta.Text;

                    using (Cargar cargar = new Cargar())
                    {
                        cargar.Show();

                        await Task.Run(() => visualizar(ruta));
                        visualizar ver = new visualizar(ruta);
                        ver.Show();

                        cargar.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Reporte No_visible");
                }
            }
        }

        private void Btn_Examinar_Click(object sender, EventArgs e)
        {

            OpenFileDialog Ofd_Reporte = new OpenFileDialog();
            Ofd_Reporte.Filter = "All files (*.*)|*.*";
            if (Ofd_Reporte.ShowDialog() == DialogResult.OK)
            {
                Txt_Ruta.Text = Ofd_Reporte.FileName;
                string[] separatingStrings = { "\\" };
                string text = Txt_Ruta.Text;
                string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string db = "";
                Boolean ruta = false;
                for (int i = 0; i < words.Length; i++)
                {
                    if (ruta)
                    {
                        if (i < words.Length - 1)
                        {
                            db += words[i] + '\\' + '\\';
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
                Txt_Ruta.Text = db;
                confirmRuta = false;
            }
        }
    }
}
