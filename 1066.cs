using System;

namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {

            double total = 0;
            double media;
            double toanum = 0;

            for (int i = 0; i < 6; i++)
            {
                double.TryParse(Console.ReadLine(), out double num1);

                if (num1 > 0)
                {
                    total++;
                    toanum += num1;
                }

            }
            media = toanum / total;
            Console.WriteLine($"{total} valores positivos");
            Console.WriteLine($"{media:N1}");
        }
    }
}
