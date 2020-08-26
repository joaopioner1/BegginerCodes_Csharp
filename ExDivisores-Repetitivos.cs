using System;

namespace ExDivisores_Repetitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
