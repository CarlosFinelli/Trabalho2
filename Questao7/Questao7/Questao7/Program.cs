using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros numeros = new Numeros();
            Console.Write("Insira um número: ");
            numeros.num = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(numeros.VerificaNumero());
        }
    }
}
