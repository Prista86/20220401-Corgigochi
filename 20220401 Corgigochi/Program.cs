using System;
using System.IO;
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
            //int giornata = 0;
            bool morto = false;
            int modifTempi = 1;
            var rnd = new Random();
            int tempoMin = 1 * modifTempi;
            int tempoMax = 2 * modifTempi;
            int tempoDay = 3 * modifTempi;
            int TempoCicloWhile = 1000;

            int dormire = tempoDay;
            int mangiare = rnd.Next(tempoMin, tempoMax);
            int pulire = rnd.Next(tempoMin, tempoMax);
            int coccole = rnd.Next(tempoMin, tempoMax);

            string stringProbDormire = "";
            string stringProbMangiare = "";
            string stringProbCoccole = "";
            string stringProbPulire = "";
            string stringUmore = "";
            string dataUltimaGiocata = "";

            string scelta;


            Corgi corgi = new Corgi();
            corgi.Nome = "1234567890";
            corgi.sFelice = "";
            corgi.sTriste = "";
            corgi.sArrabbiato = "";
            corgi.sDepresso = "";

            string path = @"C:\Users\LukePC\Desktop\Camerana\C# Camerana\Esercizi Luca\20220401 Corgigochi\InfoCorgi.txt";


            if (File.Exists(path))
            {
                Console.SetCursorPosition(20, 10);
                Console.WriteLine("Ciao! Sono stati trovati salvataggi pregressi, vuoi caricarli? 'S/N'");
                Console.SetCursorPosition(50, 12);
                scelta = Console.ReadLine();
                if (scelta == "S")
                {
                    StreamReader sr = new StreamReader("C:\\Users\\LukePC\\Desktop\\Camerana\\C# Camerana\\Esercizi Luca\\20220401 Corgigochi\\InfoCorgi.txt");
                    corgi.Nome = sr.ReadLine();
                    corgi.Necessita = sr.ReadLine();
                    stringProbDormire = sr.ReadLine();
                    stringProbMangiare = sr.ReadLine();
                    stringProbCoccole = sr.ReadLine();
                    stringProbPulire = sr.ReadLine();
                    stringUmore = sr.ReadLine();
                    giocatore = sr.ReadLine();
                    dataUltimaGiocata = sr.ReadLine();
                    sr.Close();

                    corgi.ProbDormire = int.Parse(stringProbDormire);
                    corgi.ProbMangiare = int.Parse(stringProbMangiare);
                    corgi.ProbCoccole = int.Parse(stringProbCoccole);
                    corgi.ProbPulire = int.Parse(stringProbPulire);
                    corgi.UmoreCorgi = int.Parse(stringUmore);






                    DateTime dataAttuale = DateTime.Now;
                    DateTime date = DateTime.Parse(dataUltimaGiocata);

                    TimeSpan result = dataAttuale.Subtract(date);
                    Console.WriteLine(result);
                    int minutes = result.Minutes;
                    int seconds = result.Seconds;
                    if (minutes > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Brutta carogna mi hai abbandonato per ben " + minutes + " Minuti e ");
                        Console.WriteLine(seconds + "secondi");
                        Console.ReadKey();
                    }
                    else if (minutes<1)
                    {
                        Console.Clear();
                        Console.WriteLine("Brutta carogna mi hai abbandonato per ben " + seconds + "  Secondi!!!");
                        Console.ReadKey();
                    }

                    //Console.WriteLine(dataAttuale-date);

                    Console.ReadKey();




                    
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("Allora ti auguro un buon inizio partita!");
                    Console.SetCursorPosition(75, 10);
                    Thread.Sleep(3000);
                    Console.Clear();


                    Console.WriteLine("Ciao! Come ti chiami???");
                    giocatore = Console.ReadLine();
                    Console.WriteLine($"Oggi {giocatore} è proprio un giorno speciale!!");
                    Console.WriteLine("Hai ottenuto il tuo primo Corgimon!!!");
                    Console.ReadKey();
                    Console.WriteLine("Che nome gli vuoi dare?");
                    while (true)
                    {
                        corgi.Nome = Console.ReadLine();
                        int lunghezzaNome = corgi.Nome.Length;
                        if (lunghezzaNome > 10)
                        {
                            Console.WriteLine("Il nome deve essere minore di 10 caratteri");
                        }
                        else
                        {
                            Console.WriteLine($"{corgi.Nome} è veramente un bel nome!!");
                            Console.ReadKey();
                            int differenzaNome = 10 - lunghezzaNome;
                            for (int i = 0; i < differenzaNome; i++)
                            {
                                corgi.Nome = (corgi.Nome + " ");
                            }
                            break;
                        }
                    }

                    Console.WriteLine("Tra poco inizierà la tua nuova avventura!!!");
                    Console.ReadKey();
                    for (int i = 3; i > 0; i--)
                    {
                        Console.Clear();
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                }
            }
            else
            {
                Console.WriteLine("Ciao! Come ti chiami???");
                giocatore = Console.ReadLine();
                Console.WriteLine($"Oggi {giocatore} è proprio un giorno speciale!!");
                Console.WriteLine("Hai ottenuto il tuo primo Corgimon!!!");
                Console.ReadKey();
                Console.WriteLine("Che nome gli vuoi dare?");
                while (true)
                {
                    corgi.Nome = Console.ReadLine();
                    int lunghezzaNome = corgi.Nome.Length;
                    if (lunghezzaNome > 10)
                    {
                        Console.WriteLine("Il nome deve essere minore di 10 caratteri");
                    }
                    else
                    {
                        Console.WriteLine($"{corgi.Nome} è veramente un bel nome!!");
                        Console.ReadKey();
                        int differenzaNome = 10 - lunghezzaNome;
                        for (int i = 0; i < differenzaNome; i++)
                        {
                            corgi.Nome = (corgi.Nome + " ");
                        }
                        break;
                    }
                }

                Console.WriteLine("Tra poco inizierà la tua nuova avventura!!!");
                Console.ReadKey();
                for (int i = 3; i > 0; i--)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }













            corgi.StampaCorgi();
            while (!morto)
            {
                Console.SetCursorPosition(79, 21);
                dormire--;
                mangiare--;
                pulire--;
                coccole--;
                //giornata++;



                if (dormire == 0)
                {
                    //Console.Beep();
                    corgi.VoglioDormire(giocatore);
                    dormire = tempoDay;
                    mangiare = rnd.Next(tempoMin, tempoMax);
                    pulire = rnd.Next(tempoMin, tempoMax);
                    coccole = rnd.Next(tempoMin, tempoMax);
                }

                if (mangiare == 0)
                {
                    //Console.Beep();
                    corgi.VoglioMangiare(giocatore);
                    mangiare = rnd.Next(tempoMin, tempoMax);
                }
                if (coccole == 0)
                {
                    //Console.Beep();
                    corgi.VoglioCoccole(giocatore);
                    pulire = rnd.Next(tempoMin, tempoMax);

                }
                if (pulire == 0)
                {
                    //Console.Beep();
                    corgi.DeviPulire(giocatore);
                    coccole = rnd.Next(tempoMin, tempoMax);

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


    }
}
