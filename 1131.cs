using System;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int General = 0;
            int op = 1;
            int empate = 0;
            int golInter = 0;
            int golGremio = 0;

            while (op == 1)
            {
                int.TryParse(Console.ReadLine(), out int inter);
                int.TryParse(Console.ReadLine(), out int gremio);

                General++;

                if(inter > gremio)
                {
                    golInter++;
                }
                else if (gremio > inter)
                {
                    golGremio++;
                }
                else
                {
                    empate++;
                }

                Console.WriteLine("Novo grenal(1 - sim 2 - nao)");
                int.TryParse(Console.ReadLine(), out op);

                while (op != 1 && op != 2)
                {
                    Console.WriteLine("Novo grenal(1 - sim 2 - nao)");
                    int.TryParse(Console.ReadLine(), out op);
                }
            }

            Console.WriteLine($"{General} grenais");
            Console.WriteLine($"Inter:{golInter}");
            Console.WriteLine($"Gremio:{golGremio}");
            Console.WriteLine($"Empates:{empate}");
            
            if(golInter > golGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if(golGremio > golInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}
