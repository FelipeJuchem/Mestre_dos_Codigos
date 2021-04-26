using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio9
{
    public class Transformar
    {
        public void TrasnformarArray(List<int> lista)
        {
            var listaArray = lista.ToArray();
            Console.WriteLine("Lista ja transformada em Array:");
            foreach (var num in listaArray)
            {
                Console.Write("-" + num);
            }
            Console.WriteLine("\n\nPressione Enter para voltar ao menu!");
        }
    }
}
