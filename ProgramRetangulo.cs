using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão_ATP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,h;
            Console.WriteLine("Informe o valor da altura de um retângulo");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura de um retângulo");
            h = int.Parse(Console.ReadLine());

            Retângulo valores = new Retângulo(a,h);

            double area = valores.CalcArea();
            double perimetro = valores.Perimetro();

            Console.WriteLine($"A area desse retângulo é igual à: {area}\nO perímetro é igual à: {perimetro}");

            Console.ReadLine();

        }
    }
}
