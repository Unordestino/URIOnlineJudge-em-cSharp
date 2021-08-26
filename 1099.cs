using System;

namespace _1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int leitor);

            int soma;

            for (int i = 0; i < leitor; i++)
            {
                soma = 0;
                int.TryParse(Console.ReadLine(), out int X);
                int.TryParse(Console.ReadLine(), out int Y);

                if (Y > X)
                {
                    for (int j = X + 1; j < Y; j++)
                    {
                        if (j % 2 != 0) soma += j;
                    }
                }

                else
                {
                    for (int j = Y + 1; j < X; j++)
                    {
                        if (j % 2 != 0) soma += j;
                    }
                }

                Console.WriteLine(soma);

            }
        }
    }
}
