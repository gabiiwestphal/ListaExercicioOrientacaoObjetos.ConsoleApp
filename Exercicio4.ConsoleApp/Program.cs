using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro1 = new Veiculo();

            carro1.kmInicial = 20;
            carro1.kmFinal = 120;
            carro1.qtdCombustivel = 40;

            Console.WriteLine(" O consumo de combustível do carro por 100 km foi: " + carro1.CalcularConsumo() + " litros");
        }
    }
}
