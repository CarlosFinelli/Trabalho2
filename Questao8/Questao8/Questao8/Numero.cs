using System;
using System.Collections.Generic;
using System.Text;

namespace Questao8
{
    class Numero
    {
        public int num;

        public String VerificaPar()
        {
            if (num % 2 == 0)
            {
                return "PAR";
            }
            return "ÍMPAR";
        }
    }
}
