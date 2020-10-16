using System;
using System.Collections.Generic;
using System.Text;

namespace Questao9
{
    class Numero
    {
        public int num1, num2;

        public String VerificaMultiplo()
        {
            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                return "São Multiplos";
            }
            return "Não são Multiplos";
        }
    }
}
