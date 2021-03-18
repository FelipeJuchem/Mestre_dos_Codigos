using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares."
                +Environment.NewLine);
            int soma=0;
            int[] numeros = new int[4];
            Console.WriteLine("Digite quatro numeros inteiros:");
            for (int i =0; i < 4; i++)
            {
                numeros[i]=int.Parse(Console.ReadLine());
                if((numeros[i] % 2) == 0)
                {
                    soma = soma + numeros[i];
                }
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Resultado da soma entre os numeros pares:");
            Console.WriteLine(soma);
        }
    }
}
