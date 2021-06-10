using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    class Informatyk
    {
        private string adresEmail;
        private string stronaInternetowa;
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
        public Zawody Zawod //override 
        {
            get { return Zawody.Informatyk; }
        }
        public Informatyk()
        {
            adresEmail = "000000000000";
            stronaInternetowa = "0000000000000";
        }
        public Informatyk(string adresEmail, string stronaInternetowa, string imie, string nazwisko, Data dataUrodzenia, Adres adresZamieszkania)
        {
            Pracownik p = new Pracownik();
            this.adresEmail = adresEmail;
            this.stronaInternetowa = stronaInternetowa;
            p.Imie = imie;
            p.Nazwisko = nazwisko;
            p.DataUrodzenia = new Data(dataUrodzenia);
            p.AdresZamieszkania = new Adres(adresZamieszkania);
        }
        public Informatyk(Informatyk informatyk)
        {
            adresEmail = informatyk.adresEmail;
            stronaInternetowa = informatyk.stronaInternetowa;
        }

        //???virtual ???Pracownik???? Clone()
        public virtual Informatyk Clone()
        {
            Informatyk i = new Informatyk();
            return i;
        }
       // ???override??? string SzczegolyZawodu()
        public virtual string SzczegolyZawodu()
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
        //???override??? string FormatWyjsciowy() 
        public virtual string FormatWyjsciowy()
        {
            Pracownik p = new Pracownik();
            return String.Format("{0} \nDane dodatkowe:{1} {2}", p.FormatWyjsciowy(), AdresEmail, StronaInternetowa);
        }
        //override void OdczytConsole()
        public virtual void OdczytConsole()
        {
            Pracownik p = new Pracownik();
            p.OdczytConsole();
            Console.WriteLine("Podaj adres email: "); this.AdresEmail = Console.ReadLine();
            Console.WriteLine("Podaj strone internetową: "); this.StronaInternetowa = Console.ReadLine();
        }
        //ovveride void ZapisConsole()
        public virtual void ZapisConsole()
        {
            Pracownik p = new Pracownik();
            p.ZapisConsole();
            Console.WriteLine(FormatWyjsciowy());
        }
        //virtual void OdczytXml(DataRow dr)
        public virtual void OdczytXml(DataRow dr)
        {
            Pracownik p = new Pracownik();
            p.OdczytXml(dr);
            string[] szczegoly = dr.ItemArray[4].ToString().Split('\t');
            this.adresEmail = szczegoly[0];
            this.stronaInternetowa = szczegoly[1];
        }
    }
}
