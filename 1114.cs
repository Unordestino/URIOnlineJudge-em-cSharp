using System;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            // int.TryParse(Console.ReadLine(), out int senha);

            int senha = 0;

            do
            {
                int.TryParse(Console.ReadLine(), out senha);
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }


            } while (senha != 2002);



        }
    }
}
