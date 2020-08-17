using System;

namespace ExStatusAluno_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a nota final do aluno: ");
            double input = double.Parse(Console.ReadLine());

            if (input >= 7)
            {
                Console.WriteLine("O aluno passou!");
            } else
            {
                Console.WriteLine("O aluno reprovou, faltando " + (7 - input) + " pontos para passar.");
            }
        }
    }
}
