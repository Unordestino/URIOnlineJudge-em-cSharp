using System;

namespace _1182 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int C);
            double soma = 0;

            char.TryParse(Console.ReadLine().ToUpper(), out char T);
            double[,] M = new double[12, 12];

            for (int i = 0; i <12; i++) {
                for (int j = 0; j < 12; j++) {
                    M[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 12; i++) {
                soma += M[i, C];
            }


            if (T == 'M') soma /= 12;
            Console.WriteLine(soma.ToString("F1"));

        }
    }
}
