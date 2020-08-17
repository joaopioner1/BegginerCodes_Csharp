using System;

namespace ExBhaskara_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando bhaskara");
            Console.Write("Insira o valor de A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            
            double x1 = (-b + delta) / a * 2;
            double x2 = (-b - delta) / a * 2;

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }   
    }
}
