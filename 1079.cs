using System;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int quant);

            double[] result = new double[quant];

            for(int i = 0; i < quant; i++)
            {
                double.TryParse(Console.ReadLine(), out double num1);
                double.TryParse(Console.ReadLine(), out double num2);
                double.TryParse(Console.ReadLine(), out double num3);    

                result[i] = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
            }

            for(int i = 0; i < quant; i++)
            {
                Console.WriteLine($"{result[i]:N1}");
            }

        }
    }
}
