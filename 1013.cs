using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int.TryParse(Console.ReadLine(), out int A);
            int.TryParse(Console.ReadLine(), out int B);
            int.TryParse(Console.ReadLine(), out int C);

            if(A > maior)
            {
                maior = A;
            }
            if(B > maior)
            {
                maior = B;
            }
            if(C > maior)
            {
                maior = C;
            }

            Console.WriteLine("{0} eh o maior", maior);
        }

    }
}
