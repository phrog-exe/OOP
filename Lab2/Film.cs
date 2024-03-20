using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Film
    {
        private string tytul;
        private string rezyser;
        private int rokProdukcji;
        private string gatunek;
        private int czasTrwania;
        private string opis;

        public Film(string tytul, string rezyser, int rokProdukcji, string gatunek, int czasTrwania, string opis)
        {
            this.tytul = tytul;
            this.rezyser = rezyser;
            this.rokProdukcji = rokProdukcji;
            this.gatunek = gatunek;
            this.czasTrwania = czasTrwania;
            this.opis = opis;
        }

        public void Odtworz()
        {
            Console.WriteLine("Odtwarzanie filmu: " + tytul);
            
        }

        public void DodajDoListy()
        {
            Console.WriteLine("Film został dodany do listy.");
            
        }

        public void Ocena(int ocena)
        {
            Console.WriteLine("Film został oceniony na " + ocena + " / 10.");
            
        }

        public void NapiszRecenzje(string recenzja)
        {
            Console.WriteLine("Napisano recenzję filmu: " + recenzja);
            
        }
    }
}
