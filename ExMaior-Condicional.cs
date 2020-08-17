using System;

namespace ExMaior_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O numero maior eh: " + n1);
            } else
            {
                Console.WriteLine("O numero maior eh: " + n2);
            }
        }
    }
}
