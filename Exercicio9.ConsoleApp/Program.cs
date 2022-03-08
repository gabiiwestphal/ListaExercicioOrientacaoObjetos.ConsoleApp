using System;

namespace Exercicio9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica teste = new MediaHarmonica();

            teste.qtdElementos = 5;

            Console.WriteLine(" A média harmônica será: " + teste.CalcularMediaHarmonica());
        }
    }
}
