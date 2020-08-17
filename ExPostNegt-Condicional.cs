using System;

namespace ExPostNegt_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            double input = double.Parse(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine("O numero eh positivo");
            } else
            {
                Console.WriteLine("O numero eh negativo");
            }
        }
    }
}
