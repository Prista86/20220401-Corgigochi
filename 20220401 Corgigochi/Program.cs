using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220401_Corgigochi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string giocatore;
            string nomeCorgi;
            Console.WriteLine("Ciao! Come ti chiami???");
            giocatore = Console.ReadLine();
            Console.WriteLine($"Oggi {giocatore} è proprio un giorno speciale!!");
            Console.WriteLine("Hai ottenuto il tuo primo Corgimon!!!");
            Console.ReadKey();
            Console.WriteLine("Che nome gli vuoi dare");
            nomeCorgi = Console.ReadLine();
            Console.WriteLine($"{nomeCorgi} è veramente un bel nome!!");
            Console.ReadKey();
            StampaCorgi(nomeCorgi);

        }
        static void StampaCorgi(string nomeCorgi)
        {
            Console.WriteLine($"   {nomeCorgi}    ");
            Console.WriteLine("");
            Console.WriteLine(@"  ,-.___,-.   ");
            Console.WriteLine(@"  \_/_ _\_/   ");
            Console.WriteLine(@"    )O_O(     ");
            Console.WriteLine(@"   { (_) }    ");
            Console.WriteLine(@"    `-^-'     ");
            Console.ReadKey();


        }
    }
}
