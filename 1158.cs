using System;

namespace _1158 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int X, Y;
            int soma = 0, cont = 0;

            for (int i = 0; i < N; i++) {
                cont = 0;
                soma = 0;
                string line = Console.ReadLine();
                string[] vet1 = line.Split(' ');
                int.TryParse(vet1[0], out X);
                int.TryParse(vet1[1], out Y);

                while (cont < Y) {
                    if (X % 2 != 0) {
                        soma += X;
                        cont++;
                    }
                    X++;
                }
                Console.WriteLine(soma);
            }
        }
    }
}
