using System;
using System.Collections.Generic;
using System.Text;

namespace Questao4
{
    class Funcionario
    {
        public int num, horas;
        public double valorHora, salario;

        public double Salario()
        {
            salario = valorHora * horas;
            return Math.Round(salario, 2);
        }
    }
}
