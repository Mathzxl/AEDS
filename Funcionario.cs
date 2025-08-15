using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Funcionario
    {
        private string nome;
        private string cargo;
        private double salario;

        public Funcionario(string nome, string cargo)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = 1.518;
        }
        public Funcionario(string nome, string cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }      
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }
}

