using System;

namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderadaDaProva aluno = new MediaPonderadaDaProva();

            aluno.nota1 = 10;
            aluno.peso1 = 1;
            aluno.nota2 = 8;
            aluno.peso2 = 2;

            Console.WriteLine(" A média ponderada é: " + aluno.CalculoDaMedia());
        }
    }
}
