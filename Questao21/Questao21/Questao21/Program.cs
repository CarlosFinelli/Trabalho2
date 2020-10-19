using System;

namespace Questao21
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int N;
            Console.Write("Digite o número de divisões que deseja fazer: ");
            N = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            for (var i = 0; i < N; i++)
            {
                Console.Write("Insira o primeiro valor: ");
                calc.A = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o segundo valor: ");
                calc.B = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(calc.Divisao());
                Console.WriteLine("");
                Console.WriteLine("");

            }
        }
    }
}
