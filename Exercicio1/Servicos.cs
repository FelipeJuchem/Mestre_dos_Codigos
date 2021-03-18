using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Servicos
    {
        public void Somar(int a, int b)
        {
            int soma = a + b;
            Console.WriteLine("Soma: \n A e B: {0}", soma);
        }
        public void Subtrair(int a, int b)
        {
            int subtrair = a - b;
            Console.WriteLine("Subtração: \n A e B: {0}", subtrair);
        }
        public void Multiplicar(int a, int b)
        {
            int multiplicar = a * b;
            Console.WriteLine("Multiplicação:\n A por B: {0}", multiplicar + Environment.NewLine);
        }
        public void Par(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Valor {0} é Par", a);
            }
            else
            {
                Console.WriteLine("Valor {0} e impar", a);
            }
        }
    }
}
