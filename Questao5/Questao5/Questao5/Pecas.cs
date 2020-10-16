using System;
using System.Collections.Generic;
using System.Text;

namespace Questao5
{
    class Pecas
    {
        public int cod1, cod2, num1, num2;
        public double preco1, preco2;
        public double valorTotal;

        public double Valor()
        {
            valorTotal = (num1 * preco1) + (num2 * preco2);
            return Math.Round(valorTotal, 2);
        }
    }
}
