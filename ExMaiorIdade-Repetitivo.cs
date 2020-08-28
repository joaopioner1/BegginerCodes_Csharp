using System;

namespace ExMaiorIdade_Repetitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de idades que deseja digitar: ");
            int input = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i < input; i++)
            {
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    soma += age;
                }
            }
            Console.WriteLine("Soma das idade maiores de 18 = " + soma);
        }
    }
}
