using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio9
{
    public class Busca
    {
        public int PrimeiroDaLista(List<int> lista)
        {
            int x = lista.FirstOrDefault();
            Console.WriteLine("Primeiro numero da lista: {0}", x + "\n");
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            return x;
        }
        public int UltimoDaLista(List<int> lista)
        {
            int x = lista.LastOrDefault();
            Console.WriteLine("Ultimo numero da lista: {0}", x + "\n");
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            return x;
        }
        public List<int> BuscaPares(List<int> lista)
        {
            Console.WriteLine("\nNumeros pares:");
            var pares = lista.Where(x => x % 2 == 0).ToList();
            foreach (int num in pares)
            {
                Console.Write(num + "-");
            }
            Console.WriteLine("\n\nPressione Enter para voltar ao menu!");
            return pares;
        }
        
        public void BuscaInformado(List<int> lista)
        {
            Console.Write("Informe o numero que deseja verificar na lista:");
            int.TryParse(Console.ReadLine(), out int n);
            if (lista.Contains(n))
            {
                Console.WriteLine("Numero(s) encontrado(s)");
                lista.Where(x => x.Equals(n)).ToList().ForEach(x => Console.WriteLine(x));
                Console.WriteLine("Pressione Enter para voltar ao menu!");
            }
            else
            {
                Console.WriteLine("Valor não encontrado!");
                Console.WriteLine("Pressione Enter para voltar ao menu!");
            }
        }
    }
}
