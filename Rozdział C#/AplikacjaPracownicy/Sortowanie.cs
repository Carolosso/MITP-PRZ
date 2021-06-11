using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    public class Sortowanie
    {

        public class PoNazwisku : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.Nazwisko.CompareTo(y.Nazwisko);
            }
        }
        public class PoZawodzie : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.Zawod.CompareTo(y.Zawod);
            }
        }
        public class PoImieniu : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.Nazwisko.CompareTo(y.Imie);
            }
        }
        public class PoDniu : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.DataUrodzenia.Dzien.CompareTo(y.DataUrodzenia.Dzien);
            }
        }
        public class PoMiesiacu : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.DataUrodzenia.Miesiac.CompareTo(y.DataUrodzenia.Miesiac);
            }
        }
        public class PoRoku : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.DataUrodzenia.Rok.CompareTo(y.DataUrodzenia.Rok);
            }
        }
        public class PoUlicy : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.AdresZamieszkania.Ulica.CompareTo(y.AdresZamieszkania.Ulica);
            }
        }
        public class PoNrDomu : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.AdresZamieszkania.NumerDomu.CompareTo(y.AdresZamieszkania.NumerDomu);
            }
        }
        public class PoMiescie : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y)
            {
                return x.AdresZamieszkania.Miasto.CompareTo(y.AdresZamieszkania.Miasto);
            }
        }
    }
}
