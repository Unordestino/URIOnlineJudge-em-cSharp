using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int inicio);
            int.TryParse(Console.ReadLine(), out int termino);


            if(inicio >= termino)
            {
                Console.WriteLine($"O JOGO DUROU {24 - inicio + termino} HORAS(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {termino - inicio} HORAS(S)");
            }


        }
    }
}
