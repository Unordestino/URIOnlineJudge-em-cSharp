using System;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double resul;

            int.TryParse(Console.ReadLine(), out int horas);
            int.TryParse(Console.ReadLine(), out int km);

            resul = km * horas;
            Console.WriteLine("{0:F3}", resul / 12);
        }
    }
}
