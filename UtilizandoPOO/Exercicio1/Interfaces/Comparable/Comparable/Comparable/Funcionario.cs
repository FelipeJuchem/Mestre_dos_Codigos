using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable
{

    //O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
    //  IComparable
    //      A interface Icomparable serve para fazer comparações entre objetos como no exemplo abaixo onde consigo fazer uma comparação entre os salarios 
    // de cada funcionario e logo após faço uma ordenação com Sort que só foi possivel pela implementação do Icomparable na classe Funcionario.


    public class Funcionario : IComparable<Funcionario>
    {

        public string Nome { get; set; }
        public int Salario { get; set; }

        public Funcionario(string nome, int salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public int CompareTo(Funcionario fun)
        {
            // return other.Salary.CompareTo(this.Salary);
            if (this.Salario < fun.Salario)
            {
                return -1;
            }
            else if (this.Salario > fun.Salario)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
