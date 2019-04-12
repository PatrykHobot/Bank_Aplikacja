using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BystraDrukarka : IDrukarka
    {
        public void druk(Konto konto)
        {
            Console.WriteLine("Numer konta to: {0}", konto.NumerKonta);
            Console.WriteLine("Imie i nazywsko wlasciciela to: {0}", konto.DajPelneImie());
        }
    }
}
