using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Datos_Navegador;

namespace Capa_Controlador_Navegador
{
    //******************************************** CODIGO HECHO POR TODOS SEGUN LO NECESITABAN ***************************** 
    public class logicaNav
    {
        // Instancia de la clase sentencias para ejecutar operaciones con la base de datos
        sentencias sn = new sentencias();

        // Obtiene el último ID insertado en la tabla especificada
        public string UltimoID(string sTabla)
        {
            string sUltimoID = sn.obtenerId(sTabla);
            Console.WriteLine(sUltimoID);
            return sUltimoID;
        }

        // Realiza una consulta lógica sobre la tabla y la tabla relacionada, devolviendo un DataTable con los resultados
        public DataTable ConsultaLogica(string sTabla, string sTablaRelacionada, string sCampodesc, string sColumnaForanea, string sColumnaPrimaraRelacionada)
        {
            OdbcDataAdapter dt = sn.llenaTbl(sTabla, sTablaRelacionada, sCampodesc, sColumnaForanea, sColumnaPrimaraRelacionada);
            DataTable dtTabla = new DataTable();
            dt.Fill(dtTabla);
            return dtTabla;
        }

        // Modifica el índice proporcionado a través de la lógica interna
        public string ModIndice(string sIndice1)
        {
            string sIndice = sn.modIndice(sIndice1);
            return sIndice;
        }

        // Modifica la ruta proporcionada a través de la lógica interna
        public string ModRuta(string sRuta1)
        {
            string sRuta = sn.modRuta(sRuta1);
            return sRuta;
        }

        // Prueba si la tabla existe en la base de datos
        public string TestTabla(string sTabla)
        {
            return sn.ProbarTabla(sTabla);
        }

        // Obtiene una lista de columnas y sus propiedades (si son autoincrementales, claves foráneas, etc.) para la tabla dada
        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> ObtenerColumnasYPropiedadesLogica(string sNombreTabla)
        {
            return sn.obtenerColumnasYPropiedades(sNombreTabla);
        }

        // Prueba el estado de la tabla en la base de datos
        public string TestEstado(string sTabla)
        {
            return sn.ProbarEstado(sTabla);
        }

        // Devuelve el número de registros en la tabla
        public int TestRegistros(string sTabla)
        {
            return sn.ProbarRegistros(sTabla);
        }

        // Cuenta los campos (columnas) en la tabla especificada
        public int ContarCampos(string sTabla)
        {
            return sn.contarAlias(sTabla);
        }

        // Cuenta los registros de ayuda en la tabla especificada
        public int ContarRegAyuda(string sTabla)
        {
            return sn.contarReg(sTabla);
        }

        // Devuelve un array con los nombres de los campos de la tabla especificada
        public string[] Campos(string sTabla)
        {
            string[] sCampos = sn.obtenerCampos(sTabla);
            return sCampos;
        }

        // Devuelve un array con los tipos de datos de los campos de la tabla especificada
        public string[] Tipos(string sTabla)
        {
            string[] sTipos = sn.ObtenerTipo(sTabla);
            return sTipos;
        }

        // Devuelve un array con las llaves primarias de la tabla especificada
        public string[] Llaves(string sTabla)
        {
            string[] sLlaves = sn.obtenerLLave(sTabla);
            return sLlaves;
        }

        // Obtiene los elementos para un ComboBox basado en la tabla y campos especificados
        public Dictionary<string, string> Items(string sTabla, string sCampoClave, string sCampoDisplay)
        {
            return sn.obtenerItems(sTabla, sCampoClave, sCampoDisplay);
        }

        // Devuelve la clave primaria correspondiente a un valor específico en un campo específico de la tabla
        public string LlaveCampolo(string sTabla, string sCampo, string sValor)
        {
            string sLlave = sn.llaveCampo(sTabla, sCampo, sValor);
            return sLlave;
        }

        // Devuelve la clave primaria en reverso para un valor específico en un campo específico de la tabla
        public string LlaveCampoRev(string sTabla, string sCampo, string sValor)
        {
            string sLlave = sn.llaveCampoReverso(sTabla, sCampo, sValor);
            return sLlave;
        }

        // Obtiene el ID de un reporte basado en su nombre
        public string ObtenerIdReporte(string sId)
        {
            string sLlave = sn.rutaReporte(sId);
            return sLlave;
        }

        // Ejecuta una nueva consulta en la base de datos
        public void NuevoQuery(string sQuery)
        {
            sn.ejecutarQuery(sQuery);
        }

        // Obtiene el ID de un usuario basado en su nombre de usuario
        public string ObtenerIdUsuario(string sUsername)
        {
            return sn.ObtenerIdUsuarioPorUsername(sUsername);
        }

        // Inserta datos en múltiples tablas en una transacción
        public void InsertarDatosEnMultiplesTablas(List<string> lsQueries)
        {
            sentencias sn = new sentencias();
            sn.ejecutarQueryConTransaccion(lsQueries);
        }

        // Obtiene la clave primaria de una tabla específica
        public string ObtenerClavePrimaria(string sNombreTabla)
        {
            return sn.obtenerClavePrimaria(sNombreTabla);
        }

        // Obtiene la clave foránea de una tabla referenciada
        public string ObtenerClaveForanea(string sNombreTabla, string sTablaReferencia)
        {
            return sn.ObtenerClaveForanea(sNombreTabla, sTablaReferencia);
        }
    }
}
