using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Urzadzenie
    {
        private string nazwa;
        private string model;
        private string producent;
        private int rokProdukcji;
        private string opis;
        private string funkcje;

        public Urzadzenie(string nazwa, string model, string producent, int rokProdukcji, string opis, string funkcje)
        {
            this.nazwa = nazwa;
            this.model = model;
            this.producent = producent;
            this.rokProdukcji = rokProdukcji;
            this.opis = opis;
            this.funkcje = funkcje;
        }

        public void Wlacz()
        {
            Console.WriteLine("Urządzenie zostało włączone.");
           
        }

        public void Wylacz()
        {
            Console.WriteLine("Urządzenie zostało wyłączone.");
            
        }

        public void Ustawienia()
        {
            Console.WriteLine("Otwarto ustawienia urządzenia.");
           
        }

        public void Zresetuj()
        {
            Console.WriteLine("Urządzenie zostało zresetowane.");
            
        }
    }
}
