using System;
using System.Globalization;
namespace BEE_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Compra = Console.ReadLine().Split(' ');
            int Codigo = int.Parse(Compra[0]);
            int Quantidade = int.Parse(Compra[1]);
            double valor = double.Parse(Compra[2], CultureInfo.InvariantCulture);

            string[] Compra1 = Console.ReadLine().Split(' ');
            int Codigo1 = int.Parse(Compra1[0]);
            int Quantidade1 = int.Parse(Compra1[1]);
            double valor1 = double.Parse(Compra1[2], CultureInfo.InvariantCulture);

            double final = (Quantidade * valor) + (Quantidade1 * valor1);
            Console.WriteLine($"VALOR A PAGAR: R$ " + final.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
