using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Modelo_Cotizacion;

namespace Capa_Controlador_Cotizacion
{
    public class Logica
    {
        Sentencia sn;

        public Logica()
        {
            sn = new Sentencia();
        }



        
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

/// ////////////////////////////



        public DataTable funvalidarIDCotizacionE()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.funvalidarIDCotizacionE();
                DataTable tableValidacionIdAplicacion = new DataTable();
                dtValidarIDAplicacion.Fill(tableValidacionIdAplicacion);
                return tableValidacionIdAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }




        public bool funinsertarCotizacionEn(string idCotizacion, string idVendedor, string idCliente, DateTime fechaVenc, string total)
        {
            try
            {
                // Llamar al método proInsertarCotizacionE con los parámetros correctos
                sn.proInsertarCotizacionE(idCotizacion, idVendedor, idCliente, fechaVenc, total);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la cotización: " + ex.Message);
                return false;
            }
        }

    }
}
