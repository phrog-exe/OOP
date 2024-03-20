using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Auto
    {
       

            public int przebieg, rok_prod, pojemnosc_silnika, moc_silnika;
            public String marka, model, color;
            public bool CzyJedzie;

            public Auto(int przebieg, int rok_prod, int pojemnosc_silnika, int moc_silnika, string marka, string model, string color, bool CzyJedzie)
            {
                this.przebieg = przebieg;
                this.rok_prod = rok_prod;
                this.pojemnosc_silnika = pojemnosc_silnika;
                this.moc_silnika = moc_silnika;
                this.marka = marka;
                this.model = model;
                this.color = color;
                this.CzyJedzie = CzyJedzie;
            }



            public void Wypisz_Informacje()
            {
                Console.WriteLine("Dostępne informacje: \n" + "Przebieg: " + przebieg + "Km" + "\nRok produkcji: " + rok_prod + "\nPojemność silnika: " + pojemnosc_silnika + "L"
                    + "\nMoc silnika: " + moc_silnika + "W" + "\nMarka: " + marka + "\nModel: " + model + "\nKolor: " + color + "\n" + "Czy porusza się: " + CzyJedzie + "\n"
                    );
            }

            public void UstawPrzebieg()
            {
                Console.WriteLine("\nPodaj nowy przebieg: ");
                this.przebieg = Convert.ToInt32(Console.ReadLine());

            }


            public bool Jedz()
            {
                this.CzyJedzie = true;
                return this.CzyJedzie;
            }

            public bool Zaparkuj()
            {
                this.CzyJedzie = false;
                return this.CzyJedzie;
            }
        }
    }

