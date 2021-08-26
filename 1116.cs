using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            for (int i = 0; i < N; i++)
            {
                double.TryParse(Console.ReadLine(), out double X);
                double.TryParse(Console.ReadLine(), out double Y);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine($"{X / Y:N1}");
                }

            }

        }
    }
}
