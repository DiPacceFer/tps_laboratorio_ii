using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IngresoDeDatosException : Exception
    {
        public IngresoDeDatosException(string mensaje):base(mensaje)
        {

        }
        public IngresoDeDatosException(string mensaje, Exception inner): base(mensaje, inner)
        {

        }
    }
}
