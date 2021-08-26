using System;

namespace _1132 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int X);
            int.TryParse(Console.ReadLine(), out int Y);
            int soma = 0;

            if (X > Y) {
                for (int i = Y; i <= X; i++) {
                    if (i % 13 != 0) soma += i;
                }
            }
            else {
                for (int i = X; i <= Y; i++) {
                    if (i % 13 != 0) soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
