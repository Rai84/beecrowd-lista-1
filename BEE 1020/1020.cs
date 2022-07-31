using System;

namespace BEE_1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dia, mes, ano, resto;
            n = int.Parse(Console.ReadLine());

            ano = n / 365;
            Console.WriteLine(ano + " ano(s)");
            resto = n % 365;

            mes = resto / 30;
            Console.WriteLine(mes + " mes(es)");
            resto = resto % 30;

            dia = resto % 30;
            Console.WriteLine(dia + " dia(s)");

            Console.ReadLine();
        }
    }
}
