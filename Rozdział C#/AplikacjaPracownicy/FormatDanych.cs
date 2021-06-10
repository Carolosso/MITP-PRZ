using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaPracownicy
{
    class FormatDanych
    {

        private string sciezka = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //na pulpit
        private DataSet ds;
        private DataTable dt;

        public string Sciezka
        {
            get { return sciezka; }
            set { sciezka = value; }
        }
        //public void InicjalizujKomponent()
        public void InicjalizujKomponent()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Pracownicy");
        }
        //- bezargumentowy konstruktor domyślny, w którym należy wywołać wcześniej zdefiniowaną metodę
        public FormatDanych()
        {
            InicjalizujKomponent();
        }
        public void StworzKolumny()
        {
            dt.Columns.Add("Imię", typeof(String));
            dt.Columns.Add("Nazwisko", typeof(String));
            dt.Columns.Add("Data urodzenia", typeof(String));
            dt.Columns.Add("Adres zamieszkania", typeof(String));
            dt.Columns.Add("Dane szczegółowe", typeof(String));
            ds.Tables.Add(dt);
        }
        //void ZapisXml(List<Pracownik> lista)
        public void ZapisXml(List<Pracownik> lista)
        {
            ds.WriteXml(Sciezka + "plik.xml");
            ds.ReadXml(Sciezka + "plik.xml");
        }
        public void WypełnijTabele(List<Pracownik> lista)
        {
            dt.Rows.Clear();
            DataRow dr;
            foreach (Pracownik p in lista)
            {
                dr = dt.NewRow();
                dr["Imię"] = p.Imie;
                dr["Nazwisko"] = p.Nazwisko;
                dr["Data urodzenia"] = p.DataUrodzenia;
                dr["Adres zamieszkania"] = p.AdresZamieszkania;
                dr["Dane szczegółowe"] = p.SzczegolyZawodu();
                dr["Zawód"] = p.Zawod.ToString(); ;
                dt.Rows.Add(dr);
            }
        }
        public List<Pracownik> OdczytXml()
        {
            List<Pracownik> lista = new List<Pracownik>();
            ds = new DataSet();
            ds.ReadXml(sciezka);
            Pracownik p = new Pracownik();
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    switch ((dr["Zawód"]).ToString())
                    {
                        case "Informatyk":
                            {
                                p = new Informatyk();
                                break;
                            }
                        case "Lekarz":
                            {
                                p = new Lekarz();
                                break;
                            }
                        case "Nauczyciel":
                            {
                                p = new Nauczyciel();
                                break;
                            }
                    }
                    p.OdczytXml(dr);
                    lista.Add(p);
                }
            }
            return lista;
        }  


    }
        
        
}
