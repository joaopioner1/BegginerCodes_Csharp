using System;

namespace ExCircunferencia_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o raio: ");
            double r = double.Parse(Console.ReadLine());

            double area = 3.14 * Math.Pow(r, 2);
            double diam = r * 2;
            double comp = 2 * 3.14 * r;

            Console.WriteLine("Area = " + area.ToString("F3"));
            Console.WriteLine("Diametro = " + diam.ToString("F3"));
            Console.WriteLine("comp = " + comp.ToString("F3"));
        }
    }
}
