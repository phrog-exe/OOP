using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ZamowienieWSklepie
    {
        private DateTime data;
        private string klient;
        private string produkt;
        private int ilosc;
        private string adresDostawy;
        private string status;
        private string platnosc;
        private string numerZamowienia;
        private string sledzeniePrzesylki;

        public ZamowienieWSklepie(DateTime data, string klient, string produkt, int ilosc, string adresDostawy, string status, string platnosc, string numerZamowienia, string sledzeniePrzesylki)
        {
            this.data = data;
            this.klient = klient;
            this.produkt = produkt;
            this.ilosc = ilosc;
            this.adresDostawy = adresDostawy;
            this.status = status;
            this.platnosc = platnosc;
            this.numerZamowienia = numerZamowienia;
            this.sledzeniePrzesylki = sledzeniePrzesylki;
        }

        public void AnulujZamowienie()
        {
            Console.WriteLine("Zamówienie " + numerZamowienia + " zostało anulowane.");
           
        }

        public void ZmienAdresDostawy(string nowyAdres)
        {
            adresDostawy = nowyAdres;
            Console.WriteLine("Adres dostawy zamówienia " + numerZamowienia + " został zmieniony na: " + nowyAdres);
            
        }

        public void Zaplac()
        {
            Console.WriteLine("Zamówienie " + numerZamowienia + " zostało opłacone.");
            
        }

        public void OcenZamowienie(int ocena)
        {
            Console.WriteLine("Zamówienie " + numerZamowienia + " zostało ocenione na " + ocena + " / 10.");
            
        }
    }
}
