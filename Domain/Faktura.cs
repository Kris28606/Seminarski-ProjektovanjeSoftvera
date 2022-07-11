using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Faktura : IOpstiObjekat
    {
        public int FakturaId { get; set; }
        public DateTime Datum { get; set; }
        public double UkupnaCena { get; set; }
        public NacinPlacanja NacinPlacanja { get; set; }
        public bool Stornirana { get; set; }
        public Korisnik Korisnik { get; set; }
        public List<StavkaFakture> Stavke { get; set; }

        public string NazivTabele => "Faktura";

        public string Vrednosti => $"('{Datum}',{UkupnaCena},{(int)NacinPlacanja},'{Stornirana}',{Korisnik.KorisnikId})";

        public string Uslov => $" FakturaId={FakturaId}" ;

        public string Output => "FakturaId";

        public string Kriterijum => "k.Ime like";

        public string JoinUslov => "f join Korisnik k on (f.KorisnikId=k.KorisnikId)";

        public string UpdateUslov => $" Stornirana='{Stornirana}'";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Faktura faktura = new Faktura
            {
                FakturaId = (int)reader[0],
                Datum = DateTime.Parse(reader[1].ToString()),
                UkupnaCena = (double)reader[2],
                NacinPlacanja = (NacinPlacanja)reader[3],
                Stornirana = (bool)reader[4],
                Korisnik = new Korisnik
                {
                    KorisnikId = (int)reader[5],
                    Ime = (string)reader[7],
                    Prezime = (string)reader[8],
                    Kontakt = (string)reader[9],
                    Adresa = (string)reader[10]
                }
            };
            return faktura;
        }
    }
}
