using System;

namespace ExAntecessor_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um numero inteiro: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("O numero antecessor = " + (input - 1));
        }
    }
}
