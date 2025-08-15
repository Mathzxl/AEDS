using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado 1 de um triângulo");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2 de um triângulo");
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 3 de um triângulo");
            double lado3 = double.Parse(Console.ReadLine());

            Triângulo triângulo1 = new Triângulo(10,20,30);
            Triângulo triângulo2 = new Triângulo();

            Console.ReadLine();
        }
    }
}
