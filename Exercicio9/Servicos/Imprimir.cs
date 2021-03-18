using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio9
{
    public class Imprimir
    {
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
    }
}
