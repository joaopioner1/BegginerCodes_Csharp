using System;

namespace ExLinhaNQC_Repetitivo // N = normal Q = quadrado C = cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                int quad = i * i;
                Console.Write(" " + quad);
                int cubo = i * i * i;
                Console.WriteLine(" " + cubo);

            }
        }
    }
}
