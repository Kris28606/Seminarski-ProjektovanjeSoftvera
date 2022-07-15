using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepozitorijum<T> where T : class
    {
        int Sacuvaj(T objekat);
        int Izmeni(T objekat);
        int Izbrisi(T objekat);
        T VratiJedan(T objekat);
        List<T> VratiSve(T objekat);
        List<T> Pretraga(T objekat, string kriterijum);
        List<T> VratiSveZaNekog(T objekat);
        void OtvoriKonekciju();
        void ZatvoriKonekciju();
        void ZapocniTransakciju();
        void Commit();
        void RollBack();
    }
}
