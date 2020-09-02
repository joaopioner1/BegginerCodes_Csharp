using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quando desejar parar o programa e ver o resultado final, digite '='");
            Console.Write("Insira o simbolo da operacao que deseja realizar( +, -, *, /): ");
            char answ = Console.ReadLine()[0];

            double conta = 1, input1 = 0, input2 = 0;
            if (answ == '+')
            {
                while (answ == '+')
                {
                    Console.Write("Insira um numero: ");
                    input1 = double.Parse(Console.ReadLine());
                    Console.Write("Insira o sinal: ");
                    answ = Console.ReadLine()[0];
                    conta += input1;
                    if (answ == '=') break;
                }
                Console.WriteLine("Soma total = " + conta);
            }
            else if (answ == '-')
            {
                while (answ != '=')
                { 
                    Console.Write("Insira um numero: ");
                    input1 = double.Parse(Console.ReadLine());
                    Console.Write("Insira o sinal: ");
                    answ = Console.ReadLine()[0];
                    if (answ == '=') break;
                    Console.Write("Insira um numero: ");
                    input2 = double.Parse(Console.ReadLine());
                    conta = input1 - input2;
                    Console.WriteLine("Substracao total = " + conta);
                }
            }
            else if (answ == '*')
            {
                while (answ != '=')
                {
                    Console.Write("Insira um numero: ");
                    input1 = double.Parse(Console.ReadLine());
                    Console.Write("Insira o sinal: ");
                    answ = Console.ReadLine()[0];
                    conta *= input1;
                    if (answ == '=') break;
                }
                Console.WriteLine("Produto total = " + conta);
            }
            else if (answ == '/')
            {
                while (answ == '/')
                {
                    Console.Write("Insira um numero: ");
                    input1 = double.Parse(Console.ReadLine());
                    Console.Write("Insira o sinal: ");
                    answ = Console.ReadLine()[0];
                    if (answ == '=') break;
                    Console.Write("Insira um numero: ");
                    input2 = double.Parse(Console.ReadLine());
                    conta = input1 / input2;

                    Console.WriteLine("Divisao = " + conta);
                }
            }
        }
    }
}
