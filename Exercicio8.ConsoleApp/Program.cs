using System;

namespace Exercicio8.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lataDeOleoVerniz = new LataDeOleo();

            lataDeOleoVerniz.altura = 12;
            lataDeOleoVerniz.raioDaBase = 3;

            Console.WriteLine(" O volume da lata de óleo é: " + lataDeOleoVerniz.ObtemVolume());
        }
    }
}
