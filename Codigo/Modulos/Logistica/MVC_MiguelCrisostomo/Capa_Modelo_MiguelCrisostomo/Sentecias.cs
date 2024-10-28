using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;



namespace Capa_Modelo_MiguelCrisostomo
{
    public class sentencias
    {
        conexion conn = new conexion(); // Utiliza tu clase existente

        public void insertarTraslado(string destino, DateTime fecha, int cantidad, decimal costoTotal, decimal costoTotalGeneral, decimal precioTotal, int idProducto, int idGuia, int idVehiculo)
        {
            OdbcConnection connection = conn.Conexion(); // Abre la conexión
            try
            {
                string query = "INSERT INTO Tbl_TrasladoProductos (destino, fecha, cantidad, costoTotal, costoTotalGeneral, precioTotal, Fk_id_Producto, Fk_id_guia, Fk_id_vehiculo) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);
                cmd.Parameters.AddWithValue("fecha", fecha);
                cmd.Parameters.AddWithValue("cantidad", cantidad);
                cmd.Parameters.AddWithValue("costoTotal", costoTotal);
                cmd.Parameters.AddWithValue("costoTotalGeneral", costoTotalGeneral);
                cmd.Parameters.AddWithValue("precioTotal", precioTotal);
                cmd.Parameters.AddWithValue("Fk_id_Producto", idProducto);
                cmd.Parameters.AddWithValue("Fk_id_guia", idGuia);
                cmd.Parameters.AddWithValue("Fk_id_vehiculo", idVehiculo);

                cmd.ExecuteNonQuery(); // Ejecuta la inserción
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar traslado: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }
        }

        public string ObtenerNombreProductoPorCodigo(string codigoProducto)
        {
            throw new NotImplementedException();
        }

        //**********************************************************************************************************************************************
        // Método para obtener los códigos de productos desde Tbl_Productos  
        public List<int> ObtenerCodigosProductos()
        {
            List<int> codigosProductos = new List<int>();
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT codigoProducto FROM Tbl_Productos";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    codigosProductos.Add(reader.GetInt32(0)); // Agrega cada código de producto a la lista
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener códigos de productos: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }

            return codigosProductos; // Retorna la lista de códigos de productos
        }


        // Método para obtener nombreProducto según el destino***************************************************************************
        public string ObtenerNombreProductoPorCodigo(int codigoProducto)
        {
            string nombreProducto = string.Empty;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT nombreProducto FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nombreProducto = reader.GetString(0); // Obtiene el nombre del producto  
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener nombre de producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return nombreProducto; // Retorna el nombre del producto encontrado o vacío si no se encontró  
        }


        // Método para obtener pesoProducto como texto según el código de producto
        public string ObtenerPesoProductoPorCodigo(int codigoProducto)
        {
            string pesoProducto = string.Empty;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT pesoProducto FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pesoProducto = reader.GetString(0); // Obtiene el peso del producto como texto
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener peso del producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return pesoProducto; // Retorna el peso del producto como texto
        }


        // Método para obtener stock según el código de producto
        public int ObtenerStockProductoPorCodigo(int codigoProducto)
        {
            int stockProducto = 0;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT stock FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    stockProducto = reader.GetInt32(0); // Obtiene el stock del producto  
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener stock de producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return stockProducto; // Retorna el stock del producto encontrado o 0 si no se encontró  
        }


        // Método para obtener precio según el código de producto
        public decimal ObtenerPrecioProductoPorCodigo(int codigoProducto)
        {
            decimal precioProducto = 0;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos  

            try
            {
                string query = "SELECT precioUnitario FROM Tbl_Productos WHERE codigoProducto = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("codigoProducto", codigoProducto);

                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    precioProducto = reader.GetDecimal(0); // Obtiene el precio del producto  
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener precio de producto por código: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión  
            }

            return precioProducto; // Retorna el precio del producto encontrado o 0 si no se encontró  
        }



        public int ObtenerIdVehiculoPorDestino(string destino)
        {
            int idVehiculo = 0;
            using (OdbcConnection connection = conn.Conexion())
            {
                string query = "SELECT Fk_id_vehiculo FROM Tbl_vehiculos WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idVehiculo = reader.GetInt32(0);
                    }
                }
            }
            return idVehiculo;
        }



















        //***************************************************************************************************************

        public DateTime ObtenerFechaTrasladoPorDestino(string destino)
        {
            DateTime fechaTraslado = DateTime.MinValue;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT fechaTraslado FROM Tbl_datos_pedido WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fechaTraslado = reader.GetDateTime(0); // Asigna la fecha si se encuentra
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la fecha de traslado: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return fechaTraslado; // Retorna la fecha o null si no se encontró
        }



        // METODO para obtener la fecha de emisión según el destino
        public DateTime ObtenerFechaEmisionPorDestino(string destino)
        {
            DateTime fechaEmision = DateTime.MinValue;
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT fechaEmision FROM Tbl_datos_pedido WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fechaEmision = reader.GetDateTime(0); // Obtiene la fecha de emisión
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener fecha de emisión: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }

            return fechaEmision; // Retorna la fecha de emisión encontrada o DateTime.MinValue si no se encontró
        }


        /// INSTRUCCION PARA OBTENER LA INFORMACION DEL LA TABLA: Tbl_datos_pedido ******************************************************
        // Método para obtener los destinos desde la base de datos
        // Nuevo método para obtener los destinos desde Tbl_datos_pedido
        public List<string> ObtenerDestinos()
        {
            List<string> destinos = new List<string>();
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                string query = "SELECT destino FROM Tbl_datos_pedido";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    destinos.Add(reader.GetString(0)); // Agrega cada destino a la lista
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener destinos: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }
            return destinos; // Retorna la lista de destinos
        }


        // Método para obtener el ID (Pk_id_guia) según el destino***************************************************************************
        public int ObtenerIdGuiaPorDestino(string destino)
        {
            int idGuia = -1; // Valor predeterminado para indicar que no se encontró el ID
            OdbcConnection connection = conn.Conexion();

            try
            {
                string query = "SELECT Pk_id_guia FROM Tbl_datos_pedido WHERE destino = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idGuia = reader.GetInt32(0); // Obtiene el ID si se encontró
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener ID por destino: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection);
            }

            return idGuia; // Retorna el ID encontrado o -1 si no se encontró
        }


        // Método para obtener la marca del vehículo según el destino seleccionado *************************************************************
        public string ObtenerMarcaVehiculoPorDestino(string destino)
        {
            string marcaVehiculo = "";
            OdbcConnection connection = conn.Conexion(); // Conexión a la base de datos

            try
            {
                // Consulta SQL para obtener la marca del vehículo relacionado con el destino
                string query = @"
            SELECT v.marca 
            FROM Tbl_datos_pedido dp
            INNER JOIN Tbl_vehiculos v ON dp.Fk_id_vehiculo = v.Pk_id_vehiculo
            WHERE dp.destino = ?";

                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    marcaVehiculo = reader.GetString(0); // Obtiene la marca del vehículo
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la marca del vehículo: " + ex.Message);
            }
            finally
            {
                conn.desconexion(connection); // Cierra la conexión
            }

            return marcaVehiculo; // Retorna la marca del vehículo encontrada
        }

        public void RealizarTraslado(string destino, DateTime fecha, decimal costoTotal, decimal costoTotalGeneral, decimal precioTotal, int idProducto, int idGuia)
        {
            // Conexión a la base de datos
            OdbcConnection connection = conn.Conexion(); // Usar la instancia para obtener la conexión

            try
            {
                // Consulta para insertar datos en la tabla Tbl_TrasladoProductos
                string query = "INSERT INTO Tbl_TrasladoProductos (destino, fecha, costoTotal, costoTotalGeneral, precioTotal, Fk_id_Producto, Fk_id_guia) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?)";

                // Crear el comando Odbc y asignar los parámetros
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("destino", destino);
                cmd.Parameters.AddWithValue("fecha", fecha);
                cmd.Parameters.AddWithValue("costoTotal", costoTotal);
                cmd.Parameters.AddWithValue("costoTotalGeneral", costoTotalGeneral);
                cmd.Parameters.AddWithValue("precioTotal", precioTotal);
                cmd.Parameters.AddWithValue("Fk_id_Producto", idProducto);
                cmd.Parameters.AddWithValue("Fk_id_guia", idGuia);
                

                // Ejecutar el comando de inserción
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar el traslado: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                //conn.Desconexion(connection); // Asegúrate de que este método se llame correctamente
                conn.desconexion(connection);

            }
        }




    }
}
