using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Predavac : IOpstiObjekat
    {
        public int PredavacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Pol Pol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public List<Kurs> ListaKurseva { get; set; }

        public string NazivTabele => "Predavac";

        public string Vrednosti => $"('{Ime}','{Prezime}',{(int)Pol},'{DatumRodjenja}')";

        public string Uslov => $"PredavacId={PredavacId}";

        public string Output => "PredavacId";

        public string Kriterijum => " Ime+' '+Prezime like";

        public string JoinUslov => "";

        public string UpdateUslov => $" Ime='{Ime}',Prezime='{Prezime}',Pol={(int)Pol}, DatumRodjenja='{DatumRodjenja}' ";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Predavac p = new Predavac
            {
                PredavacId = (int)reader[0],
                Ime = reader[1].ToString(),
                Prezime = reader[2].ToString(),
                Pol = (Pol)reader[3],
                DatumRodjenja = (DateTime)reader[4],

            };
            return p;
        }
    }
}
