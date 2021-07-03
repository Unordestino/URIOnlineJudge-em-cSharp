using System;

namespace _1022
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int A);
            int.TryParse(Console.ReadLine(), out int B);
            int.TryParse(Console.ReadLine(), out int C);
            int.TryParse(Console.ReadLine(), out int D);
            String test;
            test = ( (B > C) && (D > A) && (C + D) > (A + B) && (C > 0)
            && (D > 0) && (A % 2 == 0) ? "Valores Aceitos" : "Valores nao aceitos");

            Console.WriteLine(test);
        }
    }
}
