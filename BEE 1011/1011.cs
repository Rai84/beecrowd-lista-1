using System;
using System.Globalization;
namespace BEE_1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4.0 / 3) * pi * raio * raio * raio;

            Console.WriteLine("VOLUME = {0}", volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
