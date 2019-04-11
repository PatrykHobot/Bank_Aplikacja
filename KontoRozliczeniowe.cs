using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class KontoRozliczeniowe:Konto
    {
        public KontoRozliczeniowe(int id, string imie, string nazwisko, long pesel)
            : base(id, imie, nazwisko, pesel)
        {

        }
        public void Odsetki(decimal wartosc)
        {
            Bilans -= wartosc; 
        }
        public override string TypeName()
        {
            return ("ROZLICZENIOWE");
        }

    }
}
