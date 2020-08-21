using System;
using System.Runtime.InteropServices;
using System.Globalization;

namespace ExUri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero do usario: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de horas trabalhadas: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Insira quanto o usuario recebe por hora: ");
            double valorH = double.Parse(Console.ReadLine());

            double salary = valorH * h;
            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
