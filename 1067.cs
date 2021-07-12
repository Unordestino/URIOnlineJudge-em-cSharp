using System;

namespace _1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int valor);

            for(int i = 1; i <= valor; i++)
            {

                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
