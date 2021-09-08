using System;

namespace _1172 {
    class Program {
        static void Main(string[] args) {
            int[] x = new int[10];
            for (int i = 0; i < x.Length; i++) {
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < x.Length; i++) {
                if (x[i] < 1) x[i] = 1;
                Console.WriteLine($"X[{i}] = {x[i]}");
            }
        }
    }
}
