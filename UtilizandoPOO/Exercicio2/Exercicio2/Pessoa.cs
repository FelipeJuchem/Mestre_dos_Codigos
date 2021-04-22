using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string DataDeNascimento { get; set; }
        private double Altura { get; set; }

        public Pessoa()
        {
        
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nome: {Nome}\nAltura: {Altura}\nData de nascimento: {DataDeNascimento} ");
        }

        public void InserirNome(string nome)
        {
            Nome = nome;
        }

        public void InserirDataNascimento(string data)
        {
            DataDeNascimento = data;
        }
        
        public void InserirAltura(double altura)
        {
            Altura = altura;
        }
        
        
        public int CalculaIdade()
        {
            var idadeDateTime = DateTime.Parse(DataDeNascimento);
            var idade = DateTime.Now.Year - idadeDateTime.Year;
            return idade;
        }


    }
}
