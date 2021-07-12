using System;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int quant);
            int dentro = 0;
            int fora = 0;
            int N;

            for(int i = 0; i < quant; i++)
            {
                N = int.Parse(Console.ReadLine());

                if(N >= 10 && N <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");

        }
    }
}
