using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Factura
{
    public class Sentencia
    {
        Conexion cn = new Conexion();
        private string idUsuario;

        public Sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public Sentencia()
        {

        }
    }
}
