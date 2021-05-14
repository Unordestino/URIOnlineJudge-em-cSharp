using System;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int X = (A * B) - (C * D);
            Console.WriteLine("DIFERENCA = {0}", X);
            Console.ReadKey();

        }
    }
}
