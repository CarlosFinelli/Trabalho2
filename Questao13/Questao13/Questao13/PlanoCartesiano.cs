using System;
using System.Collections.Generic;
using System.Text;

namespace Questao13
{
    class PlanoCartesiano
    {
        public double x;
        public double y;

        public String Quadrante()
        {
            if (x > 0 && y > 0)
            {
                return "Q1";
            }
            if (x > 0 && y <0)
            {
                return "Q4";
            }
            if (x < 0 && y < 0)
            {
                return "Q3";
            }
            if (x < 0 && y > 0)
            {
                return "Q2";
            }
            if (x == 0 && y == 0)
            {
                return "Origem";
            }
            return "";
        }
    }
}
