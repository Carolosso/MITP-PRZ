using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    public class Lista
    {
        private List<Pracownik> lista = new List<Pracownik>();
        private FormatDanych df; //modyfikacja
        //publiczne właściwości
        public Pracownik this[int i]
        {
            get { return lista[i]; }
        }
        public int Rozmiar
        {
            get { return lista.Capacity; }
        }
        //bezargumentowy konstruktor domyslny
        public Lista()
        {
             FormatDanych df = new FormatDanych();
             lista = new List<Pracownik>();
        }
        //void Dodaj(Pracownik pracownik) dodającą pracownika do listy pracowników.
        public void Dodaj(Pracownik pracownik)
        {
            lista.Add(pracownik.Clone());
        }
        //void WstawWPolozenie(int indeks, Pracownik pracownik)
        public void WstawWPolozenie(int indeks, Pracownik pracownik)
        {
            lista.Insert(indeks, pracownik.Clone());
        }
        //int Usun(string nazwisko)
        public int Usun(string nazwisko)
        {
            for (int i = 0; i < Rozmiar; i++)
            {
                if (lista[i].Nazwisko.Equals(nazwisko))
                {
                    lista.Remove(lista[i]);
                    return i;
                }
            }
            return -1;
        }
        //void Usun(int indeks)
        public void Usun(int indeks)
        {
            if (indeks >= 0 && indeks < Rozmiar)
            {
                lista.RemoveAt(indeks);
            }
            else Console.WriteLine("Bledny indeks!");
        }
        //Pracownik Szukaj(string nazwisko) 
        public Pracownik Szukaj(string nazwisko)
        {
            foreach (Pracownik p in lista)
            {
                if (p.Nazwisko.Equals(nazwisko)) return p;
            }
            return null;
            //lista.Find(x => x.Nazwisko.Equals(nazwisko));
        }
        //void Sortuj() s
        public void Sortuj()
        {
            lista.Sort();
        }
        //void ZapisConsole() 
        public void ZapisConsole()
        {
            foreach ( Pracownik p in lista)
            {
                Console.WriteLine("{0} ", p);
            }
        }
        //void OdczytConsole()
        public void OdczytConsole()
        {
            //Pracownik p = new Pracownik();
            //p.OdczytConsole();
            //lista.Add(p);
            Pracownik p = new Pracownik();
            Console.WriteLine("Podaj typ pracownika");
            Console.WriteLine("i - informatyk");
            Console.WriteLine("l - lekarz");
            Console.WriteLine("n - nauczyciel");
            char typ = char.Parse(Console.ReadLine());
            switch (typ)
            {
                case 'i':
                    {
                        p = new Informatyk();
                        break;
                    }
                case 'l':
                    {
                        p = new Lekarz();
                        break;
                    }
                case 'n':
                    {
                        p = new Nauczyciel();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Błędny wybór.");
                        break;
                    }
            }
            p.OdczytConsole();
            lista.Add(p);
        }
        //void Wyczysc() 
        public void Wyczysc()
        {
            lista.Clear();
        }

        //modyfikacja lista
        public void OdczytXml()
        {
            lista = df.OdczytXml();
        }
        public void ZapisXml()
        {
            df.ZapisXml(lista);
        }
        public string SciezkaDoPliku
        {
            get { return df.Sciezka; }
            set { df.Sciezka = value; }
        }
    }
}
