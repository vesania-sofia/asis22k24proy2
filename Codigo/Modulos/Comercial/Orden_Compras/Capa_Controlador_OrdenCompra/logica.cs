using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_OrdenCompra;
using System.Windows.Forms;

namespace Capa_Controlador_OrdenCompra
{
    public class logica
    {
        sentencia sn;

        public logica()
        {
            sn = new sentencia();
        }




        public DataTable funConsultaLogicaProductos()
        {

            try
            {
                OdbcDataAdapter dtProducto = sn.funProductos();
                DataTable tableProducto = new DataTable();
                dtProducto.Fill(tableProducto);
                return tableProducto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public DataTable funConsultaLogicaProveedor()
        {

            try
            {
                OdbcDataAdapter dtProv = sn.funProveedores();
                DataTable tableProv = new DataTable();
                dtProv.Fill(tableProv);
                return tableProv;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }


        public DataTable funConsultaLogicaOrdenes()
        {
            try
            {
                OdbcDataAdapter dtEncabezadoOC = sn.funMostrarOrdenCompras();
                // Llamar al método que retorna un DataTable
                DataTable tablaEncabezadoOC = new DataTable();
                dtEncabezadoOC.Fill(tablaEncabezadoOC);// Cambio en el nombre del método para reflejar permiso
                return tablaEncabezadoOC;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error en cargar dtOrdenes: " + ex.Message);
                return null;
            }
        }

        //nueva
        /*
        public DataTable funConsultaLogicaOrdenesGeneradas(string sAplicacionUsuario)
        {
            DataTable table = new DataTable();
            OdbcDataAdapter dt = sn.funMostrarOrdenCompras(sAplicacionUsuario);
            if (dt == null)
            {
                MessageBox.Show("Error al obtener los datos del adaptador.");
                return null;
            }
            dt.Fill(table);
            return table;
        }

        */


        public string[] funitems(string stabla, string scampo1, string scampo2)
        {
            string[] Items = sn.funllenarCmb(stabla, scampo1, scampo2);

            return Items;




        }

        public DataTable funenviar(string stabla, string scampo1, string scampo2)
        {

            var dt = sn.funobtener(stabla, scampo1, scampo2);

            return dt;
        }


        public DataTable funenviar2(string stabla, string scampo1, string scampo2)
        {

            var dt = sn.funobtener2(stabla, scampo1, scampo2);

            return dt;
        }

        public DataTable funenviar1(string stabla, string scampo1)
        {

            var dt = sn.funobtener1(stabla, scampo1);

            return dt;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*
        public bool funingresarOrdenCompra(string sCodigoDetalle, string sCodigoEncabezado, string sCodigoProducto, string sCantidad, string sPrecioUni, string sTotal)
        {
            try
            {
                // Ejecutar la inserción
                sn.proinsertarOrdenCompra(sCodigoDetalle, sCodigoEncabezado, sCodigoProducto, sCantidad, sPrecioUni, sTotal);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar el módulo: " + ex.Message);
                return false;
            }
        } // termina

        *///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public bool funingresarEncabezadoOrdenCompra(string sNoEncabezado, string sProveedor, DateTime sFecha)
        {
            try
            {
                // Ejecutar la inserción
                sn.proinsertarEncabezadoOrdenCompra(sNoEncabezado, sProveedor, sFecha);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar el Encabezado: " + ex.Message);
                return false;
            }
        } // termina



        public string[] funitems1(string stabla, string scampo1)
        {
            string[] Items = sn.funllenarCmb1(stabla, scampo1);

            return Items;




        }

        public DataTable funenviar11(string stabla, string scampo1)
        {

            var dt1 = sn.funobtener1(stabla, scampo1);

            return dt1;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public DataTable funConsultaLogicaProducto(int CodigoProducto)
        {
            try
            {
                OdbcDataAdapter dtProducto = sn.funConsultarProducto(CodigoProducto);
                DataTable tableProducto = new DataTable();
                dtProducto.Fill(tableProducto);
                return tableProducto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7



        public string LastErrorMessage { get; private set; } // Propiedad para almacenar el último mensaje de error

        public bool CrearOrdenCompra(string numeroOC, int proveedorId, DateTime fechaEntrega, decimal total, List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles)
        {
            // Llamar al método para insertar la orden completa
            bool resultado = sn.InsertOrder(numeroOC, proveedorId, fechaEntrega, total, detalles);

            // Manejo del error en caso de que la inserción falle
            if (!resultado)
            {
                Console.WriteLine("Error al crear la orden de compra: " + sn.LastErrorMessage);
                LastErrorMessage = "No se pudo insertar la orden de compra."; // Puedes personalizar este mensaje según tus necesidades
            }
            return resultado; // Retorna el resultado de la operación
        }


        public bool ObtenerOrdenCompra(string numeroOC, out int proveedorId, out DateTime fechaEntrega, out decimal total, out List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles)
        {
            // Llama al método del modelo con parámetros de salida
            bool resultado = sn.GetOrder(numeroOC, out proveedorId, out fechaEntrega, out total, out detalles);

            // Manejo del error en caso de que la inserción falle
            if (!resultado)
            {
                Console.WriteLine("Error al obtener la orden de compra: " + sn.LastErrorMessage);
                LastErrorMessage = "No se pudo obtener la orden de compra."; // Puedes personalizar este mensaje según tus necesidades
            }

            return resultado; // Retorna el resultado de la operación
        }





        public DataTable funConsultaDetallesOrdenCompra(string noCompra)
        {
            try
            {
                // Llamar a la función CargarDetalles para obtener un DataTable
                DataTable tableAplicaciones = sn.CargarDetalles(noCompra);
                return tableAplicaciones; // Retornar el DataTable directamente
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable funConsultaDetallesOrdenCompras(string noCompra)
        {
            try
            {
                // Llamar a la función CargarDetalles para obtener un DataTable
                DataTable tableAplicaciones = sn.ObtenerEncabezadoPorNumeroCompra(noCompra);
                return tableAplicaciones; // Retornar el DataTable directamente
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public bool ActualizarStockProducto(int codigoProducto, int cantidad)
        {
            // Llama al método de la capa de sentencia para actualizar el stock
            bool resultado = sn.ActualizarStock(codigoProducto, cantidad);

            // Si hubo un error al actualizar el stock
            if (!resultado)
            {
                Console.WriteLine("Error al actualizar el stock.");
            }

            return resultado;
        }


        public bool ActualizarDeudaProveedor(int proveedorId, decimal totalOrden)
        {
            // Llama al método de la capa de sentencia para actualizar la deuda del proveedor
            bool resultado = sn.ActualizarDeudaProveedor(proveedorId, totalOrden);

            // Si hubo un error al actualizar la deuda
            if (!resultado)
            {
                Console.WriteLine("Error al actualizar la deuda del proveedor.");
            }

            return resultado;
        }

        // Método para guardar la compra
        public bool GuardarCompra(string numeroOC, int proveedorId, DateTime fechaCompra, decimal totalCompra, int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)
        {
            bool resultado = sn.GuardarCompraRealizada(numeroOC, proveedorId, fechaCompra, totalCompra, codigoProducto, precioU, cantidad, totalDetalle);

            // Si hubo un error al guardar la compra
            if (!resultado)
            {
                Console.WriteLine("Hubo un error al guardar la compra realizada.");
            }

            return resultado;
        }














        public int ObtenerStockProducto(int codigoProducto)
        {
            // Llama a la capa de sentencia para obtener el stock
            return sn.BuscarStockProducto(codigoProducto);
        }


        // Método para cargar y seleccionar el proveedor en el ComboBox


        public DataTable ObtenerProveedorPorId(int idProveedor)
        {
            try
            {
                // Llama al método en la capa de datos para buscar el proveedor
                DataTable tableProveedor = sn.BuscarProveedorPorId(idProveedor);

                // Verifica si se obtuvo el DataTable y si contiene filas
                if (tableProveedor != null && tableProveedor.Rows.Count > 0)
                {
                    return tableProveedor; // Retorna el DataTable con la información del proveedor
                }
                else
                {
                    Console.WriteLine("No se encontró proveedor con ID: " + idProveedor);
                    return null; // Retorna null si no hay resultados
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerProveedorPorId: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }

        public bool ActualizarOrdenCompra(string numeroOC, decimal nuevoTotal, List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles)
        {
            // Llamar al método para insertar la orden completa
            bool resultado = sn.ActualizarOrdenDetalle(numeroOC, nuevoTotal, detalles);
            return resultado; // Retorna el resultado de la operación
        }


        public bool EliminarDetalle(string numeroOC, int codigoProducto)
        {
            // Llamar al método de la capa de datos
             return sn.EliminarDetalleCompra(numeroOC, codigoProducto);
            
        }

        public bool EliminarOrdenCompra(string numeroOC)
        {
            // Llamar al método de la capa de datos
            return sn.EliminarOrden(numeroOC);

        }


    }

}
