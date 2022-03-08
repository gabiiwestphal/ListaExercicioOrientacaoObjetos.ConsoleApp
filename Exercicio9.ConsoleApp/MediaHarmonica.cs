using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9.ConsoleApp
{
    internal class MediaHarmonica
    {
        public int qtdElementos;


        public double CalcularMediaHarmonica()
        {
            double[] valorDeCadaElemento = new double[qtdElementos];
            double somaDoInversoDosElementos = 0;
            for (int i = 0; i < qtdElementos; i++)
            {
                Console.WriteLine($" Digite o valor do elemento { i + 1}: ");
                valorDeCadaElemento[i] = double.Parse(Console.ReadLine());

            }
            for (int i = 0; i < qtdElementos; i++)
            {
                somaDoInversoDosElementos += 1 / valorDeCadaElemento[i];

            }
            double resultado = qtdElementos / somaDoInversoDosElementos;
            return resultado;
        }
    }
}
