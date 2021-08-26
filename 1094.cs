using System;

namespace _1094
{
    class Program
    {
        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int QuantidadeDeCasos);

            int C = 0, R = 0, S = 0;
            int TotalAnimais = 0;

            for(int i = 0; i < QuantidadeDeCasos; i++)
            {

                int.TryParse(Console.ReadLine(), out int QuantidadeDeAnimais);
                char.TryParse(Console.ReadLine(), out char TipoAnimal);

                if(TipoAnimal == 'C')
                {
                    C += QuantidadeDeAnimais;
                }
                else if(TipoAnimal == 'R')
                {
                    R += QuantidadeDeAnimais;
                }
                else
                {
                    S += QuantidadeDeAnimais;
                }

                TotalAnimais += QuantidadeDeAnimais;


            }

            double porc;

            Console.WriteLine($"Total: {TotalAnimais} cobaias");
            Console.WriteLine($"Total de coelhos: {C}");
            Console.WriteLine($"Total de ratos: {R}");
            Console.WriteLine($"Total de sapos: {S}");

            porc = (C * 100) / TotalAnimais;
            Console.WriteLine($"Percentual de coelhos: {porc:N2} %");
            porc = (R * 100) / TotalAnimais;
            Console.WriteLine($"Percentual de ratos: {porc:N2} %");
            porc = (S * 100) / TotalAnimais;
            Console.WriteLine($"Percentual de sapos: {porc:N2} %");




        }
    }
}
