using System;

namespace AbstractInterface
{

    //Quando usar uma classe abstrata e quando devo usar uma interface?
    //  Classe Abstrata pode conter código implementado enquanto a interface somento pode conter os metódos 
    //ou propriedades. Classes abstratas e Interfaces não podem ser usadas para construir objetos.
    // Normalmente utiliza-se Interfaces quando é necessario implementar varios Métodos que serão obrigatorios 
    //para as classes que implementam esta interface.
    //  Utiliza-se a classe abstrata quando é necessario implementar um método e reutilizar em outras classes. 
    //  Como exemplo criri uma classe abstrata e uma interface e as classes exemplo implementam estas classes.
    public class Program
    {
        static void Main(string[] args) 
        {
            ExemploAbstract abs = new ExemploAbstract();
            ExemploInterface inter = new ExemploInterface();

            abs.Impressao();
            inter.Metodo();
        
        
        }
        
    }
}
