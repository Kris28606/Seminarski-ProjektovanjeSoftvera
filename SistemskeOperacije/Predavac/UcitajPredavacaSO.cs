using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Predavac
{
    public class UcitajPredavacaSO : OpstaSO
    {
        private Domain.Predavac predavac;
        public Domain.Predavac Rezultat { get; private set; }
        public UcitajPredavacaSO(Domain.Predavac p)
        {
            predavac = p;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = (Domain.Predavac)repozitorijum.VratiJedan(predavac);
        }
    }
}
