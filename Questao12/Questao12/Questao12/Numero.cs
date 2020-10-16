using System;
using System.Collections.Generic;
using System.Text;

namespace Questao12
{
    class Numero
    {
        public int num;
        public String retorno;

        public String Intervalo()
        {
            if (num >= 0 && num < 25)
            {
                retorno = "[0, 25]";
            }
            if (num >= 25 && num < 50)
            {
                retorno = "[25, 50]";
            }
            if (num >= 50 && num < 75)
            {
                retorno = "[50, 75]";
            }
            if (num >= 75 && num <= 100)
            {
                retorno = "[75, 100]";
            }
            if (num < 0 || num > 100)
            {
                retorno = "Fora de intervalo";
            }
            return retorno;
        }

    }
}
