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
        public string lastID(string tabla)
        {
            string lastId = sn.obtenerId(tabla);
            Console.WriteLine(lastId);
            return lastId;
        }

        // Realiza una consulta lógica sobre la tabla y la tabla relacionada, devolviendo un DataTable con los resultados
        public DataTable consultaLogica(string tabla, string tablaRelacionada, string campodesc, string columnaForanea, string columnaprimararelacionada)
        {
            OdbcDataAdapter dt = sn.llenaTbl(tabla, tablaRelacionada, campodesc, columnaForanea, columnaprimararelacionada);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        // Modifica el índice proporcionado a través de la lógica interna
        public string MIndice(string Indice1)
        {
            string indice = sn.modIndice(Indice1);
            return indice;
        }

        // Modifica la ruta proporcionada a través de la lógica interna
        public string MRuta(string Ruta1)
        {
            string ruta = sn.modRuta(Ruta1);
            return ruta;
        }

        // Prueba si la tabla existe en la base de datos
        public string TestTabla(string tabla)
        {
            return sn.ProbarTabla(tabla);
        }

        // Obtiene una lista de columnas y sus propiedades (si son autoincrementales, claves foráneas, etc.) para la tabla dada
        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> obtenerColumnasYPropiedadesLogica(string nombreTabla)
        {
            return sn.obtenerColumnasYPropiedades(nombreTabla);
        }

        // Prueba el estado de la tabla en la base de datos
        public string TestEstado(string tabla)
        {
            return sn.ProbarEstado(tabla);
        }

        // Devuelve el número de registros en la tabla
        public int TestRegistros(string tabla)
        {
            return sn.ProbarRegistros(tabla);
        }

        // Cuenta los campos (columnas) en la tabla especificada
        public int contarCampos(string tabla)
        {
            return sn.contarAlias(tabla);
        }

        // Cuenta los registros de ayuda en la tabla especificada
        public int contarRegAyuda(string tabla)
        {
            return sn.contarReg(tabla);
        }

        // Devuelve un array con los nombres de los campos de la tabla especificada
        public string[] campos(string tabla)
        {
            string[] Campos = sn.obtenerCampos(tabla);
            return Campos;
        }

        // Devuelve un array con los tipos de datos de los campos de la tabla especificada
        public string[] tipos(string tabla)
        {
            string[] Tipos = sn.ObtenerTipo(tabla);
            return Tipos;
        }

        // Devuelve un array con las llaves primarias de la tabla especificada
        public string[] llaves(string tabla)
        {
            string[] LLaves = sn.obtenerLLave(tabla);
            return LLaves;
        }

        // Obtiene los elementos para un ComboBox basado en la tabla y campos especificados
        public Dictionary<string, string> items(string tabla, string campoClave, string campoDisplay)
        {
            return sn.obtenerItems(tabla, campoClave, campoDisplay);
        }

        // Devuelve la clave primaria correspondiente a un valor específico en un campo específico de la tabla
        public string llaveCampolo(string tabla, string campo, string valor)
        {
            string llave = sn.llaveCampo(tabla, campo, valor);
            return llave;
        }

        // Devuelve la clave primaria en reverso para un valor específico en un campo específico de la tabla
        public string llaveCampoRev(string tabla, string campo, string valor)
        {
            string llave = sn.llaveCampoReverso(tabla, campo, valor);
            return llave;
        }

        // Obtiene el ID de un reporte basado en su nombre
        public string ObtenerIdReporte(string id)
        {
            string llave = sn.rutaReporte(id);
            return llave;
        }

        // Ejecuta una nueva consulta en la base de datos
        public void nuevoQuery(string query)
        {
            sn.ejecutarQuery(query);
        }

        // Obtiene el ID de un usuario basado en su nombre de usuario
        public string ObtenerIdUsuario(string username)
        {
            return sn.ObtenerIdUsuarioPorUsername(username);
        }

        // Inserta datos en múltiples tablas en una transacción
        public void insertarDatosEnMultiplesTablas(List<string> queries)
        {
            sentencias sn = new sentencias();
            sn.ejecutarQueryConTransaccion(queries);
        }

        // Obtiene la clave primaria de una tabla específica
        public string ObtenerClavePrimaria(string nombreTabla)
        {
            return sn.obtenerClavePrimaria(nombreTabla);
        }

        // Obtiene la clave foránea de una tabla referenciada
        public string ObtenerClaveForanea(string nombreTabla, string tablaReferenciada)
        {
            return sn.ObtenerClaveForanea(nombreTabla, tablaReferenciada);
        }
    }
}
