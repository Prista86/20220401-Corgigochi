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
            int giornata = 0;
            bool morto = false;
            int modifTempi = 1;
            var rnd = new Random();
            int tempoMin = 10 * modifTempi;
            int tempoMax = 20 * modifTempi;
            int tempoDay = 60 * modifTempi;
            int TempoCicloWhile = 1000;

            int dormire = tempoDay;
            int mangiare =rnd.Next(tempoMin, tempoMax);
            int pulire =rnd.Next(tempoMin, tempoMax);
            int coccole =rnd.Next(tempoMin, tempoMax);


            Corgi corgi = new Corgi();
            corgi.Nome = "Roosvelt";
            //corgi.Felice = 0;
            corgi.sFelice = "";
            corgi.sTriste = "";
            corgi.sArrabbiato = "";
            corgi.sDepresso = "";





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

            corgi.StampaCorgi();
            while (!morto)
            {
                Console.SetCursorPosition(79, 21);
                dormire--;
                mangiare--;
                pulire--;
                coccole--;
                giornata++;



                if (dormire == 0)
                {
                    //Console.Beep();
                    corgi.VoglioDormire(giocatore, giornata);
                    dormire = tempoDay;
                    mangiare = rnd.Next(tempoMin, tempoMax);
                    pulire = rnd.Next(tempoMin, tempoMax);
                    coccole = rnd.Next(tempoMin, tempoMax);
                }

                if (mangiare == 0)
                {
                    //Console.Beep();
                    corgi.VoglioMangiare(giocatore, giornata);
                    mangiare =rnd.Next(tempoMin, tempoMax);
                }
                if (coccole == 0)
                {
                    //Console.Beep();
                    corgi.VoglioCoccole(giocatore, giornata);
                    pulire =rnd.Next(tempoMin, tempoMax);

                }
                if (pulire == 0)
                {
                    //Console.Beep();
                    corgi.DeviPulire(giocatore, giornata);
                    coccole =rnd.Next(tempoMin, tempoMax);

                }

                if (corgi.UmoreCorgi > 100)
                {
                    morto = true;
                }
                Thread.Sleep(TempoCicloWhile);
            }
            //Console.Beep();
            //Console.Beep();
            Console.WriteLine("E' morto..");
            Console.ReadKey();

        }
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
