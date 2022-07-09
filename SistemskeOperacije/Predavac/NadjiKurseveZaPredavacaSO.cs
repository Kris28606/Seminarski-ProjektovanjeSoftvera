using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Predavac
{
    public class NadjiKurseveZaPredavacaSO : OpstaSO
    {
        private Domain.Predavac predavac;
        public List<Domain.Kurs> Rezultat { get; private set; }
        public NadjiKurseveZaPredavacaSO(Domain.Predavac p)
        {
            predavac = p;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = broker.VratiSveKurseveZaPredavaca(predavac);
        }
    }
}
