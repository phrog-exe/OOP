using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Produkt
    {
        private string nazwa;
        private decimal cena;
        private int ilosc;
        private string opis;
        private string kategoria;
        private string producent;

     
        

        
        public Produkt(string nazwa, decimal cena, int ilosc, string opis, string kategoria, string producent)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilosc = ilosc;
            this.opis = opis;
            this.kategoria = kategoria;
            this.producent = producent;
        }

        
        public void DodajDoKoszyka()
        {
            Console.WriteLine("Produkt \"{0}\" został dodany do koszyka.", nazwa);
        }

        
        public void Kup()
        {
            if (ilosc > 0)
            {
                Console.WriteLine("Produkt \"{0}\" został zakupiony.", nazwa);
                ilosc--;
            }
            else
            {
                Console.WriteLine("Produkt \"{0}\" jest niedostępny.", nazwa);
            }
        }

        
        public void UsunZKoszyka()
        {
            Console.WriteLine("Produkt \"{0}\" został usunięty z koszyka.", nazwa);
        }

       
        public void ZmienOpis(string nowyOpis)
        {
            opis = nowyOpis;
            Console.WriteLine("Opis produktu \"{0}\" został zmieniony.", nazwa);
        }
    }
}
