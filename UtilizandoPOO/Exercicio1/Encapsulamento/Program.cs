using System;

namespace Encapsulamento
{
    //Encapsulamento
    //  Como demonstrado abaixo encapsulamento é usado para proteger as propriedades de uma classe,
    //as propriedades da classe cidadão só podem ser acessadas atraves dos métodos Get não dando 
    //acesso direto as propriedades podendo modificalas apenas com os métodos Set caso existam.
    //  Maneira de encapsular as informações escondendo as mesmas dentro de uma classe.


    class Program
    {
        static void Main(string[] args)
        {
            Cidadao cidadao = new Cidadao();

            cidadao.SetProp("Manuel", 45, 1.70);

            Console.WriteLine(cidadao.GetNome());
            Console.WriteLine(cidadao.GetIdade());
            Console.WriteLine(cidadao.GetAltura());

        }
    }
}
