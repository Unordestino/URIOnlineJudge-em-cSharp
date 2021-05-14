using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int nome = int.Parse(Console.ReadLine());
            double horas = double.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine());

            salario = salario * horas;

            Console.WriteLine("NUMBER = {0}", nome);
            Console.WriteLine("SALARY = U$ {0:F2}", salario);
            Console.ReadKey();
        }
    }
}
