using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto, segundo,hs, ed;
            int.TryParse(Console.ReadLine(), out int entrada);

            hs = 3600;

            hora = entrada / hs;
            ed = entrada % hs;

            minuto = ed / 60;
            ed = entrada % 60;

            segundo = ed ;
            
            Console.WriteLine("{0}:{1}:{2}", hora,minuto,segundo);
        }
    }
}
