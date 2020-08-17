using System;

namespace Exdivisao_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nominador: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o denominador: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n2 > 0 || n2 < 0)
            {
                Console.WriteLine("Resultado da divisao = " + n1 / n2);
            } else
            {
                Console.WriteLine("Erro, denominador = 0;");
            }
        }
    }
}
