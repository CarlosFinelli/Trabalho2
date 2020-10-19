using System;

namespace Questao23
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Insira um número: ");
            num = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            for (var i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
