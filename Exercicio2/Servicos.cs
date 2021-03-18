using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaFuncionarios
{
    public class Servicos
    {
        public void Menor(List<Funcionario> listaFuncionario)
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
        }
        public void Maior(List<Funcionario> listaFuncionario)
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
        } 
    }
}
