using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Factura;

namespace Capa_Controlador_Factura
{
    public class Logica
    {
        Sentencia sn;

        public Logica(string idUsuario)
        {
            sn = new Sentencia(idUsuario);
        }

        public Logica() { }
    }
}
