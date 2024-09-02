using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorReporteria
{
    public class Controlador
    {

        CapaModeloReporteria.Sentencias sentencias = new CapaModeloReporteria.Sentencias();

        public DataTable MostrarReportes()
        {
            OdbcDataAdapter data = sentencias.DisplayReportes();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public int guardarReporte(String[] datosReporte)
        {
            string campos = "";
            //validamos si existen campos vacios
            for (int i = 0; i <= datosReporte.Length-1; i++)
            {
                if (datosReporte[i].Length < 1)
                {
                    MessageBox.Show("Existen campos que no pueden esatar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            //luego craemos una variable plana con todos los datos del arreglo para agregarlo al sql de guardar reporte
            for (int i = 0; i <= datosReporte.Length - 2; i++)
            {
                campos = campos +"'" +datosReporte[i] + "',";
            }
            campos = campos + "'"+datosReporte[datosReporte.Length-1]+"'";
            sentencias.registrarReporte(campos);
            return 1;
        }

        public int borrar_reporte(TextBox idReporte)
        {
            //se valida que el textbox no este vacio o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //luego rectificamos que el usuario quiere barrar el reporte
            DialogResult result = MessageBox.Show("¿Desea eliminar el reporte #"+idReporte.Text+"?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sentencias.eliminarReporte(idReporte.Text);
            return 1;
        }
        public int ModReporteria(string ruta, string nombre_archivo, string aplicacion, string estado, TextBox idReporte)
        {
            //se valida que el textbox no este vacio o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text) || string.IsNullOrEmpty(ruta) || string.IsNullOrEmpty(nombre_archivo) ||
                string.IsNullOrEmpty(aplicacion) || string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //luego rectificamos que el usuario quiere barrar el reporte
            DialogResult result = MessageBox.Show("¿Desea Modificar el reporte #" + idReporte.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se modifico el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            //aqui con los datos que recibimos de la capavista a hora la mandamos a la funicon ModificarReporte en sentencias.cs
            sentencias.ModificarReporte(ruta, nombre_archivo, aplicacion, estado, idReporte.Text);
            return 1;
        }

        public DataTable queryReporteria(TextBox query)
        {
                OdbcDataAdapter data2 = sentencias.queryReportes(query.Text);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                return tabla2;
        }

        public List<string> listadoAplicaciones()
        {
            List<string> applicationCodes = sentencias.getAplicaciones();
            return applicationCodes;
        }

        public String getNextId()
        {
            int nextId = sentencias.getMaxIdReport();
            nextId = nextId + 1;
            return nextId.ToString();
        }
    }
}
