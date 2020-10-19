using System;

namespace Questao19
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros numero = new Numeros();
            Console.Write("Insira o número de números que deseja inserir: ");
            numero.N = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < numero.N; i++)
            {
                Console.WriteLine("Insira um número: ");
                numero.num = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                numero.Calculo();
            }
            Console.WriteLine($"In: {numero.A}");
            Console.WriteLine($"Out: {numero.B}");
        }
    }
}
