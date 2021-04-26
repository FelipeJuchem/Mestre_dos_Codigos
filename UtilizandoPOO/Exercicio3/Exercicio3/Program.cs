using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio3
{
    public class Program
    {
        public Program()
        {

        }
        
        static List<ContaCorrente> listaContasCorrentes = new List<ContaCorrente>();
        static List<ContaEspecial> listaContasEspeciais = new List<ContaEspecial>();
        
        static void Main(string[] args)
        {
            var opcoes = new Opcoes();
            inicio:
            opcoes.Inicializar(listaContasCorrentes, listaContasEspeciais);

            Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu anterior!");
            Console.ReadLine();
            Console.Clear();
            goto inicio;
        }
    }
}
