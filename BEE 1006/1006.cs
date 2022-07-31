using System;
using System.Globalization;
namespace BEE_1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MEDIA = (A * 2 + B * 3 + C * 5) / 10;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
