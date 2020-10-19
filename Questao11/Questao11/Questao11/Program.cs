using System;
using System.Collections.Generic;

namespace Questao11
{
    class Program
    {
        static List<Menu> menu;
        static void Main(string[] args)
        {

            Menu compra = new Menu();
            menu = new List<Menu>();

            menu.Add(new Menu(1, "Cachorro Quente", 4.00));
            menu.Add(new Menu(2, "X-Salada", 4.50));
            menu.Add(new Menu(3, "X-Bacon", 5.00));
            menu.Add(new Menu(4, "Torrada Simples", 2.00));
            menu.Add(new Menu(5, "Refrigerante", 1.50));
            Console.Write("Por favor, insira código do item que deseja comprar: ");
            compra.compra = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira a quantidade que deseja comprar: ");
            compra.qtd = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"O valor total a ser pago é: {compra.Total()}");

        }
        
    }
}
