using System;
using System.Globalization;

namespace _1160 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int T);

            string[] vec = new string[T];

            for (int i = 0; i < T; i++) {
              
                vec = Console.ReadLine().Split(' ');

                int PA = 0, PB = 0;  // A e B
                double G1 = 0, G2 = 0;
                int anos = 0;

                PA = int.Parse(vec[0]);
                PB = int.Parse(vec[1]);

                G1 = double.Parse(vec[2]);
                G2 = double.Parse(vec[3]);

                while (PB >= PA) {
                    PA +=(int) (PA * G1) / 100;
                    PB +=(int) (PB * G2) / 100;
                    anos++;
                    if (anos > 100) {
                        break;
                    }
                }

                if (anos > 100) {
                    Console.WriteLine("Mais de 1 seculo.");
                } else {
                    Console.WriteLine(anos + " anos.");
                }

            }

        }
    }
}
