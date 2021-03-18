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
                lista.Add(numero);
                Console.WriteLine(" Adicionado com sucesso!\n ");
            }
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        
        
        public void InserirInicio(List<int> lista)
        {
            Console.WriteLine("Digite o numero que deseja adicionar no inicio da lista:");
            int x = int.Parse(Console.ReadLine());
            lista.Insert(0, x);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void InserirUltimo(List<int> lista)
        {
            Console.WriteLine("Digite o numero que deseja adicionar no final da lista:");
            int x = int.Parse(Console.ReadLine());
            lista.Add(x);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void RemoverPrimeiro(List<int> lista)
        {
            Console.WriteLine($"Numero {lista.First()} foi removido com sucesso!");
            lista.RemoveAt(0);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void RemoverUltimo(List<int> lista)
        {
            Console.WriteLine($"Numero {lista.Last()} foi removido com sucesso!");
            lista.RemoveAt(lista.Count - 1);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        
        
    }
}
