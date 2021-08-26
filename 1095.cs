using System;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 60;
            for(int i = 1; j >= 0 ; i+= 3)
            {
                Console.Write($"I={i} ");
                if(j >= 0)
                {
                    Console.Write($"J={j}");
                    j -= 5;
                }
                Console.WriteLine();
            }
        }
    }
}
