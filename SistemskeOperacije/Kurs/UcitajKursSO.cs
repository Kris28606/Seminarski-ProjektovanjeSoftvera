using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Kurs
{
    public class UcitajKursSO : OpstaSO
    {
        private Domain.Kurs kurs;
        public Domain.Kurs Rezultat { get; private set; }
        public UcitajKursSO(Domain.Kurs k)
        {
            kurs = k;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = (Domain.Kurs)repozitorijum.VratiJedan(kurs);
        }
    }
}
