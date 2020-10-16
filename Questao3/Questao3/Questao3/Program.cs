using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.Write("Insira o valor de A: ");
            calculadora.A = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de B: ");
            calculadora.B = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de C: ");
            calculadora.C = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de D: ");
            calculadora.D = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            calculadora.Multiplicacao();
            Console.WriteLine($"Diferença: {calculadora.Diferenca()}");

        }
    }
}
