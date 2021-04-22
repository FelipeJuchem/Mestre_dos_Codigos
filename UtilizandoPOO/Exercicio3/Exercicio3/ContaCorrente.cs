using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public class ContaCorrente : ContaBancaria
    {
        const double taxaDeOperacao = 0.2;

        public override void Depositar(double valor)
        {
            valor = valor - taxaDeOperacao;
            Saldo = Saldo + valor;
            Console.WriteLine($"Depósito efetuado com sucesso!\n Seu saldo é de ${Saldo.ToString("N2")} Reais");
        }

        public override void Sacar(double valor)
        {
            if(Saldo <= 0 || (Saldo - (valor + taxaDeOperacao)) < 0)
            {
                Console.WriteLine("Saldo Insuficiente para o saque!");
            }
            else
            {
                Saldo = Saldo - valor - taxaDeOperacao;
                Console.WriteLine("Saque Realizado com sucesso!");
                Console.WriteLine($"Seu saldo é de ${Saldo.ToString("N2")} Reais");
            }
        }

        
    }
}
