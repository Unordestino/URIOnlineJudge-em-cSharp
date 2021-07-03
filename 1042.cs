using System;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double A);
            double.TryParse(Console.ReadLine(), out double B);
            double.TryParse(Console.ReadLine(), out double C);

            if(A + B > C && A + C > B && B + C > A)
            {
                Console.WriteLine("Perimetro = {0:F1}", A + B + C);
            }
            else
            {
                Console.WriteLine("Area = {0:F1}", ( (A + B) * C) /2);
            }


        }
    }
}
