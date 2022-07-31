using System;

namespace BEE_1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
