using Lab2;
using System;
using System.Drawing;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        /*  Auto auto1 = new Auto(5000, 2002, 5, 700, "Mercedes", "G wagon", "Czarny", false);

           auto1.Wypisz_Informacje();
          auto1.Jedz();
          auto1.UstawPrzebieg();
          auto1.Wypisz_Informacje();
          auto1.Zaparkuj();
          auto1.Wypisz_Informacje(); 
        */

        /* Ksiazka ksiazka1 = new Ksiazka("Buszujący w zbożu", "J.D. Salinger", "Literatura piękna", "Albatros", 1991, 304, true, "-------");

           ksiazka1.WypiszInformacje();
           ksiazka1.Wypozycz();
           ksiazka1.WypiszInformacje();
           ksiazka1.Zwroc();
           ksiazka1.WypiszInformacje();
           ksiazka1.DodajRecenzje();
           ksiazka1.WypiszInformacje();
           ksiazka1.DodajRecenzje();
           ksiazka1.WypiszInformacje(); 
        */

        /* Pracownik pracownik1 = new Pracownik("Adam", "Adamski", "Pomywacz", "Pułaskiego 23", "12.03.1990", 111222333, true, 0);
          pracownik1.Info();
          pracownik1.Zwolnij();
          pracownik1.Wyplata();
          pracownik1.Info();
          pracownik1.Awansuj();
          pracownik1.Info();
        */

        /* Produkt produkt1 = new Produkt("Laptop", 2500, 10, "Laptop z ekranem 15 cali", "Elektronika", "Dell");
          produkt1.DodajDoKoszyka();
          produkt1.Kup();
          produkt1.ZmienOpis("Laptop z ekranem 15 cali, 8GB RAM");
          produkt1.UsunZKoszyka(); */

        /* Zamowienie zamowienie1 = new Zamowienie(DateTime.Now,"Jan Kowalski","Lizak",2,"Jabłoniowa 34", "Przyjęte do realizacji");

          zamowienie1.ZlozZamowienie();
          zamowienie1.Zaplac();
          zamowienie1.Dostarcz();

          */

        /* Film Film1 = new Film("Matrix", "Rodzeństwo Wachowskich", 1999 ,"Sci-Fi" ,136 ,"Haker komputerowy Neo dowiaduje się od tajemniczych rebeliantów, że świat, w którym żyje, jest tylko obrazem przesyłanym do jego mózgu przez roboty.");
       
        Film1.Odtworz();
        Film1.DodajDoListy();
        Film1.Ocena(9);
        Film1.NapiszRecenzje("Jeden z bardziej wpływowych filmów w historii kina."); */

        /* Gra Gra1 = new Gra("The Witcher 3: Wild Hunt", "RPG", "PC, PS4, Xbox One", 2015, "CD Projekt RED", "Gracz wciela się w postać łowcy potworów, Geralta z Rivii.");

        Gra1.Zagraj();
        Gra1.ZapiszStanGry();
        Gra1.WczytajStanGry();
        Gra1.UkonczGre(); */

        /* Urzadzenie mojeUrzadzenie = new Urzadzenie("Smartfon", "Galaxy S21", "Samsung", 2021, "Flagowy smartfon firmy Samsung.", "Wyświetlanie obrazu, dzwonienie, przeglądanie internetu, etc.");
        mojeUrzadzenie.Wlacz();
        mojeUrzadzenie.Ustawienia();
        mojeUrzadzenie.Zresetuj();
        mojeUrzadzenie.Wylacz(); */

        /* Piosenka Piosenka1 = new Piosenka("Bohemian Rhapsody", "Queen", "A Night at the Opera", 1975, "Rock", 354);
 
        Piosenka1.Odtworz();
        Piosenka1.DodajDoPlaylisty();
        Piosenka1.Ocen(9);
        Piosenka1.PodzielSie(); */

        /* string[] skladniki = { "mąka", "jajka", "mleko", "masło", "sól" };
        Przepis Przepis1 = new Przepis("Placek po węgiersku", skladniki,"1. Wymieszaj mąkę, jajka, mleko, i cukier w misce.\n2. Rozgrzej patelnię i dodaj masło.\n3. Smaż placek na patelni z obu stron.\n4. Gotowy placek podawaj na ciepło.", 20, 4,"obiad");

        Przepis1.DodajDoListyZakupow();
        Przepis1.Ugotuj();
        Przepis1.Ocen(8);
        Przepis1.PodzielSie(); */

        /* KlientSklepu klient1 = new KlientSklepu("Jan", "Kowalski", "ul. Testowa 123, 00-000 Warszawa", "123456789", "jan.kowalski@example.com", new DateTime(1990, 5, 15), 1000);

         klient1.ZlozZamowienie();
         klient1.ZmienDane("ul. Nowa 456, 00-001 Warszawa", "987654321", "jan.kowalski@nowyadres.com");
         klient1.SprawdzSaldo();
         klient1.DodajDoUlubionych("Telefon"); */

        /* PracownikFirmy pracownik1 = new PracownikFirmy("Jan", "Kowalski", "Programista", new DateTime(1990, 5, 15), "ul. Testowa 123, 00-000 Warszawa", "123456789", "jan.kowalski@example.com", DateTime.Now, 5000, "IT");

        pracownik1.ZlozWniosekUrlopowy();
        pracownik1.WygenerujUmowe();
        pracownik1.Podwyzka(1000);
        pracownik1.Zwolnij(); */

        /* ProduktWSklepie telefon = new ProduktWSklepie("Smartfon", 1299.99 , 10, "Nowoczesny smartfon z ekranem o przekątnej 6 cali.", "Elektronika", "Samsung", new string[] { "smartfon.jpg" }, DateTime.Now, false);
        
        telefon.Dostepnosc();
        telefon.DodajDoKoszyka();
        telefon.Kup();
        telefon.Kup();
        telefon.ZwrocProdukt();
        telefon.Dostepnosc(); */

        /* ZamowienieWSklepie zamowienie = new ZamowienieWSklepie(DateTime.Now, "Jan Kowalski", "Telefon", 1, "ul. Testowa 123, 00-000 Warszawa", "Oczekujące", "Przelew", "123456", "XY789Z" );

        zamowienie.AnulujZamowienie();
        zamowienie.ZmienAdresDostawy("ul. Nowa 456, 00-001 Warszawa");
        zamowienie.Zaplac();
        zamowienie.OcenZamowienie(9); */

        /* Samochod Samochod1 = new Samochod("Toyota","Corolla",2019,30000,1.8,140,"Benzyna","Srebrny","Klimatyzacja, nawigacja, system audio","WZ12345");
    
        Samochod1.UruchomSilnik();
        Samochod1.Jedz();
        Samochod1.Zaparkuj();
        Samochod1.Zatankuj(); */

        /*Mieszkanie Mieszkanie1 = new Mieszkanie("ul. Testowa 123, 00-000 Warszawa",60.5, 2, 3, 2010, 3500, "Nowoczesne mieszkanie w centrum miasta.", new string[] { "mieszkanie_1.jpg", "mieszkanie_2.jpg" },"Internet, telewizja kablowa", "W pełni umeblowane");

        Mieszkanie1.ZobaczMieszkanie();
        Mieszkanie1.DodajOgloszenie();
        Mieszkanie1.KupMieszkanie(); */

        /* UrzadzenieElektroniczne smartfon = new UrzadzenieElektroniczne("Smartfon", "Galaxy S21", "Samsung", 2021, "Najnowszy flagowy smartfon firmy Samsung.", "Wyświetlanie obrazu, dzwonienie, przeglądanie internetu, etc.", 2999.99, 24, "Instrukcja obsługi znajduje się w opakowaniu.");
       
        smartfon.Wlacz();
        smartfon.Ustawienia();
        smartfon.Napraw();
        smartfon.Wylacz(); */

        Student student = new Student("Jan", "Kowalski", 20, "123456");

        student.DodajOcene("Matematyka", 4);
        student.DodajOcene("Matematyka", 5);
        student.DodajOcene("Fizyka", 3);
        student.DodajOcene("Fizyka", 4);
        student.DodajOcene("Informatyka", 5);

        student.WyswietlInformacje();


    }

}

