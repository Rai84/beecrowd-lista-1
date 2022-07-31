using System;

namespace BEE_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tempo, Velocidade;
            Tempo = int.Parse(Console.ReadLine());
            Velocidade = int.Parse(Console.ReadLine());

            double Litro;


            Litro = ((Tempo * Velocidade) / 12.0);
            Console.WriteLine(Litro.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
