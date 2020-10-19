using System;
using System.Collections.Generic;
using System.Text;

namespace Questao22
{
    class Fatorial
    {
        public int N, result = 1;
        public int calculo() {
            for (var i = N; i >= 1; i--)
            {
                result *= i;
            }
            return result;
         }
    }
}
