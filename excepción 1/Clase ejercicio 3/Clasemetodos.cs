using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepción_1.Clase_ejercicio_3
{
    internal class Clasemetodos
    {
        public void ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }

        public void ValidarEdad(int edad)
        {
            if (edad < 0)
            {
                throw new ArgumentOutOfRangeException("La edad no puede ser negativa.");
            }
        }
    }
}
