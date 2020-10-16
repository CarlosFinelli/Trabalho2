using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.Write("Insira o valor de A: ");
            calculadora.A = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de B: ");
            calculadora.B = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor de C: ");
            calculadora.C = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Triangulo: {calculadora.AreaTriangulo()}");
            Console.WriteLine($"Circulo: {calculadora.AreaCirculo()}");
            Console.WriteLine($"Trapezio: {calculadora.AreaTrapezio()}");
            Console.WriteLine($"Quadrado: {calculadora.AreaQuadrado()}");
            Console.WriteLine($"Retangulo: {calculadora.AreaRetangulo()}");
            Console.ReadKey();
        }
    }
}
