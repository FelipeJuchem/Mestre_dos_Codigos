using System;
using System.Collections.Generic;
using System.Text;

namespace RefOut
{
    public class Objeto
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Objeto()
        {
            
        }
        public Objeto(string nome)
        {
            Nome = nome;
        }
        public void mudar(ref Objeto obj)
        {
            obj = new Objeto();
            obj.Nome = "Alan";
        }
        public override string ToString()
        {
            return "nome:  " + Nome;
        }
        
        public void Metodo(out string msg, out int idade)
        {
            msg = " 1º Mensagem de saida";
            idade =  44;
        }

    }
}
