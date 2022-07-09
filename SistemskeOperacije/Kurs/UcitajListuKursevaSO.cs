using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Kurs
{
    public class UcitajListuKursevaSO : OpstaSO
    {
        public List<Domain.Predavac> Rezultat { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = broker.VratiSvePredavace();
        }
    }
}
