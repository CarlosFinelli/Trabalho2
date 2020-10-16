using System;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Digite um número: ");
            numero.num = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(numero.Intervalo());
            Console.ReadKey();
        }
    }
}
