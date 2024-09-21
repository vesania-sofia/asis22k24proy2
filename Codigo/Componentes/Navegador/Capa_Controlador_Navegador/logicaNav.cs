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
        //metodo para llamar la funcion Obtener ID => Randy 
        public string lastID(string tabla) //ver el ultimo ID
        {
            string lastId = sn.obtenerId(tabla);
            Console.WriteLine(lastId);
            return lastId;
        }
        //metodo para llamar la funcion Obtener Extra => Randy 
        public string[] extras(string tabla)
        {
            string[] Extras = sn.obtenerExtra(tabla);

            return Extras;
        }
        public DataTable consultaLogica(string tabla, string tablaRelacionada, string campodesc, string columnaForanea, string columnaprimararelacionada)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl(tabla, tablaRelacionada, campodesc, columnaForanea, columnaprimararelacionada);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;

        }


        /*eli*/
        /* public DataTable consultaLogica2()  //obtener datos de la consulta
         {
             OdbcDataAdapter dt = sn.llenaTbl2();
             DataTable table = new DataTable();
             dt.Fill(table);
             return table;
         }*/

        /**/
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
        /*public string verificacion(string valor)
        {
        //    string indice2 = sn.VerificacionR(valor);

            return indice2;
        }*/
        public string TestTabla(string tabla)
        {
            return sn.ProbarTabla(tabla);
        }


        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> obtenerColumnasYPropiedadesLogica(string nombreTabla)
        {
            // Llamada al método en la capa de datos, que ahora incluye la información de las claves foráneas
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
        /*
        public int obtenerMaxId(string tabla)
        {
            return sn.maxId(tabla);
        } */
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

        public string ObtenerIdModulo(string aplicacion)
        {
            string llave = sn.IdModulo(aplicacion);
            return llave;
        }

        public string ObtenerIdReporte(string id)
        {
            string llave = sn.rutaReporte(id);
            return llave;
        }

        public void nuevoQuery(string query)//trasporta el query de la capa de disenio a Datos
        {
            sn.ejecutarQuery(query);
        }

        public void insertarDatosEnDosTablas(List<string> queries)
        {
            // Verificar si hay consultas válidas
            if (queries == null || queries.Count == 0)
            {
                throw new ArgumentException("Debe haber al menos una consulta válida para ejecutar.");
            }

            // Llamar al método de transacción con la lista de queries
            sn.ejecutarQueryConTransaccion(queries);
        }

        // Método para obtener el ID de usuario a partir del username
        public string ObtenerIdUsuario(string username)
        {
            // Llamar al método de la capa de sentencias y retornar el resultado como string
            return sn.ObtenerIdUsuarioPorUsername(username);
        }
        public void insertarDatosEnMultiplesTablas(List<string> queries)
        {
            sentencias sn = new sentencias();
            sn.ejecutarQueryConTransaccion(queries);  // Pasamos la lista de queries para ser ejecutadas dentro de una transacción
        }
        public string ObtenerClavePrimaria(string nombreTabla)
        {
            // Llama al método de la capa de datos (sentencias)
            return sn.obtenerClavePrimaria(nombreTabla);
        }

        public string ObtenerClaveForanea(string nombreTabla, string tablaReferenciada)
        {
            return sn.ObtenerClaveForanea(nombreTabla, tablaReferenciada);
        }



    }
}
