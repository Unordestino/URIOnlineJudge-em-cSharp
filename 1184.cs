using System;

namespace _1184 {
    class Program {
        static void Main(string[] args) {
            char.TryParse(Console.ReadLine().ToUpper(), out char T);
            double soma = 0;
            double[,] M = new double[12, 12];

            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    M[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    if (j < i) soma += M[i, j];
                }
            }


            if (T == 'M') soma /= ((12 * 12) - 12) / 2;
            Console.WriteLine(soma.ToString("F1"));

        }
    }
}
