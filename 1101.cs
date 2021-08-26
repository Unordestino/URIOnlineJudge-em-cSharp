using System;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            while(m > 0 && n > 0)
            {

                if(m > n)
                {
                     for(int i = n; i <= m; i++)
                     {
                        soma += i;
                        Console.Write(i + " ");

                      }
                }
                else
                {
                    for (int i = m; i <= n; i++)
                    {
                        soma += i;
                        Console.Write(i + " ");
                       

                    }

                }

                Console.WriteLine("Soma=" + soma);
                m = int.Parse(Console.ReadLine());
                n = int.Parse(Console.ReadLine());
                soma = 0;
            }
        }
    }
}
