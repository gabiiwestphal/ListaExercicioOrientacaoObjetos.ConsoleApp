using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera1 = new Esfera();

            esfera1.raio = 10;

            Console.WriteLine(" O volume da esfera é: " + esfera1.VolumeDaEsfera() + " u.a.");
        }
    }
}
