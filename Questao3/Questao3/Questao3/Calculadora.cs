using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3
{
    class Calculadora
    {
        public double A, B, C, D;
        public double diferenca, produto1, produto2;

        public void Multiplicacao()
        {
            produto1 = A * B;
            produto2 = C * D;
        }
        public double Diferenca()
        {
            diferenca = produto1 - produto2;
            return diferenca;
        }
    }
}
