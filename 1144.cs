using System;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    Console.Write(i + " " + i * i + " " + i * i * i);
                    Console.WriteLine();
                    Console.Write($"{i} {i*i+1} {i*i*i+1}");
                }
                Console.WriteLine();
            }
        }
    }
}
