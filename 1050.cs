using System;

namespace _1050
{
    class Program
    {
            
        static void Main(string[] args)
        {
            
            int dd;
            dd = int.Parse(Console.ReadLine());

            switch (dd)
            {
                default:
                    Console.WriteLine("DDD não encontrado");
                    break;

                case 61:
                    Console.WriteLine("Brasilia");
                    break;

                case 71:
                    Console.WriteLine("Salvador");
                    break;

                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;

                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;

                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;

                case 19:
                    Console.WriteLine("Campinas");
                    break;

                case 27:
                    Console.WriteLine("Vitria");
                    break;

                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;


            }
            
        }
    }
}
