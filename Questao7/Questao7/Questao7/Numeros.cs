using System;
using System.Collections.Generic;
using System.Text;

namespace Questao7
{
    class Numeros
    {
        public double num;

        public String VerificaNumero()
        {
            if (num > 0)
            {
                return "NÃO NEGATIVO";
            } else
            {
                return "NEGATIVO";
            }
        }
    }
}
