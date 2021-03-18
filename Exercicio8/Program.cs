using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_8
{
    class Program
    {
        
        private const int SAIR = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.");
            Console.Write(Environment.NewLine);
            List<decimal> lista = new List<decimal>();
            Console.WriteLine("Digite numeros decimais ou 0 para parar de inserir numeros:");
            decimal.TryParse(Console.ReadLine(), out decimal num);

            while(num != SAIR)
            {
                lista.Add(num);

                Console.WriteLine("Digite um numero decimal");
                decimal.TryParse(Console.ReadLine(), out num);
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Numeros em ordem Crescente: {string.Join(" - ", lista.OrderBy(x => x))}");
            Console.WriteLine($"Numeros em ordem Decrescente: {string.Join(" - ", lista.OrderByDescending(x => x))}");


        }    
    }
}