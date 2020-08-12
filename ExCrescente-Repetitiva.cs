using System;
using System.Globalization;

namespace ExCrescente_Repetitiva
{
    class Program
    {
        static void Main(string[] args)  
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Insira o primeiro número: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            double y = double.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("CRESCENTE");
                }
                else
                {
                    Console.WriteLine("DECRESCENTE");
                }
                Console.Write("Insira o primeiro número: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Insira o segundo número: ");
                y = double.Parse(Console.ReadLine());
            }
        }
    }
}
