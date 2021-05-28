using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    public class Data
    {
        //prywatne pola
        private int dzien;
        private string miesiac;
        private int rok;
        private static readonly string[] miesiace = { "Styczeń", "Luty","Marzec", "Kwiecień","Maj","Czerwiec","Lipiec","Sierpień","Wrzesień","Październik","Listopad","Grudzień" };
        //private static readonly string[] miesiace = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames;
        
        //publiczne właściwości
        public int Dzien
        {
            get { return dzien; }
            set { dzien = value; }
        }
        public string Miesiac
        {
            get { return miesiac; }
            set { miesiac = value; }
        }
        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }
        //publiczne metody
        //bezargumentowy konstruktor domyslny
        public Data() { }
        //konstruktor inicjalizujacy wszystkie pola składowe na podstawie odp dobranych arg
        public Data(int dzien, string miesiac, int rok) 
        {
            this.dzien = dzien;
            this.miesiac = miesiac;
            this.rok = rok;
        }
        //konstruktor kopiujacy(inicjalizujacy) wszystkie pola skladowe na pod arg wzorcowego typu Data
        public Data(Data data)
        {
            dzien = data.dzien;
            miesiac = data.miesiac;
            rok = data.rok;
        }
        //override string ToString()
        public override string ToString()
        {
            string format;
            format = String.Format("Dzień: {0} Miesiąc: {1} Rok: {2}", Dzien, Miesiac, Rok);
            return format;
        }
        //static string ZwrocMiesiac(int miesiac)
        public static string ZwrocMiesiac(int miesiac)
        {
            if (miesiac >= 1 || miesiac <= 12) return miesiace[miesiac - 1];
            return "Blad miesiaca!";
        }
    }
}
