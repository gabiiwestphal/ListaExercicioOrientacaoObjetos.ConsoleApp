using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa1 = new CaixaRetangular();

            caixa1.altura = 10;
            caixa1.largura = 10;
            caixa1.comprimento = 10;

            Console.WriteLine(" O volume da caixa é: " + caixa1.ObtemVolume());

        }
    }
}
