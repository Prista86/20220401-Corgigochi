using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20220401_Corgigochi
{
    class Program
    {
        static void Main(string[] args)
        {
            string giocatore = "Luca";            
            bool esci = false;
            int modifTempi = 1;
            var rnd = new Random();
            int tempoMin = 15 * modifTempi;
            int tempoMax = 20 * modifTempi;
            int tempoDay = 50 * modifTempi;
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
            int timeHide = 2500;

            string dateLastPlay = "";

            Corgi corgi = new Corgi();
            corgi.Nome = "1234567890";
            corgi.sFelice = "";
            corgi.sTriste = "";
            corgi.sArrabbiato = "";
            corgi.sDepresso = "";
            corgi.modUmoreCorgi = 0;
            corgi.Giornata = 0;

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
                    else if (minutes < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Brutta carogna mi hai abbandonato per ben " + seconds + "  Secondi!!!");
                        Console.ReadKey();
                    }
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
            while (!esci)
            {
                Console.SetCursorPosition(79, 22);
                dormire--;
                mangiare--;
                pulire--;
                coccole--;
                if (dormire == 0)
                {
                    //Console.Beep();
                    corgi.VoglioDormire(corgi, giocatore, timeHide, dateLastPlay);
                    dormire = tempoDay;
                    mangiare = rnd.Next(tempoMin, tempoMax);
                    pulire = rnd.Next(tempoMin, tempoMax);
                    coccole = rnd.Next(tempoMin, tempoMax);
                }

                if (mangiare == 0)
                {
                    //Console.Beep();
                    corgi.VoglioMangiare(corgi, giocatore, timeHide, dateLastPlay);
                    mangiare = rnd.Next(tempoMin, tempoMax);
                }
                if (coccole == 0)
                {
                    //Console.Beep();
                    corgi.VoglioCoccole(corgi, giocatore, timeHide, dateLastPlay);
                    pulire = rnd.Next(tempoMin, tempoMax);

                }
                if (pulire == 0)
                {
                    //Console.Beep();
                    corgi.DeviPulire(corgi, giocatore, timeHide, dateLastPlay);
                    coccole = rnd.Next(tempoMin, tempoMax);

                }
                if (corgi.UmoreCorgi > 10000)
                {
                    esci = true;
                    Console.WriteLine("E' morto..");
                    Console.ReadKey();
                }
                else if (corgi.Giornata > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Bravo lo hai tenuto in vita per 5 giorni! Hai vinto!");
                    Console.ReadKey();
                    esci = true;
                }

                if (Console.KeyAvailable == true)
                {
                    Console.ReadKey();
                    StampaAzioni();
                    AzioniPratica(corgi, giocatore, timeHide, dateLastPlay);
                }
                else if (Console.KeyAvailable == false)
                {
                    //Console.WriteLine("NON Press ");
                }

                Thread.Sleep(TempoCicloWhile);
            }
            //Console.Beep();
            //Console.Beep();

        }

        static void FaiDormire(Corgi corgi, string giocatore, int timeHide)
        {
            if (corgi.ProbDormire < 1)
            {                
                Console.SetCursorPosition(46, 11);
                Console.WriteLine(giocatore + " non devo mica Dormire!!!                  ");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("                           ");
            }
            else
            {
                Console.SetCursorPosition(43, 11);
                Console.WriteLine($"Buona notte {giocatore} a domani!");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                corgi.ProbDormire -= 5;
                corgi.StampaCorgi();
                Console.SetCursorPosition(35, 24);
                Console.WriteLine($"{corgi.Nome} Va a dormire! La giornata n° {corgi.Giornata} è finita!");
                Console.SetCursorPosition(79, 22);
                corgi.Necessita = "";
                Console.SetCursorPosition(79, 22);
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("                                                                    ");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                 ");
            }

        }
        static void FaiMangiare(Corgi corgi, string giocatore, int timeHide)
        {
            if (corgi.ProbMangiare < 1)
            {
                Console.SetCursorPosition(45, 11);
                Console.WriteLine(giocatore + " non devo mangiare!!!              ");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                ");
            }
            else
            {

                Console.SetCursorPosition(43, 11);
                Console.WriteLine($"Bravo {giocatore} mi sono saziato un po'!");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                corgi.ProbMangiare -= 5;
                corgi.StampaCorgi();
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                 ");
                Console.SetCursorPosition(35, 24);
                Console.WriteLine($"Bene! {corgi.Nome} ha mangiato!");
                Console.SetCursorPosition(79, 22);
                corgi.Necessita = "";
                Console.SetCursorPosition(79, 22);
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("                                                                    ");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");

            }


        }
        static void Pulisci(Corgi corgi, string giocatore, int timeHide)
        {
            if (corgi.ProbPulire < 1)
            {
                Console.SetCursorPosition(47, 11);
                Console.WriteLine("Non ho mica Cagato!!!         ");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(47, 11);
                Console.WriteLine("                                ");
                Console.SetCursorPosition(79, 22);
            }
            else
            {
                Console.SetCursorPosition(35, 11);
                Console.WriteLine($"Grazie {giocatore} ora non sento più puzza di mérd@!");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                corgi.ProbPulire -= 5;
                corgi.StampaCorgi();
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                 ");
                Console.SetCursorPosition(35, 24);
                Console.WriteLine($"Ottimo! Hai pulito la cacca di {corgi.Nome}!");
                Console.SetCursorPosition(79, 22);
                corgi.Necessita = "";
                Console.SetCursorPosition(79, 22);
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("                                                                    ");
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(" ");

            }



        }

        static void GiocaConLui(Corgi corgi, string giocatore, int timeHide)
        {
            //corgi.modUmoreCorgi -= 30;
            corgi.ProbPulire = 0;
            corgi.ProbDormire = 0;
            corgi.ProbCoccole = 0;
            corgi.ProbMangiare = 0;
            Console.SetCursorPosition(35, 11);
            Console.WriteLine($"Grazie!! {giocatore} è sempre bello giocare insieme!!");
            Console.SetCursorPosition(79, 22);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(35, 24);
            Console.WriteLine($"Bello! Hai giocato con {corgi.Nome}!");
            Console.SetCursorPosition(79, 22);
            corgi.Necessita = "";
            Console.SetCursorPosition(79, 22);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 24);
            Console.WriteLine("                                                                    ");
            Console.SetCursorPosition(79, 22);
            Console.WriteLine(" ");
            Console.SetCursorPosition(45, 11);
            Console.WriteLine("                                 ");

        }
        static void FaiNulla(Corgi corgi, string giocatore, int timeHide)
        {
            corgi.modUmoreCorgi += 20;
            Console.SetCursorPosition(35, 11);
            Console.WriteLine($"No ma bravo {giocatore} fregatene proprio di me..!");
            Console.SetCursorPosition(79, 22);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 11);

        }
        public static void AzioniPratica(Corgi corgi, string giocatore, int timeHide, string dateLastPlay)
        {
            Console.SetCursorPosition(79, 22);
            string azione = Console.ReadLine();
            int i = 1;
            while (i > 0)
            {
                if (azione == "1" || azione == "2" || azione == "3" || azione == "4" || azione == "5" || azione == "6" || azione == "7")
                {
                    i = 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Devi inserire un numero da 1 a 7");
                    azione = Console.ReadLine();
                }
            }
            bool n = int.TryParse(azione, out int azioneNum);
            switch (azioneNum)
            {
                case 1:
                    corgi.Giornata++;
                    FaiDormire(corgi, giocatore, timeHide);
                    break;
                case 2:
                    FaiMangiare(corgi, giocatore, timeHide);
                    break;
                case 3:
                    Coccolare(corgi, giocatore, timeHide);
                    break;
                case 4:
                    Pulisci(corgi, giocatore, timeHide);
                    break;
                case 5:
                    GiocaConLui(corgi, giocatore, timeHide);
                    break;
                case 6:
                    FaiNulla(corgi, giocatore, timeHide);
                    break;
                case 7:
                    EsciDalGioco(corgi, giocatore, dateLastPlay);
                    break;
                default:
                    while (azioneNum != 1 || azioneNum != 2 || azioneNum != 3 || azioneNum != 4 || azioneNum != 5 || azioneNum != 6 || azioneNum != 7)
                    {
                        Console.SetCursorPosition(35, 25);
                        Console.WriteLine("Devi inserire un numero da 1 a 7");
                        Console.ReadKey();
                    }
                    break;
            }

        }
        static void Coccolare(Corgi corgi, string giocatore, int timeHide)
        {
            corgi.modUmoreCorgi -= 10;
            corgi.ProbPulire -= 2;
            corgi.ProbDormire -= 2;
            //this.ProbCoccole -= 2;
            corgi.ProbMangiare -= 2;
            Console.SetCursorPosition(40, 11);
            Console.WriteLine($"Bravo {giocatore} Ne avevo proprio bisogno!");
            Console.SetCursorPosition(79, 22);
            Console.WriteLine(" ");
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("                                               ");
            corgi.ProbCoccole -= 5;
            corgi.StampaCorgi();
            Console.SetCursorPosition(45, 11);
            Console.WriteLine("                                 ");
            Console.SetCursorPosition(35, 24);
            Console.WriteLine($"Bravo! Hai coccolato {corgi.Nome}!");
            Console.SetCursorPosition(79, 22);
            corgi.Necessita = "";
            Console.SetCursorPosition(79, 22);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 24);
            Console.WriteLine("                                                                    ");
            Console.SetCursorPosition(79, 22);
            Console.WriteLine(" ");



        }
        static void SalvaLife(Corgi corgi, string giocatore, string dateLastPlay)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\LukePC\\Desktop\\Camerana\\C# Camerana\\Esercizi Luca\\20220401 Corgigochi\\InfoCorgi.txt", false, Encoding.ASCII);
            sw.WriteLine(corgi.Nome);
            sw.WriteLine(corgi.Necessita);
            sw.WriteLine(corgi.ProbDormire);
            sw.WriteLine(corgi.ProbMangiare);
            sw.WriteLine(corgi.ProbCoccole);
            sw.WriteLine(corgi.ProbPulire);
            sw.WriteLine(corgi.UmoreCorgi);
            sw.WriteLine(giocatore);
            DateTime dt = DateTime.Now;
            dateLastPlay = dt.ToString();
            sw.WriteLine(dateLastPlay);
            sw.Close();


        }
        static void EsciDalGioco(Corgi corgi, string giocatore, string dateLastPlay)
        {
            Console.Clear();
            Console.WriteLine("Sei sicuro che vuoi uscire? ");
            string scelta = Console.ReadLine();
            if (scelta == "S")
            {
                Console.WriteLine("Vuoi salvare la partita?");
                scelta = Console.ReadLine();
                if (scelta == "S")
                {
                    SalvaLife(corgi, giocatore, dateLastPlay);
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static void StampaAzioni()
        {
            Console.SetCursorPosition(35, 13);
            Console.WriteLine(" _____________________________________________");
            Console.SetCursorPosition(35, 14);
            Console.WriteLine("|                                             |");
            Console.SetCursorPosition(35, 15);
            Console.WriteLine("|  1. Mandalo a dormire.                      |");
            Console.SetCursorPosition(35, 16);
            Console.WriteLine("|  2. Dargli da mangiare.                     |");
            Console.SetCursorPosition(35, 17);
            Console.WriteLine("|  3. Fagli le coccole.                       |");
            Console.SetCursorPosition(35, 18);
            Console.WriteLine("|  4. Pulisci la cacca.                       |");
            Console.SetCursorPosition(35, 19);
            Console.WriteLine("|  5. Gioca con lui.                          |");
            Console.SetCursorPosition(35, 20);
            Console.WriteLine("|  6. Non  fare nulla.                     ___|");
            Console.SetCursorPosition(35, 21);
            Console.WriteLine("|  7. Esci dal gioco.                     |   |");
            Console.SetCursorPosition(35, 22);
            Console.WriteLine("|  Vuoi eseguire una di queste Azioni?    |   |");
            Console.SetCursorPosition(35, 23);
            Console.WriteLine("|_________________________________________|___|");
        }
    }



}






