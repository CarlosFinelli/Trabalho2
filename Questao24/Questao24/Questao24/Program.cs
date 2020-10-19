using System;

namespace Questao24
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Digite um número: ");
            N = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            for (var i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
