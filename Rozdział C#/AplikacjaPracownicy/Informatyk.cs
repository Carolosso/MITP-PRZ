using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    class Informatyk : Pracownik
    {
        private string adresEmail;
        private string stronaInternetowa;
        //publiczne właściwości
        public string AdresEmail
        {
            get { return adresEmail; }
            set { adresEmail = value; }
        }
        public string StronaInternetowa
        {
            get { return stronaInternetowa; }
            set { stronaInternetowa = value; }
        }
        public override Zawody Zawod  
        {
            get { return Zawody.Informatyk; }
        }
        // publiczne metody
        //bezargumentowy konstruktor domyslny
        public Informatyk() 
        {
            adresEmail = "000000000000";
            stronaInternetowa = "0000000000000";
        }
        //konstruktor inicjalizujacy wszystkie pola składowe na podstawie odp dobranych arg

        public Informatyk(string adresEmail, string stronaInternetowa, string imie, string nazwisko, Data dataUrodzenia, Adres adresZamieszkania)
        {
            this.adresEmail = adresEmail;
            this.stronaInternetowa = stronaInternetowa;
            base.Imie = imie;
            base.Nazwisko = nazwisko;
            base.DataUrodzenia = new Data(dataUrodzenia);
            base.AdresZamieszkania = new Adres(adresZamieszkania);
        }
        //konstruktor kopiujacy(inicjalizujacy) wszystkie pola skladowe na pod arg wzorcowego

        public Informatyk(Informatyk informatyk)
        {
            adresEmail = informatyk.adresEmail;
            stronaInternetowa = informatyk.stronaInternetowa;
        }

        //Pracownik Clone()
        public override Pracownik Clone()
        {
            Informatyk i = new Informatyk();
            return i;
        }
       // string SzczegolyZawodu()
        public override string SzczegolyZawodu()
        {
            string format;
            format = String.Format("{0}\t{1}", AdresEmail, StronaInternetowa);
            return format;
        }

        //override string ToString()
        public override string ToString()
        {
            string format;
            Pracownik p = new Pracownik();
            format = String.Format("{0} {1} {2}", p.ToString(), AdresEmail, StronaInternetowa);
            return format;
        }
         
        public override string FormatWyjsciowy()
        {
            return String.Format("Zawód: {0}\n{1}Dane dodatkowe: {2}, {3}",
            this.Zawod, base.FormatWyjsciowy(), adresEmail, stronaInternetowa);

        }
        //override void OdczytConsole()
        public override void OdczytConsole()
        {
            base.OdczytConsole();
            Console.WriteLine("Podaj adres email: "); this.AdresEmail = Console.ReadLine();
            Console.WriteLine("Podaj strone internetową: "); this.StronaInternetowa = Console.ReadLine();
        }
        //ovveride void ZapisConsole()
        public override void ZapisConsole()
        {
            base.ZapisConsole();
            Console.WriteLine(FormatWyjsciowy());
        }
        //virtual void OdczytXml(DataRow dr)
        public override void OdczytXml(DataRow dr)
        {
            Pracownik p = new Pracownik();
            p.OdczytXml(dr);
            string[] szczegoly = dr.ItemArray[4].ToString().Split('\t');
            this.adresEmail = szczegoly[0];
            this.stronaInternetowa = szczegoly[1];
        }
    }
}
