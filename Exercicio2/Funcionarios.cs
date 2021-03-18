using System;
using System.Collections.Generic;
using System.Text;

namespace ListaFuncionarios
{

    public class Funcionario
        {
            
            public string Nome { get; set; }
            public double Salario { get;  set; }

            public Funcionario( string nome, double salario)
            {
                this.Nome = nome;
                this.Salario = salario;
            }
        public Funcionario()
        {

        }
        
        public override string ToString()
        {
            return  " " + this.Nome + "     Salario: " + this.Salario + "\n";
        }

    }
}

