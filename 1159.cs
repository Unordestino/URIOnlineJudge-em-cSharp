using System;

namespace _1159 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            while (x != 0) {
                int cont = 0;
                int soma = 0;

                while (cont < 5) {
                    if (x % 2 == 0) {
                        soma += x;
                        cont++;
                    }
                    x++;
                }
                Console.WriteLine(soma);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}

