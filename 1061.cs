using System;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, diaFim, hora, horaFim, minuto, minutoFinal, segundo, segundoFinal;

            Console.Write("Dia ");
            dia = int.Parse(Console.ReadLine());

            hora = int.Parse(Console.ReadLine());
            minuto = int.Parse(Console.ReadLine());
            segundo = int.Parse(Console.ReadLine());

            Console.Write("Dia ");
            diaFim = int.Parse(Console.ReadLine());

            horaFim = int.Parse(Console.ReadLine());
            minutoFinal = int.Parse(Console.ReadLine());
            segundoFinal = int.Parse(Console.ReadLine());

            segundo = segundoFinal - segundo;
            minuto = minutoFinal - minuto;
            hora = horaFim - hora;
            dia = diaFim - dia;

            if(segundo < 0)
            {
                segundo += 60;
                minuto--;
            }
            if(minuto < 0)
            {
                minuto += 60;
                hora--;
            }
            if (hora < 0)
            {
                hora += 24;
                dia--;
            }

            Console.WriteLine("{0} dia(s)", dia);
            Console.WriteLine("{0} hora(s)", hora);
            Console.WriteLine("{0} minuto(s)", minuto);
            Console.WriteLine("{0} segundo(s)", segundo);


        }
    }
}
