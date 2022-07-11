using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Kurs
{
    public class UcitajListuKursevaSO : OpstaSO
    {
        public List<Domain.Kurs> Rezultat { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = repozitorijum.VratiSve(new Domain.Kurs()).OfType<Domain.Kurs>().ToList();
        }
    }
}
