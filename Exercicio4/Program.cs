using System;
using System.Collections.Generic;

namespace ListaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação que receba N alunos com suas respectivas notas." +
                " Use foreach para a estrutura de repetição." + Environment.NewLine);
            List<Aluno> alunos = new List<Aluno>();
                       
            inicio:
            Console.WriteLine("Digite o nome do Aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a Nota do Aluno:");
            int nota = int.Parse(Console.ReadLine());
            alunos.Add(new Aluno(nome, nota));
            
            Console.WriteLine("Deseja adicionar outro aluno? [s/n]");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write(Environment.NewLine);
                goto inicio;
            }
            else
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Alunos com nota maior ou igual a 7:\n");
                foreach (Aluno aluno in alunos)
                {
                    if (aluno.Nota >= 7)
                    Console.Write(aluno);
                }  
            }
            

        }
    }
}
