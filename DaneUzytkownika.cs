using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DaneUzytkownika
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public long Pesel { get; }
        public DaneUzytkownika(string imie, string nazwisko, string pesel)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = long.Parse(pesel);
        }

    }
}
