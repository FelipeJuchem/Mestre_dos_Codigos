using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio9
{
    public class Busca
    {
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
        public void BuscaPares(List<int> lista)
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
        public void BuscaInformado(List<int> lista)
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


    }
}
