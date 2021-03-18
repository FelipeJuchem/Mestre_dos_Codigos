using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio9
{
    public class Program
    {
        private const int Inserir_Dados_Lista = 0;
        private const int Imprimir_Todos_Numeros_Lista = 1;
        private const int Imprimir_Todos_Ordem_Crescente = 2;
        private const int Imprimir_Todos_Ordem_Decrescente = 3;
        private const int Imprimir_Primeiro_Numero = 4;
        private const int Imprimir_Ultimo_Numero = 5;
        private const int Inserir_Primeiro_numero = 6;
        private const int Inserir_Ultimo_numero = 7;
        private const int Remover_Primeiro_numero = 8;
        private const int Remover_Ultimo_numero = 9;
        private const int Retornar_Pares = 10;
        private const int Retornar_Numero_Informado = 11;
        private const int Transformar_Array = 12;

        static public Servicos servicos = new Servicos();
        static List<int> lista = new List<int>();
        static void Main(string[] args)
        {
           Processar();
        }
        public static void Processar()
        {
            int opcao;
        
            Console.WriteLine("9: Utilizando a biblioteca LINQ crie no console e execute: \n\n" +
                    "  Digite a opção desejada:\n\n" +
                    "   0 - Inserir dados na Lista.\n" +
                    "   1 - Imprimir todos os números da lista.\n" +
                    "   2 - Imprimir todos os números da lista na ordem crescente.\n" +
                    "   3 - Imprimir todos os números da lista na ordem decrescente.\n" +
                    "   4 - Imprima apenas o primeiro número da lista.\n" +
                    "   5 - Imprima apenas o ultimo número da lista.\n" +
                    "   6 - Insira um número no início da lista.\n" +
                    "   7 - Insira um número no final da lista.\n" +
                    "   8 - Remova o primeiro número.\n" +
                    "   9 - Remova o último número.\n" +
                    "  10 - Retorne apenas os números pares.\n" +
                    "  11 - Retorne apenas o número informado.\n" +
                    "  12 - Transforme todos os números da lista em um Array.\n");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);
            switch (opcao)
            {
                case Inserir_Dados_Lista:
                    servicos.InserirDados(lista);
                    break;
                case Imprimir_Todos_Numeros_Lista:
                    servicos.ImprimirLista(lista);
                    break;
                case Imprimir_Todos_Ordem_Crescente:
                    servicos.ImprimirCrescrente(lista);
                    break;
                case Imprimir_Todos_Ordem_Decrescente:
                    servicos.ImprimirDecrescrente(lista);
                    break;
                case Imprimir_Primeiro_Numero:
                    servicos.PrimeiroDaLista(lista);
                    break;
                case Imprimir_Ultimo_Numero:
                    servicos.UltimoDaLista(lista);
                    break;
                case Inserir_Primeiro_numero:
                    servicos.InserirInicio(lista);
                    break;
                case Inserir_Ultimo_numero:
                    servicos.InserirUltimo(lista);
                    break;
                case Remover_Primeiro_numero:
                    servicos.RemoverPrimeiro(lista);
                    break;
                case Remover_Ultimo_numero:
                    servicos.RemoverUltimo(lista);
                    break;
                case Retornar_Pares:
                    servicos.RetornarPares(lista);
                    break;
                case Retornar_Numero_Informado:
                    servicos.RetornInformado(lista);
                    break;
                case Transformar_Array:
                    servicos.TrasnformarArray(lista);
                    break;
            }
            Console.Clear();
            Processar();
        }
        
    }  
    
}
