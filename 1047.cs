using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            int c;
            int d;

            int aux;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            aux = ((b * 60) + d) - ((a * 60) + c);

            if (aux <= 0)

                aux += 24 * 60;
                Console.WriteLine($"O JOGO DUROUR {aux / 60} HORAS(S) E {aux % 60} MINUTOS()" );







        }
    }
}
