using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotal;
            double totalCombustivel;
            int.TryParse(Console.ReadLine(), out distanciaTotal);
            double.TryParse(Console.ReadLine(), out totalCombustivel);

            Console.WriteLine("{0:F3} km/l",distanciaTotal / totalCombustivel);
        }
    }
}
