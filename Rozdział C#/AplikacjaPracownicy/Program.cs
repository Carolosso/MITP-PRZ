using System;

namespace AplikacjaPracownicy
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Lista l = new Lista();
            int wybor = 1;
            while (wybor != 0) {
                Console.Clear();
                Console.WriteLine("********MENU********");
                Console.WriteLine("1. Dodawanie pracownikow do listy.");
                Console.WriteLine("2. Wstawianie pracowników w dowolne miejsce na liście.");
                Console.WriteLine("3. Usuwanie pracowników po zadanym nazwisku.");
                Console.WriteLine("4. Usuwanie pracowników po zadanym numerze indeksu.");
                Console.WriteLine("5. Wyszukiwanie pracowników na liście.");
                Console.WriteLine("6. Sortowanie pracowników po zadanym polu.");
                Console.WriteLine("7. Wyświetlanie danych wszystkich pracownikow.");
                Console.WriteLine("8. Wczytywanie danych do dodawanych do listy pracowników.");
                Console.WriteLine("9. Odczyt i zapis danych do pliku w formacie Xml.");
                Console.WriteLine("10. Czyszczenie zawartości listy pracowników.");
                Console.WriteLine("0. Wyjście.");
                Console.WriteLine("********************");
                Console.WriteLine("Podaj wybór: ");
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        {
                            Console.Clear();

                            Pracownik p = new Pracownik();
                            p.OdczytConsole();
                            l.Dodaj(p);

                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();

                            Pracownik p = new Pracownik();
                            Console.WriteLine("Podaj numer indeksu: "); int indeks = int.Parse(Console.ReadLine());
                            l.WstawWPolozenie(indeks,p);

                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();

                            Pracownik p = new Pracownik();
                            Console.WriteLine("Podaj nazwisko: "); string nazwisko = Console.ReadLine();
                            l.Usun(nazwisko);

                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();

                            Pracownik p = new Pracownik();
                            Console.WriteLine("Podaj numer indeksu: "); int indeks = int.Parse(Console.ReadLine());
                            l.Usun(indeks);

                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();

                            Pracownik p = new Pracownik();
                            Console.WriteLine("Podaj nazwisko: "); string nazwisko = Console.ReadLine();
                            l.Szukaj(nazwisko);

                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();

                            //IComparable<Pracownik> icp;
                            //Pracownik p = new Pracownik();
                            //Console.WriteLine("Podaj argument sortowania: "); string sort = Console.ReadLine();
                            //l.Sortuj(sort);

                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();

                            Pracownik p = new Pracownik();
                            p.ZapisConsole();

                            Console.ReadKey();
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();

                            Pracownik p = new Pracownik();
                            p.OdczytConsole();

                            Console.ReadKey();
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();

                            l.ZapisXml();
                            l.OdczytXml();

                            Console.ReadKey();
                            break;
                        }
                    case 10:
                        {
                            Console.Clear();

                            l.Wyczysc();

                            Console.ReadKey();
                            break;
                        }
                    case 0:
                        {
                            System.Environment.Exit(1);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Błedny wybór!");
                            Console.ReadKey();
                            break;
                        }
                }
          }
        }
    }

    //typ wyliczeniowy
    public enum Zawody : short
    {
        Pracownik, Informatyk, Lekarz, Nauczyciel
    }
}
