using System;
using System.Transactions;

namespace ExGasolina_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de L que seu carro faz por km: ");
            double lKm = double.Parse(Console.ReadLine());
            Console.Write("Insira a quilometragem incial do automovel: ");
            double kmIncial = double.Parse(Console.ReadLine());
            Console.Write("Insira a quilometagem final do automovel: ");
            double kmFinal = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da gasolina: ");
            double precoGasolina = double.Parse(Console.ReadLine());

            double media = (kmFinal - kmIncial) / lKm;
            double precoPagar = media * precoGasolina / 4;

            Console.WriteLine("O total a pagar dividido por todos é: %.2f" + precoPagar.ToString("F2"));

        }
    }
}