using System;

namespace Questao14
{
    class Program
    {
        static void Main(string[] args)
        {
            INSS inss = new INSS();
            Console.Write("Insira o valor da sua renda: ");
            inss.salario = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Imposto de renda: {inss.Total()}");
        }
    }
}
