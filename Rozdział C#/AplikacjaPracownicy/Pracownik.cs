using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace AplikacjaPracownicy
{
    public class Pracownik
    {
        //prywatne pola
        private string imie;
        private string nazwisko;
        private Data dataUrodzenia;
        private Adres adresZamieszkania;

        //publiczne właściwości
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public Data DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }
        public Adres AdresZamieszkania
        {
            get { return adresZamieszkania; }
            set { adresZamieszkania = value; }
        }
        public virtual Zawody Zawod
        {
            get { return Zawody.Pracownik; }
        }

        //publiczne metody
        //bezargumentowy konstruktor domyslny
        public Pracownik() 
        {
            dataUrodzenia = new Data();
            adresZamieszkania = new Adres();
            imie = "";
            nazwisko = "";
        }
        //konstruktor inicjalizujacy wszystkie pola składowe na podstawie odp dobranych arg
        public Pracownik(string imie, string nazwisko, Data dataUrodzenia, Adres adresZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            DataUrodzenia = new Data(dataUrodzenia);
            AdresZamieszkania = new Adres(adresZamieszkania);
        }
        //konstruktor kopiujacy(inicjalizujacy) wszystkie pola skladowe na pod arg wzorcowego typu Data
        public Pracownik(Pracownik pracownik)
        {
            imie = pracownik.imie;
            nazwisko = pracownik.nazwisko;
            dataUrodzenia = pracownik.dataUrodzenia;
            adresZamieszkania = pracownik.adresZamieszkania;
        }
        //virtual Pracownik Clone()
        public virtual Pracownik Clone()
        {
            Pracownik p = new Pracownik();
            return p;
        }
        //override string ToString()
        public override string ToString()
        {
           string format;
            format = String.Format("{0} {1} {2} {3} {4} {5} {6} {7}",
                Imie, Nazwisko, dataUrodzenia.Dzien, dataUrodzenia.Miesiac, dataUrodzenia.Rok, adresZamieszkania.Ulica,
                adresZamieszkania.NumerDomu, adresZamieszkania.Miasto);
           return format;
        }
        //virtual string FormatWyjsciowy()
        public virtual string FormatWyjsciowy()
        {
            string format;
            format = String.Format("Imię, nazwisko:{0} {1} \nData urodzenia:  {2} {3} {4}\nAdres zamieszkania: {5} {6} {7}",
                Imie, Nazwisko, DataUrodzenia.Dzien, DataUrodzenia.Miesiac, DataUrodzenia.Rok, AdresZamieszkania.Ulica,
                AdresZamieszkania.NumerDomu, AdresZamieszkania.Miasto);
            return format;
        }
        //virtual string SzczegolyZawodu() 
        public virtual string SzczegolyZawodu()
        {
            return "brak";
        }
        //string DataToString() 
        public string DataToString()
        {
            string format;
            format = String.Format("{0} {1} {2}", dataUrodzenia.Dzien, dataUrodzenia.Miesiac, dataUrodzenia.Rok);
            return format;
        }
        //string AdresToString() 
        public string AdresToString()
        {
            string format;
            format = String.Format("{0} {1} {2}", adresZamieszkania.Ulica,adresZamieszkania.NumerDomu, adresZamieszkania.Miasto);
            return format;
        }
        //virtual void OdczytConsole()
        public virtual void OdczytConsole()
        {
            Console.WriteLine("Podaj imie: "); this.Imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: "); this.Nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj date urodzenia: \n dzień:"); this.DataUrodzenia.Dzien = int.Parse(Console.ReadLine());
            Console.Write("miesiac: "); this.DataUrodzenia.Miesiac = Console.ReadLine();
            Console.Write("rok: "); this.DataUrodzenia.Rok = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ulice: "); this.AdresZamieszkania.Ulica = Console.ReadLine();
            Console.WriteLine("Podaj nr domu: "); this.AdresZamieszkania.NumerDomu = Console.ReadLine();
            Console.WriteLine("Podaj miasto: "); this.AdresZamieszkania.Miasto = Console.ReadLine();

        }
        //virtual void ZapisConsole()
        public virtual void ZapisConsole()
        {
            Console.WriteLine(FormatWyjsciowy());
        }
        //virtual void OdczytXml(DataRow dr)
        public virtual void OdczytXml(DataRow dr)
        {
            this.imie = dr.ItemArray[0].ToString();
            this.nazwisko = dr.ItemArray[1].ToString();
            string[] data = dr.ItemArray[2].ToString().Split(' ');
            this.dataUrodzenia.Dzien = Int32.Parse(data[0]);
            this.dataUrodzenia.Miesiac = data[1];
            this.dataUrodzenia.Rok = Int32.Parse(data[2]);
            string[] adres = dr.ItemArray[2].ToString().Split(' ');
            this.AdresZamieszkania.Ulica = adres[0];
            this.AdresZamieszkania.NumerDomu = adres[1];
            this.AdresZamieszkania.Miasto = adres[2];
        }

    }
}
