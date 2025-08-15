using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do titular de uma conta");
            string titular = Console.ReadLine();

            Console.WriteLine("Digite o saldo da conta desse titular");
            double saldo = double.Parse(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria(saldo,titular);

            Console.WriteLine($"O saldo da conta do {titular} é: {saldo}");

            Console.WriteLine("Digite o valor do deposito");
            double d = double.Parse(Console.ReadLine());

            double deposito = conta.Deposito(d);

            Console.WriteLine($"Após o deposito o valor do saldo agora é de: {conta.saldo}");

            Console.WriteLine("Coloque o valor do saque");
            double s = double.Parse(Console.ReadLine());

            if (conta.Saque(s))
            {
                Console.WriteLine("Saque Realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Não foi possivel conluir o saque (Saldo insulficiente)");
            }

            conta.MostraSaldo();

            Console.ReadLine();
        }
    }
}

