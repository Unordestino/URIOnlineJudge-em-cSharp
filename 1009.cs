using System;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        { 
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double venda = double.Parse(Console.ReadLine());
            double aux =  ((venda * 15) / 100) + salario;
            Console.WriteLine("TOTAL = R$ {0:F2}", aux);
        }
    }
}
