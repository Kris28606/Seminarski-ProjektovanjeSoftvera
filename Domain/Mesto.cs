using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Mesto : IOpstiObjekat
    {
        public int MestoId { get; set; }
        public string Naziv { get; set; }
        public int PTT { get; set; }

        public string NazivTabele => "Mesto";

        public string Vrednosti => $"('{Naziv}','{PTT}')";

        public string Uslov => $"MestoId={MestoId}";

        public string Output => "";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => "";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Mesto m = new Mesto
            {
                MestoId = (int)reader[0],
                Naziv = (string)reader[1],
                PTT = Int32.Parse(reader[2].ToString())
            };
            return m;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
