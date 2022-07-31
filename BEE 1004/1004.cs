using System;

namespace BEE_1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
