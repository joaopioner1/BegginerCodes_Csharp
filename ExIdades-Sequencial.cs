using System;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um nome: ");
            String nome1 = Console.ReadLine();
            Console.Write("Insira uma idade:" );
            double idade1 = double.Parse(Console.ReadLine());

            Console.Write("Insira outro nome:" );
            String nome2 = Console.ReadLine();
            Console.Write("Insira outra idade: ");
            double idade2 = double.Parse(Console.ReadLine());

            double media = (idade1 + idade2) / 2;
            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " é " + media + " anos.");
        }
    }
}
