using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7.ConsoleApp
{
    internal class Salario
    {
        public decimal salarioBase;
        public decimal totalDeVendas;
        public decimal comissao;



        public decimal CalcularSalarioTotal()
        {
            decimal total = salarioBase + (totalDeVendas * comissao);
            return total;
        }
    }
}
