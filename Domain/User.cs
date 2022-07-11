using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class User : IOpstiObjekat
    {
        public int UserId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }

        public string NazivTabele => "[User]";

        public string Vrednosti => "";

        public string Uslov => $"Email='{Email}' and Sifra='{Sifra}'";

        public string Output => "";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => "";

        public IOpstiObjekat ProcitajObjekat(SqlDataReader reader)
        {
            User u = new User
            {
                UserId = (int)reader["UserId"],
                Ime = (string)reader["Ime"],
                Prezime = (string)reader["Prezime"],
                Email = (string)reader["Email"],
                Sifra = (string)reader["Sifra"]
            };
            return u;
        }
    }
}
