using System;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int num1);
            int.TryParse(Console.ReadLine(), out int num2);
            int soma = 0;

            if(num1 < num2)
            {
                for(int i = num1 + 1; i < num2; i++)
                {
                    if(i%2 !=0)
                    {
                        soma+= i;
                    }
                }
            }
            else
            {
                for(int i = num2+1; i < num1; i++)
                {
                    if(i%2 != 0)
                    {
                        soma += i;
                    }
                }
            }

            Console.WriteLine((uint)soma);

        }
    }
}
