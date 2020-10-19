using System;

namespace Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanoCartesiano plano = new PlanoCartesiano();
            Console.Write("Insira o valor de X: ");
            plano.x = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de Y: ");
            plano.y = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(plano.Quadrante());
            Console.ReadKey();
        }
    }
}
