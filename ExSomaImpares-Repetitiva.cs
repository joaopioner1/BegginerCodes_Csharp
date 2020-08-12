using System;
using System.Xml.Serialization;

namespace ExSomaImpares_Repetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int troca;
            if (x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }
            int soma = 0;
            for (int i = x+1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine("SOMA DOS ÍMPARES = " + soma);
        }
    }
}
