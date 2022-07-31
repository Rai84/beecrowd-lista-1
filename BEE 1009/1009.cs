using System;
using System.Globalization;
namespace BEE_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Vendedor = Console.ReadLine();
            double Salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bonus = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (bonus * 0.15) + Salario;
            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
