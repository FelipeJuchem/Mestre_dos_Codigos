using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public class ContaEspecial : ContaBancaria, Imprimivel
    {
       
        public override void Depositar(double valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine($"Depósito efetuado com sucesso!\n Seu saldo é de ${Saldo.ToString("N2")} Reais");
        }

        public void MostrarDados()
        {
            Console.WriteLine("\nConta Corrente:\n" +
                $"Numero da Conta: {NumeroDaConta}  Saldo: {Saldo.ToString("N2")}");
        }

        public override void Sacar(double valor)
        {
            if (Saldo - valor < -10) 
            {
                Console.WriteLine("Saldo Insuficiente para o saque!");
                if (Saldo - valor >= -10)
                {
                    Console.WriteLine("Limite de $-10 Reais");
                }
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque Realizado com sucesso!");
                Console.WriteLine($"Seu saldo é de ${Saldo.ToString("N2")} Reais");
            }
        }
    }
}
