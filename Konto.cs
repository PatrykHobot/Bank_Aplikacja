using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Konto
    {
        public string NumerKonta { get; }
        public decimal Bilans;
        public string Imie { get; }
        public string Nazwisko { get; }
        public long Pesel { get; }
        public int Id { get; }

        public Konto(int id, string imie, string nazwisko, long pesel)
        {
            Id = id;
            NumerKonta = GenerujNumerKonta(id);
            Bilans = 0.0M;
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Id = id;
        }
        public string DajPelneImie()
        {
            string pelneimie = string.Format("{0} {1}", Imie, Nazwisko);
            return pelneimie;
        }
        public string ZwrocBalans()
        {
            string bilans = string.Format("{0}", Bilans + "zł");
            return bilans;
        }
        public abstract string TypeName();
        string GenerujNumerKonta(int id)
        {
            var numerkonta = string.Format("94{0:D10}", id);
            return numerkonta;
        }
        public void ZmienBalans(decimal wartosc)
        {
            Bilans = +wartosc;
        }

    }
}
