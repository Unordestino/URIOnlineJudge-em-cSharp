using System;

namespace _1178 {
    class Program {
        static void Main(string[] args) {

            double X = double.Parse(Console.ReadLine());
            double[] N = new double[100];

            N[0] = X;

            for (int i = 1; i < N.Length; i++) {
                N[i] = N[i - 1] / 2.0000;
            }

            for (int i = 0; i < N.Length; i++) {
                Console.WriteLine($"N[{i}] = {N[i].ToString("F4")}");
            }

        }
    }
}
