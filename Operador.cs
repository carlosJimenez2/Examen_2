using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2
{
    class Operador
    {
        protected double Base;
        protected double Altura;
        protected double LongitudLado;
        protected double Radio;

        public void setBase(double n1)
        {
            Base = n1;
        }

        public void setAltura(double n2)
        {
            Altura = n2;

        }
        public void setLongitudLado(double n3)
        {
            LongitudLado = n3;
        }

        public void setRadio(double n4)
        {
            Radio = n4;
        }
    }
}
