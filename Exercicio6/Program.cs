using System;

namespace RefOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação, que demonstre a diferença entre REF e OUT."+Environment.NewLine);
            //Exemplo de REF
            //Objeto Recebe Nome
            Objeto obj = new Objeto();
            Console.WriteLine("Escreva um Nome que será escrito no Objeto.Nome" + Environment.NewLine);
            obj.Nome = Console.ReadLine();
            Console.WriteLine("Nome esta com Valor digitado");
            Console.WriteLine(" * "+obj.Nome+" * ");
            //Mudo o objeto atraves da Referencia
            obj.mudarNomeParaAlan(ref obj);
            Console.WriteLine("Chamando metodo passando REF ele muda o valor do Objeto e sua referencia");
            Console.WriteLine(" * " +obj.Nome + " * " + Environment.NewLine);

            //Exemplo de OUT
            Console.WriteLine("Utilizando o OUT o Valor ja deve estar setado no método \ne o objeto instanciado ja vai vir com um valor:");
            string msg1;
            int idade1;
            obj.Metodo(out msg1, out idade1);
            Console.WriteLine(msg1);
            Console.WriteLine(" 2º " + idade1);
            Console.WriteLine("As variaveis criadas receberam os valores que vieram do Método");
        }        
    }
}
