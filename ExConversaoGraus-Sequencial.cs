using System;

namespace ExConversaoGraus_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a temperatura em graus Fahrenheit: ");
            double input = double.Parse(Console.ReadLine());

            double convert = (input - 32) / 9;

            Console.WriteLine("A temperatura em Celsius eh: " + convert.ToString("F3"));
        }
    }
}
