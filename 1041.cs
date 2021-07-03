using System;

namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);

            if(x == 0.0 && x == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if(x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if(y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x > 0 && y < 00)
            {
                Console.WriteLine("Q4");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }


        }
    }
}
