using System;

namespace Questao15
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            while (senha != 2002)
            {
                Console.WriteLine("senha Inválida");
                Console.Write("Insira a senha: ");
                senha = Convert.ToInt16(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Acesso Permitido");
            Console.ReadKey();
        }
    }
}
