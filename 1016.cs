using System;

namespace _1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int km);

            Console.WriteLine($"{km * 2} minutos");


        }
    }
}
