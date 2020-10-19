using System;
using System.Collections.Generic;
using System.Text;

namespace Questao21
{
    class Calc
    {
        public int A, B;
        public double result;

        public double Divisao()
        {
            if (B == 0)
            {
                Console.WriteLine("Divisão impossível");
                return 0;
            }
            else
            {
                result = (A / B);
                return Math.Round(result, 1);
            }
            
        }
    }
}
