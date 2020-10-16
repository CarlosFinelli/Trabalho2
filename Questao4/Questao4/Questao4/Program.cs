using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Insira o número do funcionário: ");
            funcionario.num = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o número de horas trabalhadas: ");
            funcionario.horas = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira o valor hora do funcionário: ");
            funcionario.valorHora = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Number = {funcionario.num}");
            Console.WriteLine($"Salary = {funcionario.Salario()}");
        }
    }
}
