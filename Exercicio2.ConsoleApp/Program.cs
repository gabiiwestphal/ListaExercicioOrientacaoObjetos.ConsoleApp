using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor_FahrenheitToCelsius valor = new Conversor_FahrenheitToCelsius();

            valor.grausfahrenheit = 32;

            Console.WriteLine( " 32° fahrenheit é igual a " + valor.ConverterParaCelsius() + "° celsius");
        }
    }
}
