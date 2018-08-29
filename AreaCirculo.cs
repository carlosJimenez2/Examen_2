using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2
{
    class AreaCirculo: Operador
    {
        public double getAreaCirculo()
        {
            return((3.1416*(Radio*Radio)));

        }

        public void Area(double Radio)
        {
            Console.WriteLine("El area del circulo es: " + (3.1416 * (Radio * Radio)));

        }
    }
}
