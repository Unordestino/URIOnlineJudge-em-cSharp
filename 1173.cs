using System;

namespace _1173 {
    class Program {
        static void Main(string[] args) {
            int[] vec = new int[10];
            int.TryParse(Console.ReadLine(), out int cont);
            for (int i = 0; i < vec.Length; i++) {
                if (vec[i] == vec[0]) {
                    vec[0] = cont;
                    Console.WriteLine($"N[{i}] = {vec[0]}");

                } else {
                vec[i] = vec[i -1] * 2;
                Console.WriteLine($"N[{i}] = {vec[i]}");

                }
            }
        }
    }
}
