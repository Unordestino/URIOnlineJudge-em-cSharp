using System;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int entrada);
            int cont = 1;
           
            while(cont <= 6)
            {
                if(entrada % 2 != 0)
                {
                    cont++;
                    Console.WriteLine(entrada);
                }
                entrada++;
            }
        }
    }
}
