using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Funcionario");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o cargo desse Funcionario");
            string cargo = Console.ReadLine();

            Funcionario info = new Funcionario(nome,cargo);

            Console.WriteLine($"O salário do funcionario {nome} que exerce o cargo de {cargo} é: R${info.Salario}");

            Console.ReadLine();
        }
    }
}
