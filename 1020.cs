using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, entrada;

            entrada = int.Parse(Console.ReadLine());

            ano = entrada / 365;
            entrada = entrada % 365;

            mes = entrada / 30;
            entrada = entrada % 30;

            dia = entrada;

            Console.WriteLine("{0} ano (s)", ano);
            Console.WriteLine("{0} mes (s)", mes);
            Console.WriteLine("{0} dia (s)", dia);
        }
    }
}
