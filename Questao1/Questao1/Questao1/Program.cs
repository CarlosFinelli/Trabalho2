using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma = new Soma();
            Console.Write("Insira o valor de A: ");
            soma.A = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de B: ");
            soma.B = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            soma.soma();
            Console.WriteLine($"Soma = {soma.resultado}");
        }
    }
}
