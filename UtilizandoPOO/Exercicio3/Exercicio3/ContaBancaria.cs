using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public abstract class ContaBancaria
    {
        protected const double taxaDeOperacao = 0.2;
        protected const double Limite = -10.0;
        
        public int NumeroDaConta { get; private set; }
        public double Saldo { get; set; }

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);

        public void SetNumeroDaConta(int numero)
        {
            NumeroDaConta = numero;
        }
    }
}
