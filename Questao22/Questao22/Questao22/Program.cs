using System;

namespace Questao22
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatorial fatorial = new Fatorial();
            Console.Write("Insira o número que deseja o fatorial: ");
            fatorial.N = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(fatorial.calculo());

        }
    }
}
