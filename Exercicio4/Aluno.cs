using System;
using System.Collections.Generic;
using System.Text;

namespace ListaAlunos
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }
        public Aluno()
        {

        }
        public Aluno(string nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }
        public override string ToString()
        {
            return "Aluno: " + " " + this.Nome + "     Nota: " + this.Nota + "\n";
        }
    }
}
