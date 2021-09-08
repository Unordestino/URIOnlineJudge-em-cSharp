using System;

namespace _1175 {
    class Program {
        static void Main(string[] args) {
            int[] N = new int[20];
            int[] M = new int[20];
            int inverso = N.Length - 1;
            for (int i = 0; i < N.Length; i++) {
                N[i] = int.Parse(Console.ReadLine());
                M[inverso] = N[i];
                inverso--;
            }

            for (int i = 0; i < N.Length; i++) {
                Console.WriteLine($"N[{i}] = {M[i]}");            
            }

        }
    }
}
