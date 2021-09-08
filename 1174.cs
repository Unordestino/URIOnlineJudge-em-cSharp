using System;

namespace _1174 {
    class Program {
        static void Main(string[] args) {
            double[] A = new double[100];
            for (int i = 0; i < A.Length; i++) {
                A[i] = double.Parse(Console.ReadLine());
                if (A[i] <= 10) {
                    Console.WriteLine($"A[{i}] = {A[i].ToString("F1")}");
                }
            }
        }
    }
}
