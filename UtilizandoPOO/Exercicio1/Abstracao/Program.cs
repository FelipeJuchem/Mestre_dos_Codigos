using System;

namespace Abstracao
{

    //Abstração
    //  Construir uma classe priorizando o importante para certo fim.
    //  Abstração é usada quando procura-se padronizar as classes que herdarão a classe pai pois as mesmas
    //deverão por obrigatoriedade implementar os metodos da classe pai.
    //  A classe abstrata precisa ter pelo menos um método abstrato sem corpo e uma classe pode herdar apenas uma classe.
    
    class Program
    {
        static void Main(string[] args)
        {
            Cidadao maria = new Maria();
            Cidadao joao = new Joao();
            
            Printa(maria);
            Printa(joao);
        }
        static public void Printa(Cidadao cidadao)
        {
            cidadao.Imprimir();
        }
    }
}
