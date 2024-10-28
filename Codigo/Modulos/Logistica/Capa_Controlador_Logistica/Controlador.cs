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
        Sentencias sn = new Sentencias();
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
                sn.registrarChofer(idChofer.Text, sNombreEmp, sNumeroIdent, sNombre, sLicencia, sTelefono, sDireccion);
                return 1;
            }
        }
        public DataTable cargarChoferes()
        {
            return sn.cargarChoferes();
        }

        public string getNextId()
        {
            int nextId = sn.getMaxIdChofer();
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
                sn.eliminarChofer(idChofer);
            }
        }

        //metodo de modificar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public void modificarChofer(string idChofer, string nombreEmp, string numeroIdent, string nombre, string licencia, string telefono, string direccion)
        {
            sn.modificarChofer(idChofer, nombreEmp, numeroIdent, nombre, licencia, telefono, direccion);
        }
        //metodo de buscar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public DataTable buscarChofer(string idChofer)
        {
            return sn.buscarChofer(idChofer);
        }
        public void RealizarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            sn.InsertarSolicitudMantenimiento(idMantenimiento, nombreSolicitante, tipoMantenimiento, componenteAfectado, fecha, responsableAsignado, codigo_error_Problema, estadoMantenimiento, tiempoEstimado, id_Movimiento);
        }

        // Método para obtener existencias de una bodega (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            return sn.ObtenerExistenciasBodega(idBodega);
        }

        // Método para cargar existencias (puede agregar más lógica si es necesario) (Realizado por Daniel Sierra 0901-21-12740)
        public void CargarExistencias(string idBodega)
        {
            OdbcDataReader dr = ObtenerExistenciasBodega(idBodega);
            // Aquí puedes agregar lógica para manejar los datos obtenidos, como llenarlos en un DataGridView
        }

        public void CargarExistencias(string idBodega, DataTable dtExistencias)
        {
            using (OdbcDataReader dr = ObtenerExistenciasBodega(idBodega))
            {
                if (dr != null)
                {
                    try
                    {
                        dtExistencias.Load(dr); // Carga los datos en el DataTable
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al cargar las existencias: " + ex.Message);
                    }
                    finally
                    {
                        dr.Close(); // Asegúrate de cerrar el DataReader
                    }
                }
                else
                {
                    throw new Exception("No se pudieron obtener existencias para la bodega seleccionada.");
                }
            }
        }

        // Método para realizar auditoría (Realizado por Daniel Sierra 0901-21-12740)
        public void RealizarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            sn.InsertarAuditoria(idBodega, idProducto, cantidadFisica, cantidadRegistrada, discrepancia);
        }

        // Método para obtener las bodegas

        public List<KeyValuePair<int, string>> listadoBodegas()
        {
            return sn.GetBodegas(); // Llama al método actualizado
        }




        // Método para obtener productos
        public List<KeyValuePair<int, string>> listadoProductos()
        {
            return sn.GetProductos(); // Llama al método actualizado
        }

        // Método para registrar una auditoría
        public void RealizarAuditoria(int idBodega, int idProducto, DateTime fechaAuditoria, string observaciones, int cantidadRegistrada, int cantidadFisica, bool discrepancia)
        {
            sn.InsertarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia);
        }

        // Método para cargar las auditorías en el DataGridView
        public DataTable CargarAuditorias()
        {
            return sn.ObtenerAuditorias();
        }

        public void RealizarAuditoria(
     int idBodega,
     int idProducto,
     DateTime fechaAuditoria,
     string observaciones,
     int cantidadRegistrada,
     int cantidadFisica,
     bool discrepancia,
     DataGridView dgvAuditorias)
        {
            try
            {
                // Llamar al método para insertar auditoría
                string resultado = sn.InsertarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia);

                // Comprobar el resultado de la inserción
                if (resultado == "Auditoría realizada con éxito")
                {
                    MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAuditorias(dgvAuditorias); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Error al realizar auditoría: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CargarAuditorias(DataGridView dgvAuditorias)
        {
            try
            {
                DataTable dtAuditorias = sn.ObtenerAuditorias();
                dgvAuditorias.DataSource = dtAuditorias;

                // Configura las columnas según sea necesario
                if (dtAuditorias.Columns.Count > 0)
                {
                    dgvAuditorias.Columns[0].HeaderText = "ID Auditoría"; // Pk_ID_AUDITORIA
                    dgvAuditorias.Columns[1].HeaderText = "Bodega"; // Fk_ID_BODEGA
                    dgvAuditorias.Columns[2].HeaderText = "Producto"; // Fk_ID_PRODUCTO
                    dgvAuditorias.Columns[3].HeaderText = "Fecha Auditoría"; // FECHA_AUDITORIA
                    dgvAuditorias.Columns[4].HeaderText = "Observaciones"; // OBSERVACIONES
                    dgvAuditorias.Columns[5].HeaderText = "Cantidad Registrada"; // CANTIDAD_REGISTRADA
                    dgvAuditorias.Columns[6].HeaderText = "Cantidad Física"; // CANTIDAD_FISICA
                    dgvAuditorias.Columns[7].HeaderText = "Discrepancia"; // DISCREPANCIA_DETECTADA
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------
        public string[] itemsCuenta(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbCuentas(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarCuentas(string tabla, string campo1, string campo2)
        {
            var dt1 = sn.obtenerCuentas(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX TIPO POLIZA ----------------------------------

        public string[] itemsTP(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbTP(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarTP(string tabla, string campo1, string campo2)
        {
            var dt1 = sn.obtenerTP(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public string[] itemsOP(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmbTP(tabla, campo1, campo2);
            return Items;
        }

        public DataTable enviarOP(string tabla, string campo1, string campo2)
        {
            var dt1 = sn.obtenerTP(tabla, campo1, campo2);
            return dt1;
        }

        // ---------------------------------- Funcion para actualizar la tabla cuentas ----------------------------------

        public void ActualizarTblCuentas(int idCuenta, string tipoOperacion, decimal valor)
        {
            Sentencias sn = new Sentencias();

            sn.ActulizarCuentas(idCuenta, tipoOperacion, valor);
            return;
        }

        // ---------------------------------- Insertar en polizas ----------------------------------
        public void LlenarEncabezado(string fechaSeleccionada, string concepto, int tipoPoli)
        {
            Sentencias sn = new Sentencias();
            sn.LlenarEncabezado(fechaSeleccionada, concepto, tipoPoli);
            return;
        }

        public void LlenarDetalle(string fechaSeleccionada, string concepto, List<object[]> detalles)
        {
            Sentencias sn = new Sentencias();
            sn.LlenarDetalle(fechaSeleccionada, concepto, detalles);
            return;
        }

    }
}

