using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Pracownik
    {
        String imie, nazwisko, stanowisko, adres, data_urodzenia;
        int numer_telefonu, stan_konta;
        bool stan_zatrudnienia;


       

        public Pracownik(string imie, string nazwisko, string stanowisko, string adres, string data_urodzenia, int numer_telefonu, bool stan_zatrudnienia, int stan_konta)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.stanowisko = stanowisko;
            this.adres = adres;
            this.data_urodzenia = data_urodzenia;
            this.numer_telefonu = numer_telefonu;
            this.stan_zatrudnienia = stan_zatrudnienia;
            this.stan_konta = stan_konta;
        }

       

        public void Info()
        {
            Console.WriteLine("\nimie : " + imie + "\nNazwisko: " + nazwisko + "\nStanowisko: " + stanowisko + "\nAdres: " + adres
                              + "\nData urodzenia: " + data_urodzenia + "\nNumer telefonu: " + numer_telefonu + "\nStan zatrudnienia: " + stan_zatrudnienia
                              + "\nStan konta: " + stan_konta);
        }
        public int Wyplata()
        {
            this.stan_konta = stan_konta + 5000;
            return stan_konta;

        }

        public bool Zwolnij()
        {
            this.stan_zatrudnienia = false;
            return stan_zatrudnienia;
        }

        public bool Zatrudnij()
        {
            this.stan_zatrudnienia = true;
            return stan_zatrudnienia;
        }

        public void Awansuj()
        {
            Console.WriteLine("Pracownik \"{0}\" \"{1}\" otrzymuje awans!", imie, nazwisko);
            stanowisko = "Kierownik";
            this.stan_konta = stan_konta + 1500;
        }
    }
}
