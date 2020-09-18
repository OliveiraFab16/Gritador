using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string digiteUmaPalavra;

            //<---Inicio(Digite)--->//
            Console.Write("digiteUmaPalavra: ");
            digiteUmaPalavra = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine($"{digiteUmaPalavra}!!!".ToUpper());
            //<---Fim(Digite)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
        }
    }
}
