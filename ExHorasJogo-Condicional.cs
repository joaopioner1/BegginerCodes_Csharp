
using System;

namespace ExHorasJogo_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a hora que o jogo comecou e terminou: ");
            String[] vet = Console.ReadLine().Split(' ');
            int h1 = int.Parse(vet[0]);
            int h2 = int.Parse(vet[1]);

            int duracao = 0;
            if (h1 > h2)
            {
                duracao = 24 - h1 + h2;
            } 
            else
            {
                duracao = h1 - h2;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
