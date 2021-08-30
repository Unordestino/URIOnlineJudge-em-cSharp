using System;

namespace _1153 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int N);
            int resul = 1;
            for (int i = N; i >= 1; i--) {
                resul *= i;
            }
                Console.WriteLine(resul);
        }
    }
}
