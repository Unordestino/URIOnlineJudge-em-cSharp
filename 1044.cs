using System;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux, A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            if(A < B)
            {
                aux = A;
                A = B;
                B = aux;
            }
            if (A % B == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
