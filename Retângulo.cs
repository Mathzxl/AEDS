using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão_ATP
{
    class Retângulo
    {
        private int largura;
        private int altura;

        public Retângulo (int largura, int altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        public int Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double CalcArea()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return 2 * (largura + altura);
        }
    }
}
