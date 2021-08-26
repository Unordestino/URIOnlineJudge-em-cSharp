using System;

namespace _1150 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int X);
            int.TryParse(Console.ReadLine(), out int Z);
            int soma = 0;
            int cont = 0;


            while (Z <= X) {
            int.TryParse(Console.ReadLine(), out Z);

            }
            while (soma < Z) {
                soma += X;
                cont++;
                X++;
            }
            Console.WriteLine(cont);
        }
    }
}
