using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6.ConsoleApp
{
    internal class Conversor_CelsiusToFahrenheit
    {
        public double grausCelsius;

        public double ConverterParaFahrenheit()
        {
            double fahrenheit = grausCelsius * (9 / 5) + 32;
            return fahrenheit;
        }
    }
}
