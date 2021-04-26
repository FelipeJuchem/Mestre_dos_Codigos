using ListaFuncionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Testes.DataBuilder
{
    public static class FuncionarioTestDataBuilder
    {
        const string NOME1 = "Jagunço";
        const double SALARIO1 = 5000;
        const string NOME2 = "Dunga";
        const double SALARIO2 = 3000;
        const string NOME3 = "Jumiranda";
        const double SALARIO3 = 1000;




        public static Funcionario NewFuncionario1()
        {
            return new Funcionario(NOME1,SALARIO1);
        }

        public static Funcionario NewFuncionario2()
        {
            return new Funcionario(NOME2, SALARIO2);
        }
        public static Funcionario NewFuncionario3()
        {
            return new Funcionario(NOME3, SALARIO3);
        }
    }
}
