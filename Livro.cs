using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Livro
    {
        private string titulo;
        private string autor;
        private int anopublicacao;
        private string genero;

        public Livro(string titulo, string autor, int anopublicacao, string genero)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anopublicacao = anopublicacao;
            this.genero = genero;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int AnoPublicacao
        {
            get { return anopublicacao; }
            set { anopublicacao = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public void InformaçõesLivro()
        {
            Console.WriteLine($"Titulo do livro: {titulo}\nAutor do livro: {autor}\nAno de publicação do livro: {anopublicacao}\nGenero do livro: {genero}");
        }

        public bool TesteGenero()
        {
            if (genero == "ficção")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
