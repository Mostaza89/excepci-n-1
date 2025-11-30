using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepción_1.Clase_ejercicio_5
{
    internal class DatoInvalidoException: Exception
    {
        public DatoInvalidoException(string mensaje) : base(mensaje)
        {

        }
    }
}
