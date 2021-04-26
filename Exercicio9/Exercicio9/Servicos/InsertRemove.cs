using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio9
{
    public class InsertRemove
    {
        
        public void InserirDados(List<int> lista)
        {
            Console.WriteLine("Quantos numeros deseja adicionar?:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("  Digite o numero:");
                int numero = int.Parse(Console.ReadLine());
                Inserir(lista, numero);
            }
            Console.WriteLine("Pressione Enter para voltar ao menu!");
        }
        
        public void InserirInicio(List<int> lista)
        {
            Console.WriteLine("Digite o numero que deseja adicionar no inicio da lista:");
            int x = int.Parse(Console.ReadLine());
            InserirNoInicioDaLista(lista, x);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void InserirUltimo(List<int> lista)
        {
            Console.WriteLine("Digite o numero que deseja adicionar no final da lista:");
            int x = int.Parse(Console.ReadLine());
            InserirNoFimDaLista(lista,x);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void RemoverPrimeiro(List<int> lista)
        {
            Console.WriteLine($"Numero {lista.First()} foi removido com sucesso!");
            RemoverPrimeiroDaLista(lista);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void RemoverUltimo(List<int> lista)
        {
            Console.WriteLine($"Numero {lista.Last()} foi removido com sucesso!");
            RemoverUltimoDaLista(lista);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }

        public void InserirNoInicioDaLista(List<int> lista, int numero)
        {
            lista.Insert(0, numero);
        }

        public void InserirNoFimDaLista(List<int> lista, int numero)
        {
            lista.Add(numero);
        }

        public void Inserir(List<int> lista, int numero)
        {
            lista.Add(numero);
        }

        public void RemoverPrimeiroDaLista(List<int> lista)
        {
            lista.RemoveAt(0);
        }

        public void RemoverUltimoDaLista(List<int> lista)
        {
            lista.RemoveAt(lista.Count - 1);
        }

        
        
        
    }
}
