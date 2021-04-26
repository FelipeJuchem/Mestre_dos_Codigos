using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFuncionarios
{
    public class Servicos
    {
        public Funcionario MenorSalario(List<Funcionario> listaFuncionario)
        {
            int indexFuncionario = 0;
            Funcionario funcionario = new Funcionario();
            funcionario = listaFuncionario[0];
            while (indexFuncionario < listaFuncionario.Count)
            {
                if (funcionario.Salario > listaFuncionario[indexFuncionario].Salario)
                {
                    funcionario = listaFuncionario[indexFuncionario];
                }
                indexFuncionario++;
            }
            Console.WriteLine($"Menor Salario: "+funcionario);
            return funcionario;
        }
        public Funcionario MaiorSalario(List<Funcionario> listaFuncionario)
        {
            int indexFuncionario = 0;
            Funcionario funcionario = new Funcionario();
            funcionario = listaFuncionario[0];
            while (indexFuncionario < listaFuncionario.Count)
            {
                if (funcionario.Salario < listaFuncionario[indexFuncionario].Salario)
                {
                    funcionario  = listaFuncionario[indexFuncionario];
                }
                indexFuncionario++;
            }
            Console.WriteLine("Maior Salario: "+funcionario);
            return funcionario;
        } 
    }
}
