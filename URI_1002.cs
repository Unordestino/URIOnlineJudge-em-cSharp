using System;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double A;
            double R = double.Parse(Console.ReadLine());
            A = n * (R * R);
            Console.WriteLine("A={0:F4}", A);
            Console.ReadKey();
            
        }
    }
}
