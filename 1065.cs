using System;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;
            for(int i  = 1; i <= 5; i++)
            {
            int.TryParse(Console.ReadLine(), out int num);

                if(num % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if(num > 0)
                {
                    positivo++;
                }
                else if(num < 0)
                {
                    negativo++;
                }


            }

            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");

        }
    }
}
