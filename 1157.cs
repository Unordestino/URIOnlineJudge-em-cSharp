using System;

namespace _1557 {
    class Program {
        static void Main(string[] args) {
            int.TryParse(Console.ReadLine(), out int N);
            bool n = true;
            for (int i = 1; i <= N; i++) {
                if (N % i == 0) {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
