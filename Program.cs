using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenagerKont menagerKont = new MenagerKont();

            //menagerKont.StworzKontoOszczednosciowe("Patryk", "Hobot", 669972268);
            //menagerKont.StworzKontoOszczednosciowe("Mikolaj", "Hobot", 669972268);
            //menagerKont.StworzKontoRozliczeniowe("Patryk", "Hobot", 669972268);

            //List<Konto> konta = (List<Konto>)menagerKont.GetKonta();//co tu sie odjebalo, mam przeciez liste _konta

            //IDrukarka drukarka = new Drukarka();
            //foreach(Konto konto in konta)
            //{
            //    drukarka.druk(konto);
            //}
            //IEnumerable<string> urzytkownicy = menagerKont.ListaKlientow();
            //foreach (string urzytkownik in urzytkownicy)
            //{
            //    Console.WriteLine(urzytkownik);
            //}


            MenagerBanku menagerBanku = new MenagerBanku();
            menagerBanku.Run();
            






            Console.ReadKey();
        }
    }
}
