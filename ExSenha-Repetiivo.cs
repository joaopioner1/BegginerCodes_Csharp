using System;

namespace ExSenha_Repetiivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Acesso ínválido: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso válido.");
        }
    }
}
