using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Para OdbcDataReader
using Capa_Modelo_Logistica; // Para Sentencias
using System.Windows.Forms;
using System.Data;

namespace Capa_Controlador_Logistica
{
    public class Controlador
    {
        //Metodo de ingreso de datos de chofer realizado por Ammy Catun 0901-21-4857
        private Capa_Modelo_Logistica.Sentencias sentencias = new Capa_Modelo_Logistica.Sentencias();
        public int guardarChofer(TextBox idChofer, string sNombreEmp, string sNumeroIdent, string sNombre, string sLicencia, string sTelefono, string sDireccion)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idChofer.Text) || string.IsNullOrEmpty(sNombreEmp) || string.IsNullOrEmpty(sNumeroIdent) ||
                string.IsNullOrEmpty(sNombre) || string.IsNullOrEmpty(sLicencia) || string.IsNullOrEmpty(sTelefono) || string.IsNullOrEmpty(sDireccion))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarChofer(idChofer.Text, sNombreEmp, sNumeroIdent, sNombre, sLicencia, sTelefono, sDireccion);
                return 1;
            }
        }

        public DataTable cargarChoferes()
        {
            return sentencias.cargarChoferes();
        }

        public string getNextId()
        {
            int nextId = sentencias.getMaxIdChofer();
            nextId = nextId + 1;
            return nextId.ToString();
        }
        //metodo de eliminar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public void eliminarChofer(string idChofer)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idChofer))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sentencias.eliminarChofer(idChofer);
            }
        }

        //metodo de modificar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public void modificarChofer(string idChofer, string nombreEmp, string numeroIdent, string nombre, string licencia, string telefono, string direccion)
        {
            sentencias.modificarChofer(idChofer, nombreEmp, numeroIdent, nombre, licencia, telefono, direccion);
        }
        //metodo de buscar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public DataTable buscarChofer(string idChofer)
        {
            return sentencias.buscarChofer(idChofer);
        }

        // Método para obtener existencias de una bodega (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            return sentencias.ObtenerExistenciasBodega(idBodega);
        }

        // Método para cargar existencias (puede agregar más lógica si es necesario) (Realizado por Daniel Sierra 0901-21-12740)
        public void CargarExistencias(string idBodega)
        {
            OdbcDataReader dr = ObtenerExistenciasBodega(idBodega);
            // Aquí puedes agregar lógica para manejar los datos obtenidos, como llenarlos en un DataGridView
        }

        // Método para realizar auditoría (Realizado por Daniel Sierra 0901-21-12740)
        public void RealizarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            sentencias.InsertarAuditoria(idBodega, idProducto, cantidadFisica, cantidadRegistrada, discrepancia);
        }
        // Método para obtener productos de bodega (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerProductosPorBodega(string idBodega)
        {
            return sentencias.ObtenerProductosPorBodega(idBodega);
        }
        public void RealizarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            sentencias.InsertarSolicitudMantenimiento(idMantenimiento, nombreSolicitante, tipoMantenimiento, componenteAfectado, fecha, responsableAsignado, codigo_error_Problema, estadoMantenimiento, tiempoEstimado, id_Movimiento);
        }
    }
}

