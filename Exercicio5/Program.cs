using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação que calcule a fórmula de Bhaskara." + Environment.NewLine);

            Console.WriteLine("Calculo de Bhaskara"+Environment.NewLine);
            Console.WriteLine("Insira o valor A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor C");
            double c = double.Parse(Console.ReadLine());

            double x = Math.Pow(b, 2) - (4 * a * c);
            x = Math.Sqrt(x);
            if (x >= 0)
            {
                double x1 = (-b + x);
                double x2 = (-b - x);
                x1 = x1 / (2 * a);
                x2 = x2 / (2 * a);
                Console.WriteLine("x1: {0:f4}", x1);
                Console.WriteLine("x2: {0:f4}", x2);
            }
            else
            {
                Console.WriteLine("A equação de 2º grau não possui raízes reais!");
            }
        }
    }
}
