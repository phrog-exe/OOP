using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   public class Piosenka
    {
        private string tytul;
        private string wykonawca;
        private string album;
        private int rokWydania;
        private string gatunek;
        private int czasTrwania;

        public Piosenka(string tytul, string wykonawca, string album, int rokWydania, string gatunek, int czasTrwania)
        {
            this.tytul = tytul;
            this.wykonawca = wykonawca;
            this.album = album;
            this.rokWydania = rokWydania;
            this.gatunek = gatunek;
            this.czasTrwania = czasTrwania;
        }

        public void Odtworz()
        {
            Console.WriteLine("Odtwarzanie piosenki: " + tytul + " - " + wykonawca);
            
        }

        public void DodajDoPlaylisty()
        {
            Console.WriteLine("Piosenka została dodana do playlisty.");
            
        }

        public void Ocen(int ocena)
        {
            Console.WriteLine("Piosenka została oceniona na " + ocena + " / 10.");
            
        }

        public void PodzielSie()
        {
            Console.WriteLine("Piosenka została udostępniona.");
            
        }
    }
}
