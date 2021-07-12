using System;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            for (int i = 1; i <= 5; i++)
            {
                int.TryParse(Console.ReadLine(), out int num);

                if (num % 2 == 0)
                {
                    cont++;
                }
            }

            Console.WriteLine($"{cont} valores pares");

        }
    }
}
