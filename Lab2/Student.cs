using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public partial class Student
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string numerIndeksu;
        private Dictionary<string, List<int>> przedmiotyZOcenami;

        public Student(string imie, string nazwisko, int wiek, string numerIndeksu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.numerIndeksu = numerIndeksu;
            this.przedmiotyZOcenami = new Dictionary<string, List<int>>();
        }

        public void DodajOcene(string przedmiot, int ocena)
        {
            if (przedmiotyZOcenami.ContainsKey(przedmiot))
            {
                przedmiotyZOcenami[przedmiot].Add(ocena);
            }
            else
            {
                przedmiotyZOcenami.Add(przedmiot, new List<int> { ocena });
            }
        }

        public double ObliczSredniaOcen(string przedmiot)
        {
            if (przedmiotyZOcenami.ContainsKey(przedmiot))
            {
                var oceny = przedmiotyZOcenami[przedmiot];
                return oceny.Count > 0 ? oceny.Average() : 0;
            }
            else
            {
                return 0;
            }
        }

        
    }

    public partial class Student
    {
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Wiek: {wiek}");
            Console.WriteLine($"Numer indeksu: {numerIndeksu}");
            Console.WriteLine("Przedmioty z ocenami:");
            foreach (var przedmiot in przedmiotyZOcenami)
            {
                Console.WriteLine($"{przedmiot.Key} - Średnia ocen: {ObliczSredniaOcen(przedmiot.Key)}");
            }
        }

    }

}
