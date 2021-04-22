using System;
using System.Collections.Generic;
using System.Linq;

namespace Enumerable
{
    //  IEnumerable é uma ferramenta usada em consultas grandes onde ela vai percorrer a lista até onde encontrar o item, 
    //ja na busca com List toda a lista sera percorrida mesmo o item estando no inicio da mesma, usar IEnumerable traz grandes
    //vantagens em ocupação de memória e tempo de resposta nas pesquisas.

    public class Program
    {

        static void Main(string[] args)
        {
            var car1 = new Carro("Golf");
            var car2 = new Carro("Golf2");
            var car3 = new Carro("Golf3");
            var car4 = new Carro("Golf4");
            var car5 = new Carro("Golf5");
            var car6 = new Carro("Golf6");
            var car7 = new Carro("Golf7");
            var car8 = new Carro("Golf8");
            var car9 = new Carro("Golf9");
            var car10 = new Carro("Golf10");
            var car11 = new Carro("Golf11");
            var car12 = new Carro("Golf12");
            var car13 = new Carro("Golf13");
            var car14 = new Carro("Golf14");
            var car15 = new Carro("Golf15");
            var car16 = new Carro("Golf16");

            List<Carro> carroLista = new List<Carro>();

            carroLista.Add(car1);
            carroLista.Add(car2);
            carroLista.Add(car3);
            carroLista.Add(car4);
            carroLista.Add(car5);
            carroLista.Add(car6);
            carroLista.Add(car7);
            carroLista.Add(car8);
            carroLista.Add(car9);
            carroLista.Add(car10);
            carroLista.Add(car11);
            carroLista.Add(car12);
            carroLista.Add(car13);
            carroLista.Add(car14);
            carroLista.Add(car15);
            carroLista.Add(car16);

            Console.WriteLine("Consulta com IEnumereble:\n");
            var carro = carroLista.Where(x => x.Modelo == CarroBusca());
            var c = carro.FirstOrDefault();
            Console.WriteLine(c.Modelo);

            Console.WriteLine("\n\nConsulta com List:\n");
            var carro2 = carroLista.Where(x => x.Modelo == CarroBusca()).ToList();
            var c2 = carro2.FirstOrDefault();
            Console.WriteLine(c2.Modelo);

            Console.ReadKey();

            string CarroBusca()
            {
                Console.WriteLine($"Analisando Lista!");
                string car = "Golf3";
                return car;
            }
        }
    }

    public class Carro
    {
        public string Modelo { get; set; }


        public Carro(string modelo)
        {
            Modelo = modelo;
        }

    }
}
