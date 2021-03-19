using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class Cidadao
    {
        private string Nome;
        private int Idade;
        private double Altura;

        public string GetNome()
        {
            return Nome;
        }
        public int GetIdade()
        {
            return Idade;
        }
        public double GetAltura()
        {
            return Altura;
        }

    public void SetProp(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }
}
