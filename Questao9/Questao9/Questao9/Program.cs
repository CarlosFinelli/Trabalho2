using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Insira um número: ");
            numero.num1 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira outro número: ");
            numero.num2 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(numero.VerificaMultiplo());
            Console.ReadKey();
        }
    }
}
