using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Problemi:
    // Come utilizzare una funzioen dentro una classe
    // come mettere un ReadLine con scadenza temporale

namespace _20220401_Corgigochi
{
    class Program
    {
        static void Main(string[] args)
        {
            string giocatore = "Luca";
            int numero = 1;
            int dormire = numero;
            int mangiare = numero;
            int pulire = numero;
            int coccole = numero;

            Corgi corgi = new Corgi();
            corgi.Nome = "Roosvelt";
            corgi.Felice = 0;
            corgi.Triste = 0;
            corgi.Arrabbiato = 0;
            corgi.Depresso = 0;
            corgi.Dormire = 0;
            corgi.Mangiare = 0;
            corgi.Coccole = 0;
            corgi.Pulire = 0;


            //Console.WriteLine("Ciao! Come ti chiami???");
            //giocatore = Console.ReadLine();
            //Console.WriteLine($"Oggi {giocatore} è proprio un giorno speciale!!");
            //Console.WriteLine("Hai ottenuto il tuo primo Corgimon!!!");
            //Console.ReadKey();
            //Console.WriteLine("Che nome gli vuoi dare?");
            //nomeCorgi = Console.ReadLine();
            //Console.WriteLine($"{corgi.Nome} è veramente un bel nome!!");
            //Console.ReadKey();
            //StampaCorgi(corgi.Nome);
            //Console.WriteLine("Tra poco inizierà la tua nuova avventura!!!");
            //Console.ReadKey();

            //for (int i = 3; i > 0; i--)
            //{
            //    Console.Clear();
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}           

            while (true)
            {
                dormire--;
                mangiare--;
                pulire--;
                coccole--;
                if (dormire == 0)
                {
                    corgi.StampaCorgi();
                    corgi.VoglioDormire();
                    dormire = numero;
                }
                
                if (mangiare == 0)
                {
                    corgi.StampaCorgi();
                    corgi.VoglioMangiare();                    
                    mangiare = numero;
                }
                if (pulire == 0)
                {
                    corgi.StampaCorgi();
                    corgi.DeviPulire();                   
                    pulire = numero;
                }
                if (coccole == 0)
                {
                    corgi.StampaCorgi();

                    corgi.VoglioCoccole();
                    coccole = numero;
                }

                if (corgi.Dormire + corgi.Mangiare+corgi.Pulire+corgi.Coccole < 10)
                {
                    corgi.Felice = 99;
                }
                if (corgi.Dormire + corgi.Mangiare + corgi.Pulire + corgi.Coccole > 10)
                {
                    corgi.Triste = 99;
                }
                if (corgi.Dormire + corgi.Mangiare + corgi.Pulire + corgi.Coccole > 20)
                {
                    corgi.Arrabbiato = 99;
                }
                if (corgi.Dormire + corgi.Mangiare + corgi.Pulire + corgi.Coccole > 30)
                {
                    corgi.Depresso = 99;
                }
                Console.Clear();
                Console.SetCursorPosition(25, 17);
                //Thread.Sleep(1000);
            }
        }
    }
}
