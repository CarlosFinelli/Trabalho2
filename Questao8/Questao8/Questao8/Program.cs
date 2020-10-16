using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Insira um número: ");
            numero.num = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(numero.VerificaPar());
            Console.ReadKey();
        }
    }
}
