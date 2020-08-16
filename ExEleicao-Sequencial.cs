using System;

namespace ExEleicao_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o numero total de eleitores: ");
            int eleitores = int.Parse(Console.ReadLine());
            Console.Write("Insira o numero total de votos validos: ");
            int vValidos = int.Parse(Console.ReadLine());
            Console.Write("Insira o numero total de votos brancos: ");
            int vBrancos = int.Parse(Console.ReadLine());
            Console.Write("Insira o numero total de votos nulos: ");
            int vNulos = int.Parse(Console.ReadLine());

            float perValidos = 100 * vValidos / eleitores; //per = percent
            float perBrancos = 100 * vBrancos / eleitores;
            float perNulos = 100 * vNulos / eleitores;

            Console.WriteLine("Porcentagem de votos validos: " + perValidos.ToString("F3") + "%");
            Console.WriteLine("Porcentagem de votos brancos: " + perBrancos.ToString("F3") + "%");
            Console.WriteLine("Porcentagem de votos nulos: " + perNulos.ToString("F3") + "%");

        }
    }
}
