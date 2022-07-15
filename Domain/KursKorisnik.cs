using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class KursKorisnik : IOpstiObjekat
    {
        public Kurs Kurs { get; set; }
        public Korisnik Korisnik { get; set; }

        public string NazivTabele => "KursKorisnik";

        public string Vrednosti => $"({Kurs.KursId},{Korisnik.KorisnikId})";

        public string Uslov => $" KorisnikId={Korisnik.KorisnikId}";

        public string Output => "KorisnikId";

        public string Kriterijum => "";

        public string JoinUslov => " kk join Kurs k on (kk.KursId=k.KursId)";

        public string UpdateUslov => "";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Kurs k = new Kurs {
                KursId = (int)reader[0],
                Naziv = (string)reader[3],
                Cena = Double.Parse(reader[4].ToString()),
                DatumPocetka = (DateTime)reader[5],
                Trajanje = (int)reader[6]
            };
            return k;
        }
    }
}
