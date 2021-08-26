using System;

namespace _1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            while (X != 0) {
               
                for (int i = 1; i <= X; i++) {
                    if (i == X) {
                        Console.Write(i + "\n");
                    } else {
                        Console.Write(i + " ");
                    }
                }
                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
