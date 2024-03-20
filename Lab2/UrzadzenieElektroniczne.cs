using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class UrzadzenieElektroniczne
    {
        private string nazwa;
        private string model;
        private string producent;
        private int rokProdukcji;
        private string opis;
        private string funkcje;
        private double cena;
        private int gwarancja;
        private string instrukcjaObslugi;

        public UrzadzenieElektroniczne(string nazwa, string model, string producent, int rokProdukcji, string opis, string funkcje, double cena, int gwarancja, string instrukcjaObslugi)
        {
            this.nazwa = nazwa;
            this.model = model;
            this.producent = producent;
            this.rokProdukcji = rokProdukcji;
            this.opis = opis;
            this.funkcje = funkcje;
            this.cena = cena;
            this.gwarancja = gwarancja;
            this.instrukcjaObslugi = instrukcjaObslugi;
        }

        public void Wlacz()
        {
            Console.WriteLine("Urządzenie " + nazwa + " zostało włączone.");
            
        }

        public void Wylacz()
        {
            Console.WriteLine("Urządzenie " + nazwa + " zostało wyłączone.");
            
        }

        public void Ustawienia()
        {
            Console.WriteLine("Otwarto ustawienia urządzenia " + nazwa + ".");
            
        }

        public void Napraw()
        {
            Console.WriteLine("Urządzenie " + nazwa + " zostało naprawione.");
            
        }
    }
}

