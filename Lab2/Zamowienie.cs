using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   public class Zamowienie
    {

             DateTime data;
             string klient;
             string produkt;
             int ilosc;
             string adresDostawy;
             string status;

            public Zamowienie(DateTime data, string klient, string produkt, int ilosc, string adresDostawy, string status)
            {
                this.data = data;
                this.klient = klient;
                this.produkt = produkt;
                this.ilosc = ilosc;
                this.adresDostawy = adresDostawy;
                this.status = status;
            }

            public void ZlozZamowienie()
            {
                Console.WriteLine("Zamówienie zostało złożone.");
            }

            public void AnulujZamowienie()
            {
                Console.WriteLine("Zamówienie zostało anulowane.");
            }

            public void Dostarcz()
            {
                Console.WriteLine("Zamówienie zostało dostarczone.");
            }

            public void Zaplac()
            {
                Console.WriteLine("Zamówienie zostało opłacone.");
            }
        }
    }

