using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Korisnik : IOpstiObjekat
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public string Adresa { get; set; }
        public Mesto Mesto { get; set; }
        public List<Kurs> ListaKurseva { get; set; }

        public string NazivTabele => "Korisnik";

        public string Vrednosti => $"('{Ime}','{Prezime}','{Kontakt}','{Adresa}',{Mesto.MestoId})";

        public string Uslov => $"KorisnikId={KorisnikId}";

        public string Output => "KorisnikId";

        public string Kriterijum => " k.Ime+' '+k.Prezime like";

        public string JoinUslov => "k join Mesto m on (k.MestoId= m.MestoId)";

        public string UpdateUslov => "";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Korisnik korisnik = new Korisnik
            {
                KorisnikId = (int)reader[0],
                Ime = (string)reader[1],
                Prezime = (string)reader[2],
                Kontakt = (string)reader[3],
                Adresa = (string)reader[4],
                Mesto = new Mesto
                {
                    MestoId = (int)reader[5],
                    Naziv = (string)reader[7],
                    PTT = Int32.Parse(reader[8].ToString())
                }
            };
            return korisnik;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
