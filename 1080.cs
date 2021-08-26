using System;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 1;

            for(int i = 1; i <= 100; i++)
            {
                int.TryParse(Console.ReadLine(), out int num);
                if (num == 1)
                {
                    maior = num;
                    posicao = 1;
                }
                else if (num > maior)
                {
                    maior = num;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);

        }
    }
}
