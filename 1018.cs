using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int divi;

            int.TryParse(Console.ReadLine(), out int entrada);

            Console.WriteLine("{0} nota(s) de R$ 100.00", entrada / 100);
            divi = entrada % 100;

            Console.WriteLine("{0} nota(s) de R$ 50.00", divi / 50);
            divi = divi % 50;

            Console.WriteLine("{0} nota(s) de R$ 20.00", divi / 20);
            divi = divi % 20;

            Console.WriteLine("{0} nota(s) de R$ 10.00", divi / 10);
            divi = divi % 10;

            Console.WriteLine("{0} nota(s) de R$ 5.00", divi / 5);
            divi = divi % 5;

            Console.WriteLine("{0} nota(s) de R$ 2.00", divi / 2);
            divi = divi % 2;

            Console.WriteLine("{0} nota(s) de R$ 1.00", divi / 1);
        }
    }
}
