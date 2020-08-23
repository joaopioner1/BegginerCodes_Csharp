using System;
using System.Transactions;

namespace ExMultiplo_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos.");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos.");
            }
        }
    }
}
