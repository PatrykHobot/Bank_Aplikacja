using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class KontoOszczednosciowe : Konto
    {
        public KontoOszczednosciowe(int id, string imie, string nazwisko, long pesel)
            : base(id, imie, nazwisko, pesel)
        {
        }
        public void Nadwyzka(decimal oplata)
        {
            Bilans += Bilans * oplata;
        }
        public override string TypeName()
        {
            return ("OSZCZEDNOSCIOWE");
        }



    }
}
