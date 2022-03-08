using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro1 = new Cilindro();

            cilindro1.altura = 5;
            cilindro1.raioDaBase = 4;

            Console.WriteLine(" O volume do cilindro é: " + cilindro1.ObtemVolume() + "cm");

        }
    }
}
