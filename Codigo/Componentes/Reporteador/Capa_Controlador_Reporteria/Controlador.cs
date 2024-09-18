using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Reporteria
{
    public class Controlador
    {
        Capa_Modelo_Reporteria.Sentencias sentencias = new Capa_Modelo_Reporteria.Sentencias();

        public DataTable MostrarReportes()
        {
            OdbcDataAdapter data = sentencias.DisplayReportes();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public int guardarReporte(TextBox idReporte, string ruta, string nombre_archivo, string aplicacion, string estado, string modulo)
        {
            //se valida que el textbox no este vacio o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text) || string.IsNullOrEmpty(ruta) || string.IsNullOrEmpty(nombre_archivo) ||
                string.IsNullOrEmpty(aplicacion) || string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(modulo))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarReporte(idReporte.Text, ruta, nombre_archivo, aplicacion, estado, modulo);
                return 1;
            }
        }

        public int borrar_reporte(TextBox idReporte)
        {
            //se valida que el textbox no este vacio o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar el reporte #" + idReporte.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarReporte(idReporte.Text);
                    return 1;
                }
            }
        }

        public int ModReporteria(string ruta, string nombre_archivo, string aplicacion, string estado, TextBox idReporte, string modulo)
        {
            //se valida que el textbox no este vacio o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text) || string.IsNullOrEmpty(ruta) || string.IsNullOrEmpty(nombre_archivo) ||
                string.IsNullOrEmpty(aplicacion) || string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(modulo))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere barrar el reporte
                DialogResult result = MessageBox.Show("¿Desea Modificar el reporte #" + idReporte.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se modifico el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    //aqui con los datos que recibimos de la capavista a hora la mandamos a la funicon ModificarReporte en sentencias.cs
                    sentencias.ModificarReporte(ruta, nombre_archivo, aplicacion, estado, idReporte.Text, modulo);
                    return 1;
                }
            }
        }

        public DataTable queryReporteria(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryReportes(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public string queryRuta(string aplicacion)
        {
            string ruta;
            if (string.IsNullOrEmpty(aplicacion))
            {
                MessageBox.Show("No existe una aplicación valida");
                return "0";
            }
            else
            {
                ruta = sentencias.queryRutastring(aplicacion);
                if (ruta != "")
                {
                    return ruta;
                }
                else
                {
                    return "0";
                }
            }
        }

        public List<string> listadoAplicaciones()
        {
            List<string> applicationCodes = sentencias.getAplicaciones();
            return applicationCodes;
        }

        public List<string> listadoModulos()
        {
            List<string> moduleCodes = sentencias.getModulos();
            return moduleCodes;
        }

        public String getNextId()
        {
            int nextId = sentencias.getMaxIdReport();
            nextId = nextId + 1;
            return nextId.ToString();
        }
    }
}
