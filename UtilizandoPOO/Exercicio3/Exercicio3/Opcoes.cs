using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio3
{
    public class Opcoes
    {
        public Opcoes()
        {

        }

        public void Inicializar(List<ContaCorrente> listaContasCorrentes, List<ContaEspecial> listaContasEspeciais)
        {
            var _program = new Program();

            const int Criar_Nova_ContaCorrente = 1;
            const int Criar_Nova_ContaEspecial = 2;
            const int Depositar = 3;
            const int Sacar = 4;
            const int Imprimir_Dados = 5;

            Console.WriteLine("Opções\n" +
                "1 = Criar nova conta Corrente\n" +
                "2 = Criar noca conta Especial\n" +
                "3 = Depositar\n" +
                "4 = Sacar\n" +
                "5 = Imprimir Dados");

            Console.Write("\nOpção: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            Console.Write(Environment.NewLine);

            switch (opcao)
            {
                case Criar_Nova_ContaCorrente:
                    Console.Write("Digite o numero da nova conta:");
                    int numeroContaCorrente = int.Parse(Console.ReadLine());
                    NovaContaCorrente(numeroContaCorrente, listaContasCorrentes);
                    break;

                case Criar_Nova_ContaEspecial:
                    Console.Write("Digite o numero da nova conta:");
                    int numeroContaEspecial = int.Parse(Console.ReadLine());
                    NovaContaEspecial(numeroContaEspecial, listaContasEspeciais);
                    break;

                case Depositar:
                    Console.WriteLine("Conta corrente ou Especial?\n1 = Corrente  \n2 = Especial");
                    int tipoContaDeposito = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o numero da Conta em que deseja fazer o depósito:");
                    int numeroConta = int.Parse(Console.ReadLine());

                    if (tipoContaDeposito == 1)
                    {
                        var contaCorrente = listaContasCorrentes.FirstOrDefault(x => x.NumeroDaConta == numeroConta);
                        if (contaCorrente == null)
                        {
                            Console.WriteLine("Conta não existe");
                        }
                        else
                        {
                            Console.WriteLine("Taxa de $0,20 centavos por transação");
                            Console.WriteLine("Digite o valor a ser Depositado: (0.0)");
                            double valor = double.Parse(Console.ReadLine());
                            contaCorrente.Depositar(valor);
                        }
                    }
                    else
                    {
                        var contaEspecial = listaContasEspeciais.FirstOrDefault(x => x.NumeroDaConta == numeroConta);
                        if (contaEspecial == null)
                        {
                            Console.WriteLine("Conta não existe");
                        }
                        else
                        {
                            Console.WriteLine("Digite o valor a ser Depositado: (0.0)");
                            double valor = double.Parse(Console.ReadLine());
                            contaEspecial.Depositar(valor);
                        }
                    }
                    break;

                case Sacar:
                    Console.WriteLine("Conta corrente ou Especial?\n1 = Corrente - \n2 = Especial");
                    int tipoContaSaque = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o numero da Conta em que deseja fazer o saque:");
                    int numeroContaSaque = int.Parse(Console.ReadLine());

                    if (tipoContaSaque == 1)
                    {
                        var contaCorrente = listaContasCorrentes.FirstOrDefault(x => x.NumeroDaConta == numeroContaSaque);
                        if (contaCorrente == null)
                        {
                            Console.WriteLine("Conta não existe");
                        }
                        else
                        {
                            Console.WriteLine("Taxa de $0,20 centavos por transação");
                            Console.WriteLine("Digite o valor a ser Retirado: (0,0)");
                            double valor = double.Parse(Console.ReadLine());
                            contaCorrente.Sacar(valor);
                        }

                    }
                    else
                    {
                        var contaEspecial = listaContasEspeciais.FirstOrDefault(x => x.NumeroDaConta == numeroContaSaque);
                        if (contaEspecial == null)
                        {
                            Console.WriteLine("Conta não existe");
                        }
                        else
                        {
                            Console.WriteLine("Digite o valor a ser Retirado: (0,0)");
                            double valor = double.Parse(Console.ReadLine());
                            contaEspecial.Sacar(valor);
                        }
                    }
                    break;

                case Imprimir_Dados:
                    foreach (var contaCorrente in listaContasCorrentes)
                    {
                        contaCorrente.MostrarDados();
                    }

                    foreach (var contaEspecial in listaContasEspeciais)
                    {
                        contaEspecial.MostrarDados();
                    }

                    break;
            }

        }
        public void NovaContaCorrente(int numeroConta, List<ContaCorrente> listaContasCorrentes)
        {
            var contaSelect = listaContasCorrentes.FirstOrDefault(x => x.NumeroDaConta == numeroConta);

            if (contaSelect == null)
            {
                ContaCorrente conta = new ContaCorrente();
                conta.SetNumeroDaConta(numeroConta);
                listaContasCorrentes.Add(conta);
                Console.WriteLine("Conta criada com sucesso!");
            }
            else
            {
                Console.WriteLine("Conta com este número já existe");
            }
        }

        public void NovaContaEspecial(int numeroConta, List<ContaEspecial> listaContasEspeciais)
        {
            var contaSelect = listaContasEspeciais.FirstOrDefault(x => x.NumeroDaConta == numeroConta);
            if (contaSelect == null)
            {
                ContaEspecial conta = new ContaEspecial();
                conta.SetNumeroDaConta(numeroConta);
                listaContasEspeciais.Add(conta);
                Console.WriteLine("Conta criada com sucesso!");
            }
            else
            {
                Console.WriteLine("Conta com este número já existe");
            }
        }
    }
}
