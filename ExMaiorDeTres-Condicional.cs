using System;

namespace ExMaiorDeTres_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o terceiro número: ");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O número maior é = " + n1);
            }
            else if (n2 < n3)
            {
                Console.WriteLine("O número maior é = " + n3);
            }
            else
            {
                Console.WriteLine("O número maior é = " + n2);
            }

        }
    }
}
