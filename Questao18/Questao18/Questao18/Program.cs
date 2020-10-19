using System;

namespace Questao18
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Insira um valor: ");
            N = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            for (var i = 0; i <= N; i++ )
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
