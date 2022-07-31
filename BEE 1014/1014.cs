using System;
using System.Globalization;
namespace BEE_1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Kml = (x / y);

            Console.WriteLine(Kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
