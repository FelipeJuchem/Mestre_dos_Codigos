using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Cachorro: ICloneable
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raça { get; set; }

        public Cachorro()
        {

        }

        public Cachorro(Cachorro cachorro)
        {
            Nome = cachorro.Nome;
            Idade = cachorro.Idade;
            Raça = cachorro.Raça;
        }

        public object Clone()
        {
            return new Cachorro(this);
        }
    }
}
