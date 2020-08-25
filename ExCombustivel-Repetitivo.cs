using System;

namespace ExCombustivel_Repetitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (input != 4)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    alcool += 1;
                } 
                else if (input == 2)
                {
                    gasolina += 1;
                } 
                else if (input == 3)
                {
                    diesel += 1;
                }
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool = " + alcool);
            Console.WriteLine("Gasolina = " + gasolina);
            Console.WriteLine("Diesel = " + diesel);
        }
    }
}
