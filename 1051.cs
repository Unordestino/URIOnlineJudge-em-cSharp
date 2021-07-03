using System;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double salario);

            if(salario >= 0 && salario <= 2000)
            {
                Console.WriteLine("Isento");
            }

            else if(salario <= 3000)
            {
                salario = salario * 0.8;
            }

            else if (salario <= 4500)
            {
                salario = salario * 0.18;
            }

            else if (salario > 4500)
            {
                salario = salario * 0.28;
            }

            Console.WriteLine("R$ {0:D2}",salario );
        }
    }
}
