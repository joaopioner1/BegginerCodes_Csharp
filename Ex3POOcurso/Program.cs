using System;
using System.Net.Http.Headers;

namespace Ex3POOcurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            e1.name = Console.ReadLine();
            Console.Write("Salário: ");
            e1.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            e2.name = Console.ReadLine();
            Console.Write("Salário: ");
            e2.salary = double.Parse(Console.ReadLine());

            double media = (e1.salary + e2.salary) / 2.0;
            Console.WriteLine("Salário médio = " + media);
        }
    }
}
