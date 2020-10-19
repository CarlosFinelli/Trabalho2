using System;
using System.Collections.Generic;
using System.Text;

namespace Questao19
{
    class Numeros
    {
        public int num, A = 0, B = 0, N;

        public void Calculo()
        {
            if (num >= 10 && num <= 20)
            {
                A++;
            } else
            {
                B++;
            }

        }
    }
}
