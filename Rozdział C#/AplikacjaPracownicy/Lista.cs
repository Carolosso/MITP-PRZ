using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    public class Lista
    {
        List<Pracownik> lista = new List<Pracownik>();
        //publiczne właściwości
        public Pracownik this[int i]
        {
            get { return lista[i]; }
        }
        public int Rozmiar
        {
            get { return lista.Count; }
        }
        //bezargumentowy konstruktor domyslny
        public Lista()
        {
            Lista lista = new Lista();
        }
        //void Dodaj(Pracownik pracownik) dodającą pracownika do listy pracowników.
        public void Dodaj(Pracownik pracownik)
        {
            lista.Add(pracownik);
        }
        //void WstawWPolozenie(int indeks, Pracownik pracownik)
        public void WstawWPolozenie(int indeks, Pracownik pracownik)
        {
            lista.Insert(indeks, pracownik);
        }
        //int Usun(string nazwisko)
        public int Usun(string nazwisko)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Nazwisko.Equals(nazwisko))
                {
                    return i;
                }
            }
            return -1;
        }
        //void Usun(int indeks)
        public void Usun(int indeks)
        {
            if (indeks >= 0 && indeks < lista.Count)
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
                if (p.Nazwisko.Equals(nazwisko))
                {
                    return p;
                }
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
            Pracownik p = new Pracownik();
            p.OdczytConsole();
            lista.Add(p);
        }
        //void Wyczysc() 
        public void Wyczysc()
        {
            lista.Clear();
        }
    }
}
