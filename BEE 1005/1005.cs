using System;
using System.Globalization;
namespace BEE_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NOTA1, NOTA2;
            NOTA1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            NOTA2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MEDIA = (NOTA1 * 3.5 + NOTA2 * 7.5) / 11;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
