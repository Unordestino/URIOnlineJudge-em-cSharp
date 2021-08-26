using System;

namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0;
            double nota2 = 0;
            double soma = 0;
            int cont = 0;
            while (cont < 2)
            {
                double.TryParse(Console.ReadLine(), out nota1);
                double.TryParse(Console.ReadLine(), out nota2);

                if (nota1 >= 0 && nota1 <= 10)
                {
                    soma += nota1;
                    cont++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

                if (nota2 >= 0 && nota2 <= 10)
                {
                    soma += nota2;
                    cont++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            Console.WriteLine($"media = {soma/2:N2}");

        }
    }
}
