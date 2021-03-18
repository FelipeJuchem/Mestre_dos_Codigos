using System;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var servicos = new Servicos();
            Console.WriteLine("Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados."+Environment.NewLine);
            inicio:
            Console.WriteLine("Digite os valores A e B:");
            Console.Write("A:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B:");
            int b = int.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            servicos.Somar(a, b);
            
            servicos.Subtrair(a, b);

            servicos.Multiplicar(a, b);

            servicos.Par(a);

            servicos.Par(b);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Deseja digitar novos valores?[s/n]");
            char escolha = char.Parse(Console.ReadLine());
            if(escolha=='s' || escolha== 'S')
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("Fim do programa");
            }
        }
        
        
    }
}
