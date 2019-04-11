using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MenagerKont
    {
        private List<Konto> _konta;//= new List<Konto>();//czym sie rozni interfejs listy od samej listy
        
        public MenagerKont()
        {
            _konta = new List<Konto>();//co nam daje ze obiekt listy tworzymy w konstruktorze a nie wczesniej
        }
        public IEnumerable<Konto> GetKonta()
        {
            return _konta;

        }
        private int generacjaId()
        {
            int id = 1;

            if (_konta.Any())
            {
                id = _konta.Max(x => x.Id) + 1;
            }

            return id;
        }
        public KontoOszczednosciowe StworzKontoOszczednosciowe(string imie, string nazwisko, long pesel)
        {
            int id = generacjaId();

            KontoOszczednosciowe konto = new KontoOszczednosciowe(id, imie, nazwisko, pesel);

            _konta.Add(konto);

            return konto;
        }
        public KontoRozliczeniowe StworzKontoRozliczeniowe(string imie, string nazwisko, long pesel)
        {
            int id = generacjaId();
            KontoRozliczeniowe konto = new KontoRozliczeniowe(id, imie, nazwisko, pesel);
            _konta.Add(konto);
            return konto;



        }
        public IEnumerable<Konto> PobierzWszystkieKonta(string imie, string nazwisko, long pesel)
        {
            return _konta.Where(x => x.Imie == imie && x.Nazwisko == nazwisko && x.Pesel == pesel);
        }
        public Konto GetKonto(string numerkonta)
        {
            return _konta.Single(x => x.NumerKonta == numerkonta); 
        }
        public IEnumerable<string> ListaKlientow()
        {
            return _konta.Select(a => string.Format("Imię: {0} | Nazwisko: {1} | PESEL: {2}", a.Imie, a.Nazwisko, a.Pesel)).Distinct();//sprawdzicccccccccccccccccc
        }
        public void ZamkniecieMiesiaca()
        {
            foreach (KontoOszczednosciowe konto in _konta.Where(x => x is KontoOszczednosciowe))//sprawdzicccccc
            {
                konto.Nadwyzka(0.04M);
            }
            foreach (KontoRozliczeniowe konto in _konta.Where(x => x is KontoRozliczeniowe))//sprawdzicc    
            {
                konto.Odsetki(5.0M);
            }
        }
        public void WplacPieniadze(string numerkonta,decimal wartosc)
        {
            Konto konto = GetKonto(numerkonta);
            konto.ZmienBalans(wartosc);
        }
        public void WyplacPieniadze(string numerkonta, decimal wartosc)
        {
            Konto konto = GetKonto(numerkonta);
            konto.ZmienBalans(-wartosc);
        }
    }
}
