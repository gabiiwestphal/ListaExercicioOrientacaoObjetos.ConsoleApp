using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.ConsoleApp
{
    internal class Cilindro
    {
        public double altura;
        public double raioDaBase;

        public double ObtemVolume()
        {
            double volume = altura * ( Math.PI * (raioDaBase * raioDaBase));
            return volume;
        }

    }
}
