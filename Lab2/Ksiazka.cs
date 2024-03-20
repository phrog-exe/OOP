using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Ksiazka
    {
        public String tytul, autor, gatunek, wydawnictwo, recenzja;
        public int rok_wydania, liczba_stron;
        public bool dostepnosc;

        public Ksiazka(string tytul, string autor, string gatunek, string wydawnictwo, int rok_wydania, int liczba_stron, bool dostepnosc, String recenzja)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.gatunek = gatunek;
            this.wydawnictwo = wydawnictwo;
            this.rok_wydania = rok_wydania;
            this.liczba_stron = liczba_stron;
            this.dostepnosc = dostepnosc;
            this.recenzja = recenzja;

        }

        public void WypiszInformacje()
        {
            Console.WriteLine("Dostępne informacje: \n" + "Tytuł: " + tytul + "\nAutor: " + autor + "\nGatunek: " + gatunek
            + "\nWydawnictwo: " + wydawnictwo + "\nRok wydania: " + rok_wydania + "\nLiczba stron: " + liczba_stron + "\nDostępność: " + dostepnosc + "\n"
            + "Recenzje: " + '"' + recenzja + '"' + "\n");

        }

        public bool Wypozycz()
        {
            this.dostepnosc = false;
            return this.dostepnosc;
        }

        public bool Zwroc()
        {
            this.dostepnosc = true;
            return this.dostepnosc;
        }

        public String DodajRecenzje()
        {
            Console.WriteLine("Dodaj recenzje: \n");
            this.recenzja = Console.ReadLine();

            return this.recenzja;
        }

    }
}
