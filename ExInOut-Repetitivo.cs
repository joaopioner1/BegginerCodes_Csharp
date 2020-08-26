using System;

namespace ExInOut_Repetitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de números que deseja digitar: ");
            int n = int.Parse(Console.ReadLine());

            short countIn = 0, countOut = 0;
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input >= 10 && input <= 20)
                {
                    countIn += 1;
                } else
                {
                    countOut += 1;
                }
            }
            Console.WriteLine("\n" + countIn + " in");
            Console.WriteLine(countOut + " out");
        }
    }
          
}
