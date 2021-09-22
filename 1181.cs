using System;

namespace _1181 {
    class Program {
        static void Main(string[] args) {

            double[,] M = new double[12, 12];
            int.TryParse(Console.ReadLine(), out int L);
            char.TryParse(Console.ReadLine().ToUpper(), out char T);
            double soma = 0;


            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    M[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < 12; j++) {
                soma += M[L, j];
            }

            if (T == 'M') soma /= 12;

             Console.WriteLine(soma.ToString("F1"));
        }
    }
}
