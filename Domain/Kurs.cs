using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Kurs : IOpstiObjekat
    {
        public int KursId { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public DateTime DatumPocetka { get; set; }
        public int Trajanje { get; set; }

        public string NazivTabele => "Kurs";

        public string Vrednosti => $"('{Naziv}', {Cena}, '{DatumPocetka}', {Trajanje})";

        public string Uslov => $"KursId={KursId}";

        public string Output => "KursId";

        public string Kriterijum => " Naziv like";

        public string JoinUslov => "";

        public string UpdateUslov => $" Naziv='{Naziv}', Cena={Cena}, DatumPocetka='{DatumPocetka}', Trajanje={Trajanje} ";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            Kurs k = new Kurs
            {
                KursId = (int)reader["KursId"],
                Naziv = reader["Naziv"].ToString(),
                DatumPocetka = (DateTime)reader["DatumPocetka"],
                Cena = (double)reader["Cena"],
                Trajanje = (int)reader["Trajanje"]
            };
            return k;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
