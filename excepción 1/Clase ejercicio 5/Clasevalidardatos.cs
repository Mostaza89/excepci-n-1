using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepción_1.Clase_ejercicio_5
{
    internal class Clasevalidardatos
    {
        public void ValidarDatos(string nombre, int edad, string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new DatoInvalidoException("El campo Nombre es obligatorio.");
            }

            if (edad < 18 || edad > 99)
            {
                throw new DatoInvalidoException("La edad:  " + edad + " no es válida. Debe ser entre 18 y 99 años.");
            }

            if (!correo.Contains("@"))
            {
                throw new DatoInvalidoException("El correo electrónico no es válido (falta el '@').");
            }
        }
    }
}
