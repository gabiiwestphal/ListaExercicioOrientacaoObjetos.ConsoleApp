using System;

namespace Exercicio7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario1 = new Salario();

            salario1.salarioBase = 1000;
            salario1.totalDeVendas = 100;

            Console.WriteLine(" digite o percentual de comissão das vendas: ");
            salario1.comissao = Decimal.Parse(Console.ReadLine());

            Console.WriteLine(" A comissão é de : " + salario1.CalcularSalarioTotal());
             
        }
    }
}
