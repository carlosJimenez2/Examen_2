using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2
{
    class AreaCuadrado : Operador
    {
        public double getAreaCuadrado()
        {
            return (LongitudLado * LongitudLado);
        }

        public void Area(double LongitudLado)
        {
            Console.WriteLine("El area del cuadrado es: " + (LongitudLado*LongitudLado));

        }


    }
}
