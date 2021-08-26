using System;

namespace _1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int X);
            int.TryParse(Console.ReadLine(), out int Y);

            while(X != 0 && Y != 0)
            {
                if (X == 0 || Y == 0) break;

                else if (Y > 0 && X > 0) Console.WriteLine("primeiro");

                else if (Y > 0 && X < 0) Console.WriteLine("segundo");

                else if (Y < 0 && X < 0) Console.WriteLine("terceiro");

                else if (Y < 0 && X > 0) Console.WriteLine("quarto");

                int.TryParse(Console.ReadLine(), out  X);
                int.TryParse(Console.ReadLine(), out  Y);
            }


        }
    }
}
