using System;

namespace BEE_1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            int diferença = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + diferença);
        }
    }
}
