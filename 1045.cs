using System;

namespace _1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double A);
            double.TryParse(Console.ReadLine(), out double B);
            double.TryParse(Console.ReadLine(), out double C);

            if(A >= (B + C) || B > (A+C) || C >= (A+B))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if( (A*A) == (B*B + C*C ) || B*B == (A*A + C*C) || C*C == (A*A + B+B))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if( (A*A) > (B*B + C*C) || B*B > (A*A + C*C) || C*C > (A*A + B*B))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if( A*A < (B*B + C*C) || B*B < (A*A + C*C) || C*C < (A*A + B*B))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if(A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if( (A == B && A != C) || (A == C && A != B) || (B == C && B != A))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }


        }
    }
}
