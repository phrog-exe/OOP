using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Mieszkanie
    {
        private string adres;
        private double powierzchnia;
        private int liczbaPokoi;
        private int pietro;
        private int rokBudowy;
        private double cena;
        private string opis;
        private string[] zdjecia;
        private string dostepneMedia;
        private string umeblowanie;

        public Mieszkanie(string adres, double powierzchnia, int liczbaPokoi, int pietro, int rokBudowy, double cena, string opis, string[] zdjecia, string dostepneMedia, string umeblowanie)
        {
            this.adres = adres;
            this.powierzchnia = powierzchnia;
            this.liczbaPokoi = liczbaPokoi;
            this.pietro = pietro;
            this.rokBudowy = rokBudowy;
            this.cena = cena;
            this.opis = opis;
            this.zdjecia = zdjecia;
            this.dostepneMedia = dostepneMedia;
            this.umeblowanie = umeblowanie;
        }

        public void KupMieszkanie()
        {
            Console.WriteLine("Mieszkanie zostało zakupione.");
            
        }

        public void WynajmijMieszkanie()
        {
            Console.WriteLine("Mieszkanie zostało wynajęte.");
            
        }

        public void ZobaczMieszkanie()
        {
            Console.WriteLine("Adres mieszkania: " + adres);
            Console.WriteLine("Powierzchnia: " + powierzchnia + " m2");
            Console.WriteLine("Liczba pokoi: " + liczbaPokoi);
            Console.WriteLine("Piętro: " + pietro);
            Console.WriteLine("Rok budowy: " + rokBudowy);
            Console.WriteLine("Cena: " + cena + " zł");
            Console.WriteLine("Opis: " + opis);
            
        }

        public void DodajOgloszenie()
        {
            Console.WriteLine("Dodano ogłoszenie o mieszkania do serwisu.");
            
        }
    }
}
