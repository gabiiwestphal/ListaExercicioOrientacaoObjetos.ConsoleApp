using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.ConsoleApp
{
    internal class CaixaRetangular
    {
        public decimal altura;
        public decimal largura;
        public decimal comprimento;
        public decimal ObtemVolume()
        {
            decimal volumeDaCaixa = altura * comprimento * largura;
            return volumeDaCaixa;
        }

    }
}
