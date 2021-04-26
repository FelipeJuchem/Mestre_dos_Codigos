using System;
using System.Collections.Generic;

namespace ListaFuncionarios
{
    public class Program
    {
        static Servicos servicos = new Servicos();
        static List<Funcionario> listaFuncionario = new List<Funcionario>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação que receba nome e salário de N funcionários. Utilize a repetição for e while." + Environment.NewLine);

            Console.Write("Quantos funcionários serão cadastrados? ");
            int totalFuncionarios = int.Parse(Console.ReadLine());

            for (int indiceFuncionario = 0; indiceFuncionario < totalFuncionarios; indiceFuncionario++)
            {
                Console.WriteLine("Dados do " + (indiceFuncionario + 1) + "º funcionário: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                listaFuncionario.Add(new Funcionario( nome, salario));
                Console.WriteLine();
            }

            servicos.MaiorSalario(listaFuncionario);
            servicos.MenorSalario(listaFuncionario);
            

        }
    }
}
