using System;

namespace _1177 {
    class Program {
        static void Main(string[] args) {
            int[] N = new int[1000];
            int.TryParse(Console.ReadLine(), out int T);
            int pos = 0;
            while(pos < 999) {
                for (int j = 0; j < T; j++) {
                    if (pos > 999) break;
                    N[pos] = j;
                    pos++;
                }
            }

            for (int i = 0; i < N.Length; i++) {
                Console.WriteLine("N[" + i + "] = " + N[i]);
            }
            
        }
    }
}
