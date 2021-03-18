using System;

namespace MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while."+ Environment.NewLine);
            int tres = 0;
            Console.WriteLine("Multiplos de 3:");
            while (tres < 99)
            {
                tres += 3;
                Console.Write(" "+tres+" ");    
            }
            Console.ReadKey();
        }
    }
}
