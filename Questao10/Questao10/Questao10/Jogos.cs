using System;
using System.Collections.Generic;
using System.Text;

namespace Questao10
{
    class Jogos
    {
        public int hora1, hora2;

        public int Tempo()
        {
            int resultado1, resultado2;
            int retorno = 0;
            if (hora1 > hora2)
            {
                resultado1 = 24 - hora1;
                resultado2 = 0 + hora2;
                retorno = resultado1 + resultado2;
            } else if (hora2 > hora1)
            {
                retorno = hora2 - hora1;
            } else if (hora1 == hora2)
            {
                retorno = 24;
            }
            return retorno;
        }
    }
}
