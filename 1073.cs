using System;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int num);

            for(int cont = 1; cont <= num; ++cont)
            {
                if(cont % 2 == 0)
                {
                    Console.WriteLine($"{cont}^2 = {cont * cont}");
                }
            }


        }
    }
}
