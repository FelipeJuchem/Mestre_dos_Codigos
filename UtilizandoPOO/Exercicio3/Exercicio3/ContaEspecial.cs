using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public class ContaEspecial : ContaBancaria
    {
       
        public override void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public override void Sacar(double valor)
        {
            if (Saldo - valor <= 0)
            {
                Console.WriteLine("Saldo Insuficiente para o saque!");
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque Realizado com sucesso!");
            }
        }
    }
}
