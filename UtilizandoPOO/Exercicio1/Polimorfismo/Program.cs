using System;

namespace Polimorfismo
{
    //Polimorfismo:
    //  Polimorfismo se da quando usamos um mesmo método que realiza funções diferentes em varias classes atraves de herança ou Interfaces,
    //abaixo um exemplo de polimorfismo com o metodo imprimir sendo usado na sua clase base e nas outras classes que estão herdando 
    //mas imprimindo mensagens diferentes.


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
