using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   public class Przepis
    {
        private string nazwa;
        private string[] skladniki;
        private string instrukcje;
        private int czasPrzygotowania;
        private int iloscPorcji;
        private string kategoria;

        public Przepis(string nazwa, string[] skladniki, string instrukcje, int czasPrzygotowania, int iloscPorcji, string kategoria)
        {
            this.nazwa = nazwa;
            this.skladniki = skladniki;
            this.instrukcje = instrukcje;
            this.czasPrzygotowania = czasPrzygotowania;
            this.iloscPorcji = iloscPorcji;
            this.kategoria = kategoria;
        }

        public void DodajDoListyZakupow()
        {
            Console.WriteLine("Dodano składniki do listy zakupów dla przepisu: " + nazwa);
            
        }

        public void Ugotuj()
        {
            Console.WriteLine("Przygotowano potrawę na podstawie przepisu: " + nazwa);
            
        }

        public void Ocen(int ocena)
        {
            Console.WriteLine("Przepis " + nazwa + " został oceniony na " + ocena + " / 10.");
            
        }

        public void PodzielSie()
        {
            Console.WriteLine("Podzielono się przepisem: " + nazwa);
           
        }
    }
}
