using System;

namespace _1179 {
    class Program {
        static void Main(string[] args) {
            int[] par = new int[5];
            int[] impar = new int[5];
            int X, contPar = 0, contImpar = 0;


            for (int i = 0; i < 15; i++) {

                X = int.Parse(Console.ReadLine());

                if (X % 2 == 0) {
                    par[contPar] = X;
                    contPar++;
                } else {
                    impar[contImpar] = X;
                    contImpar++;
                }
               
                if (contPar == 5) {
                    contPar = 0;
                    for (int j = 0; j < par.Length; j++) {
                        Console.WriteLine("par[" + j + "] = " + par[j]);
                    }
                }else if (contImpar == 5) {
                    contImpar = 0;
                    for (int j = 0; j < impar.Length; j++) {
                        Console.WriteLine("impar[" + j + "] = " + impar[j]);
                    }
                }
               

            }

            for (int i = 0; i < contImpar; i++) {
                Console.WriteLine("impar[" + i + "] = " + impar[i]);
            }
            for (int i = 0; i < contPar; i++) {
                Console.WriteLine("par[" + i + "] = " + par[i]);
            }

        }
    }
}
