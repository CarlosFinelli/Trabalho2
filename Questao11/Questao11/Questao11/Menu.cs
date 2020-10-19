using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Questao11
{
    public class Menu
    {
        public Menu() {}

        public int Cod { get; set; }
        public String Item { get; set; }
        public double Valor { get; set; }

        public int compra;
        public int qtd;

        public Menu(int cod, String item, double valor)
        {
            this.Cod = cod;
            this.Item = item;
            this.Valor = valor;
        }

        public double Total()
        {
            Menu menu = new Menu();
            if (compra == Cod)
            {
                double total = qtd * Valor;
                return total;
            }
            if (compra != Cod)
            {
                Console.WriteLine("Código do produto inválido");
                return 0;
            }
            return 0;
        }
    }
}
