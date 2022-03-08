using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8.ConsoleApp
{
    internal class LataDeOleo
    {
        public decimal altura;
        public decimal raioDaBase;

        public decimal ObtemVolume()
        {
            decimal volume = altura * (Math.PI * (raioDaBase * raioDaBase));
            return volume;
        }
    }
}
