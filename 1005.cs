using System;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double X = (A * 3.5 + B * 7.5) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0:F5}", X);
            Console.ReadKey();
        }
    }
}
