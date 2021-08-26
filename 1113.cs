using System;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {

             int.TryParse(Console.ReadLine(), out int X);
             int.TryParse(Console.ReadLine(), out int Y);

            while (X != Y)
            {
                if(X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if(Y > X)
                {
                    Console.WriteLine("Crescente");
                }
                int.TryParse(Console.ReadLine(), out  X);
                int.TryParse(Console.ReadLine(), out  Y);
            }

        }
    }
}
