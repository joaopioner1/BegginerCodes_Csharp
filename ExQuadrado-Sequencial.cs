using System;

namespace ExQuadrado_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine("O quadrado desse numero eh: " + Math.Pow(input, 2));
        }
    }
}
