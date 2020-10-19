using System;

namespace Questao17
{
    class Program
    {
        static void Main(string[] args)
        {
            int Gasolina = 0, Alcool = 0, Diesel = 0;
            int opcao = 0;
            while (opcao != 4)
            {
                Console.WriteLine("1 = Alcool");
                Console.WriteLine("2 =  Gasolina");
                Console.WriteLine("3 = Diesel");
                Console.WriteLine("4 = Fim");
                Console.WriteLine("");
                Console.Write("Insira sua opção: ");
                opcao = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (opcao == 1)
                {
                    Alcool++;
                }
                if (opcao == 2)
                {
                    Gasolina++;
                }
                if (opcao == 3)
                {
                    Diesel++;
                }
                if (opcao > 4 || opcao == 0)
                {
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Muito obrigado.");
            Console.WriteLine("");
            Console.WriteLine($"Alcool: {Alcool}");
            Console.WriteLine($"Gasolina: {Gasolina}");
            Console.WriteLine($"Diesel: {Diesel}");
            Console.ReadKey();
        }
    }
}
