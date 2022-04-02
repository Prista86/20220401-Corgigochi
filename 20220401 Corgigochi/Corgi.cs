using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20220401_Corgigochi
{
    class Corgi
    {
        public string Nome { get; set; }
        public int ProbDormire { get; set; }
        public int ProbMangiare { get; set; }
        public int ProbCoccole { get; set; }
        public int ProbPulire { get; set; }
        public int UmoreCorgi { get; set; }
        public string Necessita { get; set; }
        public string sFelice { get; set; }
        public string sTriste { get; set; }
        public string sArrabbiato { get; set; }
        public string sDepresso { get; set; }
        public string StringProbDormire { get; set; }
        public string StringProbMangiare { get; set; }
        public string StringProbCoccole { get; set; }
        public string StringProbPulire { get; set; }

        int modUmoreCorgi = 0;
        int timeHide = 2500;



        //AZIONI giocatore
        public void FaiDormire(int giornata, string giocatore)
        {
            if (this.ProbDormire < 1)
            {
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("Non devo mica Dormire!!!                  ");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");                
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(46, 11);
                Console.WriteLine("                           ");
            }
            else
            {
                Console.SetCursorPosition(43, 11);
                Console.WriteLine($"Buona notte {giocatore} a domani!");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                this.ProbDormire -= 5;
                StampaCorgi();
                Console.SetCursorPosition(35, 24);
                Console.WriteLine($"{this.Nome} Va a dormire! La giornata n°{giornata}è finita!");
                Console.SetCursorPosition(79, 21);
                this.Necessita = "";
                Console.SetCursorPosition(79, 21);
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("                                                                    ");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                 ");
            }

        }
        public void FaiMangiare(string giocatore)
        {
            if (this.ProbMangiare < 1)
            {
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("Non devo Mangiare!!!              ");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                ");
            }
            else
            {

                Console.SetCursorPosition(43, 11);
                Console.WriteLine($"Bravo {giocatore} mi sono saziato un po'!");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                this.ProbMangiare -= 5;
                StampaCorgi();
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                 ");
                Console.SetCursorPosition(35, 24);
                Console.WriteLine($"Bene! {this.Nome} ha mangiato!");
                Console.SetCursorPosition(79, 21);
                this.Necessita = "";
                Console.SetCursorPosition(79, 21);
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("                                                                    ");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");

            }


        }
        public void Pulisci(string giocatore)
        {
            if (this.ProbPulire < 1)
            {
                Console.SetCursorPosition(47, 11);
                Console.WriteLine("Non ho mica Cagato!!!         ");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(47, 11);
                Console.WriteLine("                                ");
                Console.SetCursorPosition(79, 21);
            }
            else
            {
                Console.SetCursorPosition(35, 11);
                Console.WriteLine($"Grazie {giocatore} ora non sento più puzza di mérd@!");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");
                Thread.Sleep(timeHide);
                this.ProbPulire -= 5;
                StampaCorgi();
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("                                 ");
                Console.SetCursorPosition(35, 24);
                Console.WriteLine($"Ottimo! Hai pulito la cacca di {this.Nome}!");
                Console.SetCursorPosition(79, 21);
                this.Necessita = "";
                Console.SetCursorPosition(79, 21);
                Thread.Sleep(timeHide);
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("                                                                    ");
                Console.SetCursorPosition(79, 21);
                Console.WriteLine(" ");
                
            }



        }
        public void Coccolare(string giocatore)
        {
            modUmoreCorgi -= 10;
            this.ProbPulire -= 2;
            this.ProbDormire -= 2;
            //this.ProbCoccole -= 2;
            this.ProbMangiare -= 2;
            Console.SetCursorPosition(40, 11);
            Console.WriteLine($"Bravo {giocatore} Ne avevo proprio bisogno!");
            Console.SetCursorPosition(79, 21);
            Console.WriteLine(" ");
            Thread.Sleep(timeHide);            
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("                                               ");
            this.ProbCoccole -= 5;
            StampaCorgi();
            Console.SetCursorPosition(45, 11);
            Console.WriteLine("                                 ");
            Console.SetCursorPosition(35, 24);
            Console.WriteLine($"Bravo! Hai coccolato {this.Nome}!");
            Console.SetCursorPosition(79, 21);
            this.Necessita = "";
            Console.SetCursorPosition(79, 21);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 24);
            Console.WriteLine("                                                                    ");
            Console.SetCursorPosition(79, 21);
            Console.WriteLine(" ");
            


        }
        public void GiocaConLui(string giocatore)
        {
            modUmoreCorgi -= 30;
            this.ProbPulire -= 3;
            this.ProbDormire -= 3;
            this.ProbCoccole -= 3;
            this.ProbMangiare -= 3;
            Console.SetCursorPosition(35, 11);
            Console.WriteLine($"Grazie!! {giocatore} è sempre bello giocare insieme!!");
            Console.SetCursorPosition(79, 21);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("                                                            ");
            Console.SetCursorPosition(35, 24);
            Console.WriteLine($"Bello! Hai giocato con {this.Nome}!");
            Console.SetCursorPosition(79, 21);
            this.Necessita = "";
            Console.SetCursorPosition(79, 21);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 24);
            Console.WriteLine("                                                                    ");
            Console.SetCursorPosition(79, 21);
            Console.WriteLine(" ");
            Console.SetCursorPosition(45, 11);
            Console.WriteLine("                                 ");

        }
        public void FaiNulla(string giocatore)
        {
            modUmoreCorgi += 20;
            Console.SetCursorPosition(35, 11);
            Console.WriteLine($"No ma bravo {giocatore} fregatene proprio di me..!");
            Console.SetCursorPosition(79, 21);
            Thread.Sleep(timeHide);
            Console.SetCursorPosition(35, 11);

        }
        public void AzioniPratica(int giornata, string giocatore)
        {
            Console.SetCursorPosition(79, 21);
            string azione = Console.ReadLine();
            int i = 1;
            while (i > 0)
            {
                if (azione == "1" || azione == "2" || azione == "3" || azione == "4" || azione == "5" || azione == "6")
                {
                    i = 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Devi inserire un numero da 1 a 6");
                    azione = Console.ReadLine();
                }
            }
            bool n = int.TryParse(azione, out int azioneNum);
            switch (azioneNum)
            {
                case 1:
                    FaiDormire(giornata,giocatore);
                    break;
                case 2:
                    FaiMangiare(giocatore);
                    break;
                case 3:
                    Coccolare(giocatore);
                    break;
                case 4:
                    Pulisci(giocatore);
                    break;
                case 5:
                    GiocaConLui(giocatore);
                    break;
                case 6:
                    FaiNulla(giocatore);
                    break;
                default:
                    while (azioneNum != 1 || azioneNum != 2 || azioneNum != 3 || azioneNum != 4 || azioneNum != 5 || azioneNum != 6)
                    {
                        Console.SetCursorPosition(35, 25);
                        Console.WriteLine("Devi inserire un numero da 1 a 6");
                        Console.ReadKey();
                    }
                    break;
            }
        }

        //************************************************************************************************************

        //Azioni Corgi
        public void VoglioDormire(string giocatore, int giornata)
        {
            this.Necessita = $"   {giocatore} ho sonno!";
            this.ProbDormire += 5;
            StampaCorgi();
            AzioniPratica(giornata, giocatore);
        }
        public void VoglioMangiare(string giocatore, int giornata)
        {
            this.Necessita = $"    {giocatore} ho fame!";
            this.ProbMangiare += 5;
            StampaCorgi();
            AzioniPratica(giornata, giocatore);
        }
        public void DeviPulire(string giocatore, int giornata)
        {
            this.Necessita = $"   {giocatore} ho cagato..";
            this.ProbPulire += 5;
            StampaCorgi();
            AzioniPratica(giornata, giocatore);
        }
        public void VoglioCoccole(string giocatore, int giornata)
        {
            this.Necessita = $"{giocatore} voglio le coccole!!";
            this.ProbCoccole += 5;
            StampaCorgi();
            AzioniPratica(giornata, giocatore);
        }

        public void StampaCorgi()
        {
            CalcolaUmoreCorgi();
            if (this.sFelice.Length < 1)
            {
                this.sFelice = "  ";
            }
            if (this.sTriste.Length < 1)
            {
                this.sTriste = "  ";
            }
            if (this.sArrabbiato.Length < 1)
            {
                this.sArrabbiato = "  ";
            }
            if (this.sDepresso.Length < 1)
            {
                this.sDepresso = "  ";
            }

            if (this.ProbDormire < 10 && this.ProbDormire >= 0)
            {
                this.StringProbDormire = this.ProbDormire.ToString();
                this.StringProbDormire = (this.StringProbDormire + " ");
            }
            else
            {
                this.StringProbDormire = this.ProbDormire.ToString();
            }
            if (this.ProbMangiare < 10 && this.ProbMangiare >= 0)
            {
                this.StringProbMangiare = this.ProbMangiare.ToString();
                this.StringProbMangiare = (this.StringProbMangiare + " ");
            }
            else
            {
                StringProbMangiare = this.ProbMangiare.ToString();
            }
            if (this.ProbCoccole < 10 && this.ProbCoccole >= 0)
            {
                this.StringProbCoccole = this.ProbCoccole.ToString();
                this.StringProbCoccole = (this.StringProbCoccole + " ");
            }
            else
            {
                this.StringProbCoccole = this.ProbCoccole.ToString();
            }
            if (this.ProbPulire < 10 && this.ProbPulire >= 0)
            {
                this.StringProbPulire = this.ProbPulire.ToString();
                this.StringProbPulire = (this.StringProbPulire + " ");
            }
            else
            {
                this.StringProbPulire = this.ProbPulire.ToString();
            }



            Console.Clear();
            Console.SetCursorPosition(30, 1);
            Console.WriteLine($@"            |¯¯¯¯|                   |¯¯¯¯|");
            Console.SetCursorPosition(30, 2);
            Console.WriteLine($@"Felice      | {this.sFelice} |      {this.Nome}     | {this.StringProbDormire} |  Dormire");
            Console.SetCursorPosition(30, 3);
            Console.WriteLine($@"            |----|                   |----|");
            Console.SetCursorPosition(30, 4);
            Console.WriteLine($@"Triste      | {this.sTriste} |     ,-.___,-.     | {this.StringProbMangiare} |  Mangiare");
            Console.SetCursorPosition(30, 5);
            Console.WriteLine($@"            |----|     \_/_ _\_/     |----|");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine($@"Arrabbiato  | {this.sArrabbiato} |       )O_O(       | {this.StringProbCoccole} |  Coccole");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine(@"            |----|      { (_) }      |----|");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine($@"Depresso    | {this.sDepresso} |       `-^-'       | {this.StringProbPulire} |  Pulire");
            Console.SetCursorPosition(30, 9);
            Console.WriteLine($@"            |____|                   |____|");
            Console.WriteLine();
            Console.WriteLine($@"                                               {this.Necessita}");
            Console.WriteLine();
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
            Console.WriteLine("|  5. Gioca con lui.                       ___|");
            Console.SetCursorPosition(35, 20);
            Console.WriteLine("|  6. Non  fare nulla.                    |   |");
            Console.SetCursorPosition(35, 21);
            Console.WriteLine("|  Vuoi eseguire una di queste Azioni?    |   |");
            Console.SetCursorPosition(35, 22);
            Console.WriteLine("|_________________________________________|___|");


        }
        public void CalcolaUmoreCorgi()
        {
            this.UmoreCorgi = this.ProbDormire + this.ProbMangiare + this.ProbPulire + this.ProbCoccole;

            if (this.UmoreCorgi + modUmoreCorgi <= -20)                  // Felicità
            {
                sFelice = $"{(char)2}{(char)179}";
                sTriste = "";
                sArrabbiato = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > -20 && this.UmoreCorgi <= -10)
            {
                sFelice = $"{(char)2}{(char)178}";
                sTriste = "";
                sArrabbiato = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > -10 && this.UmoreCorgi <= 0)
            {
                sFelice = $"{(char)2}{(char)185}";
                sTriste = "";
                sArrabbiato = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > -0 && this.UmoreCorgi <= 10)  //Tristezza
            {
                sTriste = $"{(char)1}{(char)185}";
                sFelice = "";
                sArrabbiato = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 10 && this.UmoreCorgi <= 20)
            {
                sTriste = $"{(char)1}{(char)178}";
                sFelice = "";
                sArrabbiato = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 20 && this.UmoreCorgi <= 30)
            {
                sTriste = $"{(char)1}{(char)179}";
                sFelice = "";
                sArrabbiato = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 30 && this.UmoreCorgi <= 40)  // Arrabbiatura
            {
                sArrabbiato = $"{(char)1}{(char)185}";
                sFelice = "";
                sTriste = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 40 && this.UmoreCorgi <= 50)
            {
                sArrabbiato = $"{(char)1}{(char)178}";
                sFelice = "";
                sTriste = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 50 && this.UmoreCorgi <= 60)
            {
                sArrabbiato = $"{(char)1}{(char)179}";
                sFelice = "";
                sTriste = "";
                sDepresso = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 60 && this.UmoreCorgi <= 70)  //Depressione
            {
                sDepresso = $"{(char)1}{(char)185}";
                sFelice = "";
                sTriste = "";
                sArrabbiato = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 70 && this.UmoreCorgi <= 80)
            {
                sDepresso = $"{(char)1}{(char)178}";
                sFelice = "";
                sTriste = "";
                sArrabbiato = "";
            }
            else if (this.UmoreCorgi + modUmoreCorgi > 80 && this.UmoreCorgi <= 90)
            {
                sDepresso = $"{(char)1}{(char)179}";
                sFelice = "";
                sTriste = "";
                sArrabbiato = "";
            }
        }

    }
}
