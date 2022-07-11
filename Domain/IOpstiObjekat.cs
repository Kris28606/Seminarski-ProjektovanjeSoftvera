using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IOpstiObjekat
    {
        string NazivTabele { get; }
        string Vrednosti { get; }
        string Uslov { get; }
        string Output { get; }
        string Kriterijum { get;  }
        string JoinUslov { get; }
        string UpdateUslov { get; }
        IOpstiObjekat ProcitajObjekat(SqlDataReader reader);
    }
}
