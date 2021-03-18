using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio9
{
    public class Servicos
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
        public void ImprimirLista(List<int> lista)
        {
            foreach (int num in lista)
            {
                Console.Write(num + "-");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void ImprimirCrescrente(List<int> lista)
        {
            List<int> sortedLista = lista.OrderBy(x => x).ToList();
            foreach (int x in sortedLista)
            {
                Console.Write(x + "-");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void ImprimirDecrescrente(List<int> lista)
        {
            List<int> sortedLista = lista.OrderByDescending(x => x).ToList();
            foreach (int x in sortedLista)
            {
                Console.Write(x + "-");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void PrimeiroDaLista(List<int> lista)
        {
            int x = lista.FirstOrDefault();
            Console.WriteLine("Primeiro numero da lista: {0}", x + "\n");
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void UltimoDaLista(List<int> lista)
        {
            int x = lista.LastOrDefault();
            Console.WriteLine("Ultimo numero da lista: {0}", x + "\n");
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
        public void RetornarPares(List<int> lista)
        {
            Console.WriteLine("\nNumeros pares:");
            var pares = lista.Where(x => x % 2 == 0).ToList();
            foreach (int num in pares)
            {
                Console.Write(num + "-");
            }
            Console.WriteLine("\n\nPressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void RetornInformado(List<int> lista)
        {
            Console.Write("Informe o numero que deseja verificar na lista:");
            int.TryParse(Console.ReadLine(), out int n);
            if (lista.Contains(n))
            {
                Console.WriteLine("Numero(s) encontrado(s)");
                lista.Where(x => x.Equals(n)).ToList().ForEach(x => Console.WriteLine(x));
            }
            else
            {
                Console.WriteLine("Valor não encontrado!");
            }
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
        public void TrasnformarArray(List<int> lista)
        {
            var listaArray = lista.ToArray();
            Console.WriteLine("Lista ja transformada em Array:");
            foreach (var num in listaArray)
            {
                Console.Write("-" + num);
            }
            Console.WriteLine("\n\nPressione Enter para voltar ao menu!");
            Console.ReadKey();
        }
    }
}
