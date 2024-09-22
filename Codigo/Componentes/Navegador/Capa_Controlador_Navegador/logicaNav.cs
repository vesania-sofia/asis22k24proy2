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

    public class logicaNav
    {
        sentencias sn = new sentencias();
        public string lastID(string tabla)
        {
            string lastId = sn.obtenerId(tabla);
            Console.WriteLine(lastId);
            return lastId;
        }

        public DataTable consultaLogica(string tabla, string tablaRelacionada, string campodesc, string columnaForanea, string columnaprimararelacionada)
        {
            OdbcDataAdapter dt = sn.llenaTbl(tabla, tablaRelacionada, campodesc, columnaForanea, columnaprimararelacionada);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;

        }

        public string MIndice(string Indice1)
        {
            string indice = sn.modIndice(Indice1);

            return indice;
        }

        public string MRuta(string Ruta1)
        {
            string ruta = sn.modRuta(Ruta1);

            return ruta;
        }

        public string TestTabla(string tabla)
        {
            return sn.ProbarTabla(tabla);
        }

        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> obtenerColumnasYPropiedadesLogica(string nombreTabla)
        {
            return sn.obtenerColumnasYPropiedades(nombreTabla);
        }

        public string TestEstado(string tabla)
        {
            return sn.ProbarEstado(tabla);
        }

        public int TestRegistros(string tabla)
        {
            return sn.ProbarRegistros(tabla);
        }

        public int contarCampos(string tabla)
        {
            return sn.contarAlias(tabla);
        }

        public int contarRegAyuda(string tabla)
        {
            return sn.contarReg(tabla);
        }

        public string[] campos(string tabla)
        {
            string[] Campos = sn.obtenerCampos(tabla);

            return Campos;
        }

        public string[] tipos(string tabla)
        {
            string[] Tipos = sn.ObtenerTipo(tabla);

            return Tipos;
        }

        public string[] llaves(string tabla)
        {
            string[] LLaves = sn.obtenerLLave(tabla);

            return LLaves;
        }

        public Dictionary<string, string> items(string tabla, string campoClave, string campoDisplay)
        {
            return sn.obtenerItems(tabla, campoClave, campoDisplay);
        }

        public string llaveCampolo(string tabla, string campo, string valor)
        {
            string llave = sn.llaveCampo(tabla, campo, valor);
            return llave;
        }

        public string llaveCampoRev(string tabla, string campo, string valor)
        {
            string llave = sn.llaveCampoReverso(tabla, campo, valor);
            return llave;
        }

        public string ObtenerIdReporte(string id)
        {
            string llave = sn.rutaReporte(id);
            return llave;
        }

        public void nuevoQuery(string query)
        {
            sn.ejecutarQuery(query);
        }

        public string ObtenerIdUsuario(string username)
        {
            return sn.ObtenerIdUsuarioPorUsername(username);
        }

        public void insertarDatosEnMultiplesTablas(List<string> queries)
        {
            sentencias sn = new sentencias();
            sn.ejecutarQueryConTransaccion(queries);
        }

        public string ObtenerClavePrimaria(string nombreTabla)
        {
            return sn.obtenerClavePrimaria(nombreTabla);
        }

        public string ObtenerClaveForanea(string nombreTabla, string tablaReferenciada)
        {
            return sn.ObtenerClaveForanea(nombreTabla, tablaReferenciada);
        }
    }
}
