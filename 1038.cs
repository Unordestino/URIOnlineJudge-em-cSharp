using System;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int Y);
            double.TryParse(Console.ReadLine(), out double X);

            switch (Y)
            {
                case 1:
                    X *= 4.00;
                    break;

                case 2:
                    X *= 4.50;
                    break;

                case 3:
                    X *= 5.00;
                    break;

                case 4:
                    X *= 2.00;
                    break;

                case 5:
                    X *= 1.50;
                    break;

            }

            Console.WriteLine("Total: R$ {0:F2}", X);

        }
    }
}
