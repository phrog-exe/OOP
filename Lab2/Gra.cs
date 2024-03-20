using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Gra
    {

        private string tytul;
        private string gatunek;
        private string platforma;
        private int rokWydania;
        private string producent;
        private string opis;
        private string wymaganiaSprzetowe;
        private string recenzje;

        public Gra(string tytul, string gatunek, string platforma, int rokWydania, string producent, string opis, string wymaganiaSprzetowe, string recenzje)
        {
            this.tytul = tytul;
            this.gatunek = gatunek;
            this.platforma = platforma;
            this.rokWydania = rokWydania;
            this.producent = producent;
            this.opis = opis;
            this.wymaganiaSprzetowe = wymaganiaSprzetowe;
            this.recenzje = recenzje;
        }

        public void Zagraj()
        {
            if (platforma == "PC" || platforma == "PS4")
            {
                Console.WriteLine("Rozpoczęto grę: " + tytul);
            }
            else
            { Console.WriteLine("Error: błąd platformy, gra jest przeznaczona na PC oraz PS4"); }
        }

        public void ZapiszStanGry()
        {
            Console.WriteLine("Zapisano stan gry: " + tytul);

        }

        public void WczytajStanGry()
        {
            Console.WriteLine("Wczytano stan gry: " + tytul);

        }

        public void UkonczGre()
        {
            Console.WriteLine("Gra ukończona: " + tytul);

        }

        
    }
}
