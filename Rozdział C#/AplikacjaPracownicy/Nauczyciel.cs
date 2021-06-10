﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    class Nauczyciel
    {
        private string przedmiot;
        private string tytul;
        public string Przedmiot
        {
            get { return przedmiot; }
            set { przedmiot = value; }
        }
        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }
        public Zawody Zawod //override 
        {
            get { return Zawody.Nauczyciel; }
        }
        public Nauczyciel()
        {
            przedmiot = "000000000000";
            tytul = "0000000000000";
        }
        public Nauczyciel(string przedmiot, string tytul, string imie, string nazwisko, Data dataUrodzenia, Adres adresZamieszkania)
        {
            Pracownik p = new Pracownik();
            this.przedmiot = przedmiot;
            this.tytul = tytul;
            p.Imie = imie;
            p.Nazwisko = nazwisko;
            p.DataUrodzenia = new Data(dataUrodzenia);
            p.AdresZamieszkania = new Adres(adresZamieszkania);
        }
        public Nauczyciel(Nauczyciel nauczyciel)
        {
            przedmiot = nauczyciel.przedmiot;
            tytul = nauczyciel.tytul;
        }

        //???virtual ???Pracownik???? Clone()
        public virtual Nauczyciel Clone()
        {
            Nauczyciel n = new Nauczyciel();
            return n;
        }
        // ???override??? string SzczegolyZawodu()
        public virtual string SzczegolyZawodu()
        {
            string format;
            format = String.Format("{0}\t{1}",Przedmiot, Tytul);
            return format;
        }

        //override string ToString()
        public override string ToString()
        {
            string format;
            Pracownik p = new Pracownik();
            format = String.Format("{0} {1} {2}", p.ToString(), Przedmiot, Tytul);
            return format;
        }
        //???override??? string FormatWyjsciowy() 
        public virtual string FormatWyjsciowy()
        {
            Pracownik p = new Pracownik();
            return String.Format("{0} \nDane dodatkowe: {1} {2}", p.FormatWyjsciowy(), Przedmiot, Tytul);
        }
        //override void OdczytConsole()
        public virtual void OdczytConsole()
        {
            Pracownik p = new Pracownik();
            p.OdczytConsole();
            Console.WriteLine("Podaj przedmiot: "); this.Przedmiot = Console.ReadLine();
            Console.WriteLine("Podaj tytul: "); this.Tytul = Console.ReadLine();
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
            this.przedmiot = szczegoly[0];
            this.tytul = szczegoly[1];
        }
    }
}
