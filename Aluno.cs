using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas;

        public Aluno(string nome, int matricula, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public double Media()
        {
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            double media = soma / notas.Length;

            return media;
        }
    }
}
