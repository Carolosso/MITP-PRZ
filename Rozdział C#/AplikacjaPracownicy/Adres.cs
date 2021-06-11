using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    public class Adres
    {
        //prywatne pola
        private string ulica;
        private string numerDomu;
        private string miasto;
        //publiczne własciwosci 
        public string Ulica
        {
            get { return ulica; }
            set { ulica = value; }
        }
        public string NumerDomu
        {
            get { return numerDomu; }
            set { numerDomu = value; }
        }
        public string Miasto
        {
            get { return miasto; }
            set { miasto = value; }
        }

        // publiczne metody
        //bezargumentowy konstruktor domyslny
        public Adres() { }
        //konstruktor inicjalizujacy wszystkie pola składowe na podstawie odp dobranych arg
        public Adres(string ulica, string numerDomu, string miasto)
        {
            this.ulica = ulica;
            this.numerDomu = numerDomu;
            this.miasto = miasto;
        }
        //konstruktor kopiujacy(inicjalizujacy) wszystkie pola skladowe na pod arg wzorcowego typu Data
        public Adres(Adres adres)
        {
            ulica = adres.ulica;
            numerDomu = adres.numerDomu;
            miasto = adres.miasto;
        }
        //override string ToString()
        public override string ToString()
        {
            string format;
            format = String.Format("Ulica: {0} numerDomu: {1} Miasto: {2}", ulica, numerDomu, miasto);
            return format;
        }

    }
}
