using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class ContaBancaria
    {
        private double saldo;
        private string titular;

        public ContaBancaria(double saldo, string titular)
        {
            this.saldo = saldo;
            this.titular = titular;
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public bool Saque(double saque)
        {
            if (saldo > 0 && saldo > saque)
            {
                saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Deposito(double deposito)
        {
            saldo += deposito;
            return saldo;
        }

        public void MostraSaldo()
        {
            Console.WriteLine($"O saldo do titular {titular} é : {saldo}");
        }
    }
}
