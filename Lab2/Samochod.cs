using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Samochod
    {
        private string marka;
        private string model;
        private int rokProdukcji;
        private int przebieg;
        private double pojemnoscSilnika;
        private int mocSilnika;
        private string typPaliwa;
        private string kolor;
        private string wyposazenie;
        private string numerRejestracyjny;

        public Samochod(string marka, string model, int rokProdukcji, int przebieg, double pojemnoscSilnika, int mocSilnika, string typPaliwa, string kolor, string wyposazenie, string numerRejestracyjny)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.przebieg = przebieg;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.mocSilnika = mocSilnika;
            this.typPaliwa = typPaliwa;
            this.kolor = kolor;
            this.wyposazenie = wyposazenie;
            this.numerRejestracyjny = numerRejestracyjny;
        }

        public void UruchomSilnik()
        {
            Console.WriteLine("Silnik samochodu został uruchomiony.");
            
        }

        public void Jedz()
        {
            Console.WriteLine("Samochód porusza się.");
            
        }

        public void Zaparkuj()
        {
            Console.WriteLine("Samochód został zaparkowany.");
            
        }

        public void Zatankuj()
        {
            Console.WriteLine("Samochód został zatankowany.");
            
        }
    }
}
