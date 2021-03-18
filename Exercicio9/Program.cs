using Exercicio9.Servicos;
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
        private const int Busca_Primeiro_Numero = 4;
        private const int Busca_Ultimo_Numero = 5;
        private const int Inserir_Primeiro_numero = 6;
        private const int Inserir_Ultimo_numero = 7;
        private const int Remover_Primeiro_numero = 8;
        private const int Remover_Ultimo_numero = 9;
        private const int Retornar_Pares = 10;
        private const int Retornar_Numero_Informado = 11;
        private const int Transformar_Array = 12;
        private const int Sair = 13;

        static public Encerrar sair = new Encerrar();
        static public Transformar tranformar = new Transformar();
        static public Busca busca = new Busca();
        static public Imprimir imprimir = new Imprimir();
        static public InsertRemove servicos = new InsertRemove();
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
                    "  12 - Transforme todos os números da lista em um Array.\n" +
                    "  13 - Sair\n");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);
            switch (opcao)
            {
                case Inserir_Dados_Lista:
                    servicos.InserirDados(lista);
                    break;
                case Imprimir_Todos_Numeros_Lista:
                    imprimir.ImprimirLista(lista);
                    break;
                case Imprimir_Todos_Ordem_Crescente:
                    imprimir.ImprimirCrescrente(lista);
                    break;
                case Imprimir_Todos_Ordem_Decrescente:
                    imprimir.ImprimirDecrescrente(lista);
                    break;
                case Busca_Primeiro_Numero:
                    busca.PrimeiroDaLista(lista);
                    break;
                case Busca_Ultimo_Numero:
                    busca.UltimoDaLista(lista);
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
                    busca.BuscaPares(lista);
                    break;
                case Retornar_Numero_Informado:
                    busca.BuscaInformado(lista);
                    break;
                case Transformar_Array:
                    tranformar.TrasnformarArray(lista);
                    break;
                case Sair:
                    sair.Fechar();
                    break;
            }
            Console.Clear();
            Processar();
        }
        
    }  
    
}
