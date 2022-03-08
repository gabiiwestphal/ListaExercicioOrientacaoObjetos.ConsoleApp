using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.ConsoleApp
{
    internal class Veiculo
    {
        public decimal kmInicial;
        public decimal kmFinal;
        public decimal qtdCombustivel;

        public decimal CalcularConsumo()
        {
            decimal consumo = qtdCombustivel / (kmFinal - kmInicial);
            return consumo;
        }
    }
}
