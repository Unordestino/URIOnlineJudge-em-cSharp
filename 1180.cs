using System;

namespace _1180 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int N);
            int[] X = new int[N];
            int menor = 0, posicao = 0;

            for (int i = 0; i < N; i++) {
                int.TryParse(Console.ReadLine(), out X[i]);
                if (i == 0) {
                    menor = X[i];
                    posicao = i;
                }
                if (X[i] < menor) {
                    menor = X[i];
                    posicao = i;
                }
            }
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicao);
        }
    }
}
