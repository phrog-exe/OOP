using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PracownikFirmy
    {
        private string imie;
        private string nazwisko;
        private string stanowisko;
        private DateTime dataUrodzenia;
        private string adres;
        private string numerTelefonu;
        private string email;
        private DateTime dataZatrudnienia;
        private int wynagrodzenie;
        private string dzial;
        private bool urlop;

        public PracownikFirmy(string imie, string nazwisko, string stanowisko, DateTime dataUrodzenia, string adres, string numerTelefonu, string email, DateTime dataZatrudnienia, int wynagrodzenie, string dzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.stanowisko = stanowisko;
            this.dataUrodzenia = dataUrodzenia;
            this.adres = adres;
            this.numerTelefonu = numerTelefonu;
            this.email = email;
            this.dataZatrudnienia = dataZatrudnienia;
            this.wynagrodzenie = wynagrodzenie;
            this.dzial = dzial;
            this.urlop = false;
        }

        public void ZlozWniosekUrlopowy()
        {
            if (!urlop)
            {
                urlop = true;
                Console.WriteLine("Złożono wniosek urlopowy przez pracownika: " + imie + " " + nazwisko);
            }
            else
            {
                Console.WriteLine("Pracownik już znajduje się na urlopie.");
            }
            
        }

        public void WygenerujUmowe()
        {
            Console.WriteLine("Wygenerowano umowę dla pracownika: " + imie + " " + nazwisko);
            
        }

        public void Podwyzka(int kwota)
        {
            wynagrodzenie += kwota;
            Console.WriteLine("Pracownikowi " + imie + " " + nazwisko + " została podwyższona pensja o " + kwota + " zł.");
            
        }

        public void Zwolnij()
        {
            Console.WriteLine("Zwolniono pracownika: " + imie + " " + nazwisko);
            
        }
    }
}
