using System;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int quant);
            int N;

            for(int i = 0; i < quant; i++)
            {
                N = int.Parse(Console.ReadLine());
                if(N > 0)
                {
                    if(N % 2 != 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                }
                else if(N < 0)
                {
                    if(N % 2 != 0)
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }

                }
                else
                {
                    Console.WriteLine("NULL");
                }


            }



        }
    }
}
