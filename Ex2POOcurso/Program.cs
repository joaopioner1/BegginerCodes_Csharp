using System;

namespace Ex2POOcurso
{
    class Program
    {
        static void Main(string[] args)
        { 

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Idade: ");
            p1.age = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            p1.name = Console.ReadLine();

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Idade: ");
            p2.age = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            p2.name = Console.ReadLine();

            if (p1.age > p2.age)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.name);
            } else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.name);
            }
        }
    }
}
