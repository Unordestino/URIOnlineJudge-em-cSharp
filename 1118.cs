using System;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            double soma;
            double nota1 = 0;
            double nota2 = 0;
            int cont;

            while (X != 2)
            {
                cont = 0;
                soma = 0;

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

                Console.WriteLine($"media = {soma / 2:N}");

                Console.WriteLine("novo calculo (1-sim 2-nao)");

                int.TryParse(Console.ReadLine(), out X);

                while(X != 1 && X != 2)
                {
                Console.WriteLine("novo calculo (1-sim 2-nao)");

                int.TryParse(Console.ReadLine(), out X);
                }

            }

        }
    }
}
