using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5.ConsoleApp
{
    internal class Esfera
    {
        public double raio;

        public double VolumeDaEsfera()
        {
            double volume = ( 4 / 3 ) * Math.PI * Math.Pow(raio, 3);
            return volume;
        }
    }
}
