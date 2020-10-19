using System;
using System.Collections.Generic;
using System.Text;

namespace Questao20
{
    class Numero
    {
        public double A, B, C;

        public double MediaPonderada()
        {
            double media = ((A * 2) + (B * 3) + (C * 5)) / 2 + 3 + 5;
            return Math.Round(media, 1);
        }
    }
}
