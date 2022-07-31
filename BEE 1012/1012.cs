using System;
using System.Globalization;
namespace BEE_1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Area = Console.ReadLine().Split(' ');

            double A = double.Parse(Area[0], CultureInfo.InvariantCulture);
            double B = double.Parse(Area[1], CultureInfo.InvariantCulture);
            double C = double.Parse(Area[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"TRIANGULO: {(A * C / 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {(3.14159 * C * C).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {((A + B) * C / 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {(B * B).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {(A * B).ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
