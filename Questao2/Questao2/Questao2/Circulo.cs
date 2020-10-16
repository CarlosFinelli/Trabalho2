using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class Circulo
    {
        public double r, area;
        public double Pi = 3.14159;

        public double Area()
        {
            area = Pi * Math.Pow(r, 2);
            return Math.Round(area, 4);
        }
    }
}
