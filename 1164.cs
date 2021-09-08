using System;

namespace _1164 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int N);
            int X = 0, soma = 0;
            for (int i = 0; i < N; i++) {
                soma = 0;
                X = int.Parse(Console.ReadLine());
                for (int j = 1; j < X; j++) {
                    if (X % j == 0) soma += j;
                }
            if (soma == X) Console.WriteLine(X + " eh perfeito");
            else Console.WriteLine(X + " nao eh perfeito");
            }
        }
    }
}
