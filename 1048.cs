using System;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double salario);
            string porc = "";
            double novoSalario = 0;
            double resjuste = 0;

            if(salario >= 0 && salario <= 400.00) 
            {
                porc = "15%";
                resjuste = salario * 0.15;
                novoSalario = salario + resjuste;

            }

            else if(salario <= 800.00)
            {
                porc = "12%";
                resjuste = salario * 0.12;
                novoSalario = salario + resjuste;
            }

            else if(salario <= 1200.00)
            {
                porc = "10%";
                resjuste = salario * 0.10;
                novoSalario = salario + resjuste;

            }


           else if(salario <= 2000.00)
            {
                porc = "7%";
                resjuste = salario * 0.7;
                novoSalario = salario + resjuste;

            }          
            
            
            else if(salario > 2000.00)
            {
                porc = "4%";
                resjuste = salario * 0.4;
                novoSalario = salario + resjuste;

            }



            Console.WriteLine($"Novo salario: {novoSalario:N2}");
            Console.WriteLine($"Reajuste ganho: {resjuste:N2}");
            Console.WriteLine($"Em percentual: {porc}");

        }
    }
}
