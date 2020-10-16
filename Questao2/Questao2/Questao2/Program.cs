using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            Console.Write("Insira o valor do Raio: ");
            circulo.r = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"A = {circulo.Area()}");
        }
    }
}
