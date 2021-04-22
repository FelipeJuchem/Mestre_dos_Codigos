using System;

namespace Exercicio4
{

    //Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão.


    public class Program
    {

        static public Televisao televisao = new Televisao();
        static public ControleRemoto controle = new ControleRemoto();

        static void Main(string[] args)
        {
        inicio:

            Console.WriteLine("-------------------------------------\n" +
             $"| Canal:{televisao.Canal}                           |\n" +
             "|                                   |\n" +
             "|                                   |\n" +
             "|                TV                 |\n" +
             "|                                   |\n" +
             "|                                   |\n" +
             "|                                   |\n" +
             "|                                   |\n" +
             $"|                           Vol:{televisao.Vomule}   |\n" +
             "-------------------------------------\n" +
             "                 ||||                \n" +
             "                 ||||                \n" +
             "          ------------------         \n\n");
             


            Console.WriteLine("Controle Remoto:\n" +
                "Opções:\n" +
                " Trocar canal = 1\n" +
                " Subir canal = 2\n" +
                " Descer canal = 3\n" +
                " Aumentar volume = 4\n" +
                " Diminuir volume = 5");
            
            Console.Write("Digite a opção desejada:");
            int opcao = int.Parse(Console.ReadLine());

            const int TrocarCanal = 1;
            const int AumentarCanal = 2;
            const int DiminuirCanal = 3;
            const int AumentarVolume = 4;
            const int DiminuirVolume = 5;

            switch (opcao)
            {
                case TrocarCanal:
                    controle.TrocarCanal(televisao);
                    break;
                case AumentarVolume:
                    controle.AumentarVolume(televisao);
                    break;
                case DiminuirVolume:
                    controle.DiminuirVolume(televisao);
                    break;
                case AumentarCanal:
                    controle.SubirCanal(televisao);
                    break;
                case DiminuirCanal:
                    controle.DescerCanal(televisao);
                    break;
            }

            Console.Clear();
            goto inicio;

























           
        
        
        
        
        



        
        }
    }
}
