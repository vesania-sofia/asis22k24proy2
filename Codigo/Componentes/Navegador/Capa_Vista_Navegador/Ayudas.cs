using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;
//using CapaDatos;

namespace Capa_Vista_Navegador
{
    public partial class Ayudas : Form
    {
        logicaNav logic = new logicaNav();  // Instancia de la lógica del navegador
        OdbcConnection conn = new OdbcConnection("Dsn=colchoneria");  // Conexión a la base de datos usando ODBC
        string[] aliasC = new string[40];  // Arreglo para almacenar alias de campos

        public Ayudas()
        {
            InitializeComponent();
            llenartabla();  // Llenar la tabla al iniciar el formulario
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 
        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtener el directorio base de la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            // Combinar el directorio base con la carpeta "Ayuda"
            string ayudaPath = Path.Combine(basePath, "Ayuda");

            OpenFileDialog rutaFile = new OpenFileDialog();
            rutaFile.InitialDirectory = ayudaPath;  // Establecer la carpeta predeterminada como Ayuda
            rutaFile.Filter = "chm files (*.chm)|*.chm";  // Filtro para seleccionar archivos .chm
            rutaFile.Title = "Seleccionar archivo de ayuda .chm";  // Título del cuadro de diálogo

            if (rutaFile.ShowDialog() == DialogResult.OK)
            {
                // Obtener solo el nombre del archivo (sin la ruta completa)
                string fileName = Path.GetFileName(rutaFile.FileName);

                // Asignar el nombre del archivo al campo de texto
                txtruta.Text = fileName;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog rutaFile = new OpenFileDialog();
            rutaFile.InitialDirectory = "c:\\";
            rutaFile.Filter = "chm files (*.html)|*.html";  // Filtro para seleccionar archivos .html
            if (rutaFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtindice.Text = rutaFile.FileName;  // Asignar la ruta seleccionada al campo de texto
            }
        }

        // Método para llenar la tabla con los registros de la tabla 'ayuda'
        void llenartabla()
        {
            OdbcCommand codigo = new OdbcCommand();
            codigo.Connection = conn;
            codigo.CommandText = ("SELECT Id_ayuda, Ruta, indice FROM ayuda WHERE estado =1");
            try
            {
                OdbcDataAdapter ejecutar = new OdbcDataAdapter();
                ejecutar.SelectCommand = codigo;
                DataTable datostabla = new DataTable();
                ejecutar.Fill(datostabla);
                dataGridView1.DataSource = datostabla;  // Llenar el DataGrid con los datos obtenidos
                ejecutar.Update(datostabla);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.ToString());  // Mostrar error en caso de que la consulta falle
                conn.Close();
            }
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 

        // Método para crear el query de INSERT para agregar un nuevo registro en 'ayuda'
        string crearInsert()
        {
            string query = "INSERT INTO ayuda (Ruta, indice, estado) VALUES  ('" + txtruta.Text.Replace("\\", "/") + "', '" + txtindice.Text + "', '1')";
            return query;
        }

        // Método para crear el query de DELETE, que marca como eliminada una ayuda cambiando su estado
        string crearDelete()
        {
            string query = "UPDATE ayuda SET estado = 0 WHERE Id_ayuda = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return query;
        }

        // Método para crear el query de UPDATE, para modificar la ruta y el índice de una ayuda
        string crearUpdate()
        {
            string query = "UPDATE ayuda SET Ruta = '" + txtruta.Text.Replace("\\", "/") + "', indice = '" + txtindice.Text + "' WHERE Id_ayuda = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return query;
        }

        // Evento del botón para agregar una nueva ayuda
        private void Button3_Click(object sender, EventArgs e)
        {
            if (txtruta.Text == "" || txtindice.Text == "")
            {
                MessageBox.Show("Por favor, llene los campos de ruta e índice");
            }
            else
            {
                logic.nuevoQuery(crearInsert());
                txtindice.Clear();
                txtruta.Clear();
                MessageBox.Show("Ayuda agregada Correctamente!");
                llenartabla();  // Actualizar la tabla
            }
        }

        // Evento al hacer clic en una celda del DataGrid para seleccionar una ayuda y mostrarla en los campos de texto
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txtruta.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtindice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro de la tabla");
            }
        }

        // Evento del botón para modificar una ayuda seleccionada
        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtruta.Text == "" || txtindice.Text == "")
            {
                MessageBox.Show("Por favor, llene ambos campos para continuar...");
            }
            else
            {
                logic.nuevoQuery(crearUpdate());
                txtindice.Clear();
                txtruta.Clear();
                MessageBox.Show("Ayuda modificada correctamente");
                llenartabla();  // Actualizar la tabla
            }
        }

        // Evento del botón para eliminar una ayuda seleccionada (cambia su estado)
        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtruta.Text == "" || txtindice.Text == "")
            {
                MessageBox.Show("Hola");
            }
            else
            {
                logic.nuevoQuery(crearDelete());
                txtindice.Clear();
                txtruta.Clear();
                MessageBox.Show("Ayuda eliminada Correctamente");
                llenartabla();  // Actualizar la tabla
            }
        }

        private void Ayudas_Load(object sender, EventArgs e)
        {
            // Evento que ocurre cuando se carga el formulario, sin implementación
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Evento que ocurre cuando se hace clic en el label, sin implementación
        }

        // Método que permite seleccionar un archivo HTML desde un diálogo
        private void Button2_Click_1(object sender, EventArgs e)
        {
            // Obtener el directorio base de la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Combinar la ruta base con la carpeta "HTML"
            string htmlDirectory = Path.Combine(basePath, @"..\..\..\HTML");

            OpenFileDialog rutaFile = new OpenFileDialog();
            rutaFile.InitialDirectory = Path.GetFullPath(htmlDirectory);  // Establecer el directorio inicial como la carpeta "HTML"
            rutaFile.Filter = "HTML files (*.html)|*.html";  // Filtro para solo mostrar archivos .html
            if (rutaFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Obtener solo el nombre del archivo (sin la ruta completa)
                string fileName = Path.GetFileName(rutaFile.FileName);

                // Asignar el nombre del archivo al campo de texto
                txtindice.Text = fileName;
            }
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
    }
}
