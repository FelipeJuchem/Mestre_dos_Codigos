using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new List<Funcionario>
            {
                new Funcionario("Diego",1200),
                new Funcionario("Fabio",2000),
                new Funcionario("Felipe",500),
                new Funcionario("Leticia",300)
            };

            funcionario.Sort();

            foreach(var fun in funcionario)
            {
                Console.WriteLine($"Funcionario {fun.Nome} Salario: {fun.Salario}");
            }
        }

    }
}
