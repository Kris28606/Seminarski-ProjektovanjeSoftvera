using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class KursPredavac : IOpstiObjekat
    {
        public Kurs Kurs { get; set; }
        public Predavac Predavac { get; set; }
        public string NazivTabele => "KursPredavac";

        public string Vrednosti => $"({Kurs.KursId},{Predavac.PredavacId})";

        public string Uslov => $" PredavacId={Predavac.PredavacId}";

        public string Output => "KursId";

        public string Kriterijum => "";

        public string JoinUslov => "kp join Kurs k on (kp.KursId=k.KursId)";

        public string UpdateUslov => "";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Kurs k = new Kurs {
                KursId = (int)reader[0],
                Naziv = (string)reader[3],
                Cena = Double.Parse(reader[4].ToString()),
                DatumPocetka = DateTime.Parse(reader[5].ToString()),
                Trajanje = (int)reader[6]
            };
            return k;
        }
    }
}
