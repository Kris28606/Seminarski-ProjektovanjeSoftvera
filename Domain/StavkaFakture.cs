using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class StavkaFakture : IOpstiObjekat
    {
        public int FakturaId { get; set; }
        public int RedniBroj { get; set; }
        public double VrednostStavke { get; set; }
        public Kurs Kurs { get; set; }

        public string NazivTabele => "StavkaFakture";

        public string Vrednosti => $"({FakturaId},{RedniBroj},{VrednostStavke},{Kurs.KursId})";

        public string Uslov => "";

        public string Output => "FakturaId";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => "";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            return null;
        }
    }
}
