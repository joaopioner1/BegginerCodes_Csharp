using System;
using System.Globalization;

namespace ExDivisao_Repetitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de pares de numero que deseja digitar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                if (b != 0)
                {
                    double divisao = a / b;
                    Console.WriteLine(divisao.ToString("F1"));
                } else
                {
                    Console.WriteLine("Divisão impossível.");
                }
            }
        }
    }
}
