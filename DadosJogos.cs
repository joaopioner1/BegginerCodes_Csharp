using System;

namespace DadosJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa foi feito para calcular qual jogo eh o favorito e o menos favorito. " 
            +"Para parar o programa digite stop");
            Console.WriteLine("Jogos da pesquisa: Minecraft, GTAV, CSGO, Fortnite e FIFA");

            String answ; //answer
            int mine = 0, gta = 0, cs = 0, fort = 0, fifa = 0, total;
            double percentMine = 0, percentGTA = 0, percentCS = 0, percentFort = 0, percentFIFA = 0;
            Console.Write("Insira a quantidade de pessoas que irao responder a enquete: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                Console.Write("Digite o seu jogo preferido (dentre os citados acima): ");
                answ = Console.ReadLine();

                if (answ.Equals("Minecraft"))
                {
                    mine += 1;
                } else if (answ.Equals("GTAV"))
                {
                    gta += 1;
                } else if (answ.Equals("CSGO"))
                {
                    cs += 1;
                } else if (answ.Equals("Fortnite"))
                {
                    fort += 1;
                } else 
                {
                    fifa += 1;   
                }
                total = mine + gta + cs + fort + fifa;
                percentMine = 100 * mine / total; 
                percentGTA = 100 * gta / total;
                percentCS = 100 * cs / total;
                percentFort = 100 * fort / total;
                percentFIFA = 100 * fifa / total;
            }
            Console.WriteLine("\nPercentual minecraft = %" + percentMine.ToString("F2"));
            Console.WriteLine("Percentual GTA V = %" + percentGTA.ToString("F2"));
            Console.WriteLine("Percentual CSGO = %" + percentCS.ToString("F2"));
            Console.WriteLine("Percentual Fortneti = %" + percentFort.ToString("F2"));
            Console.WriteLine("Percentual FIFA = %" + percentFIFA.ToString("F2"));

        }
    }
}
