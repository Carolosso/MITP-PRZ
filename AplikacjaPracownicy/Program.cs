using System;

namespace AplikacjaPracownicy
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data();
            Adres a1 = new Adres();
            Pracownik p1 = new Pracownik();
            p1.OdczytConsole();
            p1.ZapisConsole();
        }
    }

    //typ wyliczeniowy
    public enum Zawody : short
    {
        Pracownik, Informatyk, Lekarz, Nauczyciel
    }
}
