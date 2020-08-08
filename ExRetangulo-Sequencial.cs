using System;

namespace ExRetangulo_Sequencial
{
    class Program
    {
        static void Main(string[] args) {

            double altura, largura;
            
            Console.Write("Insira a altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Insira a largura do retângulo: ");
            largura = double.Parse(Console.ReadLine());

            double area = altura * largura;
            double perimetro = 2 * (altura + altura) + 2 * (largura + largura);
            double diagonal = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));

            Console.WriteLine("AREA = " + area);
            Console.WriteLine("PERÍMETRO = " + perimetro);
            Console.WriteLine("DIAGONAL = " + diagonal);
        }
    }
}
