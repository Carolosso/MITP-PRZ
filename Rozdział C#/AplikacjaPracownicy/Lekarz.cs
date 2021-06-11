using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    class Lekarz : Pracownik
    {
        private string specjalizacja;
        private string tytul;
        public string Specjalizacja
        {
            get { return specjalizacja; }
            set { specjalizacja = value; }
        }
        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }
        public override Zawody Zawod 
        {
            get { return Zawody.Lekarz; }
        }
        public Lekarz()
        {
            specjalizacja = "000000000000";
            tytul = "0000000000000";
        }
        public Lekarz(string specjalizacja, string tytul, string imie, string nazwisko, Data dataUrodzenia, Adres adresZamieszkania)
        {
            Pracownik p = new Pracownik();
            this.specjalizacja = specjalizacja;
            this.tytul = tytul;
            p.Imie = imie;
            p.Nazwisko = nazwisko;
            p.DataUrodzenia = new Data(dataUrodzenia);
            p.AdresZamieszkania = new Adres(adresZamieszkania);
        }
        public Lekarz(Lekarz lekarz)
        {
            specjalizacja = lekarz.specjalizacja;
            tytul = lekarz.tytul;
        }

        // Pracownik Clone()
        public override Pracownik Clone()
        {
            Lekarz l = new Lekarz();
            return l;
        }
        //  string SzczegolyZawodu()
        public override string SzczegolyZawodu()
        {
            string format;
            format = String.Format("{0}\t{1}", Specjalizacja, Tytul);
            return format;
        }

        //override string ToString()
        public override string ToString()
        {
            string format;
            Pracownik p = new Pracownik();
            format = String.Format("{0} {1} {2}", p.ToString(), Specjalizacja, Tytul);
            return format;
        }
        // string FormatWyjsciowy() 
        public override string FormatWyjsciowy()
        {
            return String.Format("{0} \nDane dodatkowe: {1} {2}", base.FormatWyjsciowy(), Specjalizacja, Tytul);
        }
        //override void OdczytConsole()
        public override void OdczytConsole()
        {
            base.OdczytConsole();
            Console.WriteLine("Podaj specjalizacje: "); this.Specjalizacja = Console.ReadLine();
            Console.WriteLine("Podaj tytul: "); this.Tytul = Console.ReadLine();
        }
        //overide void ZapisConsole()
        public override void ZapisConsole()
        {
            Pracownik p = new Pracownik();
            p.ZapisConsole();
            Console.WriteLine(FormatWyjsciowy());
        }
        // void OdczytXml(DataRow dr)
        public override void OdczytXml(DataRow dr)
        {
            Pracownik p = new Pracownik();
            p.OdczytXml(dr);
            string[] szczegoly = dr.ItemArray[4].ToString().Split('\t');
            this.specjalizacja = szczegoly[0];
            this.tytul = szczegoly[1];
        }
    }
}
