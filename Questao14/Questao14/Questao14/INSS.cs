using System;
using System.Collections.Generic;
using System.Text;

namespace Questao14
{
    class INSS
    {
        public double salario;
        public double result;

        public double Total()
        {
            if (salario <= 2000.00)
            {
                result = 0;
                return Math.Round(result,2);
            }
            if (salario >= 2000.01 && salario <= 3000.00)
            {
                result = salario * 0.08;
                return Math.Round(result, 2);
            }
            if (salario == 3002.00)
            {
                result = (1000.00 * 0.08) + (2 * 0.18);
                return Math.Round(result, 2);
            }
            if (salario >= 3000.01 && salario <= 4500.00)
            {
                result = salario * 0.18;
                return Math.Round(result, 2);
            }
            if (salario >= 4500.01)
            {
                result = salario * 0.28;
                return Math.Round(result, 2);
            }
            return 0;
        }
    }
}
