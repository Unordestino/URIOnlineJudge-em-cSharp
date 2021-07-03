using System;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {

            double triangulo, raio, trapezio, quadrado, retangulo;
            
            double.TryParse(Console.ReadLine(), out double A);

            double.TryParse(Console.ReadLine(), out double B);

            double.TryParse(Console.ReadLine(), out double C);

            triangulo = (A / 2) * C;
            Console.WriteLine("TRIANGULO: {0:F3}", triangulo);

            raio = C * C * 3.14159;
            Console.WriteLine("CIRCULO: {0:F3}", raio);

            trapezio = (A + B) * (C / 2);
            Console.WriteLine("TRAPEZIO: {0:F3}", trapezio);

            quadrado = B * B;
            Console.WriteLine("QUADRADO: {0:F3}", quadrado);

            retangulo = A * B;
            Console.WriteLine("RETANGULO: {0:F3}", retangulo);


        }
    }
}
