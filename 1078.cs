
using System;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {N} = {i * N}");
            }


        }
    }
}
