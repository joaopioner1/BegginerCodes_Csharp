using System;

namespace ExTriangulo_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a base: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Insira a altura: ");
            double a = double.Parse(Console.ReadLine());

            double area = b * a / 2;

            Console.WriteLine("A area do triangulo eh: " + area.ToString("F2"));
        }
    }
}
