using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula desse aluno");
            int matricula = int.Parse(Console.ReadLine());

            double[] notas = new double[5];

            Console.WriteLine("Digite as notas desse aluno");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"{i+1}º nota:");
                notas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Aluno infos = new Aluno(nome,matricula,notas);

            double media = infos.Media();

            Console.WriteLine($"A media das notas do aluno {nome} é: {media} ");
            
            Console.ReadLine();
        }
    }
}
