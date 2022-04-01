using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220401_Corgigochi
{
    class Corgi
    {
        public string Nome { get; set; }
        public int Felice { get; set; }
        public int Triste { get; set; }
        public int Arrabbiato { get; set; }
        public int Depresso { get; set; }
        public int Dormire { get; set; }
        public int Mangiare { get; set; }
        public int Coccole { get; set; }
        public int Pulire { get; set; }
        public int ProbDormire { get; set; }
        public int ProbMangiare { get; set; }
        public int ProbCoccole { get; set; }
        public int ProbPulire { get; set; }
        public string Necessita { get; set; }


        //AZIONI giocatore
        public void FaiDormire()
        {            
            this.ProbDormire = 0;
            this.Dormire = this.ProbDormire;
        }
        public void FaiMangiare()
        {            
            this.ProbMangiare -= 3;
            this.Mangiare = this.ProbMangiare;
        }
        public void Pulisci()
        {   
            this.ProbPulire -= 5;
            this.Pulire = this.ProbPulire;
        }
        public void Coccolare()
        {             
            this.ProbCoccole -= 4;
            this.Coccole = this.ProbCoccole;
        }
        public void FaiNulla()
        {

        }
        public void AzioniPratica()
        {
            Console.SetCursorPosition(35, 18);
            string azione = Console.ReadLine();
            bool n = int.TryParse(azione, out int azioneNum);
            switch (azioneNum)
            {
                case 1:
                    FaiDormire();
                    break;
                case 2:
                     FaiMangiare();
                    break;
                case 3:
                    Coccolare();
                    break;
                case 4:
                    Pulisci();
                    break;
                case 5:
                    FaiNulla();
                    break;
                default:
                    Console.WriteLine("Devi inserire un numero da 1 a 5");
                    break;
            }
        }

        //Azioni Corgi
        public void VoglioDormire()
        {
            Console.SetCursorPosition(50, 9);
            this.Necessita = "Voglio dormire";
            Console.WriteLine(this.Necessita);
            this.ProbDormire++;
            this.Dormire = this.ProbDormire;
            StampaCorgi();
            AzioniPratica();
        }
        public void VoglioMangiare()
        {
            Console.SetCursorPosition(49, 9);
            this.Necessita = "Voglio Mangiare";
            Console.WriteLine(this.Necessita);
            this.ProbMangiare+=2;
            this.Mangiare = this.ProbMangiare;
            StampaCorgi();
            AzioniPratica();
        }
        public void DeviPulire()
        {
            Console.SetCursorPosition(50, 9);
            this.Necessita = " Devi pulire ";
            Console.WriteLine(this.Necessita);
            this.ProbPulire+=3;
            this.Pulire = this.ProbPulire;
            StampaCorgi();
            AzioniPratica();
        }
        public void VoglioCoccole()
        {
            Console.SetCursorPosition(50, 9);
            this.Necessita = "Voglio coccole";
            Console.WriteLine(this.Necessita);
            this.ProbCoccole++;
            this.Coccole = this.ProbCoccole;
            StampaCorgi();
            AzioniPratica();
        }

        public void StampaCorgi()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 1);
            Console.WriteLine($@"            |¯¯¯¯|                   |¯¯¯¯|");
            Console.SetCursorPosition(30, 2);
            Console.WriteLine($@"Felice      | {this.Felice}  |      {this.Nome}     | {this.Dormire}  |  Dormire");
            Console.SetCursorPosition(30, 3);
            Console.WriteLine($@"            |----|                   |----|");
            Console.SetCursorPosition(30, 4);
            Console.WriteLine($@"Triste      | {this.Triste}  |     ,-.___,-.     | {this.Mangiare}  |  Mangiare");
            Console.SetCursorPosition(30, 5);
            Console.WriteLine($@"            |----|     \_/_ _\_/     |----|");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine($@"Arrabbiato  | {this.Arrabbiato}  |       )O_O(       | {this.Coccole}  |  Coccole");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine(@"            |----|      { (_) }      |----|");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine($@"Depresso    | {this.Depresso}  |       `-^-'       | {this.Pulire}  |  Pulire");
            Console.SetCursorPosition(30, 9);
            Console.WriteLine($@"            |____|                   |____|");
            Console.WriteLine($@"                                                  {this.Necessita}");
            Console.WriteLine();
            Console.SetCursorPosition(35, 12);
            Console.WriteLine("Vuoi eseguire una di queste Azioni?");
            Console.SetCursorPosition(35, 13);
            Console.WriteLine("1. Mandalo a dormire.");
            Console.SetCursorPosition(35, 14);
            Console.WriteLine("2. Dargli da mangiare.");
            Console.SetCursorPosition(35, 15);
            Console.WriteLine("3. Fagli le coccole.");
            Console.SetCursorPosition(35, 16);
            Console.WriteLine("4. Pulisci la cacca.");
            Console.SetCursorPosition(35, 17);
            Console.WriteLine("5. Nono fare nulla.");
            //Console.ReadKey();
        }

    }
}
