using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.ConsoleApp
{
    internal class Conversor_FahrenheitToCelsius
    {
        public double grausfahrenheit; 

        public double ConverterParaCelsius()
        {
            double celsius = ( grausfahrenheit - 32 ) / 1.8;
            return celsius;
        }
    }
}
