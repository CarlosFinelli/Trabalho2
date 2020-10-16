using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogos jogos = new Jogos();
            Console.Write("Insira o horário do jogo 1: ");
            jogos.hora1 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o horário do jogo 2: ");
            jogos.hora2 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"O jogo durou {jogos.Tempo()} horas");
        }
    }
}
