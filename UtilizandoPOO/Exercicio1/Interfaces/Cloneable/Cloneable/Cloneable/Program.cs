using System;

namespace Cloneable
{
    // ICloneable o que ela faz?
    //      A Interface Icloneable é uma ferramenta usada para fazer cópias profundas e superficiais de objetos e suas referencias onde 
    //se aplicada a cópia superficial(Shallow) são copiados apenas as referencias do objeto enquanto na cópia profunda(Deep) clona o 
    //objeto e todos os objetos a ele referenciados.
    //  No Exemplo abaixo podemos ver um exemplo simples de como usar o ICloneable onde eu faço uma cópia de cachorro e imprimo
    //o cachorro usado para a clonagem e o clone do mesmo.


    class Program
    {
        static void Main(string[] args)
        {
            Cachorro custelinha = new Cachorro { Nome = "Custelinha", Idade = 2, Raça = "Pastor Alemão" };

            Cachorro custelinhaClone = (Cachorro)custelinha.Clone();

            Console.WriteLine("Cachorro inicial");
            Console.WriteLine($"Nome: {custelinha.Nome} -- Idade: {custelinha.Idade} -- Raça: {custelinha.Raça}\n\n");

            Console.WriteLine("Cachorro clone");
            Console.WriteLine($"Nome: {custelinhaClone.Nome} -- Idade: {custelinhaClone.Idade} -- Raça: {custelinhaClone.Raça}");

            Console.ReadKey();



        }
    }
}
