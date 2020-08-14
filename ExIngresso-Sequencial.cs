using System;

namespace ExIngresso_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do ingresso: ");
            double valorIngresso = double.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de socios: ");
            int numeroSocios = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de criancas: ");
            int numeroCriancas = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de pessoas comuns: ");
            int numeroComuns = int.Parse(Console.ReadLine());

            int publicoTotal = numeroComuns + numeroCriancas + numeroSocios;
            double valorPendente = publicoTotal * valorIngresso;
            double desconto = valorIngresso * 30.00 / 100 * numeroSocios;
            double valorTotal = numeroComuns * numeroSocios - desconto;

            Console.WriteLine("Publico total = " + publicoTotal);
            Console.WriteLine("Valor arrecadado = " + valorTotal);
            Console.WriteLine("Valor Pendente = " + (valorPendente - valorTotal));
        }
    }
}
