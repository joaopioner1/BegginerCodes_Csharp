using System;

namespace ExTempo_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a velocidade media (km/h): ");
            double vm = double.Parse(Console.ReadLine());
            Console.Write("Insira a distancia da viagem: ");
            double distancia = double.Parse(Console.ReadLine());

            int tempoHoras = (int) distancia / (int) vm;
            int tempoMinutos = (int) distancia % (int) vm;

            Console.WriteLine("O tempo levado eh: " + tempoHoras + " hr(s) e " + tempoMinutos + " min");
        }
    }
}
