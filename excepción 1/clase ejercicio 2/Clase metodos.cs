using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepción_1.clase_ejercicio_2
{
    internal class Clase_metodos
    {
        public void IniciarProceso(string dato)
        {
            Calcular(dato);
        }

        public void Calcular(string dato)
        {
            Convertir(dato);
        }

        public void Convertir(string dato)
        {
            int numero = int.Parse(dato);
        }
    }
}
