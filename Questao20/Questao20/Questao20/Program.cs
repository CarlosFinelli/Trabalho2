using System;

namespace Questao20
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            int N;
            Console.Write("Insira o número de vezes que deseja repetir: ");
            N = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            for (var i = 0; i < N; i++)
            {
                Console.Write("Insira um valor: ");
                numero.A = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o segundo valor: ");
                numero.B = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o terceiro valor: ");
                numero.C = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Média ponderada: {numero.MediaPonderada()}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
