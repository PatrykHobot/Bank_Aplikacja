using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Drukarka : IDrukarka
    {
        public void druk(Konto konto)
        {
            Console.WriteLine("Numer konta: {0}", konto.NumerKonta);
            Console.WriteLine("Typ konta: {0}", konto.TypeName());
            Console.WriteLine("bilans: {0}", konto.ZwrocBalans());
            Console.WriteLine("imie i nazwisko: {0}", konto.DajPelneImie());
            Console.WriteLine("Pesel: {0}", konto.Pesel);
            Console.WriteLine(" ");

        }
    }
}
