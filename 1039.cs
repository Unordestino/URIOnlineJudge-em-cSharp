using System;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double exame = 0;
            double.TryParse(Console.ReadLine(), out double N1);
            double.TryParse(Console.ReadLine(), out double N2);
            double.TryParse(Console.ReadLine(), out double N3);
            double.TryParse(Console.ReadLine(), out double N4);
            double media;

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4) / 10;

            Console.WriteLine("Media: {0}",media);

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0)
            {
                Console.Write("Nota do exame: ");
                exame = double.Parse(Console.ReadLine());


                if (exame + media / 2.0 > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
            Console.WriteLine("Media final: {0}",(exame + media) / 2.0);

            }

            else
            {
                Console.WriteLine("Aluno reprovado.");
            }





        }
    }
}
