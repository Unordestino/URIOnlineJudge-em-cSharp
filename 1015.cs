using System;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, resul;
            double x2, y2;

            double.TryParse(Console.ReadLine(), out x1);
            double.TryParse(Console.ReadLine(), out y1);

            double.TryParse(Console.ReadLine(), out x2);
            double.TryParse(Console.ReadLine(), out y2);

            resul = ( ( (x2 - x1) * (x2 - x1) ) + ( (y2 - y1) * (y2 - y1) ) );
             
            Console.WriteLine("{0:F4}", Math.Sqrt(resul));

        }
    }
}
