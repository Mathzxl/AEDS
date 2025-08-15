using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Titulo de um livro");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite o autor desse livro");
            string autor = Console.ReadLine();
            Console.WriteLine("Digite o ano de publicação desse livro");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o genero do livro");
            string genero = Console.ReadLine();

            Livro info = new Livro(titulo,autor,ano,genero.ToLower());

            info.InformaçõesLivro();

            if (info.TesteGenero())
            {
                Console.WriteLine("O livro é do gênero Ficção");
            }
            else
            {
                Console.WriteLine("O livro não é do gênero Ficção");
            }

            Console.ReadLine();
        }
    }
}
