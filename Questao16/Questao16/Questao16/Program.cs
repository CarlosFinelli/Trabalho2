using System;

namespace Questao16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y = 1;
            while (x != 0 && y != 0)
            {
                Console.Write("Insira o valor de X: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Insira o valor de Y: ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                Console.ReadKey();
            }
        }
    }
}
