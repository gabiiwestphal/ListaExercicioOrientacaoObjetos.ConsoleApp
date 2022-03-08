using System;

namespace Exercicio6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor_CelsiusToFahrenheit valor1 = new Conversor_CelsiusToFahrenheit();

            valor1.grausCelsius = 0;

            Console.WriteLine(" 0° celsius é igual a " + valor1.ConverterParaFahrenheit() + "° fahrenheit");




        }
    }
}
