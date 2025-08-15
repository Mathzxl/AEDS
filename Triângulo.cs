using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Triângulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triângulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public Triângulo()
        {
            lado1 = 5;
            lado2 = 10;
            lado3 = 20;
        }

        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }
    }
}
