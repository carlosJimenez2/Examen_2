using System;

namespace Examen2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base = 0;
            string BaseString = "";
            double Altura = 0;
            string AlturaString = "";
            double LongitudLado = 0;
            string LongitudLadoString = "";
            double Radio = 0;
            string RadioString = "";


            Console.WriteLine("Introduce el valor de la base");
            BaseString = Console.ReadLine();
            Base = Convert.ToDouble(BaseString);

            Console.WriteLine("Introduce el valor de la altura");
            AlturaString = Console.ReadLine();
            Altura = Convert.ToDouble(AlturaString);

            Console.WriteLine("Introduce el valor de cualquier lado del cuadrado");
            LongitudLadoString = Console.ReadLine();
            LongitudLado = Convert.ToDouble(LongitudLadoString);

            Console.WriteLine("Introduce el valor del radio");
            RadioString = Console.ReadLine();
            Radio = Convert.ToDouble(RadioString);


            AreaCirculo Circulo = new AreaCirculo();
            Circulo.setRadio(Radio);
            Console.WriteLine("El area del circulo es = {0}", Circulo.getAreaCirculo());
            Circulo.Area(5);
            Console.WriteLine("");

            AreaTriangulo Triangulo = new AreaTriangulo();
            Triangulo.setBase(Base);
            Triangulo.setAltura(Altura);
            Console.WriteLine("El area del triangulo es = {0}", Triangulo.getAreaTriangulo());
            Triangulo.Area(6, 7);
            Console.WriteLine("");

            AreaCuadrado Cuadrado = new AreaCuadrado();
            Cuadrado.setLongitudLado(LongitudLado);
            Console.WriteLine("El area del cuadrado es = {0}", Cuadrado.getAreaCuadrado());
            Cuadrado.Area(8);
            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}
