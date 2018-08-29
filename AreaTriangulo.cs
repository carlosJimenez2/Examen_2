using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2
{
    class AreaTriangulo :Operador
    {
        public double getAreaTriangulo()
        {
            return ((Base*Altura)/2);

        }

        public void Area(double Base, double Altura)
        {
            Console.WriteLine("El area del triangulo es: " + (Base * Altura) / 2);

        }
    }
}