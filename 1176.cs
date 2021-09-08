using System;

namespace _1176 {
    class Program {
        static void Main(string[] args) {
            int T = int.Parse(Console.ReadLine());
            for (int j = 0; j < T; j++) {
                int N = int.Parse(Console.ReadLine());
                long anterior = 0, atual = 1, proximo;
                for (int i = 0; i < N; i++) {
                    proximo = anterior + atual;
                    anterior = atual;
                    atual = proximo;
                }
                Console.WriteLine("Fib(" + N + ") = " + anterior);
            }
        }
    }
}
