using System;

namespace _1151 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int N);
            int proximo, anterior = 0, atual = 1;
            for (int i = 1; i <= N; i++) {
                if (i == N) Console.WriteLine(anterior);
                else Console.Write(anterior + " ");
                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
                             
            }
        }
    }
}
