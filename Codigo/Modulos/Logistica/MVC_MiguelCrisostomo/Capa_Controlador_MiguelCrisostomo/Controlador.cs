using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_MiguelCrisostomo;






namespace Capa_Controlador_MiguelCrisostomo
{
    public class controlador
    {
        Capa_Modelo_MiguelCrisostomo.sentencias sentencias = new Capa_Modelo_MiguelCrisostomo.sentencias();
        private conexion conn = new conexion(); // Instancia de la clase Conexion


        public void guardarTraslado(string destino, DateTime fecha, int cantidad, decimal costoTotal, decimal costoTotalGeneral, decimal precioTotal, int idProducto, int idGuia, int idVehiculo)
        {
            sentencias.insertarTraslado(destino, fecha, cantidad, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, idVehiculo);
        }

        public int ObtenerIdGuiaPorDestino(string destino)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias
            return modelo.ObtenerIdGuiaPorDestino(destino); // Llama al método en la capa de modelo
        }

        // METODO para obtener la fecha de emisión por destino
        public DateTime ObtenerFechaEmisionPorDestino(string destino)
        {
            return sentencias.ObtenerFechaEmisionPorDestino(destino); // Llama al método en la capa de modelo
        }

        // METODO para obtener la FechaTraslado
        public DateTime ObtenerFechaTrasladoPorDestino(string destino)
        {
            return sentencias.ObtenerFechaTrasladoPorDestino(destino); // Llama al método en la capa de modelo
        }

        // Método para obtener código de producto
        public List<int> ObtenerCodigosProductos()
        {
            return sentencias.ObtenerCodigosProductos(); // Llama al método en Sentencias

        }

        // Método para obtener el nombre del producto
        public string ObtenerNombreProductoPorCodigo(int codigoProducto)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
            return modelo.ObtenerNombreProductoPorCodigo(codigoProducto); // Llama al método en la capa de modelo  
        }

        // Método para obtener pesoProducto como texto por código de producto
        public string ObtenerPesoProductoPorCodigo(int codigoProducto)
        {
            return sentencias.ObtenerPesoProductoPorCodigo(codigoProducto); // Llama al método en Sentencias
        }

        // Método para obtener stockProducto por código de producto
        public int ObtenerStockProductoPorCodigo(int codigoProducto)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
            return modelo.ObtenerStockProductoPorCodigo(codigoProducto); // Llama al método en la capa de modelo  
        }

        // Método para obtener Precio Del Producto por código de producto
        public decimal ObtenerPrecioProductoPorCodigo(int codigoProducto)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
            return modelo.ObtenerPrecioProductoPorCodigo(codigoProducto); // Llama al método en la capa de modelo  
        }


        public void RealizarTraslado(string destino, DateTime fecha, decimal costoTotal, decimal costoTotalGeneral, decimal precioTotal, int idProducto, int idGuia)
        {
            sentencias modelo = new sentencias(); // Instancia de la clase sentencias  
             modelo.RealizarTraslado(destino, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia); 
        }

        public int ObtenerIdVehiculoPorDestino(string destino)
        {
            return sentencias.ObtenerIdVehiculoPorDestino(destino);
        }






    }
}
