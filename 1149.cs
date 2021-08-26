using System;

namespace _1149 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int A);
            int.TryParse(Console.ReadLine(), out int N);
            int soma = 0;

            while (N <= 0) {
                int.TryParse(Console.ReadLine(), out N);
            }
            for (int i = 1; i <= N; i++) {
                soma += A;
                A++;
            }
            Console.WriteLine(soma);

        }
    }
}
