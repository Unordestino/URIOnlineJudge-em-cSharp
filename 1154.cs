using System;

namespace _1154 {
    class Program {
        static void Main(string[] args) {
            double soma =0;
            int quantidade = 0;
            int.TryParse(Console.ReadLine(), out int Idade);
            while (Idade >= 0) {
                soma += Idade;
                quantidade ++;
                int.TryParse(Console.ReadLine(), out Idade);

            }

            Console.WriteLine((soma / quantidade).ToString("F2"));
        }
    }
}
