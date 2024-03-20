using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class KlientSklepu
    {
        private string imie;
        private string nazwisko;
        private string adres;
        private string numerTelefonu;
        private string email;
        private DateTime dataUrodzenia;
        private string historiaZakupow;
        private string[] ulubioneProdukty;
        private decimal saldoKonta;

        public KlientSklepu(string imie, string nazwisko, string adres, string numerTelefonu, string email, DateTime dataUrodzenia, decimal saldoKonta)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.numerTelefonu = numerTelefonu;
            this.email = email;
            this.dataUrodzenia = dataUrodzenia;
            this.saldoKonta = saldoKonta;
            this.historiaZakupow = "";
            this.ulubioneProdukty = new string[0];
        }

        public void ZlozZamowienie()
        {
            Console.WriteLine("Zamówienie zostało złożone przez klienta: " + imie + " " + nazwisko);
           
        }

        public void ZmienDane(string nowyAdres, string nowyNumerTelefonu, string nowyEmail)
        {
            this.adres = nowyAdres;
            this.numerTelefonu = nowyNumerTelefonu;
            this.email = nowyEmail;
            Console.WriteLine("Dane klienta zostały zaktualizowane.");
           
        }

        public void SprawdzSaldo()
        {
            Console.WriteLine("Saldo konta klienta " + imie + " " + nazwisko + ": " + saldoKonta);
            
        }

        public void DodajDoUlubionych(string produkt)
        {
            Array.Resize(ref ulubioneProdukty, ulubioneProdukty.Length + 1);
            ulubioneProdukty[ulubioneProdukty.Length - 1] = produkt;
            Console.WriteLine("Produkt '" + produkt + "' został dodany do ulubionych.");
            
        }
    }
}
