using System;

namespace POO
{

    //Utilizando POO
    //  Oque é POO?
    //      POO é paradigma orientado a objetos onde diversas classes tem caracteristicas para definir um objeto na vida real, 
    //este paradigma se baseia principalmente em dois conceitos: classes e objetos.
    // Como exemplo eu criei uma classe Carro e criei o objeto carro na classe Program onde agora posso definir os valores do objeto criado.
class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Modelo = "Golf";
            carro.Cor = "Prata";
            carro.Ano = "2017";
            carro.Novo = true;
        }
    }
}
