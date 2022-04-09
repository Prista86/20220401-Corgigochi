using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20220401_Corgigochi
{
    public class Corgi
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
        public int modUmoreCorgi { get; set; }
        public int Giornata { get; set; }
        


        //Azioni Corgi
        public void VoglioDormire(Corgi corgi, string giocatore, int timeHide, string dateLastPlay)
        {
            this.Necessita = $"   {giocatore} ho sonno!";
            this.ProbDormire += 5;
            StampaCorgi();
        }
        public void VoglioMangiare(Corgi corgi, string giocatore, int timeHide, string dateLastPlay)
        {
            this.Necessita = $"    {giocatore} ho fame!";
            this.ProbMangiare += 5;
            StampaCorgi();
        }
        public void DeviPulire(Corgi corgi, string giocatore, int timeHide, string dateLastPlay)
        {
            this.Necessita = $"   {giocatore} ho cagato..";
            this.ProbPulire += 5;
            StampaCorgi();
        }
        public void VoglioCoccole(Corgi corgi, string giocatore, int timeHide, string dateLastPlay)
        {
            this.Necessita = $"{giocatore} voglio le coccole!!";
            this.ProbCoccole += 5;
            StampaCorgi();
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
            Console.WriteLine($@"Felice      | {this.sFelice} |     {this.Nome}    | {this.StringProbDormire} |  Dormire");
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
            Console.WriteLine("                                        Premi Invio per compiere una azione! ");
            


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
            else if (this.UmoreCorgi + this.modUmoreCorgi > -20 && this.UmoreCorgi <= -10)
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
            else if (this.UmoreCorgi + this.modUmoreCorgi > 70 && this.UmoreCorgi <= 80)
            {
                sDepresso = $"{(char)1}{(char)178}";
                sFelice = "";
                sTriste = "";
                sArrabbiato = "";
            }
            else if (this.UmoreCorgi + this.modUmoreCorgi > 80 && this.UmoreCorgi <= 90)
            {
                sDepresso = $"{(char)1}{(char)179}";
                sFelice = "";
                sTriste = "";
                sArrabbiato = "";
            }
        }
        
        


    }
}
