using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    internal class MediaPonderadaDaProva
    {
        public decimal nota1, peso1, nota2, peso2;

        public decimal CalculoDaMedia()
        {
            decimal media = (peso1 + nota1 + peso2 + nota2)/ (peso1 + peso2) ;
            return media;
        }

    }
}
