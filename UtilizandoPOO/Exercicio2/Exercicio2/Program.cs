using System;

namespace Exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma classe para representar uma pessoa:\n");
            var pessoa = new Pessoa();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            pessoa.InserirNome(nome);

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());
            pessoa.InserirAltura(altura);

            Console.Write("Data de nascimento(dd/mm/yyyy):  ");
            string dataNascimento = Console.ReadLine();
            pessoa.InserirDataNascimento(dataNascimento);

            pessoa.Imprimir();

            Console.Write($"Idade: {pessoa.CalculaIdade()} Anos");
           Console.ReadKey();
        }
    }
}
