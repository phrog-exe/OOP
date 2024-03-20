using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ProduktWSklepie
    {
        private string nazwa;
        private double cena;
        private int ilosc;
        private string opis;
        private string kategoria;
        private string producent;
        private string[] zdjecia;
        private DateTime dataDodania;
        private bool promocja;

        public ProduktWSklepie(string nazwa, double cena, int ilosc, string opis, string kategoria, string producent, string[] zdjecia, DateTime dataDodania, bool promocja)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilosc = ilosc;
            this.opis = opis;
            this.kategoria = kategoria;
            this.producent = producent;
            this.zdjecia = zdjecia;
            this.dataDodania = dataDodania;
            this.promocja = promocja;
        }

        public void Dostepnosc()
        {
            if (ilosc > 0)
                Console.WriteLine("Produkt " + nazwa + " jest dostępny.");
            else
                Console.WriteLine("Produkt " + nazwa + " jest aktualnie niedostępny.");
        }

        public void DodajDoKoszyka()
        {
            Console.WriteLine("Produkt " + nazwa + " został dodany do koszyka.");
        }

        public void Kup()
        {
            if (ilosc > 0)
            {
                ilosc--;
                Console.WriteLine("Produkt " + nazwa + " został kupiony.");
            }
            else
            {
                Console.WriteLine("Przepraszamy, produkt " + nazwa + " aktualnie niedostępny.");
            }
        }

        public void ZwrocProdukt()
        {
            ilosc++;
            Console.WriteLine("Produkt " + nazwa + " został zwrócony.");
        }
    }
}
