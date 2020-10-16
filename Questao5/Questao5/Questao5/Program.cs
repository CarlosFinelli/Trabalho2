using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pecas pecas = new Pecas();
            Console.Write("Insira o código da peça 1: ");
            pecas.cod1 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o número de peças que irá comprar: ");
            pecas.num1 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o preço unitário da peça: ");
            pecas.preco1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o código da peça 2: ");
            pecas.cod2 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o número de peças que irá comprar: ");
            pecas.num2 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o preço unitário da peça: ");
            pecas.preco2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Valor total a pagar: R${pecas.Valor()}");
            Console.ReadKey();
        }
    }
}
