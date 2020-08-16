using System;

namespace ExPorcentagem_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero real: ");
            double input = double.Parse(Console.ReadLine());

            double porcentagem = input * 20.00 / 100;

            Console.WriteLine("O número acrescentado de 20 por cento = " + (porcentagem + input)); 
        }
    }
}
