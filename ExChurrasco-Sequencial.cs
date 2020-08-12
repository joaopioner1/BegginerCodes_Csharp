using System;

namespace ExChurrasco_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de mulheres que irão para a festa: ");
            int quantM = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de homens que irão para a festa: ");
            int quantH = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de crianças que irão para a festa: ");
            int quantC = int.Parse(Console.ReadLine());

            double mediaCH = quantH * 400;
            double mediaCM = quantM * 320;
            double mediaCC = quantC * 200;
            double mediaTotal = (mediaCC + mediaCH + mediaCM) / 1000;

            Console.WriteLine("O total necessário de carne para compar é: " + mediaTotal);
        }
    }
}
/*Considere que você deseja uma comemoração especial para o seu aniversário e
assim irá convidar familiares a amigos para um churrasco na sua residência. Você
irá precisar comprar a carne a ser consumida pelos seus convidados, logo precisa
de uma forma de calcular a quantidade certa a ser adquirida.
Desenvolva o algoritmo do programa para auxiliar no cálculo da quantidade de carne
bovina (sem osso) a ser comprada considerando que homens, mulheres e crianças
consomem uma quantidades diferentes de carne.
Consumo de carne médio

Homens: 400 gramas
Mulheres: 320 gramas
Crianças: 200 gramas
*Observação: geralmente é adicionada uma margem de segurança na quantidade
de carne a ser comprada para evitar que falte. Adicione uma margem de segurança
de 20% no total de carne a ser adquirida.

 */
