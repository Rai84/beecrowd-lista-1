using System;
using System.Globalization;
namespace BEE_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, HoraDeTrabalho;
            double Salario, ValorDoSalario;

            Numero = int.Parse(Console.ReadLine());
            HoraDeTrabalho = int.Parse(Console.ReadLine());
            ValorDoSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = (HoraDeTrabalho * ValorDoSalario);

            Console.WriteLine("NUMBER = " + Numero);
            Console.WriteLine($"SALARY = U$ {Salario.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
