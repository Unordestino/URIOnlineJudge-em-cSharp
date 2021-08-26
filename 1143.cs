using System;

namespace Urion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int num1);

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    Console.Write(i + " " + i * i + " " + i * i * i);
                }
                Console.WriteLine();
            }

        }
    }
}
