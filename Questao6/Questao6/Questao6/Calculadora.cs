using System;
using System.Collections.Generic;
using System.Text;

namespace Questao6
{
    class Calculadora
    {
        public double A, B, C;
        private double Pi = 3.14159;

        public double AreaTriangulo()
        {
            double area = (A * C) / 2;
            return Math.Round(area, 3);
        }

        public double AreaCirculo()
        {
            double area = Pi * (Math.Pow(C, 2));
            return Math.Round(area, 3);
        }

        public double AreaTrapezio()
        {
            double area = ((A + B) / 2) * C;
            return Math.Round(area, 3);
        }

        public double AreaQuadrado()
        {
            double area = Math.Pow(B, 2);
            return Math.Round(area, 3);
        }
        public double AreaRetangulo()
        {
            double area = A * B;
            return Math.Round(area, 3);
        }
    }
}
