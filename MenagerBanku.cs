using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MenagerBanku
    {
        private MenagerKont menagerKont;
        private IDrukarka drukarka;

        public MenagerBanku()
        {
            menagerKont = new MenagerKont();
            drukarka = new Drukarka();
        }
        private void DrukujMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - Lista kont klienta");
            Console.WriteLine("2 - Dodaj konto rozliczeniowe");
            Console.WriteLine("3 - Dodaj konto oszczędnościowe");
            Console.WriteLine("4 - Wpłać pieniądze na konto");
            Console.WriteLine("5 - Wypłać pieniądze z konta");
            Console.WriteLine("6 - Lista klientów");
            Console.WriteLine("7 - Wszystkie konta");
            Console.WriteLine("8 - Zakończ miesiąc");
            Console.WriteLine("0 - Zakończ");
        }
        public void Run()
        {
            int akcja;
            do
            {
                DrukujMenu();
                akcja = WyborAkcji();
                switch (akcja)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę kont klienta");
                        ListaKont();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Wybrano otwarcie konta rozliczeniowego");
                        DodajKontoRozliczeniowe();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Wybrano otwarcie konta oszczędnościowego");
                        DodajKontoOszczednosciowe();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Wybrano wpłatę pieniędzy na konto");

                        DodajPieniadze();

                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Wybrano wypłatę pieniędzy z konta");
                        PobierzPienieadze();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę klientów");
                        ListaKlientow();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę wszystkich kont");
                        ListaWszystkichKont();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Wybrano zamknięcie miesiąca");
                        ZakonczenieMiesiaca();
                        Console.ReadKey();
                        break;
                }

            }
            while (akcja != 0);



        }
        private int WyborAkcji()
        {
        ponow:
            Console.Write("Akcja: ");
            string akcja = Console.ReadLine();
            if (string.IsNullOrEmpty(akcja))
            {
                Console.WriteLine("Nie wpisales zadnej liczby sprobuj ponownie: ");
                goto ponow;

            }

            return int.Parse(akcja);

        }
        private void ListaKont()
        {
            Console.Clear();
            DaneUzytkownika dane = Czytajdane();
            Console.WriteLine();
            Console.WriteLine("Konto klienta: {0} {1} {2}", dane.Imie, dane.Nazwisko, dane.Pesel);
            foreach (Konto konto in menagerKont.PobierzWszystkieKonta(dane.Imie, dane.Nazwisko, dane.Pesel))
            {
                drukarka.druk(konto);
            }
            Console.ReadKey();

        }
        private DaneUzytkownika Czytajdane()
        {
            string imie;
            string nazwisko;
            string pesel;

            Console.WriteLine("Podaj Dane klienta: ");
            Console.Write("Imie: ");
            imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            nazwisko = Console.ReadLine();
            Console.Write("pesel: ");
            pesel = Console.ReadLine();
            return new DaneUzytkownika(imie, nazwisko, pesel);



        }
        private void DodajKontoRozliczeniowe()
        {
            Console.Clear();
            DaneUzytkownika dane = Czytajdane();
            Konto kontoRozliczeniowe = menagerKont.StworzKontoRozliczeniowe(dane.Imie, dane.Nazwisko, dane.Pesel);

            Console.WriteLine("Utworzono konto rozliczeniowe");
            drukarka.druk(kontoRozliczeniowe);
            Console.ReadKey();

        }
        private void DodajKontoOszczednosciowe()
        {
            Console.Clear()
                ;
            DaneUzytkownika dane = Czytajdane();
            Konto kontoOszczednosciowe = menagerKont.StworzKontoOszczednosciowe(dane.Imie, dane.Nazwisko, dane.Pesel);
            Console.WriteLine("utworzono konto oszczednosciowe");
            drukarka.druk(kontoOszczednosciowe);
            Console.ReadKey();


        }
        private void DodajPieniadze()
        {
            string numerkonta;
            decimal wartosc;
            Console.WriteLine("Wplata pieniedzy");
            Console.Write("Podaj numer konta");
            numerkonta = Console.ReadLine();
            Console.Write("Kwota: ");
            wartosc = decimal.Parse(Console.ReadLine());
            menagerKont.WplacPieniadze(numerkonta, wartosc);
            Konto konto = menagerKont.GetKonto(numerkonta);
            drukarka.druk(konto);



        }
        private void PobierzPienieadze()
        {
            string numerkonta;
            decimal wartosc;
            Console.WriteLine("Wyolata pieniedzy");
            Console.Write("Podaj numer konta: ");
            numerkonta = Console.ReadLine();
            Console.Write("wartosc: ");
            wartosc = decimal.Parse(Console.ReadLine());
            menagerKont.WyplacPieniadze(numerkonta, wartosc);
            Konto konto = menagerKont.GetKonto(numerkonta);
            drukarka.druk(konto);


        }
        private void ListaKlientow()
        {
            Console.Clear();
            Console.WriteLine("Lista klientow:");
            foreach (string klienci in menagerKont.ListaKlientow())
            {
                Console.WriteLine(klienci);
            }
            Console.Read();

        }
        private void ListaWszystkichKont()
        {
            Console.Clear();
            Console.WriteLine("wszystkie konta: ");
            foreach (Konto konto in menagerKont.GetKonta())
            {
                drukarka.druk(konto);

            }
            Console.ReadKey();
        }
        private void ZakonczenieMiesiaca()
        {
            Console.Clear();
            menagerKont.ZamkniecieMiesiaca();
            Console.WriteLine("zamknieto miesiac");
            Console.ReadKey();

        }
    }
}
