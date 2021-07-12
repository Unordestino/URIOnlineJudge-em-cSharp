using System;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int positivos = 0;
            while (cont <= 6)
            {
                double.TryParse(Console.ReadLine(), out double num);
                if(num >= 0)
                {
                    positivos += 1;
                }
                cont += 1;
            }


            Console.WriteLine($"{positivos} valores positivos");


        }
    }
}
