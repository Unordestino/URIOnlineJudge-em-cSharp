using System;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int X);
            int.TryParse(Console.ReadLine(), out int Y);

                for (int i = 1; i <= Y; i++)
                {

                Console.Write(i);
                if (i % X == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
