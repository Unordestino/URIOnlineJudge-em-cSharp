using System;

namespace _1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            for(int i = 1; i < 10000; i++)
            {
                if(i % N == 2)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
