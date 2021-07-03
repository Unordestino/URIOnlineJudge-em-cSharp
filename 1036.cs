using System;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double A);
            double.TryParse(Console.ReadLine(), out double B);
            double.TryParse(Console.ReadLine(), out double C);
            double delta = ((B * B) - (4 * A * C));

            if(delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = {0:F5}",( - B + Math.Sqrt(delta) ) / (2 * A));
                Console.WriteLine("R2 = {0:F5}",( - B - Math.Sqrt(delta) ) / (2 * A));
            }

        }
    }
}
